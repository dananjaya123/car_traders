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
            lblColor.Text = car.Color;
            lblManufacturingYear.Text = car.Manufacturing_year;

            if (car.Image_data != null)
            {
                using (MemoryStream ms = new MemoryStream(car.Image_data))
                {
                    imgCar.Image = System.Drawing.Image.FromStream(ms);
                }
            }


        }

        private void SearchCarUserColtrollFrom_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void SearchCarUserColtrollFrom_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void SearchCarUserColtrollFrom_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void SearchCarUserColtrollFrom_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Cardata.Model_name);
        }
    }
}
