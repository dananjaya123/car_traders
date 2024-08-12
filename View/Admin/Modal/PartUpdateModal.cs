using car_traders.Model;
using car_traders.Repository;
using iText.IO.Image;
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

    public partial class PartUpdateModal : MaterialForm
    {

        private readonly CarPartsRepository _carPartsRepository;
        private CarPart _carPart;

        public PartUpdateModal(CarPart carPart)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);


            _carPart = carPart;

            _carPartsRepository = new CarPartsRepository();

            InitializeComponent();
            loadTextValues();

        }

        public PartUpdateModal()
        {
            InitializeComponent();
        }

        private void loadTextValues()
        {
            texBrandName.Text = _carPart.Brand_name;
            texUpdatePartQty.Text = _carPart.Qty.ToString();
            texUpdatePartPrice.Text = _carPart.Price.ToString();
            texCarMode.Text = _carPart.Car_model;
            texPartName.Text = _carPart.Parts_name;
            texDescription.Text = _carPart.Description;

            if (_carPart.Image_data != null)
            {
                using (MemoryStream ms = new MemoryStream(_carPart.Image_data))
                {
                    imgUpdateCarPart.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }


        private void btnUpdateCarParts_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from the form fields
                var partName = texPartName.Text;
                var priceText = texUpdatePartPrice.Text;
                var qtyText = texUpdatePartQty.Text;
                var brand = texBrandName.Text;
                var model = texCarMode.Text;
                var description = texDescription.Text;

                // Validate Car brand
                if (string.IsNullOrEmpty(brand))
                {
                    lblErrorBrandName.Text = "Please Enter the Car Brand";
                    lblErrorBrandName.Visible = true;
                    return;
                }
                // Validate qty
                if (!int.TryParse(qtyText, out int qty) || qty <= 0)
                {
                    lblErrorPartQty.Text = "Please Enter a valid QTY";
                    lblErrorPartQty.Visible = true;
                    return;
                }
                // Validate price
                if (!double.TryParse(priceText, out double price) || price <= 0)
                {
                    lblErrorUpdatePartPrice.Text = "Please Enter a valid Price";
                    lblErrorUpdatePartPrice.Visible = true;
                    return;
                }
                // Validate Car model
                if (string.IsNullOrEmpty(model))
                {
                    lblErrorCarModel.Text = "Please Enter the Car Model";
                    lblErrorCarModel.Visible = true;
                    return;
                }

                // Validate partName
                if (string.IsNullOrEmpty(partName))
                {
                    lblErrorPartName.Text = "Please Enter the Part name";
                    lblErrorPartName.Visible = true;
                    return;
                }


                // Validate Car description
                if (string.IsNullOrEmpty(description))
                {
                    lblErrorDescription.Text = "Please Enter the Car Description";
                    lblErrorDescription.Visible = true;
                    return;
                }


                // Retrieve the car part from the repository
                var carPart = _carPartsRepository.getCarPartById(_carPart.Id);

                if (carPart != null)
                {
                    // Update car part properties
                    carPart.Parts_name = partName;
                    carPart.Price = price;
                    carPart.Qty = qty;
                    carPart.Brand_name = brand;
                    carPart.Car_model = model;
                    carPart.Description = description;


                    // Update the car part in the repository
                    if (_carPartsRepository.updateCarPart(carPart))
                    {
                        MessageBox.Show("Car Part updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error updating car part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Car part not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void texBrandName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblErrorBrandName.Visible = false;
        }

        private void texUpdatePartQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblErrorPartQty.Visible = false;
        }

        private void texUpdatePartPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblErrorUpdatePartPrice.Visible = false;
        }

        private void texCarMode_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblErrorCarModel.Visible = false;
        }

        private void texPartName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblErrorPartName.Visible = false;
        }

        private void texDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblErrorDescription.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirm before deleting
                var result = MessageBox.Show("Are you sure you want to delete this car part?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Retrieve the car part from the repository
                    var part = _carPartsRepository.getCarPartById(_carPart.Id);

                    if (part != null)
                    {
                        // Mark the part as inactive
                        part.Is_active = false;

                        // Update the car part in the repository
                        if (_carPartsRepository.updateCarPart(part))
                        {
                            MessageBox.Show("Car Part deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error deleting car part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Car part not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearCarParts_Click(object sender, EventArgs e)
        {

        }
    }
}
