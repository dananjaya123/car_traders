using car_traders.Repository;
using MaterialSkin;
using MaterialSkin.Controls;
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
        public ForgotPasswordModelForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

            _userRepository = new UserRepository();
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
    }
}
