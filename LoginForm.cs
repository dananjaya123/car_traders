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
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using car_traders.Common;

namespace car_traders
{
    public partial class LoginForm : MaterialForm
    {
        private HashPassword _hashPassword;
        private UserRepository _userRepository;
        public LoginForm()
        {
            InitializeComponent();
            /*MaterialButton desing add*/
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

            _userRepository = new UserRepository();
            _hashPassword = new HashPassword();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = texUserName.Text;
                var password = texPassword.Text;


                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashedPassword = _hashPassword.HashPasswords(password);


                var user = _userRepository.Login(userName, hashedPassword);

                if (user != null)
                {
                    if (user.Role_name == "ADMIN")
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();

                    }

                    if (user.Role_name == "CUSTOMER")
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();


                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void texPassword_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form modelBackgraund = new Form();
            using (RegisterModelForm model = new RegisterModelForm())
            {
                modelBackgraund.StartPosition = FormStartPosition.Manual;
                modelBackgraund.FormBorderStyle = FormBorderStyle.None;
                modelBackgraund.Opacity = .50;
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

        

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordModelForm form = new ForgotPasswordModelForm();
            form.Show();

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
    }
}
