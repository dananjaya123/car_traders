using car_traders.Model;
using car_traders.Service;
using car_traders.Service.Common;
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
        CarPartsService _carPartsService;
        OrderService _orderService;
        IDGenerate _IDGenerate;
        OrderDetailService _orderDetailService;
        EmailSend _EmailSend;
        AlertService _AlertService;
        public SearchCarPartsForm()
        {
            InitializeComponent();
            _carPartsService = new CarPartsService();
            _orderService = new OrderService();
            _IDGenerate = new IDGenerate();
            _orderDetailService = new OrderDetailService();
            _EmailSend = new EmailSend();
            _AlertService = new AlertService();
            loadCarPartDetail();

        }

        private void loadCarPartDetail()
        {
            resultContainer.Controls.Clear();
            List<CarPart> partlist = _carPartsService.getAllCarPartList();
            if (partlist == null || partlist.Count == 0)
            {
                _AlertService.AlertBox("No car  found !", "Error");
                return;
            }

            foreach (CarPart carpart in partlist)
            {
                CarPartControlForm carPartForm = new CarPartControlForm();
                carPartForm.loadCarPartCart(carpart);
                resultContainer.Controls.Add(carPartForm);

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

        private void texSearchCarPart_TextChanged(object sender, EventArgs e)
        {
            if (texSearchCarPart.TextLength >= 1)
            {
                resultContainer.Controls.Clear();
                List<CarPart> partlist = _carPartsService.getCarPartsByPartName(texSearchCarPart.Text);
                if (partlist == null || partlist.Count == 0)
                {
                    _AlertService.AlertBox("No car Part found !", "Error");

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
                    //get the car part control click values
                    carPart = CarPartControlForm.clickCarPartData;

                    if (carPart.Status == "SOLD OUT")
                    {
                        lblStatus.ForeColor = Color.Red;
                    }

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
                    _AlertService.AlertBox("Please check your selected qty", "Error");
                    return;
                }
                // Convert numInputQty.Value to double for multiplication
                double totalAmount = price * (double)numInputQty.Value;
                lblTotal.Text = totalAmount.ToString("F2");
            }
            else
            {
                _AlertService.AlertBox("Invalid price value.", "Error");
            }
        }

        private void SearchCarPartsForm_Load(object sender, EventArgs e)
        {

        }

        private List<OrderDetails> OrderDetailsList = new List<OrderDetails>();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                loader.Visible = true;
                if (carPart.Status == "SOLD OUT")
                {
                    _AlertService.AlertBox("SOLD OUT", "Error");
                    btnSubmit.Visible = false;
                    return;
                }



                double total;
                if (double.TryParse(lblTotal.Text, out total))
                {
                    if (total > 0)
                    {
                        if (int.Parse(lblQty.Text) < numInputQty.Value)
                        {
                            _AlertService.AlertBox("Please check your selected qty", "Warning");
                            return;
                        }

                        User user = LoginForm.SesionUserData;
                        if (user != null)
                        {

                            OrderDetails orderDetails = new OrderDetails
                            {
                                Item_name = carPart.Parts_name,
                                Item_Id = carPart.Id,
                                Item_type = "PART",
                                Total_price = total,
                                Qty = (int)numInputQty.Value,
                                //Order_code = order.Order_code,
                                Is_active = true


                            };
                            OrderDetailsList.Add(orderDetails);//add to order detail list 

                            lblCartOrderCount.Text = OrderDetailsList.Count.ToString(); // set detail list count

                            lblCartOrderCount.Visible = true;
                            lblTotal.Text = "0";
                            numInputQty.Value = 0;
                            loader.Visible = false;

                            _AlertService.AlertBox("Success", "Success");



                        }
                        else
                        {
                            _AlertService.AlertBox("Cannot place an order for this car. Please re-login.", "Error");
                        }
                    }
                    else
                    {
                        _AlertService.AlertBox("Please Select minimum qty is 1 .", "Error");

                    }

                }
                else
                {
                    _AlertService.AlertBox("Invalid price value.", "Warning");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Click Part Form Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loader.Visible = false;
            }
        }



        private void btnViewCart_Click(object sender, EventArgs e)
        {
            if (OrderDetailsList.Count <= 0)
            {
                _AlertService.AlertBox("Select the Car parts.", "Warning");
                return;
            }
            Form modelBackgraund = new Form();
            using (CarPartsCartViewModalForm model = new CarPartsCartViewModalForm(OrderDetailsList, this))
            {
                modelBackgraund.StartPosition = FormStartPosition.Manual;
                modelBackgraund.FormBorderStyle = FormBorderStyle.None;
                modelBackgraund.Opacity = .0;
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

        public void ClearOrderDetailsList()
        {
            OrderDetailsList.Clear();
            lblCartOrderCount.Text = "0";
            lblCartOrderCount.Visible = false;
            loadCarPartDetail();
        }

        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.DarkBlue;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.CornflowerBlue;
        }

        private void btnViewCart_MouseHover(object sender, EventArgs e)
        {
            btnViewCart.BackColor = Color.Teal;

        }

        private void btnViewCart_MouseLeave(object sender, EventArgs e)
        {
            btnViewCart.BackColor = Color.DarkCyan;
        }

        private void btnEmptyMsBoxClose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
