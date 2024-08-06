using car_traders.Repository;
using iText.IO.Image;
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
    
    public partial class PartUpdateModel : MaterialForm
    {
        private Guid _id;
        private string _brandName;
        private double _price;
        private int _qty;
        private string _category;
        private string _carModel;
        private string _status;
        private byte[] _image;

        private readonly CarPartsRepository _carPartsRepository;

        public PartUpdateModel(Guid id, string brandName, double price, int qty, string category, string carModel, string status, byte[] image)
        {
            _id = id;
            _brandName = brandName;
            _price = price;
            _qty = qty;
            _category = category;
            _carModel = carModel;
            _status = status;
            _image = image;

            _carPartsRepository = new CarPartsRepository();

            InitializeComponent();
            loadTextValues();
   
        }

        public PartUpdateModel()
        {
            InitializeComponent();
        }

        private void loadTextValues()
        {
            texBrandName.Text = _brandName;

            if (_image != null)
            {
                using (MemoryStream ms = new MemoryStream(_image))
                {
                    imgUpdateCarPart.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }


        private void btnUpdateCarParts_Click(object sender, EventArgs e)
        {
            try
            {
                var partName = texPartName.Text;
                var priceText = texUpdatePartPrice.Text;
                var qtyText = texUpdatePartQty.Text;

                // Validate partName
                if (string.IsNullOrEmpty(partName))
                {
                    lblErrorUpadatePartName.Text = "Please Enter the Par name";
                    lblErrorUpadatePartName.Visible = true;
                    return;
                }


                // Validate qty
                if (!int.TryParse(qtyText, out int qty) || qty <= 0)
                {
                    lblErrorPartQty.Text = "Please Enter the valid QTY";
                    lblErrorPartQty.Visible = true;
                    return;
                }

                // Validate price
                if (!double.TryParse(priceText, out double price) || price <= 0)
                {
                    lblErrorUpdatePartPrice.Text = "Please Enter the valid Price";
                    lblErrorUpdatePartPrice.Visible = true;
                    return;
                }

                    var carPart = _carPartsRepository.getCarPartById(_id);

                    if (carPart != null)
                    {
                        // Convert image to byte array

                        carPart.Parts_name = partName;
                        carPart.Price = price;
                        carPart.Qty = qty;


                        if (_carPartsRepository.updateCarPart(carPart))
                        {
                            MessageBox.Show("Car Part update successfully");

                        }
                        else
                        {
                            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                     
                    }
                    else
                    {
                        MessageBox.Show("Car part not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
       
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
