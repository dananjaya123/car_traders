using car_traders.Model;
using car_traders.Service;
using car_traders.Service.Common;
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

    public partial class ReportViewForm : Form
    {
        readonly PDFGenerate _pdfGenarate;
        readonly OrderService _orderService;
        private string btnSelectValue;
        public ReportViewForm()
        {
            InitializeComponent();
            _pdfGenarate = new PDFGenerate();
            _orderService = new OrderService();
        }

        internal void selectMainFormButtonValues(string selectValues)
        {
            btnSelectValue = selectValues;
            lblTitle.Text = $"ORDER {btnSelectValue} REPORT";
            loadTable();
        }

        private void loadTable()
        {
            try
            {
                loader.Visible = true;

                var fromDate = dateFrom.Value;
                var toDate = dateTo.Value;
                var searchVal = texSearch.Text;

                List<Model.Order> orderList = _orderService.getAllOrdersByDateWise(btnSelectValue, fromDate, toDate, searchVal);
                listViewReport.Items.Clear();

                if (orderList.Count <= 0)
                {
                    pnlEmptyMs.Visible = true;
                    return;
                }

                // Calculate the total amount
                double totalAmountSum = 0.0;

                foreach (var order in orderList)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                       order.Order_code,
                       order.status,
                       order.Total_amount.ToString("F2"), // Convert double to string with 2 decimal places
                       order.Created.ToString("yyyy/mm/dd"),
                       order.qty.ToString(),
                       order.Is_payment? "PAID" : "NOT PAID",
                       order.User_code

                    });

                    listViewReport.Items.Add(listViewItem);
                    // Add to total amount sum
                    totalAmountSum += order.Total_amount;
                }
                // Display the total amount sum in the label
                totalAmount.Text = $"Rs : {totalAmountSum:F2}"; // Format as a string with 2 decimal places
                loader.Visible = false;
                pnlEmptyMs.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                loader.Visible = true;
                loadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEmptyMsBoxClose_Click(object sender, EventArgs e)
        {
            pnlEmptyMs.Visible = false;
        }

        private void btnCarPdfPrint_Click(object sender, EventArgs e)
        {
            _pdfGenarate.pdfConverter(listViewReport, $"{btnSelectValue}.pdf");
        }
    }
}
