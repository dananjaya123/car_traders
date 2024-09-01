using car_traders.Model;
using car_traders.Service;
using car_traders.Service.Common;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Cmp;
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

namespace car_traders.View.View_Admin.View_Customer
{
    public partial class ViewCustomerForm : Form
    {
        private readonly UserService _userService;
        private readonly PDFGenerate _pdfGenarate;
        private readonly AlertService _AlertService;

        public ViewCustomerForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _pdfGenarate = new PDFGenerate();
            _AlertService = new AlertService();
            loadTable();
        }
        private void loadTable()
        {
            try
            {
                List<User> userList = _userService.getUsersByRole("CUSTOMER");
                listViewCustomer.Items.Clear();
                if (userList.Count > 0)
                {
                    pnlEmptyMs.Visible = false;
                    foreach (User user in userList)
                    {
                        var listViewItem = new ListViewItem(new[]
                        {
                        user.User_code,
                        user.Name,
                        user.Contact_num,
                        user.Email,
                        user.Address,
                        user.User_name,
                        user.Role_name
                    });
                        listViewCustomer.Items.Add(listViewItem);

                    }

                }
                else
                {
                    pnlEmptyMs.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Form modelBackgraund = new Form();
            using (RegisterModalForm model = new RegisterModalForm())
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

        private User userData;
        private void listViewCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listViewCustomer.SelectedItems)
                {
                    loader.Visible = true;
                    var userCode = item.SubItems[0].Text;

                    userData = _userService.getUserByUsercode(userCode);
                    if (userData != null)
                    {
                        Form modelBackgraund = new Form();
                        using (RegisterModalForm model = new RegisterModalForm())
                        {

                            model.UdateUser(userData);

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
                    else
                    {
                        _AlertService.AlertBox("cannot find this User", "Error");

                    }


                }
                loader.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnPdfPrint_Click(object sender, EventArgs e)
        {
            _pdfGenarate.pdfConverter(listViewCustomer, "customer.pdf");
        }

        private void texSearch_TextChanged(object sender, EventArgs e)
        {
            if (texSearch.TextLength >= 1)
            {
                List<User> userList = _userService.getUserByserchValues(texSearch.Text, "CUSTOMER");

                listViewCustomer.Items.Clear();

                if (userList == null || userList.Count == 0)
                {
                    pnlEmptyMs.Visible = true;
                    _AlertService.AlertBox("Customer not found", "Error");
                    return;
                }
                pnlEmptyMs.Visible = false;
                foreach (User user in userList)
                {
                    var listViewItem = new ListViewItem(new[]
                    {
                        user.User_code,
                        user.Name,
                        user.Contact_num,
                        user.Email,
                        user.Address,
                        user.User_name,
                        user.Role_name
                    });
                    listViewCustomer.Items.Add(listViewItem);

                }

            }
            else
            {
                loadTable();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnEmptyMsBoxClose_Click(object sender, EventArgs e)
        {
            pnlEmptyMs.Visible = false;
        }
    }
}
