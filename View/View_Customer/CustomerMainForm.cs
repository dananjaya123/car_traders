using car_traders.Model;
using car_traders.View.Customer;
using car_traders.View.View_Customer.View_Order;
using car_traders.View.View_Customer.View_Profile;
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
    public partial class CustomerMainForm : MaterialForm
    {
        public CustomerMainForm()
        {
            InitializeComponent();

            /*MaterialButton desing add   */
            var materialSkinManager = MaterialSkinManager.Instance;
            /*materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; */
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue800, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCarSearch_Click(object sender, EventArgs e)
        {

            SearchCarForm form = new SearchCarForm();
            pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();

        }

        private void pnlSlide_Paint(object sender, PaintEventArgs e)
        {
            SearchCarForm form = new SearchCarForm();
            pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            SearchCarPartsForm form = new SearchCarPartsForm();
            pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Close();
            form.Show();

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrderForm form = new ViewOrderForm();
            pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            ViewProfileForm form = new ViewProfileForm();
            User user = LoginForm.SesionUserData;
            pnlMain.Controls.Clear();
            form.UdateUser(user);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }
    }
}
