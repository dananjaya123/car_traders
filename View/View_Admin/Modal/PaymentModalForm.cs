using car_traders.Model;
using car_traders.Service;
using car_traders.Service.Common;
using car_traders.View.View_Admin.View_Orders;
using MaterialSkin.Controls;
using Org.BouncyCastle.Crypto.Macs;
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
    public partial class PaymentModalForm : MaterialForm
    {
        private readonly OrderService _orderService;
        private readonly UserService _userService;
        private Order orderData;

        private readonly EmailSend _emailSend;
        private readonly AlertService _AlertService;



        public PaymentModalForm()
        {
            _orderService = new OrderService();
            _userService = new UserService();
            _emailSend = new EmailSend();
            _AlertService = new AlertService();
            InitializeComponent();
        }

        public void loadData(Order order)
        {
            orderData = order;
            lblTotalAmount.Text = orderData.Total_amount.ToString("F2");
            texPaidAmount.Text = orderData.Total_amount.ToString("F2");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var paidAmont = texPaidAmount.Text;
            if (!double.TryParse(paidAmont, out double paid) || paid <= 0)
            {
                lblError.Text = "Please Enter a valid Amount";
                lblError.Visible = true;
                return;
            }

            if (paid != double.Parse(lblTotalAmount.Text.ToString()))
            {
                _AlertService.AlertBox("Please Enter a valid Amount", "Error");
                return;

            }

            orderData.status = "PAID";
            orderData.Is_payment = true;
            if (_orderService.updateOrder(orderData))
            {
                var userdata = _userService.getUserByUsercode(orderData.User_code);
                string mailBody = GenerateEmailBody("car traders", userdata.Name, orderData.Order_code, paidAmont);

                if (_emailSend.SendEmail("cartraders@gmail.com", userdata.Email, "Payment successfully", mailBody))
                {
                    _AlertService.AlertBox("Payment successfully", "Success");

                }
            }

        }

        private string GenerateEmailBody(string projectName, string userName, string orderCode, string amount)
        {

            string body = $@"
            <html>
                 <body style='font-family: Arial, sans-serif; color: #333;'>
                <h2 style='color: #4CAF50;'>Payment Confirmation from {projectName}</h2>
                <p>Dear {userName},</p>
                <p>Thank you for your order with <strong>{projectName}</strong>. Below are the Payment details of your order:</p>
                <ul style='list-style-type: none; padding: 0;'>
                    <li><strong>Order Code:</strong> {orderCode}</li>
                    <li><strong>Order Amount:</strong> {amount}</li>
                </ul>
                <p>If you have any questions about your order, please contact our support team.</p>
                <p>Best regards,</p>
                <p><strong>The {projectName} Team</strong></p>
            </body>
            </html>";

            return body;
        }

        private void PaymentModalForm_Load(object sender, EventArgs e)
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
    }
}
