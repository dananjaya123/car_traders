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
        public SearchCarForm()
        {
            _carRepository = new CarRepository();
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
    }
}
