using car_traders.Common;
using car_traders.Model;
using car_traders.Repository;
using car_traders.View.View_Customer.View_CarPart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.Customer
{
    public partial class SearchCarPartsForm : Form
    {
        CarPartsRepository _carPartsRepository;
        OrderRepository _orderRepository;
        IDGenerate _IDGenerate;
        OrderDetailRepository _orderDetailRepository;
        EmailSend _EmailSend;
        public SearchCarPartsForm()
        {
            InitializeComponent();
            _carPartsRepository = new CarPartsRepository();
            _orderRepository = new OrderRepository();
            _IDGenerate = new IDGenerate();
            _orderDetailRepository = new OrderDetailRepository();
            _EmailSend = new EmailSend();
            loadCarPartDetail();
        }

        private void loadCarPartDetail()
        {
            resultContainer.Controls.Clear();
            List<CarPart> partlist = _carPartsRepository.getAllCarPartList();
            if (partlist == null || partlist.Count == 0)
            {
                MessageBox.Show("No Part found in the database.");
                return;
            }


            foreach (CarPart carpart in partlist)
            {
                CarPartControlForm carPartForm = new CarPartControlForm();
                carPartForm.loadCarPartCart(carpart);
                resultContainer.Controls.Add(carPartForm);

            }
            resultContainer.Height = resultContainer.Controls.Count * 214;


            // Enable AutoScroll for the FlowLayoutPanel.
            resultContainer.HorizontalScroll.Maximum = 0;
            resultContainer.HorizontalScroll.Visible = false;
            resultContainer.AutoScroll = true;

        }

        private void texSearchCarPart_TextChanged(object sender, EventArgs e)
        {
            if (texSearchCarPart.TextLength >= 1)
            {
                resultContainer.Controls.Clear();
                List<CarPart> partlist = _carPartsRepository.getCarPartsByPartName(texSearchCarPart.Text);
                if (partlist == null || partlist.Count == 0)
                {
                    MessageBox.Show("No Part found in the database.");
                    return;
                }


                foreach (CarPart carpart in partlist)
                {
                    CarPartControlForm carPartForm = new CarPartControlForm();
                    carPartForm.loadCarPartCart(carpart);
                    resultContainer.Controls.Add(carPartForm);

                }
                resultContainer.Height = resultContainer.Controls.Count * 214;

            }
            else
            {
                loadCarPartDetail();
            }
        }

        private CarPart carPart;
        private void timerCarPart_Tick(object sender, EventArgs e)
        {
            try
            {
                if (CarPartControlForm.click == true)
                {
                    lblVisible();
                    carPart = CarPartControlForm.clickCarPartData;


                    if (carPart.Image_data != null)
                    {
                        using (MemoryStream ms = new MemoryStream(carPart.Image_data))
                        {
                            Image originalImage = System.Drawing.Image.FromStream(ms);

                            // Resize the image to fit the PictureBox size
                            Image resizedImage = originalImage.GetThumbnailImage(imgCarPart.Width, imgCarPart.Height, null, IntPtr.Zero);
                            imgCarPart.Image = resizedImage;
                        }
                    }
                    lblBrand.Text = carPart.Brand_name;
                    lblModel.Text = carPart.Car_model;
                    lblCarPartName.Text = carPart.Parts_name;
                    lblCategory.Text = carPart.Category;
                    lblQty.Text = carPart.Qty.ToString();
                    lblStatus.Text = carPart.Status;
                    lblPrice.Text = carPart.Price.ToString("F2");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Click Part Form Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblVisible()
        {
            lblBrand.Visible = true;
            lblModel.Visible = true;
            lblCarPartName.Visible = true;
            lblCategory.Visible = true;
            lblPrice.Visible = true;
            lblQty.Visible = true;
            lblStatus.Visible = true;
            lblTotal.Visible = true;

            imgCarPart.Visible = true;
            btnSubmit.Visible = true;
            numInputQty.Visible = true;


            lblPriceTag.Visible = true;
            lblQtyTag.Visible = true;
            lblBranTag.Visible = true;
            lblCategoryTag.Visible = true;
            lblModelTag.Visible = true;
            lblParNameTag.Visible = true;
            lblTotalTag.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numInputQty_ValueChanged(object sender, EventArgs e)
        {
            double price;
            if (double.TryParse(lblPrice.Text, out price))
            {
                if (int.Parse(lblQty.Text) < numInputQty.Value)
                {
                    MessageBox.Show("Please check your selected qty  "+lblQty.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Convert numInputQty.Value to double for multiplication
                double totalAmount = price * (double)numInputQty.Value;
                lblTotal.Text = totalAmount.ToString("F2");
            }
            else
            {
                MessageBox.Show("Invalid price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCarPartsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                double total;
                if (double.TryParse(lblTotal.Text, out total))
                {
                    if (total > 0)
                    {
                        if (int.Parse(lblQty.Text) < numInputQty.Value)
                        {
                            MessageBox.Show("Please check your selected qty  " + lblQty.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        User user = LoginForm.SesionUserData;
                        if (user != null)
                        {
                            loader.Visible = true;
                            Order order = new Order
                            {
                                Total_amount = total,
                                Created = DateTime.Now,
                                status = "REQUEST",
                                qty = int.Parse(numInputQty.Value.ToString("F2")),
                                Is_payment = false,
                                User_code = user.User_code,
                                Order_code = _IDGenerate.OrderCodeGenerate(),
                                Is_active = true

                            };
                            if (_orderRepository.plaseOrder(order))
                            {
                                OrderDetails orderDetails = new OrderDetails
                                {
                                    Item_name = carPart.Parts_name,
                                    Item_Id = carPart.Id,
                                    Item_type = "PART",
                                    Total_price = total,
                                    Qty = int.Parse(numInputQty.Value.ToString("F2")),
                                    Order_code = order.Order_code,
                                    Is_active = true


                                };
                                if (_orderDetailRepository.saveOrderDetail(orderDetails))
                                {

                                    string body = GenerateEmailBody("Car traders", user.User_name, order.Order_code, DateTime.Now.ToString("MMMM dd, yyyy"), carPart.Image_data);
                                    if (_EmailSend.SendEmail("cartraders@gmail.com", user.Email, "Order Request ", body))
                                    {
                                        MessageBox.Show("Order request Successfully");
                                        loader.Visible = false;
                                    }
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show($"Cannot place an order for this car. Please re-login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select minimum qty is 1 .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Invalid price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Click Part Form Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        <p>Here is the image of the car Part you ordered:</p>
        <img src='{carImageSrc}' alt='Car Image' style='max-width: 100%; height: auto;' />
        <p>If you have any questions about your order, please contact our support team.</p>
        <p>Best regards,</p>
        <p><strong>The {projectName} Team</strong></p>
    </body>
    </html>";

            return body;
        }
    }
}
