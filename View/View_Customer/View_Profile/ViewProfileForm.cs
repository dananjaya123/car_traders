using car_traders.Model;
using car_traders.Service.Common;
using car_traders.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.View_Customer.View_Profile
{
    public partial class ViewProfileForm : Form
    {
        HashPassword _hashPassword;
        UserService _userService;
        EmailSend _EmailSend;
        public ViewProfileForm()
        {
            _hashPassword = new HashPassword();
            _userService = new UserService();
            _EmailSend = new EmailSend();
            InitializeComponent();
        }

        private User userData;
        public void UdateUser(User user)
        {
            userData = user;

            btnUpdate.Visible = true;
            texName.Text = userData.Name;
            texContactNum.Text = userData.Contact_num;
            texAddress.Text = userData.Address;
            texUserName.Text = userData.User_name;
            texEmail.Text = userData.Email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string pw = texPassword.Text;

                userData.Name = texName.Text;
                userData.Contact_num = texContactNum.Text;
                userData.Email = texEmail.Text;
                userData.Address = texAddress.Text;
                userData.User_name = texUserName.Text;
                userData.Is_active = true;

                if (pw != "")
                {
                    userData.Password = _hashPassword.HashPasswords(pw);
                }

                if (_userService.updateUserDetail(userData))
                {
                    if (pw != "")
                    {
                        string bodpy = GenerateEmailBody("car traders", userData.User_name, userData.Contact_num, userData.Email, userData.Address, pw);
                        _EmailSend.SendEmail("cartraders@gmail.com", userData.Email, "Order Request ", body);
                    }

                    MessageBox.Show("Success");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateEmailBody(string projectName, string userName, string contactNum, string email, string address, string password)
        {


            string body = $@"
        <html>
            <body style='font-family: Arial, sans-serif; color: #333;'>
                <h2 style='color: #4CAF50;'>User Details Updated - {projectName}</h2>
                <p>Dear {userName},</p>
                <p>Your user details have been successfully updated in <strong>{projectName}</strong>. Below are your updated details:</p>
                <ul style='list-style-type: none; padding: 0;'>
                     <li><strong>Contact Number:</strong> {contactNum}</li>
                    <li><strong>Email:</strong> {email}</li>
                    <li><strong>Address:</strong> {address}</li>
                    <li><strong>User name:</strong> {userName}</li>
                    <li><strong>Password:</strong> {password}</li>
               </ul>
                <p>If you have any questions about your account, please contact our support team.</p>
                <p>Best regards,</p>
                <p><strong>The {projectName} Team</strong></p>
            </body>
        </html>";

            return body;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }

    }
}
