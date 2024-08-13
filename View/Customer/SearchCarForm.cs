using car_traders.Common;
using car_traders.Model;
using car_traders.Repository;
using car_traders.View.Customer;
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

        CarRepository _carRepository;
        OrderRepository _orderRepository;
        OrderDetailRepository _orderDetailRepository;
        IDGenerate _iDGenerate;
        public SearchCarForm()
        {
            _carRepository = new CarRepository();
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
            _iDGenerate = new IDGenerate();
            InitializeComponent();
        }

        private void SearchCarForm_Load(object sender, EventArgs e)
        {
            loadCarDetail();

        }

        private void loadCarDetail()
        {
            resultContainer.Controls.Clear();
            List<Car> carList = _carRepository.getAllCarList();
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
                List<Car> carList = _carRepository.getAllCarListByModelName(texSearchCar.Text);
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
                    MessageBox.Show(user.Email);
                    Order order = new Order
                    {
                        Total_amount = car.Price,
                        Created = DateTime.Now,
                        status = "REQUEST",
                        qty = 1,
                        Is_payment = false,
                        User_code = user.User_code,
                        Order_code =_iDGenerate.OrderCodeGenerate(),
                        Is_active = true

                    };
                    if (_orderRepository.plaseOrder(order))
                    {
                        OrderDetails orderDetails = new OrderDetails
                        {
                            Item_name = car.Model_name,
                            Item_Id = car.Id,
                            Item_type="CAR",
                            Total_price= car.Price,
                            Qty = 1,
                            Order_code = order.Order_code,
                            Is_active = true


                        };
                        if (_orderDetailRepository.saveOrderDetail(orderDetails))
                        {
                            MessageBox.Show("Order request Successfully");

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
    }
}
