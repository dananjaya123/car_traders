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
    public partial class CarUpdateModelForm : MaterialForm
    {
        private Car _car;

        public CarUpdateModelForm(Car car)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

            _car = car;
            InitializeComponent();
            LoadFormData();
        }

        private void LoadFormData()
        {
            // Use _car to populate the form fields
            texCarBrand.Text = _car.Car_brand;
            texCarColor.Text = _car.Color;
            texManufacturingYear.Text = _car.Manufacturing_year.ToString();
            texCarModelName.Text = _car.Model_name;
            texMileage.Text = _car.Mileage.ToString();
            comboFueltype.SelectedItem = _car.Fuel_type;
            comboTransmission.SelectedItem = _car.Transmission;
            texBodyType.Text = _car.Body_type;
            texSellerName.Text = _car.Seller_name;
            texSellerAddress.Text = _car.Seller_address;
            texsellerMobileNum.Text = _car.Mobile_number;
            texPrice.Text = _car.Price.ToString("F2"); // Format as currency
            texDescription.Text = _car.Description;

            if (_car.Image_data != null)
            {
                using (var ms = new System.IO.MemoryStream(_car.Image_data))
                {
                    imgBoxCar.Image = Image.FromStream(ms);
                }
            }
            else
            {
                imgBoxCar.Image = null;
            }
        }

        private void texCarBrand_Click(object sender, EventArgs e)
        {

        }

        private void texDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            texCarBrand.Clear();
            texCarColor.Clear();
            texManufacturingYear.Clear();
            texCarModelName.Clear();
            texMileage.Clear();
            comboFueltype.SelectedIndex = -1;
            comboTransmission.SelectedIndex = -1;
            texBodyType.Clear();
            texSellerName.Clear();
            texSellerAddress.Clear();
            texsellerMobileNum.Clear();
            texPrice.Clear();
            texDescription.Clear();
            imgBoxCar.Image = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
