using car_traders.Dta;
using car_traders.Model;
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
using car_traders.View.View_Admin.View_Orders;
using car_traders.View.View_Admin.View_Customer;
using car_traders.Service;
using car_traders.Service.Common;
using Microsoft.VisualBasic.ApplicationServices;

namespace car_traders
{
    public partial class AdminMainForm : MaterialForm
    {
        private readonly CarService _carService;
        private readonly CarPartsService _carPartService;
        private readonly OrderService _orderService;
        private readonly UserService _userService;
        private readonly PDFGenarate _pdfGenarate;

        public AdminMainForm()
        {
            InitializeComponent();
            /*MaterialButton desing add   */
            var materialSkinManager = MaterialSkinManager.Instance;
            /*materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; */
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

            // Initialize CarRepository
            _carService = new CarService();
            _carPartService = new CarPartsService();
            _userService = new UserService();
            _pdfGenarate = new PDFGenarate();
            _orderService = new OrderService();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load dashboard data
            LoadDashboardCount();

            // load table data
            LoadCarTable();
            loadCarPartsListTable();
            orderFormsLoad();
            customerFormLoad();

        }

        private void orderFormsLoad()
        {

            ViewOrderMainForm form = new ViewOrderMainForm();
            pnlOrderMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlOrderMain.Size;
            form.Dock = DockStyle.Fill;

            pnlOrderMain.Controls.Add(form);
            form.Show();
        }

        private void customerFormLoad()
        {

            ViewCustomerForm form = new ViewCustomerForm();
            pnlCustomerMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlOrderMain.Size;
            form.Dock = DockStyle.Fill;

            pnlCustomerMain.Controls.Add(form);
            form.Show();
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

                    var car = _carService.getCarById(id);

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

        private void comboCarSellerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboCarSellerType.Text;
            if (type.Equals("USED"))
            {
                texSellerName.Visible = true;
                texsellerMobileNum.Visible = true;
                texSellerAddress.Visible = true;
            }
            else
            {
                texSellerName.Visible = false;
                texsellerMobileNum.Visible = false;
                texSellerAddress.Visible = false;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(texCarBrand.Text) ||
                string.IsNullOrWhiteSpace(texCarColor.Text) ||
                string.IsNullOrWhiteSpace(dateTimeCarManuFact.Text) ||
                string.IsNullOrWhiteSpace(texCarModelName.Text) ||
                string.IsNullOrWhiteSpace(texMileage.Text) ||
                string.IsNullOrWhiteSpace(comboFueltype.Text) ||
                string.IsNullOrWhiteSpace(comboTransmission.Text) ||
                string.IsNullOrWhiteSpace(comboCarSellerType.Text) ||
                string.IsNullOrWhiteSpace(texBodyType.Text) ||
                string.IsNullOrWhiteSpace(texPrice.Text) ||
                string.IsNullOrWhiteSpace(texDescription.Text))
                {
                    lblCarFormError.Visible = true;
                    lblCarFormError.Text = "Please fill in all required fields.";
                    return;
                }

                if (comboCarSellerType.Text.Equals("USED"))
                {
                    if (string.IsNullOrWhiteSpace(texSellerName.Text) ||
                        string.IsNullOrWhiteSpace(texSellerAddress.Text) ||
                        string.IsNullOrWhiteSpace(texsellerMobileNum.Text))
                    {
                        lblCarFormError.Visible = true;
                        lblCarFormError.Text = "Please fill in all required fields.";
                        return;
                    }
                }

                if (!int.TryParse(texMileage.Text, out int mileage))
                {
                    lblCarFormError.Visible = true;
                    lblCarFormError.Text = "Mileage must be a valid numbers.(ex : 10000)";
                    return;
                }
                if (!double.TryParse(texPrice.Text, out double price))
                {
                    lblCarFormError.Visible = true;
                    lblCarFormError.Text = "Price must be a valid price.(ex : 1234)";
                    return;
                }
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
                    Selling_type = comboCarSellerType.Text,
                    Is_active = true
                };
                // Convert image from PictureBox to byte array
                if (imgBoxCar.Image != null)
                {
                    car.Image_data = ImageToByteArray(imgBoxCar.Image);
                }

                if (_carService.saveCar(car))
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
                List<Car> carList = _carService.getAllCarListByModelName(searchModelName);
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

                    var carPart = _carPartService.getCarPartById(id);


                    Form modelBackgraund = new Form();
                    using (CarPartUpdateModal model = new CarPartUpdateModal(carPart))
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
                if (string.IsNullOrWhiteSpace(texPartsNaame.Text) ||
                string.IsNullOrWhiteSpace(comboPartCategory.Text) ||
                string.IsNullOrWhiteSpace(texPartsCarModel.Text) ||
                string.IsNullOrWhiteSpace(texPartBrandName.Text))
                {
                    lblcarPartFormError.Visible = true;
                    lblcarPartFormError.Text = "Please fill in all required fields.";
                    return;
                }

                if (!int.TryParse(texPartsQty.Text, out int qty))
                {
                    lblcarPartFormError.Visible = true;
                    lblcarPartFormError.Text = "Qty must be a valid qty.(ex : 10)";
                    return;
                }

                if (!double.TryParse(texPartsPrice.Text, out double price))
                {
                    lblcarPartFormError.Visible = true;
                    lblcarPartFormError.Text = "Price must be a valid price.(ex : 1234.00)";
                    return;
                }
                var carPart = new CarPart
                {
                    Parts_name = texPartsNaame.Text,
                    Description = texPartsDescriptions.Text,
                    Price = double.Parse(texPartsPrice.Text),
                    Qty = int.Parse(texPartsQty.Text),
                    Category = comboPartCategory.Text,
                    Car_model = texPartsCarModel.Text,
                    Brand_name = texPartBrandName.Text,
                    Is_active = true

                };
                // Convert image from PictureBox to byte array
                if (imgBoxCarPats.Image != null)
                {
                    carPart.Image_data = ImageToByteArray(imgBoxCarPats.Image);
                }
                if (_carPartService.saveCarPart(carPart))
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
                    List<CarPart> parts = _carPartService.getCarPartsByPartName(searchVal);
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
            List<Car> carList = _carService.getAllCarList();
            loadCarListTable(carList);
        }

        private void loadCarPartsListTable()
        {
            var carParts = _carPartService.getAllCarPartList();
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

            lblCarFormError.Visible = false;
        }

        private void cleanCarParts()
        {
            texPartsNaame.Clear();
            texPartsDescriptions.Clear();
            texPartsPrice.Clear();
            texPartsQty.Clear();
            texPartsCarModel.Clear();
            texPartBrandName.Clear();
            imgBoxCarPats.Image = null;
            lblcarPartFormError.Visible = false;
        }

        private void clearUpdatePartForm()
        {

        }

        private void LoadDashboardCount()
        {
            //car count
            int carCount = _carService.GetCarCount();
            lblCarCount.Text = carCount.ToString();

            //car parts count
            int partCount = _carPartService.getActiveCarPartsCaount();
            lblPartsCoun.Text = partCount.ToString();

            //active customer load
            int customerCount = _userService.GetCusotmerCount();
            lblCustomerCount.Text = customerCount.ToString();

            //get activeorder count
            lblOrdersCount.Text = _orderService.GetActiveOrderCount().ToString();

            lblIncome.Text = _orderService.GetPaidOrderAmount().ToString("F2");

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
            _pdfGenarate.pdfConverter(carPartsListView, "car_part.pdf");
        }

        private void btnCarPdfPrint_Click(object sender, EventArgs e)
        {
            _pdfGenarate.pdfConverter(tblListViewCar, "car_list.pdf");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadCarPartsListTable();
        }

        private void btnCarTableReload_Click(object sender, EventArgs e)
        {
            LoadCarTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
