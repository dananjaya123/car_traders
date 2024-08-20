using car_traders.Common;
using car_traders.Model;
using car_traders.Service;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace car_traders
{
    public partial class RegisterModalForm : MaterialForm
    {
        private RoleService _roleService;
        private UserService _userService;
        private HashPassword _hashPassword;
        readonly EmailSend _EmailSend;
        public RegisterModalForm()
        {
            InitializeComponent();
            /*MaterialButton desing add*/
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

            _roleService = new RoleService();
            _userService = new UserService();
            _hashPassword = new HashPassword();
            _EmailSend = new EmailSend();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {


                // Reset all error labels
                ResetErrorLabels();

                // Validate input fields
                if (string.IsNullOrEmpty(texName.Text))
                {
                    lblName.Text = "Name is required.";
                    lblName.Visible = true;
                    return;
                }
                if (string.IsNullOrEmpty(texContactNum.Text))
                {
                    lblMobileNum.Text = "Contact number is required.";
                    lblMobileNum.Visible = true;
                    return;
                }
                if (string.IsNullOrEmpty(texAddress.Text))
                {
                    lblAddress.Text = "Address is required.";
                    lblAddress.Visible = true;
                    return;
                }
                if (string.IsNullOrEmpty(texUserName.Text))
                {
                    lblUserName.Text = "Username is required.";
                    lblUserName.Visible = true;
                    return;
                }
                if (string.IsNullOrEmpty(texEmail.Text))
                {
                    lblEmail.Text = "Email is required.";
                    lblEmail.Visible = true;
                    return;
                }
                if (string.IsNullOrEmpty(texPassword.Text))
                {
                    lblPassword.Text = "Password is required.";
                    lblPassword.Visible = true;
                    return;
                }

                var role = _roleService.getRoleByName("CUSTOMER");

                if (role != null)
                {
                    if (_userService.IsUserNameOrEmailExists(texUserName.Text, texEmail.Text))
                    {
                        MessageBox.Show("Username or Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var userCount = _userService.getUserCount(); // Get the current number of users
                    var userCode = GenerateUserCode(userCount + 1); // Generate the user code for the new user

                    var user = new User
                    {
                        Name = texName.Text,
                        User_code = userCode,
                        Contact_num = texContactNum.Text,
                        Email = texEmail.Text,
                        Address = texAddress.Text,
                        Password = _hashPassword.HashPasswords(texPassword.Text),
                        User_name = texUserName.Text,
                        Role_name = role.Role_name,
                        Is_active = true
                    };

                    if (_userService.saveUser(user))
                    {
                        MessageBox.Show("Success");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot find a User role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pwView_Click(object sender, EventArgs e)
        {
            if (texPassword.PasswordChar == '*')
            {
                texPassword.PasswordChar = '\0';
            }
            else
            {
                texPassword.PasswordChar = '*';
            }
        }

        private string GenerateUserCode(int userCount)
        {
            return $"U{userCount:D4}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            texName.Text = string.Empty;
            texContactNum.Text = string.Empty;
            texEmail.Text = string.Empty;
            texAddress.Text = string.Empty;
            texPassword.Text = string.Empty;
            texUserName.Text = string.Empty;
            ResetErrorLabels();
        }

        private void ResetErrorLabels()
        {
            lblName.Text = "";
            lblMobileNum.Text = "";
            lblAddress.Text = "";
            lblUserName.Text = "";
            lblEmail.Text = "";
            lblPassword.Text = "";

            lblName.Visible = false;
            lblMobileNum.Visible = false;
            lblAddress.Visible = false;
            lblUserName.Visible = false;
            lblEmail.Visible = false;
            lblPassword.Visible = false;
        }

        private void texName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblName.Visible = false;
        }

        private void texContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblMobileNum.Visible = false;

        }

        private void texAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblAddress.Visible = false;

        }

        private void texUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblUserName.Visible = false;

        }

        private void texEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblEmail.Visible = false;

        }

        private void texPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblPassword.Visible = false;

        }

        private User userData;
        public void UdateUser(User user)
        {
            userData = user;

            btnRegister.Visible = false;
            btnClear.Visible = false;
            btnUpdate.Visible = true;

            texName.Text = userData.Name;
            texContactNum.Text = userData.Contact_num;
            texAddress.Text = userData.Address;
            texUserName.Text = userData.User_name;
            texEmail.Text = userData.Email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
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
                        string body = GenerateEmailBody("car traders", userData.User_name, userData.Contact_num, userData.Email, userData.Address,pw);
                        _EmailSend.SendEmail("cartraders@gmail.com", userData.Email, "Order Request ", body);
                    }
                        
                    MessageBox.Show("Success");
                    this.Close();
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

    }
}

