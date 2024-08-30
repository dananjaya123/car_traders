using car_traders.Model;
using car_traders.Service;
using car_traders.Service.Common;
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
    public partial class CarUpdateModalForm : MaterialForm
    {
        private Car _car;
        private readonly CarService _carService;
        private readonly AlertService _AlertService;


        public CarUpdateModalForm(Car car)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

            _carService = new CarService();
            _car = car;
            _AlertService = new AlertService();

            InitializeComponent();
            LoadFormData();
        }

        private void LoadFormData()
        {
            // Use _car to populate the form fields
            texCarBrand.Text = _car.Car_brand;
            texCarColor.Text = _car.Color;
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
            dateTimeCarManuFact.Text = _car.Manufacturing_year;

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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var brand = texCarBrand.Text;
                var color = texCarColor.Text;
                var model = texCarModelName.Text;
                var manuYear = dateTimeCarManuFact.Text;
                var mileageTex = texMileage.Text;
                var body = texBodyType.Text;
                var priceTex = texPrice.Text;
                var fuel = comboFueltype.Text;
                var transmission = comboTransmission.Text;
                var sellerName = texSellerName.Text;
                var mobile = texsellerMobileNum.Text;
                var address = texSellerAddress.Text;
                var description = texDescription.Text;

                if (!int.TryParse(mileageTex, out int mileage) || mileage < 0)
                {
                    lblMileage.Text = "Please Enter a valid Mileage";
                    lblMileage.Visible = true;
                    return;
                }
                // Validate price
                if (!double.TryParse(priceTex, out double price) || price <= 0)
                {
                    lblPrice.Text = "Please Enter a valid Price";
                    lblPrice.Visible = true;
                    return;
                }
                // Retrieve the car  from the repository
                var car = _carService.getCarById(_car.Id);
                if (car != null)
                {
                    car.Car_brand = brand;
                    car.Color = color;
                    car.Model_name = model;
                    car.Manufacturing_year = manuYear;
                    car.Mileage = mileage;
                    car.Body_type = body;
                    car.Price = price;
                    car.Fuel_type = fuel;
                    car.Transmission = transmission;
                    car.Seller_name = sellerName;
                    car.Seller_address = address;
                    car.Mobile_number = mobile;
                    car.Description = description;

                    // Update the car part in the repository
                    if (_carService.updateCar(car))
                    {
                        _AlertService.AlertBox("Car updated successfully", "Success");
                        this.Close();
                    }
                    else
                    {
                        _AlertService.AlertBox("Error updating car", "Error");
                    }
                }
                else
                {
                    _AlertService.AlertBox("Car not found", "Error");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirm before deleting
                var result = MessageBox.Show("Are you sure you want to delete this car ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Retrieve the car part from the repository
                    var car = _carService.getCarById(_car.Id);

                    if (car != null)
                    {
                        // Mark the part as inactive
                        car.Is_active = false;

                        // Update the car part in the repository
                        if (_carService.updateCar(car))
                        {
                            _AlertService.AlertBox("Car deleted successfully", "Success");
                            this.Close();
                        }
                        else
                        {
                            _AlertService.AlertBox("Something went wrong!", "Error");
                        }
                    }
                    else
                    {
                        _AlertService.AlertBox("Car not found!", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void texPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblPrice.Visible = false;
        }

        private void texMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblMileage.Visible = false;
        }
    }
}
