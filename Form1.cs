using car_traders.Dta;
using car_traders.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Xml.Linq;

namespace car_traders
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            /*MaterialButton desing add*/
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void click_view_cars(object sender, MouseEventArgs e)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var cars = dbContext.car.ToList();
                loadCarListTable(cars);

            }

        }

        private void loadCarListTable(List<Car> cars)
        {
            tblCarList.Items.Clear();

            foreach (var car in cars)
            {
                var listViewItem = new ListViewItem(new[]
                {
                 car.Car_brand,
                 car.Color,
                 car.Manufacturing_year,
                 car.Model_name,
                 car.Fuel_type,
                 car.Transmission
             });

                tblCarList.Items.Add(listViewItem);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ApplicationDBContext())
                {
                    var car = new Car
                    {
                        Car_brand = texCarBrand.Text,
                        Color = texCarColor.Text,
                        Manufacturing_year = texManufacturingYear.Text,
                        Model_name = texCarModelName.Text,
                        Mileage = int.Parse(texMileage.Text),
                        Fuel_type = comboFueltype.Text,
                        Transmission = comboTransmission.Text,
                        Body_type = texBodyType.Text,
                        Image_url = texUrl.Text,
                        Seller_name = texSellerName.Text,
                        Seller_address = texSellerAddress.Text,
                        Mobile_number = texsellerMobileNum.Text,
                        Price = double.Parse(texPrice.Text),
                        Description = texDescription.Text,
                        Is_active = true
                    };

                    context.car.Add(car);
                    context.SaveChanges();
                    MessageBox.Show("Car added successfully");
                    clearCarForm();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Input format is incorrect: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCarForm();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            string imagesDirectory = @"D:\ESOFT\AD FINAL PROJECT 01\car_traders\Image\cars\";
            string saveFilePath = CommenUploadAndResizeImage(imagesDirectory, imgBox);
            if (saveFilePath != null)
            {
                texUrl.Text = saveFilePath;
            }
            else
            {
                MessageBox.Show("Something went wrong !.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void btnPartsSave_Click(object sender, EventArgs e)
        {
            try
            {

                using (var context = new ApplicationDBContext())
                {
                    var carPart = new CarPart
                    {
                        Pats_name = texPartsNaame.Text,
                        Description = texPartsDescriptions.Text,
                        Price = double.Parse(texPartsPrice.Text),
                        Qty = int.Parse(texPartsQty.Text),
                        Category = texPartsCategory.Text,
                        Car_model = texPartsCarModel.Text,
                        Brand_name = texPartBrandName.Text,
                        Image_url = texPartsImageUrl.Text,
                        Is_active = true

                    };
                    context.car_parts.Add(carPart);
                    context.SaveChanges();
                    MessageBox.Show("Car Part added successfully");
                    cleanCarParts();

                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Input format is incorrect: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void btnPartImageUpload_Click(object sender, EventArgs e)
        {
            string imagesDirectory = @"D:\ESOFT\AD FINAL PROJECT 01\car_traders\Image\parts\";
            string saveFilePath = CommenUploadAndResizeImage(imagesDirectory, imgBoxCarPats);
            if (saveFilePath != null)
            {
                texPartsImageUrl.Text = saveFilePath;
            }
            else
            {
                MessageBox.Show("Something went wrong !.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPartsClear_Click(object sender, EventArgs e)
        {
            cleanCarParts();
        }

        // ********** commen methods ********
        private string CommenUploadAndResizeImage(string saveDirectory, PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Resize the image to match the PictureBox size
                    Bitmap originalImage = new Bitmap(filePath);
                    Bitmap resizedImage = new Bitmap(originalImage, new Size(pictureBox.Width, pictureBox.Height));
                    pictureBox.Image = resizedImage;

                    // Save the image file to the specific directory
                    if (!Directory.Exists(saveDirectory))
                    {
                        Directory.CreateDirectory(saveDirectory);
                    }

                    // Generate a unique name for the image file
                    string fileExtension = Path.GetExtension(filePath);
                    string uniqueFileName = Guid.NewGuid().ToString() + fileExtension;
                    string savePath = Path.Combine(saveDirectory, uniqueFileName);
                    File.Copy(filePath, savePath, true);

                    // Set the image URL
                    return savePath;
                }
            }
            return null;
        }

        private void clearCarForm()
        {
            texCarBrand.Clear();
            texCarColor.Clear();
            texManufacturingYear.Clear();
            texCarModelName.Clear();
            texMileage.Clear();
            comboFueltype.SelectedIndex = -1;
            comboTransmission.SelectedIndex = -1;
            texBodyType.Clear();
            texUrl.Clear();
            texSellerName.Clear();
            texSellerAddress.Clear();
            texsellerMobileNum.Clear();
            texPrice.Clear();
            texDescription.Clear();
            imgBox.Image = null;
        }

        private void cleanCarParts()
        {
            texPartsNaame.Clear();
            texPartsDescriptions.Clear();
            texPartsPrice.Clear();
            texPartsQty.Clear();
            texPartsCategory.Clear();
            texPartsCarModel.Clear();
            texPartBrandName.Clear();
            texPartsImageUrl.Clear();
        }

       
    }
}
