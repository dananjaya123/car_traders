using car_traders.Dta;
using car_traders.Model;
using car_traders.Repository;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Utilities;
using System.Data;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Xml.Linq;

namespace car_traders
{
    public partial class AdminMainForm : MaterialForm
    {
        private readonly CarRepository _carRepository;
        private readonly CarPartsRepository _carPartsRepository;
        private readonly UserRepository _userRepository;

        public AdminMainForm()
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

            try
            {
                tblListViewCar.Items.Clear();

                foreach (var car in cars)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                       car.Car_brand,
                       car.Color,
                       car.Manufacturing_year,
                       car.Model_name,
                       car.Mileage.ToString(),
                       car.Transmission,
                       car.Body_type,
                       car.Status,
                       car.Price.ToString("F2"), // Convert double to string with 2 decimal places
                       car.Id.ToString(), // Convert Guid to string
                      
                    });

                    tblListViewCar.Items.Add(listViewItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tblListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in tblListViewCar.SelectedItems)
                {

                    // Assuming the subitems are in the same order as you added them
                    var id = Guid.Parse(item.SubItems[9].Text); // Convert from string to Guid

                    var car = _carRepository.getCarById(id);

                    Form modelBackgraund = new Form();
                    using (CarUpdateModalForm model = new CarUpdateModalForm(car))
                    {
                        modelBackgraund.StartPosition = FormStartPosition.Manual;
                        modelBackgraund.FormBorderStyle = FormBorderStyle.None;
                        modelBackgraund.Opacity = .50;
                        modelBackgraund.BackColor = Color.Black;
                        modelBackgraund.Size = this.Size;
                        modelBackgraund.Location = this.Location;
                        modelBackgraund.ShowInTaskbar = false;
                        modelBackgraund.Show();
                        model.Owner = modelBackgraund;

                        model.ShowDialog();
                        modelBackgraund.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    Car_brand = texCarBrand.Text,
                    Color = texCarColor.Text,
                    Manufacturing_year = dateTimeCarManuFact.Text,
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

                if (_carRepository.saveCar(car))
                {
                    MessageBox.Show("Car added successfully");
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
                clearCarForm();
                LoadCarTable();
                LoadDashboardCount();

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
                carPartsListView.Items.Clear();

                foreach (var part in car_parts)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                       part.Parts_name,
                       part.Price.ToString("F2"), // Convert double to string with 2 decimal places
                       part.Qty.ToString(), // Convert int to string
                       part.Category,
                       part.Car_model,
                       part.Brand_name,
                       part.Status,
                       part.Id.ToString(), // Convert Guid to string
                      
                    });

                    carPartsListView.Items.Add(listViewItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void carPartListViewRowSelect(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in carPartsListView.SelectedItems)
                {
                    // Assuming the subitems are in the same order as you added them
                    var id = Guid.Parse(item.SubItems[7].Text); // Convert from string to Guid

                    var carPart = _carPartsRepository.getCarPartById(id);


                    Form modelBackgraund = new Form();
                    using (PartUpdateModal model = new PartUpdateModal(carPart))
                    {
                        modelBackgraund.StartPosition = FormStartPosition.Manual;
                        modelBackgraund.FormBorderStyle = FormBorderStyle.None;
                        modelBackgraund.Opacity = .50;
                        modelBackgraund.BackColor = Color.Black;
                        modelBackgraund.Size = this.Size;
                        modelBackgraund.Location = this.Location;
                        modelBackgraund.ShowInTaskbar = false;
                        modelBackgraund.Show();
                        model.Owner = modelBackgraund;

                        model.ShowDialog();
                        modelBackgraund.Dispose();
                    }

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
                if (_carPartsRepository.saveCarPart(carPart))
                {
                    MessageBox.Show("Car Part added successfully");
                    loadCarPartsListTable();
                    LoadDashboardCount();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }

                cleanCarParts();



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

        }
        private void btnUpdateCarParts_Click(object sender, EventArgs e)
        {

        }
        private void btnClearCarParts_Click(object sender, EventArgs e)
        {

        }


        private void btnDeleteCarPart_Click(object sender, EventArgs e)
        {

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

        private void clearUpdatePartForm()
        {

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

        private void texUpdateCarPartName_Click(object sender, EventArgs e)
        {
        }

        private void texUpdatePartQty_Click(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabViewPats_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintPartList_Click(object sender, EventArgs e)
        {
            if (carPartsListView.Items.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Result.pdf"
                };

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }

                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(carPartsListView.Columns.Count)
                            {
                                DefaultCell = { Padding = 2 },
                                WidthPercentage = 100,
                                HorizontalAlignment = Element.ALIGN_LEFT
                            };

                            // Adding headers
                            foreach (ColumnHeader col in carPartsListView.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.Text));
                                pTable.AddCell(pCell);
                            }

                            // Adding data rows
                            foreach (ListViewItem item in carPartsListView.Items)
                            {
                                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                                {
                                    pTable.AddCell(subItem.Text);
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();
                                document.Add(pTable);
                                document.Close();

                                fileStream.Close();
                            }

                            MessageBox.Show("Data exported successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No records found", "Info");
            }
        }
    }
}
