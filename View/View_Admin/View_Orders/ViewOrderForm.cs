using car_traders.Model;
using car_traders.Service;
using car_traders.Service.Common;
using car_traders.View.View_Admin.Modal;
using car_traders.View.View_Customer.View_Order;
using Mysqlx.Crud;
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
    public partial class ViewOrderForm : Form
    {
        readonly OrderService _orderService;
        readonly OrderDetailService _orderDetailService;
        readonly CarService _carService;
        readonly CarPartsService _carPartsService;
        readonly UserService _userService;
        readonly User sesionUser = LoginForm.SesionUserData;
        readonly PDFGenarate _pdfGenarate;
        private string btnSelectValue = "";
        public ViewOrderForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();
            _carService = new CarService();
            _carPartsService = new CarPartsService();
            _pdfGenarate = new PDFGenarate();
            _userService = new UserService();


        }

        public void selectMainFormButtonValues(string btnValue)
        {
            btnSelectValue = btnValue;
            lblTitle.Text = $"ORDER {btnValue} FORM";
            loadTable();
        }
        private void loadTable()
        {
            try
            {
                List<Model.Order> orderList = _orderService.getAllOrdersByStatus(btnSelectValue);
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


        private List<OrderDetails> detailList;
        private Model.Order order;
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
                        detailList = _orderDetailService.getOrderDetailListByOrderCode(order.Order_code);
                        Model.User userData = _userService.getUserByUsercode(order.User_code);
                        if (detailList != null)
                        {
                            visibleLable();
                            statusCheck();

                            //load user data
                            lblUserName.Text = userData.Name;
                            lblMobileNumber.Text = userData.Contact_num;
                            lblAddress.Text = userData.Address;
                            lblUserCode.Text = userData.User_code;

                            // load order data
                            lblOrderCode.Text = order.Order_code;
                            lblPayment.Text = order.Is_payment ? "PAID" : "NOT PAID";
                            lblQty.Text = order.qty.ToString();
                            lblTotalAmount.Text = order.Total_amount.ToString("F2");
                            lblStatus.Text = order.status;

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
            if (order.status == "CANCEL" || order.status == "REJECT")
            {
                lblStatus.ForeColor = Color.Red;
                unVisibleButton();
            }
            else if (order.status == "PAID")
            {
                lblStatus.ForeColor = Color.Blue;
                unVisibleButton();
            }
        }

        private void unVisibleButton()
        {
            btnCancel.Visible = false;
            btnPayment.Visible = false;
        }
        private void visibleLable()
        {

            lblOrderCode.Visible = true;
            lblPayment.Visible = true;
            lblQty.Visible = true;
            lblTotalAmount.Visible = true;
            lblStatus.Visible = true;

            btnCancel.Visible = true;
            btnViewDetails.Visible = true;
            btnPayment.Visible = true;

            lblOrderCodeTag.Visible = true;
            lblPaymenTag.Visible = true;
            lblQtyTag.Visible = true;
            lblTotalAmountTag.Visible = true;
            lblStatusTag.Visible = true;

            lblUserNameTag.Visible = true;
            lblMobileTag.Visible = true;
            lblUserCodeTag.Visible = true;
            lblAddressTag.Visible = true;

            lblUserName.Visible = true;
            lblMobileNumber.Visible = true;
            lblAddress.Visible = true;
            lblUserCode.Visible = true;
        }

        private void texSearch_TextChanged(object sender, EventArgs e)
        {
            if (texSearch.TextLength >= 1)
            {
                
                List<Model.Order> orderList = _orderService.getCustomerOrderByOrderCodeAndStatu(btnSelectValue, texSearch.Text);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the order is in the "REQUEST" status
                if (order.status != "REQUEST")
                {
                    loadTable();
                    MessageBox.Show($"This Order cannot be reject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                order.status = "REJECT";
                order.Is_active = false;
                if (!_orderService.updateOrder(order))
                {
                    MessageBox.Show($"This Order cannot be reject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var detailItem in detailList)
                {


                    var itemId = detailItem.Item_Id;
                    var orderType = detailItem.Item_type;

                    // Deactivate the order detail
                    detailItem.Is_active = false;
                    if (_orderDetailService.updateOrderDetail(detailItem))
                    {

                        if (orderType.Equals("PART"))
                        {
                            if (!_carPartsService.UpdatePartsStatusAndQty(itemId, "AVAILABLE", true, detailItem.Qty))
                            {
                                MessageBox.Show($"{detailItem.Item_name} This Part cannot be reject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                        else if (orderType.Equals("CAR"))
                        {
                            if (!_carService.UpdateCarStatusAndQty(itemId, "AVAILABLE", true))
                            {
                                MessageBox.Show($"{detailItem.Item_name} This Car cannot be reject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }

                    }
                }
                MessageBox.Show($"{order.Order_code} This Order reject", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            Form modelBackgraund = new Form();
            using (CustomerOrderDetailViewModalForm model = new CustomerOrderDetailViewModalForm(detailList, order, this))
            {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarPdfPrint_Click(object sender, EventArgs e)
        {
            _pdfGenarate.pdfConverter(listViewOrder, $"{btnSelectValue}.pdf");

        }
    }
}
