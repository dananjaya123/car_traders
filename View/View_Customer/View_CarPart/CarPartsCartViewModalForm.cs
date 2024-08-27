using car_traders.Model;
using car_traders.Service;
using car_traders.Service.Common;
using car_traders.View.Customer;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.View_Customer.View_CarPart
{
    public partial class CarPartsCartViewModalForm : MaterialForm
    {
        private List<OrderDetails> ordersList;
        private SearchCarPartsForm searchCarForm;

        CarPartsService _carPartsService;
        OrderService _orderService;
        IDGenerate _IDGenerate;
        OrderDetailService _orderDetailService;
        EmailSend _EmailSend;
        public CarPartsCartViewModalForm(List<OrderDetails> ordersList, SearchCarPartsForm searchCarPartsForm)
        {
            InitializeComponent();
            this.ordersList = ordersList;
            this.searchCarForm = searchCarPartsForm;

            _carPartsService = new CarPartsService();
            _orderService = new OrderService();
            _IDGenerate = new IDGenerate();
            _orderDetailService = new OrderDetailService();
            _EmailSend = new EmailSend();
            loadCartDataList();
        }

        public void loadCartDataList()
        {
            try
            {
                listViewCart.Items.Clear();

                foreach (var data in ordersList)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                      data.Item_name,
                      data.Qty.ToString(),
                      data.Total_price.ToString("F2")

                    });

                    listViewCart.Items.Add(listViewItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewCart.SelectedItems.Count > 0)
                {
                    var selectedItem = listViewCart.SelectedItems[0];
                    var partName = selectedItem.SubItems[0].Text;

                    lblPartsName.Text = partName;
                    lblPartsName.Visible = true;
                    btnCancel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCart.SelectedItems.Count > 0)
                {
                    var selectedItem = listViewCart.SelectedItems[0];
                    var partName = selectedItem.SubItems[0].Text;

                    // Find and remove the item from ordersList
                    var itemToRemove = ordersList.Find(x => x.Item_name == partName);
                    if (itemToRemove != null)
                    {
                        ordersList.Remove(itemToRemove);
                    }

                    // Remove the item from listViewCart
                    listViewCart.Items.Remove(selectedItem);

                    // Clear  after removal
                    lblPartsName.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            loader.Visible = true;
            try
            {
                if (ordersList.Count <= 0)
                {
                    MessageBox.Show($"Please select the cart parts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loader.Visible = false;
                    return;
                }


                // Calculate the total quantity from the order details list
                int totalQty = ordersList.Sum(od => od.Qty);

                Model.User user = LoginForm.SesionUserData;
                // Create and save the order
                Order order = new Order
                {
                    Total_amount = ordersList.Sum(od => od.Total_price),
                    Created = DateTime.Now,
                    status = "REQUEST",
                    qty = totalQty,
                    Is_payment = false,
                    User_code = user.User_code,
                    Order_code = _IDGenerate.OrderCodeGenerate(),
                    Is_active = true
                };

                if (_orderService.plaseOrder(order))
                {
                    bool allDetailsSaved = true;

                    // Iterate through the ordersList and save each OrderDetails object
                    foreach (var orderDetails in ordersList)
                    {
                        orderDetails.Order_code = order.Order_code; // Set the order code for each order detail

                        if (!_orderDetailService.saveOrderDetail(orderDetails))
                        {
                            allDetailsSaved = false;
                            break;
                        }
                    }


                    if (allDetailsSaved)
                    {
                        foreach (var orderDetails in ordersList)
                        {
                            // Update car parts quantity based on the ordered quantity
                            CarPart carPart = _carPartsService.getCarPartById(orderDetails.Item_Id);
                            int avilableQty = carPart.Qty - orderDetails.Qty;

                            if (avilableQty > 0)
                            {
                                carPart.Qty = avilableQty;
                            }
                            else if (avilableQty == 0)
                            {
                                carPart.Qty = avilableQty;
                                carPart.Status = "SOLD OUT";
                            }

                            if (!_carPartsService.updateCarPart(carPart))
                            {
                                MessageBox.Show($"Error updating car part: {carPart.Parts_name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                loader.Visible = false;
                                return;
                            }
                        }

                        // Send the order confirmation email
                        string body = GenerateEmailBody("Car traders", user.User_name, order.Order_code, DateTime.Now.ToString("MMMM dd, yyyy"));
                        if (_EmailSend.SendEmail("cartraders@gmail.com", user.Email, "Order Request", body))
                        {

                            // Clear the orders list
                            ordersList.Clear();

                            // Reload the table
                            loadCartDataList();

                            
                            lblPartsName.Text = "";
                            lblPartsName.Visible = false;
                            btnCancel.Visible = false;

                            MessageBox.Show("order submitted successfully!", "Success");
                            loader.Visible = false;
                            // Clear the OrderDetailsList in the original form
                            searchCarForm.ClearOrderDetailsList();
                            this.Close(); // Close the modal form after submission
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error saving order details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show($"Error placing the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Click Part Form Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loader.Visible = false;
            }
        }

        private string GenerateEmailBody(string projectName, string userName, string orderCode, string requestDate)
        {

            string body = $@"
        <html>
        <body style='font-family: Arial, sans-serif; color: #333;'>
        <h2 style='color: #4CAF50;'>Order Confirmation from {projectName}</h2>
        <p>Dear {userName},</p>
        <p>Thank you for your order with <strong>{projectName}</strong>. Below are the details of your order:</p>
        <ul style='list-style-type: none; padding: 0;'>
            <li><strong>Order Code:</strong> {orderCode}</li>
            <li><strong>Request Date:</strong> {requestDate}</li>
        </ul>
        <p>If you have any questions about your order, please contact our support team.</p>
        <p>Best regards,</p>
        <p><strong>The {projectName} Team</strong></p>
        </body>
        </html>";

            return body;
        }

        private void loader_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.DarkBlue;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.CornflowerBlue;
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
