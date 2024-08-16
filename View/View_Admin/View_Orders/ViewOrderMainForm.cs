using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.View_Admin.View_Orders
{
    public partial class ViewOrderMainForm : Form
    {
        public ViewOrderMainForm()
        {
            InitializeComponent();
        }

        private void btnOrderRequestView_Click(object sender, EventArgs e)
        {
            ViewRequestOrderForm form = new ViewRequestOrderForm();
            pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnCancelOrderView_Click(object sender, EventArgs e)
        {
            VIewCancelOrderForm form = new VIewCancelOrderForm();
            pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnRejectOrderView_Click(object sender, EventArgs e)
        {
            ViewRejectOrderForm form = new ViewRejectOrderForm();
            pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnPaidOrderView_Click(object sender, EventArgs e)
        {
            ViewPaidOrderForm form = new ViewPaidOrderForm();
            pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }
    }
}
