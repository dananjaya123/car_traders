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
                    var userCount = _userRepository.getUserCount(); // Get the current number of users
                    var userCode = GenerateUserCode(userCount + 1); // Generate the user code for the new user

                    var user = new User
                    {
                        Name = texName.Text,
                        User_code = userCode,
                        Contact_num = texContactNum.Text,
                        Email = texEmail.Text,
                        Address = texAddress.Text,
                        Password = HashPassword(texPassword.Text),
                        User_name = texUserName.Text,
                        Role_name = role.Role_name,
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
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

            private void pwView_Click(object sender, EventArgs e){
            if (texPassword.PasswordChar =='*')
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