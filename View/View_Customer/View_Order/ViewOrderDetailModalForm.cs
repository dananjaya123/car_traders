using car_traders.Model;
using car_traders.Service;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore.Metadata;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace car_traders.View.View_Customer.View_Order
{
    public partial class ViewOrderDetailModalForm : MaterialForm
    {
        readonly List<OrderDetails> _orderDetailList;
        readonly Model.Order _order;
        readonly ViewOrderForm _viewOrderForm;

        readonly CarService _carService;
        readonly CarPartsService _carPartsService;
        readonly OrderService _orderService;
        readonly OrderDetailService _orderDetailService;
        public ViewOrderDetailModalForm(List<OrderDetails> detailList, Model.Order order, ViewOrderForm viewOrderForm)
        {


            InitializeComponent();
            _orderDetailList = detailList;
            _order = order;
            _viewOrderForm = viewOrderForm;

            _carService = new CarService();
            _carPartsService = new CarPartsService();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();

            loadOrderDetail();


        }

        private void ViewOrderDetailModalForm_Load(object sender, EventArgs e)
        {
           
        }

        private void loadOrderDetail()
        {
            try
            {
                listViewOrderDetail.Items.Clear();

                foreach (var data in _orderDetailList)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                      data.Item_name,
                      data.Qty.ToString(),
                      data.Order_code,
                      data.Item_type,
                      data.Total_price.ToString("F2"),
                      data.Item_Id.ToString(),
                      data.Id.ToString(),

                    });

                    listViewOrderDetail.Items.Add(listViewItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrderDetail.SelectedItems.Count > 0)
                {
                  

                    // Assuming the ID is stored as text in the sixth column (index 5)
                    string itemIdString = listViewOrderDetail.SelectedItems[0].SubItems[5].Text;
                    string detailID = listViewOrderDetail.SelectedItems[0].SubItems[6].Text;

                    // Assuming the type is stored as text in the fourth column (index 3)
                    string type = listViewOrderDetail.SelectedItems[0].SubItems[3].Text;

                    string qty = listViewOrderDetail.SelectedItems[0].SubItems[1].Text;

                    Guid itemId = Guid.Parse(itemIdString); // Convert the string to a Guid


                    numberQty.Value = int.Parse(qty);
                    lblExist.Text = qty;
                    lblOrderDetailID.Text = detailID;
                    lblType.Text = type;

                    if (type.Equals("CAR"))
                    {
                        var car = _carService.getCarById(itemId);

                        if (car.Image_data != null)
                        {
                            using (MemoryStream ms = new MemoryStream(car.Image_data))
                            {
                                imgItem.Image = System.Drawing.Image.FromStream(ms);
                            }
                        }
                    }
                    else if (type.Equals("PART"))
                    {
                        var part = _carPartsService.getCarPartById(itemId);
                        if (part.Image_data != null)
                        {
                            using (MemoryStream ms = new MemoryStream(part.Image_data))
                            {
                                imgItem.Image = System.Drawing.Image.FromStream(ms);
                            }
                        }
                    }

                    // order statsu wise btton visibility
                    if (_order.status.Equals("CANCEL") || _order.status.Equals("PAID") || _order.status.Equals("REJECT"))
                    {
                        btnCancel.Visible = false;
                    }
                    else
                    {
                        numberQty.Visible = true;
                        btnCancel.Visible = true;
                    }

                    imgItem.Visible = true;
                    imgItem.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int qty = (int)numberQty.Value;
            int existQty = int.Parse(lblExist.Text);
            if (qty > existQty)
            {
                MessageBox.Show($"Can't cancel this item. please check your qty count !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (qty <= existQty)
            {
                Guid id = Guid.Parse(lblOrderDetailID.Text);
                OrderDetails detailsData = _orderDetailService.getOrderDetailByDetailID(id);
                if (detailsData != null)
                {
                    //check input and exist detail qty and save
                    int availableQty = existQty - qty;
                    double unitPrice = detailsData.Total_price / existQty;
                    double availableTotalPrice = unitPrice * availableQty;
                    double removeQtyTotalPrice = unitPrice * qty;
                    if (availableQty == 0)
                    {
                        detailsData.Is_active = false;
                    }
                    detailsData.Qty = availableQty;
                    detailsData.Total_price = availableTotalPrice;

                    if (_orderDetailService.updateOrderDetail(detailsData))
                    {
                        // car and parts stock updates
                        if (lblType.Text.Equals("PART"))
                        {
                            // car stock update
                            if (!_carPartsService.UpdatePartsStatusAndQty(detailsData.Item_Id, "AVAILABLE", true, qty))
                            {
                                MessageBox.Show($"{detailsData.Item_name} This Part cannot be canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else if (lblType.Text.Equals("CAR"))
                        {
                            // part stock update
                            if (!_carService.UpdateCarStatusAndQty(detailsData.Item_Id, "AVAILABLE", true))
                            {
                                MessageBox.Show($"{detailsData.Item_name} This Car cannot be canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        // order qty and prise change 
                        _order.Total_amount = _order.Total_amount - removeQtyTotalPrice;
                        _order.qty = _order.qty - qty;
                        if (_order.qty == 0)
                        {
                            _order.status = "CANCEL";
                        }
                        if (_orderService.updateOrder(_order))
                        {
                            MessageBox.Show($"{detailsData.Item_name} This Item canceled", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _viewOrderForm.reloadViewOrderData();
                            loadOrderDetail();
                            this.Close();
                        }

                    }
                }
            }
        }

       
    }
}
