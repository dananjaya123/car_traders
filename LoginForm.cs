using car_traders.Model;
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
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            /*MaterialButton desing add*/
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

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
    }
}
