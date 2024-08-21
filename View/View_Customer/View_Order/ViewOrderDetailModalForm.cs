using car_traders.Model;
using car_traders.Service;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace car_traders.View.View_Customer.View_Order
{
    public partial class ViewOrderDetailModalForm : MaterialForm
    {
        List<OrderDetails> _orderDetailList;
        ViewOrderForm _viewOrderForm;
        CarService _carService;
        CarPartsService _carPartsService;
        public ViewOrderDetailModalForm(List<OrderDetails> detailList, ViewOrderForm viewOrderForm)
        {
            InitializeComponent();
            this._orderDetailList = detailList;
            this._viewOrderForm = viewOrderForm;

            _carService = new CarService();
            _carPartsService = new CarPartsService();

            loadOrderDetail();

        }

        private void loadOrderDetail()
        {
            try
            {
                listViewOrderDetail.Items.Clear();

                foreach (var data in _orderDetailList)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                      data.Item_name,
                      data.Qty.ToString(),
                      data.Order_code,
                      data.Item_type,
                      data.Total_price.ToString("F2"),
                      data.Item_Id.ToString(),

                    });

                    listViewOrderDetail.Items.Add(listViewItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrderDetail.SelectedItems.Count > 0)
                {
                    // Assuming the ID is stored as text in the sixth column (index 5)
                    string idString = listViewOrderDetail.SelectedItems[0].SubItems[5].Text;

                    // Assuming the type is stored as text in the fourth column (index 3)
                    string type = listViewOrderDetail.SelectedItems[0].SubItems[3].Text;

                    string qty = listViewOrderDetail.SelectedItems[0].SubItems[1].Text;

                    Guid id = Guid.Parse(idString); // Convert the string to a Guid
                    if (type.Equals("CAR"))
                    {
                        var car = _carService.getCarById(id);
                        
                        if (car.Image_data != null)
                        {
                            using (MemoryStream ms = new MemoryStream(car.Image_data))
                            {
                                imgItem.Image = System.Drawing.Image.FromStream(ms);
                            }
                        }
                    }
                    else if (type.Equals("PART"))
                    {
                        var part = _carPartsService.getCarPartById(id);
                        if (part.Image_data != null)
                        {
                            using (MemoryStream ms = new MemoryStream(part.Image_data))
                            {
                                imgItem.Image = System.Drawing.Image.FromStream(ms);
                            }
                        }
                    }

                    imgItem.Visible = true;
                    lblStatus.Visible = true;
                    numberQty.Visible = true;
                    btnCancel.Visible = true;
                    imgItem.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
