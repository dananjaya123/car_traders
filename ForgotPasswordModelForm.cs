using car_traders.Common;
using car_traders.Model;
using car_traders.Repository;
using iText.StyledXmlParser.Jsoup.Safety;
using MaterialSkin;
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

namespace car_traders
{
    public partial class ForgotPasswordModelForm : MaterialForm
    {
        private readonly UserRepository _userRepository;
        private readonly EmailSend _emailSend;
        private readonly IDGenerate _idgenarater;
        private readonly HashPassword _hashPassword;
        public ForgotPasswordModelForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

            _userRepository = new UserRepository();
            _emailSend = new EmailSend();
            _idgenarater = new IDGenerate();
            _hashPassword = new HashPassword();
        }

        private void texOneTimePassword_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string GenerateEmailBody(string projectName, string userName, string password, string otp)
        {
            string body = $@"
        <html>
        <body style='font-family: Arial, sans-serif; color: #333;'>
            <h2 style='color: #4CAF50;'>Welcome to {projectName}!</h2>
            <p>Dear {userName},</p>
            <p>Thank you for registering with <strong>{projectName}</strong>.</p>
            <p>Here are your login details:</p>
            <ul style='list-style-type: none; padding: 0;'>
                <li><strong>Password:</strong> {password}</li>
                <li><strong>One-Time Password (OTP):</strong> {otp}</li>
            </ul>
            <p>Please use the OTP to complete your first login. After logging in, you can change your password in your account settings.</p>
            <p>If you did not request these details, please contact our support team immediately.</p>
            <p>Best regards,</p>
            <p><strong>The {projectName} Team</strong></p>
        </body>
        </html>";

            return body;
        }

        private Model.User user;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblUserError.Visible = false;
                var searchVal = texUserName.Text;

                user = _userRepository.getEqualEmail(searchVal);
                if (user != null)
                {

                    //genarate one time passwor
                    string onetimePw = _idgenarater.IdGenerate();
                    string hashOneTimePw = _hashPassword.HashPasswords(onetimePw);
                    user.Password = hashOneTimePw;


                    if (_userRepository.updateUserDetail(user))
                    {
                        lblUserError.Text = "Please check your Email. sent the One time Password";
                        lblUserError.ForeColor = Color.Green;
                        lblUserError.Visible = true;

                        string body = GenerateEmailBody("Car traders", user.User_name, onetimePw, onetimePw);
                        if (_emailSend.SendEmail("cartraders@gmail.com", user.Email, "One time password", body))
                        {
                            texOneTimePassword.Visible = true;
                        }
                        else
                        {
                            lblUserError.Text = "Something went wrong !";
                            lblUserError.ForeColor = Color.Red;
                            lblUserError.Visible = true;
                        }

                    }

                }
                else
                {
                    lblUserError.Text = "Invalid Please enter valid Email !";
                    lblUserError.Visible = true;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            try
            {
                lblUserError.Visible = false;

                texOneTimePassword.Visible = true;

                var onetimePwTex = texOneTimePassword.Text;
                string enteredHash = _hashPassword.HashPasswords(onetimePwTex);
                if (user.Password.Equals(enteredHash))
                {
                    texNewPassword.Visible = true;
                    var newPw = texNewPassword.Text;
                    user.Password = _hashPassword.HashPasswords(newPw);
                    if (_userRepository.updateUserDetail(user))
                    {
                        MessageBox.Show("Password change succsess.", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void texNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnChangePw.Visible = true;
        }

        private void texOneTimePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            texNewPassword.Visible = true;
        }
    }
}
