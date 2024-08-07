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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders
{
    public partial class RegisterModelForm : MaterialForm
    {
        private RoleRepository _roleRepository;
        private UserRepository _userRepository;
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
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var role = _roleRepository.getRoleByName("CUSTOMER");
                if (role != null)
                {

                    var user = new User
                    {
                        Name = texName.Text,
                        Contact_num = texContactNum.Text,
                        Email = texEmail.Text,
                        Address = texAddress.Text,
                        Password = texPassword.Text,
                        User_name = texUserName.Text,
                        Role = role,
                        Is_active = true
                    };
                    if (_userRepository.saveUser(user))
                    {
                        MessageBox.Show("Success");
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
            if (texPassword.PasswordChar =='*')
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



//try
//{
//    using (MailMessage mm = new MailMessage())
//    {
//        mm.From = new MailAddress("asidananjaya999@gmail.com");
//        mm.To.Add("asidananjaya123@gmail.com");
//        mm.Subject = "YOUR PASSWORD HERE";
//        mm.Body = "Email test send body";

//        using (SmtpClient sc = new SmtpClient("smtp.gmail.com"))
//        {
//            sc.Port = 587; // Use 465 for SSL
//            sc.Credentials = new System.Net.NetworkCredential("asidananjaya999@gmail.com", "asi@$$1234");
//            sc.EnableSsl = true; // Ensure SSL is enabled

//            // Optional: Increase timeout for slow network connections
//            sc.Timeout = 10000; // 10 seconds

//            sc.Send(mm); // Send the email
//        }
//    }

//    MessageBox.Show("Email has been sent");
//}
//catch (SmtpException smtpEx)
//{
//    // Display SMTP-specific error message
//    MessageBox.Show("SMTP error: " + smtpEx.Message);
//}
//catch (Exception ex)
//{
//    // Display general error message
//    MessageBox.Show("Error: " + ex.Message);
//}