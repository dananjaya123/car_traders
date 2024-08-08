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
    public partial class RegisterModelForm : MaterialForm
    {
        private RoleRepository _roleRepository;
        private UserRepository _userRepository;
        private HashPassword _hashPassword;
        public RegisterModelForm()
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
                        MessageBox.Show("Something went wrong!");
                    }
                }
                else
                {
                    MessageBox.Show("Canot find a User role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}

