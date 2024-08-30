using car_traders.Model;
using car_traders.Service;
using car_traders.Service.Common;
using car_traders.View.Customer;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class SearchCarForm : Form
    {

        private readonly CarService _carService;
        private readonly OrderService _orderService;
        private readonly OrderDetailService _orderDetailService;
        private readonly IDGenerate _iDGenerate;
        private readonly EmailSend _emailSend;
        private readonly AlertService _AlertService;

        public SearchCarForm()
        {
            _carService = new CarService();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();
            _iDGenerate = new IDGenerate();
            _emailSend = new EmailSend();
            _AlertService = new AlertService();
            InitializeComponent();
        }

        private void SearchCarForm_Load(object sender, EventArgs e)
        {
            loadCarDetail();

        }

        private void loadCarDetail()
        {
            resultContainer.Controls.Clear();
            List<Car> carList = _carService.getAllCarList();
            if (carList == null || carList.Count == 0)
            {
                _AlertService.AlertBox("No cars found", "Error");
                return;
            }


            foreach (Car car in carList)
            {
                SearchCarUserColtrollFrom form = new SearchCarUserColtrollFrom();
                form.carDetails(car);
                resultContainer.Controls.Add(form);

            }
            //resultContainer.Height = resultContainer.Controls.Count * 214;

            // Ensure FlowLayoutPanel is set to flow vertically
            resultContainer.Height = 2 * 214;
            resultContainer.FlowDirection = FlowDirection.TopDown; // Controls are added from top to bottom
            resultContainer.WrapContents = false; // Prevents wrapping to a new row, ensuring a single column layout
            resultContainer.HorizontalScroll.Maximum = 0;
            resultContainer.HorizontalScroll.Visible = false;
            // Enable AutoScroll to make the scrollbar appear when needed
            resultContainer.AutoScroll = true;

        }
        private void texSearchCar_TextChanged(object sender, EventArgs e)
        {
            if (texSearchCar.TextLength >= 1)
            {
                resultContainer.Controls.Clear();
                List<Car> carList = _carService.getAllCarListByModelName(texSearchCar.Text);
                if (carList == null || carList.Count == 0)
                {
                    _AlertService.AlertBox("No cars found", "Error");
                    return;
                }
              
                    foreach (Car car in carList)
                    {
                        SearchCarUserColtrollFrom form = new SearchCarUserColtrollFrom();
                        form.carDetails(car);
                        resultContainer.Controls.Add(form);

                    }
                    resultContainer.Height = resultContainer.Controls.Count * 214;
                
                
            }
            else
            {
                loadCarDetail();
                //resultContainer.Height = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private Car car;
        private void timerCardetail_Tick(object sender, EventArgs e)
        {
            try
            {
                if (SearchCarUserColtrollFrom.click == true)
                {
                    lblVisible();
                    car = SearchCarUserColtrollFrom.clickCar;


                    if (car.Image_data != null)
                    {
                        using (MemoryStream ms = new MemoryStream(car.Image_data))
                        {
                            Image originalImage = System.Drawing.Image.FromStream(ms);

                            // Resize the image to fit the PictureBox size
                            Image resizedImage = originalImage.GetThumbnailImage(imgCarDetail.Width, imgCarDetail.Height, null, IntPtr.Zero);
                            imgCarDetail.Image = resizedImage;
                        }
                    }
                    lblCarModel.Text = car.Model_name;
                    lblBodyType.Text = car.Body_type;
                    lblBrand.Text = car.Car_brand;
                    lblColor.Text = car.Color;
                    lblFuelType.Text = car.Fuel_type;
                    lblManufacturing.Text = car.Manufacturing_year;
                    lblMileage.Text = car.Mileage.ToString() + " Km";
                    lblPrice.Text = "Rs " + car.Price.ToString("F2");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search Car Form Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblVisible()
        {
            lblBodyType.Visible = true;
            lblCarModel.Visible = true;
            lblColor.Visible = true;
            lblFuelType.Visible = true;
            lblManufacturing.Visible = true;
            lblMileage.Visible = true;
            lblPrice.Visible = true;
            lblBrand.Visible = true;
            lblBodyType.Visible = true;

            imgCarDetail.Visible = true;
            btnSubmit.Visible = true;

            lblBodyTag.Visible = true;
            lblBrandTag.Visible = true;
            lblFuelTag.Visible = true;
            lblModelTag.Visible = true;
            lblColortag.Visible = true;
            lblYearTag.Visible = true;

        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (car.Status == "SOLD OUT")
                {
                    _AlertService.AlertBox("SOLD OUT", "Warning");
                    btnSubmit.Visible = false;
                    return;
                }

                User user = LoginForm.SesionUserData;
                if (user != null)
                {
                    loader.Visible = true;
                    Order order = new Order
                    {
                        Total_amount = car.Price,
                        Created = DateTime.Now,
                        status = "REQUEST",
                        qty = 1,
                        Is_payment = false,
                        User_code = user.User_code,
                        Order_code = _iDGenerate.OrderCodeGenerate(),
                        Is_active = true

                    };
                    if (_orderService.plaseOrder(order))
                    {
                        OrderDetails orderDetails = new OrderDetails
                        {
                            Item_name = car.Model_name,
                            Item_Id = car.Id,
                            Item_type = "CAR",
                            Total_price = car.Price,
                            Qty = 1,
                            Order_code = order.Order_code,
                            Is_active = true


                        };
                        if (_orderDetailService.saveOrderDetail(orderDetails))
                        {
                            car.Status = "SOLD OUT";
                            if (_carService.updateCar(car))
                            {

                                string body = GenerateEmailBody("Car traders", user.User_name, order.Order_code, DateTime.Now.ToString("MMMM dd, yyyy"), car.Image_data);
                                if (_emailSend.SendEmail("cartraders@gmail.com", user.Email, "Order Request ", body))
                                {
                                    _AlertService.AlertBox("Success", "Success");
                                    loadCarDetail();
                                    loader.Visible = false;
                                    return;
                                }
                            }
                            _AlertService.AlertBox("something wrong !", "Error");
                            return;
                        }
                    }

                }
                else
                {
                    _AlertService.AlertBox("Cannot place an order for this car. Please re-login. !", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search Car Form Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateEmailBody(string projectName, string userName, string orderCode, string requestDate, byte[] carImageData)
        {
            // Convert car image data to base64 string for embedding in email
            string carImageBase64 = Convert.ToBase64String(carImageData);
            string carImageSrc = $"data:image/jpeg;base64,{carImageBase64}";

            string body = $@"
    <html>
    <body style='font-family: Arial, sans-serif; color: #333;'>
        <h2 style='color: #4CAF50;'>Order Confirmation from {projectName}</h2>
        <p>Dear {userName},</p>
        <p>Thank you for your order with <strong>{projectName}</strong>. Below are the details of your order:</p>
        <ul style='list-style-type: none; padding: 0;'>
            <li><strong>Order Code:</strong> {orderCode}</li>
            <li><strong>Request Date:</strong> {requestDate}</li>
        </ul>
        <p>Here is the image of the car you ordered:</p>
        <img src='{carImageSrc}' alt='Car Image' style='max-width: 100%; height: auto;' />
        <p>If you have any questions about your order, please contact our support team.</p>
        <p>Best regards,</p>
        <p><strong>The {projectName} Team</strong></p>
    </body>
    </html>";

            return body;
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.DarkBlue;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.CornflowerBlue;
        }

        private void btnEmptyMsBoxClose_Click(object sender, EventArgs e)
        {
            

        }
    }
}
