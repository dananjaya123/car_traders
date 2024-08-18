using car_traders.Common;
using car_traders.Model;
using car_traders.Repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace car_traders.View.View_Admin.View_Orders
{
    public partial class ViewRejectOrderForm : Form
    {
        OrderRepository _orderRepository;
        OrderDetailRepository _orderDetailRepository;
        CarRepository _carRepository;
        CarPartsRepository _carPartsRepository;
        PDFGenarate _pdfGenarate;
        UserRepository _userRepository;
        public ViewRejectOrderForm()
        {
            InitializeComponent();
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
            _carRepository = new CarRepository();
            _carPartsRepository = new CarPartsRepository();
            _pdfGenarate = new PDFGenarate();
            _userRepository = new UserRepository();
            loadTable();

        }

        private void loadTable()
        {
            try
            {
                List<Model.Order> orderList = _orderRepository.getAllOrdersByStatus("REJECT");
                listViewRejectOrder.Items.Clear();

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

                    listViewRejectOrder.Items.Add(listViewItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void visibleLable()
        {
            lblItemName.Visible = true;
            lblOrderCode.Visible = true;
            lblPayment.Visible = true;
            lblQty.Visible = true;
            lblCustomerName.Visible = true;
            lblMobileNUm.Visible = true;
            lblStatus.Visible = true;

            imgItem.Visible = true;


            lblItemNameTag.Visible = true;
            lblOrderCodeTag.Visible = true;
            lblPaymenTag.Visible = true;
            lblQtyTag.Visible = true;
            lblCustomerContactTag.Visible = true;
            lblCustomerNameTag.Visible = true;
        }

        private OrderDetails detail;
        private Model.Order order;

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listViewRejectOrder.SelectedItems)
                {
                    loader.Visible = true;
                    var orderCode = item.SubItems[0].Text;

                    order = _orderRepository.getOrderByOrderCode(orderCode);
                    if (order != null)
                    {
                        detail = _orderDetailRepository.getOrderByOrderCode(order.Order_code);
                        if (detail != null)
                        {

                            visibleLable();
                            var userData = _userRepository.getUserByUsercode(order.User_code);



                            lblItemName.Text = detail.Item_name;
                            lblOrderCode.Text = order.Order_code;
                            lblPayment.Text = order.Is_payment ? "PAID" : "NOT PAID";
                            lblQty.Text = detail.Qty.ToString();
                            lblStatus.Text = order.status;
                            lblCustomerName.Text = userData.Name;
                            lblMobileNUm.Text = userData.Contact_num;

                            if (detail.Item_type.Equals("CAR"))
                            {
                                var car = _carRepository.getCarById(detail.Item_Id);
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
                                var part = _carPartsRepository.getCarPartById(detail.Item_Id);
                                if (part.Image_data != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(part.Image_data))
                                    {
                                        imgItem.Image = System.Drawing.Image.FromStream(ms);
                                    }
                                }
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

        private void btnCarPdfPrint_Click(object sender, EventArgs e)
        {
            _pdfGenarate.pdfConverter(listViewRejectOrder, "reject_orders.pdf");

        }

        private void texSearch_TextChanged(object sender, EventArgs e)
        {
            if (texSearch.TextLength >= 1)
            {
                List<Model.Order> orderList = _orderRepository.getCustomerOrderByOrderCodeAndStatu("REJECT", texSearch.Text);
                listViewRejectOrder.Items.Clear();
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

                    listViewRejectOrder.Items.Add(listViewItem);
                }

            }
            else
            {
                loadTable();
            }
        }
    }
}
