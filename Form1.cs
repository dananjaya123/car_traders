using car_traders.Dta;
using car_traders.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Xml.Linq;

namespace car_traders
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                var car = new Car
                {
                    Id = 3,
                    Name = texCarBrand.Text,
                    Description = texCarColor.Text
                };

                context.car.Add(car);
                context.SaveChanges();
                MessageBox.Show("Employee added successfully");
            }
        }
    }
}
