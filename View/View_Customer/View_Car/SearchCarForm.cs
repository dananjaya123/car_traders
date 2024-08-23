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

        CarService _carService;
        OrderService _orderService;
        OrderDetailService _orderDetailService;
        IDGenerate _iDGenerate;
        EmailSend _emailSend;
        public SearchCarForm()
        {
            _carService = new CarService();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();
            _iDGenerate = new IDGenerate();
            _emailSend = new EmailSend();
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
                MessageBox.Show("No cars found in the database.");
                return;
            }


            foreach (Car car in carList)
            {
                SearchCarUserColtrollFrom form = new SearchCarUserColtrollFrom();
                form.carDetails(car);
                resultContainer.Controls.Add(form);

            }
            resultContainer.Height = resultContainer.Controls.Count * 214;


            // Enable AutoScroll for the FlowLayoutPanel.
            resultContainer.HorizontalScroll.Maximum = 0;
            resultContainer.HorizontalScroll.Visible = false;
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
                    MessageBox.Show("No cars found in the database.");
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
                    lblColor.Text = car.Color;
                    lblFelType.Text = car.Fuel_type;
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
            lblFelType.Visible = true;
            lblManufacturing.Visible = true;
            lblMileage.Visible = true;
            lblPrice.Visible = true;

            imgCarDetail.Visible = true;
            btnSubmit.Visible = true;

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
                    MessageBox.Show($"SOLD OUT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                    MessageBox.Show("Order request Successfully");
                                    loadCarDetail();
                                    loader.Visible = false;
                                    return;
                                }
                            }
                            MessageBox.Show($"something wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                }
                else
                {
                    MessageBox.Show($"Cannot place an order for this car. Please re-login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
