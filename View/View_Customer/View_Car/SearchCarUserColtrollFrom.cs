using car_traders.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.Customer
{
    public partial class SearchCarUserColtrollFrom : UserControl
    {
        private Car Cardata;
        public SearchCarUserColtrollFrom()
        {
            InitializeComponent();
        }

        public void carDetails(Car car)
        {
            Cardata = car;
            lblCarName.Text = car.Model_name;
            lblCarBrand.Text = car.Car_brand;
            lblColor.Text = car.Color;
            lblManufacturingYear.Text = car.Manufacturing_year;
            lblPrice.Text = car.Price.ToString("F2");
            lblStatus.Text = car.Status;
            lblCarSelingType.Text = car.Selling_type;
            if (car.Image_data != null)
            {
                using (MemoryStream ms = new MemoryStream(car.Image_data))
                {
                    imgCar.Image = System.Drawing.Image.FromStream(ms);
                }
            }

            if (car.Status == "SOLD OUT")
            {
                lblStatus.ForeColor = Color.Red;
            }

            if (car.Selling_type == "USED")
            {
                lblCarSelingType.ForeColor = Color.Blue;
            }


        }

        private void SearchCarUserColtrollFrom_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }
        private void SearchCarUserColtrollFrom_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        public static bool click = false;
        public static Car clickCar; 
        private void SearchCarUserColtrollFrom_Click(object sender, EventArgs e)
        {
            click = true;
            clickCar = Cardata;
        }
    }
}
