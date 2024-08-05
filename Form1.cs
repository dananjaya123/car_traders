using car_traders.Dta;
using car_traders.Model;
using car_traders.Repository;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Xml.Linq;

namespace car_traders
{
    public partial class Form1 : MaterialForm
    {
        private readonly CarRepository _carRepository;
        private readonly CarPartsRepository _carPartsRepository;
        private readonly UserRepository _userRepository;

        public Form1()
        {
            InitializeComponent();
            /*MaterialButton desing add   */
            var materialSkinManager = MaterialSkinManager.Instance;
            /*materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; */
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

            // Initialize CarRepository
            _carRepository = new CarRepository();
            _carPartsRepository = new CarPartsRepository();
            _userRepository = new UserRepository();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load dashboard data
            LoadDashboardCount();

            // load table data
            LoadCarTable();
            loadCarPartsListTable();





        }


        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void click_view_cars(object sender, MouseEventArgs e)
        {


        }

        // ************************************* Car Functions ************************************

        private void loadCarListTable(List<Car> cars)
        {
            //load data 
            dataGridViewCars.DataSource = cars;
            // Hide  column
            if (dataGridViewCars.Columns["Id"] != null)
            {
                dataGridViewCars.Columns["Id"].Visible = false;
                dataGridViewCars.Columns["Is_active"].Visible = false;
            }
            // Set the row height
            foreach (DataGridViewRow row in dataGridViewCars.Rows)
            {
                row.Height = 300;
            }

            if (dataGridViewCarPart.Columns["Image_data"] != null)
            {
                dataGridViewCarPart.Columns["Image_data"].Width = 300; // Adjust the width of the image column if necessary
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
                        Seller_name = texSellerName.Text,
                        Seller_address = texSellerAddress.Text,
                        Mobile_number = texsellerMobileNum.Text,
                        Price = double.Parse(texPrice.Text),
                        Description = texDescription.Text,
                        Is_active = true
                    };
                    // Convert image from PictureBox to byte array
                    if (imgBoxCar.Image != null)
                    {
                        car.Image_data = ImageToByteArray(imgBoxCar.Image);
                    }

                    context.car.Add(car);
                    context.SaveChanges();
                    MessageBox.Show("Car added successfully");
                    clearCarForm();
                    LoadCarTable();
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
            CommenUploadAndResizeImage(imgBoxCar);

        }

        private void searchCarTableLoadData(object sender, KeyEventArgs e)
        {
            var searchModelName = texCarTableSearch.Text;
            if (searchModelName == "")
            {
                LoadCarTable();

            }
            else
            {
                List<Car> carList = _carRepository.getAllCarListByModelName(searchModelName);
                loadCarListTable(carList);
            }

        }

        // ************************************* Car parts functions **********************************

        private void loadCarPartsListTable(List<CarPart> car_parts)
        {
            try
            {
                dataGridViewCarPart.DataSource = car_parts;
                // Hide  column
                if (dataGridViewCarPart.Columns["Id"] != null)
                {
                    dataGridViewCarPart.Columns["Id"].Visible = false;
                    dataGridViewCarPart.Columns["Is_active"].Visible = false;
                }

                // Set the row height
                foreach (DataGridViewRow row in dataGridViewCarPart.Rows)
                {
                    row.Height = 300;
                }

                if (dataGridViewCarPart.Columns["Image_data"] != null)
                {
                    dataGridViewCarPart.Columns["Image_data"].Width = 300; // Adjust the width of the image column if necessary
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        Parts_name = texPartsNaame.Text,
                        Description = texPartsDescriptions.Text,
                        Price = double.Parse(texPartsPrice.Text),
                        Qty = int.Parse(texPartsQty.Text),
                        Category = texPartsCategory.Text,
                        Car_model = texPartsCarModel.Text,
                        Brand_name = texPartBrandName.Text,
                        Is_active = true

                    };
                    // Convert image from PictureBox to byte array
                    if (imgBoxCarPats.Image != null)
                    {
                        carPart.Image_data = ImageToByteArray(imgBoxCarPats.Image);
                    }
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
            CommenUploadAndResizeImage(imgBoxCarPats);

        }

        private void btnPartsClear_Click(object sender, EventArgs e)
        {
            cleanCarParts();
        }

        private void searchTableCarParts(object sender, KeyEventArgs e)
        {
            try
            {
                var searchVal = texSearchCarPartTabl.Text;
                if (searchVal == "")
                {
                    loadCarPartsListTable();
                }
                else
                {
                    List<CarPart> parts = _carPartsRepository.getCarPartsByPartName(searchVal);
                    loadCarPartsListTable(parts);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dataGridViewCarPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewCarPart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewCarPart.CurrentRow.Selected = true;
                    texUpdateCarPartName.Text = dataGridViewCarPart.Rows[e.RowIndex].Cells["Parts_name"].FormattedValue.ToString();
                    texUpdatePartQty.Text = dataGridViewCarPart.Rows[e.RowIndex].Cells["Qty"].FormattedValue.ToString();
                    texUpdatePartPrice.Text = dataGridViewCarPart.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    // Load image from byte array
                    byte[] imageData = (byte[])dataGridViewCarPart.Rows[e.RowIndex].Cells["Image_data"].Value;
                    if (imageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            imgUpdateCarPart.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // ************************* commen Functions *********************************************

        private void LoadCarTable()
        {
            List<Car> carList = _carRepository.getAllCarList();
            loadCarListTable(carList);
        }

        private void loadCarPartsListTable()
        {
            var carParts = _carPartsRepository.getAllCarPartList();
            loadCarPartsListTable(carParts);
        }
        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Or the appropriate format
                return ms.ToArray();
            }
        }

        private void CommenUploadAndResizeImage(PictureBox pictureBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Bitmap originalImage = new Bitmap(openFileDialog.FileName);
                Bitmap resizedImage = new Bitmap(originalImage, new Size(pictureBox.Width, pictureBox.Height));
                pictureBox.Image = resizedImage;
            }
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
            texSellerName.Clear();
            texSellerAddress.Clear();
            texsellerMobileNum.Clear();
            texPrice.Clear();
            texDescription.Clear();
            imgBoxCar.Image = null;
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
            imgBoxCarPats.Image = null;
        }

        private void LoadDashboardCount()
        {
            //car count
            int carCount = _carRepository.GetCarCount();
            lblCarCount.Text = carCount.ToString();

            //car parts count
            int partCount = _carPartsRepository.getActiveCarPartsCaount();
            lblPartsCoun.Text = partCount.ToString();

            //active customer load
            int customerCount = _userRepository.GetCusotmerCount();
            lblCustomerCount.Text = customerCount.ToString();


        }



        private void GeneratePdf(string fileName, List<string> columnNames, List<List<string>> tableValues)
        {
            // Define the file path where the PDF will be saved
            string filePath = $"{fileName}.pdf";

            // Create a PDF writer instance with the specified file path
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                // Create a PDF document instance with the writer
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    // Create a Document instance to add elements to the PDF
                    var document = new iText.Layout.Document(pdf);


                    // Create a table with the number of columns matching the column names
                    Table table = new Table(columnNames.Count);
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    // Add header row to the table
                    foreach (var columnName in columnNames)
                    {
                        table.AddHeaderCell(columnName);
                    }

                    // Loop through the list of table values and add each row to the table
                    foreach (var rowValues in tableValues)
                    {
                        foreach (var cellValue in rowValues)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(cellValue)));
                        }
                    }

                    // Add the table to the document
                    document.Add(table);

                    // Close the document to finalize the PDF
                    document.Close();
                }
            }

            // Inform the user that the PDF was generated successfully
            MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveCustomer_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerCount_Click(object sender, EventArgs e)
        {

        }

        private void tabDashboard_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
