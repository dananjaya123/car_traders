using car_traders.Common;
using car_traders.Model;
using car_traders.Repository;
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

namespace car_traders
{
    public partial class RegisterModalForm : MaterialForm
    {
        private RoleRepository _roleRepository;
        private UserRepository _userRepository;
        private HashPassword _hashPassword;
        public RegisterModalForm()
        {
            InitializeComponent();
            /*MaterialButton desing add*/
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

            _roleRepository = new RoleRepository();
            _userRepository = new UserRepository();
            _hashPassword = new HashPassword();
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

                var role = _roleRepository.getRoleByName("CUSTOMER");

                if (role != null)
                {
                    if (_userRepository.IsUserNameOrEmailExists(texUserName.Text, texEmail.Text))
                    {
                        MessageBox.Show("Username or Email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var userCount = _userRepository.getUserCount(); // Get the current number of users
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

                    if (_userRepository.saveUser(user))
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
    }
}

