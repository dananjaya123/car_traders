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
    }
}
