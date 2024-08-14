using car_traders.Model;
using car_traders.Repository;
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
        OrderRepository _orderRepository;
        OrderDetailRepository _orderDetailRepository;
        User sesionUser = LoginForm.SesionUserData;
        public ViewOrderForm()
        {

            InitializeComponent();
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
            loadTable();
        }

        private void loadTable()
        {
            try
            {
                List<Order> orderList = _orderRepository.getAllOrdersByUser(sesionUser.User_code);
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
        private void lblBrandTag_Click(object sender, EventArgs e)
        {

        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listViewOrder.SelectedItems)
                {
                    loader.Visible = true;
                    
                    var orderCode = item.SubItems[0].Text; 

                    Order order = _orderRepository.getOrderByOrderCode(orderCode);
                    if (order != null)
                    {
                       var detail = _orderDetailRepository.getOrderByOrderCode(order.Order_code);
                        if (detail !=null)
                        {
                            visibleLable();

                            lblBrandName.Text = detail.Item_name;
                            lblItemName.Text = detail.Item_name;
                            lblOrderCode.Text = order.Order_code;
                            lblPayment.Text = order.Is_payment ? "PAID" : "NOT PAID";
                            lblQty.Text = detail.Qty.ToString();
                            lblTotalAmount.Text = order.Total_amount.ToString("F2");
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

        private void visibleLable()
        {
            lblBrandName.Visible = true;
            lblItemName.Visible = true;
            lblOrderCode.Visible = true;
            lblPayment.Visible = true;
            lblQty.Visible = true;
            lblTotalAmount.Visible = true;

            btnCancel.Visible = true;

            lblBrandTag.Visible = true;
            lblItemNameTag.Visible = true;
            lblOrderCodeTag.Visible = true;
            lblPaymenTag.Visible = true;
            lblQtyTag.Visible = true;
            lblTotalAmountTag.Visible = true;
        }
    }
}
