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
            ViewOrderForm form = new ViewOrderForm();
            pnlMain.Controls.Clear();
            form.selectMainFormButtonValues("REQUEST");
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnCancelOrderView_Click(object sender, EventArgs e)
        {
            ViewOrderForm form = new ViewOrderForm();
            pnlMain.Controls.Clear();
            form.selectMainFormButtonValues("CANCEL");
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnRejectOrderView_Click(object sender, EventArgs e)
        {
            ViewOrderForm form = new ViewOrderForm();
            pnlMain.Controls.Clear();
            form.selectMainFormButtonValues("REJECT");
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnPaidOrderView_Click(object sender, EventArgs e)
        {
            ViewOrderForm form = new ViewOrderForm();
            pnlMain.Controls.Clear();
            form.selectMainFormButtonValues("PAID");
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }
    }
}
