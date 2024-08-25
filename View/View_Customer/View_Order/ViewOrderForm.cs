using car_traders.Model;
using car_traders.Service;
using car_traders.View.View_Customer.View_CarPart;
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

namespace car_traders.View.View_Customer.View_Order
{
    public partial class ViewOrderForm : Form
    {
        readonly OrderService _orderService;
        readonly OrderDetailService _orderDetailService;
        readonly CarService _carService;
        readonly CarPartsService _carPartsService;
        readonly User sesionUser = LoginForm.SesionUserData;
        public ViewOrderForm()
        {

            InitializeComponent();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();
            _carService = new CarService();
            _carPartsService = new CarPartsService();
            loadTable();
        }

        public void reloadViewOrderData()
        {
            loadTable();
        }
        private void loadTable()
        {
            try
            {
                List<Order> orderList = _orderService.getAllOrdersByUser(sesionUser.User_code);
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
        private void texSearchCarPart_TextChanged(object sender, EventArgs e)
        {
            if (texSearch.TextLength >= 1)
            {
                List<Order> orderList = _orderService.getCustomerOrderByNameOrOrderCode(sesionUser.User_code, texSearch.Text);
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

        private List<OrderDetails> detailList;
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
                        detailList = _orderDetailService.getOrderDetailListByOrderCode(order.Order_code);
                        if (detailList != null)
                        {
                            visibleLable();
                            statusCheck();

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

            lblOrderCodeTag.Visible = true;
            lblPaymenTag.Visible = true;
            lblQtyTag.Visible = true;
            lblTotalAmountTag.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loader.Visible = true;
            try
            {
                // Check if the order is in the "REQUEST" status
                if (order.status != "REQUEST")
                {
                    loadTable();
                    MessageBox.Show($"This Order cannot be canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                order.status = "CANCEL";
                order.Is_active = false;
                if (!_orderService.updateOrder(order))
                {
                    MessageBox.Show($"This Order cannot be canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                MessageBox.Show($"{detailItem.Item_name} This Part cannot be canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                        else if (orderType.Equals("CAR"))
                        {
                            if (!_carService.UpdateCarStatusAndQty(itemId, "AVAILABLE", true))
                            {
                                MessageBox.Show($"{detailItem.Item_name} This Car cannot be canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }

                    }
                }
                MessageBox.Show($"{order.Order_code} This Order canceled", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTable();
                loader.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            loader.Visible = true;
            Form modelBackgraund = new Form();
            using (ViewOrderDetailModalForm model = new ViewOrderDetailModalForm(detailList, order, this))
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
                loader.Visible = false;
            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewDetails_MouseHover(object sender, EventArgs e)
        {
            btnViewDetails.BackColor = Color.DarkBlue;
        }

        private void btnViewDetails_MouseLeave(object sender, EventArgs e)
        {
            btnViewDetails.BackColor = Color.CornflowerBlue;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.DarkRed;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.IndianRed;
        }
    }
}
