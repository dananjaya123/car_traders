using car_traders.Model;
using car_traders.Service;
using car_traders.View.View_Admin.View_Orders;
using car_traders.View.View_Customer.View_Order;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.View_Admin.Modal
{
    public partial class CustomerOrderDetailViewModalForm : MaterialForm
    {
        readonly List<OrderDetails> _orderDetailList;
        readonly Model.Order _order;
        View_Orders.ViewOrderForm _viewOrderForm;

        readonly CarService _carService;
        readonly CarPartsService _carPartsService;
        readonly OrderService _orderService;
        readonly OrderDetailService _orderDetailService;
        public CustomerOrderDetailViewModalForm(List<OrderDetails> detailList, Order order, View_Orders.ViewOrderForm viewCustomerOrderForm)
        {
            InitializeComponent();
            _orderDetailList = detailList;
            _order = order;
            _viewOrderForm = viewCustomerOrderForm;

            _carService = new CarService();
            _carPartsService = new CarPartsService();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();

            loadOrderDetail();

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

             

                    imgItem.Visible = true;
                    imgItem.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
