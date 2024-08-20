using car_traders.Model;
using car_traders.Service;
using car_traders.Service.Common;
using car_traders.View.View_Admin.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.View_Admin.View_Orders
{
    public partial class ViewRequestOrderForm : Form
    {
        OrderService _orderService;
        OrderDetailService _orderDetailService;
        CarService _carService;
        CarPartsService _carPartsService;
        User sesionUser = LoginForm.SesionUserData;
        PDFGenarate _pdfGenarate;
        public ViewRequestOrderForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();
            _carService = new CarService();
            _carPartsService = new CarPartsService();
            _pdfGenarate = new PDFGenarate();
            loadTable();
        }


        private void loadTable()
        {
            try
            {
                List<Order> orderList = _orderService.getAllOrdersByStatus("REQUEST");
                listViewOrder.Items.Clear();

                foreach (var order in orderList)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                       order.Order_code,
                       order.status,
                       order.Total_amount.ToString("F2"), // Convert double to string with 2 decimal places
                       order.Created.ToString("yyyy/mm/dd"),
                       order.qty.ToString(),
                       order.Is_payment? "PAID" : "NOT PAID"

                    });

                    listViewOrder.Items.Add(listViewItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (order.status != "REQUEST")
                {
                    loadTable();
                    MessageBox.Show($"This Order cnot be REJECT !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var itemId = detail.Item_Id;
                var orderCode = detail.Order_code;
                var orderType = detail.Item_type;


                detail.Is_active = false;
                if (_orderDetailService.updateOrderDetail(detail))
                {
                    order.status = "REJECT";
                    order.Is_active = false;

                    if (_orderService.updateOrder(order))
                    {
                        if (orderType.Equals("PART"))
                        {
                            if (_carPartsService.UpdatePartsStatusAndQty(detail.Item_Id, "AVAILABLE", true, detail.Qty))
                            {
                                MessageBox.Show($" Your order is reject", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else if (orderType.Equals("CAR"))
                        {
                            if (_carService.UpdateCarStatusAndQty(detail.Item_Id, "AVAILABLE", true))
                            {
                                MessageBox.Show($" Your order is reject", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        loadTable();
                        return;

                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private OrderDetails detail;
        private Order order;
        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listViewOrder.SelectedItems)
                {
                    loader.Visible = true;
                    var orderCode = item.SubItems[0].Text;

                    order = _orderService.getOrderByOrderCode(orderCode);
                    if (order != null)
                    {
                        detail = _orderDetailService.getOrderByOrderCode(order.Order_code);
                        if (detail != null)
                        {
                            visibleLable();
                            statusCheck();


                            lblItemName.Text = detail.Item_name;
                            lblOrderCode.Text = order.Order_code;
                            lblPayment.Text = order.Is_payment ? "PAID" : "NOT PAID";
                            lblQty.Text = detail.Qty.ToString();
                            lblTotalAmount.Text = order.Total_amount.ToString("F2");
                            lblStatus.Text = order.status;

                            if (detail.Item_type.Equals("CAR"))
                            {
                                var car = _carService.getCarById(detail.Item_Id);
                                if (car.Image_data != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(car.Image_data))
                                    {
                                        imgItem.Image = System.Drawing.Image.FromStream(ms);
                                    }
                                }

                            }
                            else if (detail.Item_type.Equals("PART"))
                            {
                                var part = _carPartsService.getCarPartById(detail.Item_Id);
                                if (part.Image_data != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(part.Image_data))
                                    {
                                        imgItem.Image = System.Drawing.Image.FromStream(ms);
                                    }
                                }
                            }

                            if (lblPayment.Text == "NOT PAID")
                            {
                                lblPayment.ForeColor = Color.Red;
                            }





                        }

                    }
                    else
                    {
                        MessageBox.Show($" Error : cannot find this order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                loader.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void statusCheck()
        {
            lblStatus.ForeColor = Color.Green;
            if (order.status == "CANSEL")
            {
                lblStatus.ForeColor = Color.Red;
            }
            else if (order.status == "PAID")
            {
                lblStatus.ForeColor = Color.Blue;
            }
        }
        private void visibleLable()
        {
            lblItemName.Visible = true;
            lblOrderCode.Visible = true;
            lblPayment.Visible = true;
            lblQty.Visible = true;
            lblTotalAmount.Visible = true;
            lblStatus.Visible = true;

            imgItem.Visible = true;
            btnCancel.Visible = true;
            btnPayment.Visible = true;

            lblItemNameTag.Visible = true;
            lblOrderCodeTag.Visible = true;
            lblPaymenTag.Visible = true;
            lblQtyTag.Visible = true;
            lblTotalAmountTag.Visible = true;
        }

        private void texSearch_TextChanged(object sender, EventArgs e)
        {
            if (texSearch.TextLength >= 1)
            {
                List<Order> orderList = _orderService.getCustomerOrderByOrderCodeAndStatu("REQUEST", texSearch.Text);
                listViewOrder.Items.Clear();
                if (orderList == null || orderList.Count == 0)
                {
                    MessageBox.Show("No Order found .");
                    return;
                }


                foreach (var order in orderList)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                       order.Order_code,
                       order.status,
                       order.Total_amount.ToString("F2"), // Convert double to string with 2 decimal places
                       order.Created.ToString("yyyy/mm/dd"),
                       order.qty.ToString(),
                       order.Is_payment? "PAID" : "NOT PAID"

                    });

                    listViewOrder.Items.Add(listViewItem);
                }

            }
            else
            {
                loadTable();
            }
        }

        private void btnCarPdfPrint_Click(object sender, EventArgs e)
        {
            _pdfGenarate.pdfConverter(listViewOrder, "order_request.pdf");
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Form modelBackgraund = new Form();
            using (PaymentModalForm model = new PaymentModalForm())
            {
                model.loadData(order);
                modelBackgraund.StartPosition = FormStartPosition.Manual;
                modelBackgraund.FormBorderStyle = FormBorderStyle.None;
                modelBackgraund.Opacity = .0;
                modelBackgraund.BackColor = Color.Black;
                modelBackgraund.Size = this.Size;
                modelBackgraund.Location = this.Location;
                modelBackgraund.ShowInTaskbar = false;
                modelBackgraund.Show();
                model.Owner = modelBackgraund;

                model.ShowDialog();
                modelBackgraund.Dispose();
            }
        }

        private void ViewRequestOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
