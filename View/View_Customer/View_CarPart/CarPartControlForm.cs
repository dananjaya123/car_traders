using car_traders.Model;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.View_Customer.View_CarPart
{
    public partial class CarPartControlForm : UserControl
    {
        private CarPart CarPart;
        public CarPartControlForm()
        {
            InitializeComponent();
        }
        public void loadCarPartCart(CarPart carPart)
        {
            CarPart = carPart;
            lblBrand.Text = carPart.Brand_name;
            lblCarModel.Text = carPart.Car_model;
            lblCarPartName.Text = carPart.Parts_name;
            lblPrice.Text = carPart.Price.ToString("F2");
            lblQty.Text = carPart.Qty.ToString();
            lblStatus.Text = carPart.Status.ToString();
            if (carPart.Image_data != null)
            {
                using (MemoryStream ms = new MemoryStream(carPart.Image_data))
                {
                    imgCarPart.Image = System.Drawing.Image.FromStream(ms);
                }
            }

            if (carPart.Status == "SOLD OUT")
            {
                lblStatus.ForeColor = Color.Red;
            }
        }

        public static bool click = false;
        public static CarPart clickCarPartData;
        private void CarPartControlForm_Click(object sender, EventArgs e)
        {
            click = true;
            clickCarPartData = CarPart;
        }

        private void CarPartControlForm_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void CarPartControlForm_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
