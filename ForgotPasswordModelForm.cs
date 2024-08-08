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
    }
}
