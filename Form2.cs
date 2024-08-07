using MaterialSkin;
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

namespace car_traders
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();

            /*MaterialButton desing add   */
            var materialSkinManager = MaterialSkinManager.Instance;
            /*materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; */
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.Amber700, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);

        }
    }
}
