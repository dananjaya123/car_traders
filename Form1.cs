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

        private void btnSave_Click(object sender, EventArgs e)
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
                MessageBox.Show("Employee added successfully");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
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

                    imgBox.Image = new Bitmap(filePath);    

                    // Save the image file to the specific directory
                    string imagesDirectory = @"D:\ESOFT\AD FINAL PROJECT 01\car_traders\Image\";
                    if (!Directory.Exists(imagesDirectory))
                    {
                        Directory.CreateDirectory(imagesDirectory);
                    }

                    string fileName = Path.GetFileName(filePath);
                    string savePath = Path.Combine(imagesDirectory, fileName);
                    File.Copy(filePath, savePath, true);

                    // Set the image URL
                    texUrl.Text = savePath;
                }
            }

        }
    }
}
