using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.View_Admin.View_Report
{
    public partial class ViewReportMainForm : Form
    {
        public ViewReportMainForm()
        {
            InitializeComponent();
        }

        private void btnOrderRequestReport_Click(object sender, EventArgs e)
        {
            ReportViewForm form = new ReportViewForm();
            pnlMain.Controls.Clear();
            form.selectMainFormButtonValues("REQUEST");
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnCancelOrderReport_Click(object sender, EventArgs e)
        {
            ReportViewForm form = new ReportViewForm();
            pnlMain.Controls.Clear();
            form.selectMainFormButtonValues("CANCEL");
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnRejectOrderReport_Click(object sender, EventArgs e)
        {
            ReportViewForm form = new ReportViewForm();
            pnlMain.Controls.Clear();
            form.selectMainFormButtonValues("REJECT");
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnPaidOrderReport_Click(object sender, EventArgs e)
        {
            ReportViewForm form = new ReportViewForm();
            pnlMain.Controls.Clear();
            form.selectMainFormButtonValues("PAID");
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void ViewReportMainForm_Load(object sender, EventArgs e)
        {
            ReportViewForm form = new ReportViewForm();
            pnlMain.Controls.Clear();
            form.selectMainFormButtonValues("REQUEST");
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            form.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(form);
            form.Show();
        }
    }
}
