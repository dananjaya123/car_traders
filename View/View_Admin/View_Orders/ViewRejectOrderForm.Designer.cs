namespace car_traders.View.View_Admin.View_Orders
{
    partial class ViewRejectOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRejectOrderForm));
            btnCarPdfPrint = new MaterialSkin.Controls.MaterialButton();
            colOrderCode = new ColumnHeader();
            colStatus = new ColumnHeader();
            colTotalAmount = new ColumnHeader();
            colOrderDate = new ColumnHeader();
            colQty = new ColumnHeader();
            colIsPaid = new ColumnHeader();
            texSearch = new TextBox();
            lblStatus = new Label();
            imgItem = new PictureBox();
            lblPayment = new Label();
            lblQty = new Label();
            lblItemName = new Label();
            lblOrderCode = new Label();
            lblPaymenTag = new Label();
            lblQtyTag = new Label();
            lblItemNameTag = new Label();
            lblOrderCodeTag = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            loader = new PictureBox();
            listViewRejectOrder = new MaterialSkin.Controls.MaterialListView();
            lblCustomerNameTag = new Label();
            lblCustomerName = new Label();
            lblMobileNUm = new Label();
            lblCustomerContactTag = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            SuspendLayout();
            // 
            // btnCarPdfPrint
            // 
            btnCarPdfPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarPdfPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCarPdfPrint.Depth = 0;
            btnCarPdfPrint.HighEmphasis = true;
            btnCarPdfPrint.Icon = (Image)resources.GetObject("btnCarPdfPrint.Icon");
            btnCarPdfPrint.Image = (Image)resources.GetObject("btnCarPdfPrint.Image");
            btnCarPdfPrint.Location = new Point(599, 92);
            btnCarPdfPrint.Margin = new Padding(4, 6, 4, 6);
            btnCarPdfPrint.MouseState = MaterialSkin.MouseState.HOVER;
            btnCarPdfPrint.Name = "btnCarPdfPrint";
            btnCarPdfPrint.NoAccentTextColor = Color.Empty;
            btnCarPdfPrint.Size = new Size(64, 36);
            btnCarPdfPrint.TabIndex = 92;
            btnCarPdfPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCarPdfPrint.UseAccentColor = false;
            btnCarPdfPrint.UseVisualStyleBackColor = true;
            btnCarPdfPrint.Click += btnCarPdfPrint_Click;
            // 
            // colOrderCode
            // 
            colOrderCode.Text = "Order Code";
            colOrderCode.Width = 100;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 100;
            // 
            // colTotalAmount
            // 
            colTotalAmount.Text = "Amount";
            colTotalAmount.Width = 150;
            // 
            // colOrderDate
            // 
            colOrderDate.Text = "Order Date";
            colOrderDate.Width = 150;
            // 
            // colQty
            // 
            colQty.Text = "QTY";
            // 
            // colIsPaid
            // 
            colIsPaid.Text = "Is Payment";
            colIsPaid.Width = 150;
            // 
            // texSearch
            // 
            texSearch.Location = new Point(8, 11);
            texSearch.Name = "texSearch";
            texSearch.Size = new Size(474, 31);
            texSearch.TabIndex = 1;
            texSearch.Tag = "";
            texSearch.TextChanged += texSearch_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.OrangeRed;
            lblStatus.Location = new Point(678, 312);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 25);
            lblStatus.TabIndex = 90;
            lblStatus.Text = "status";
            lblStatus.Visible = false;
            // 
            // imgItem
            // 
            imgItem.Location = new Point(670, 92);
            imgItem.Name = "imgItem";
            imgItem.Size = new Size(264, 217);
            imgItem.TabIndex = 89;
            imgItem.TabStop = false;
            imgItem.Visible = false;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPayment.ForeColor = SystemColors.WindowFrame;
            lblPayment.Location = new Point(812, 476);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(85, 25);
            lblPayment.TabIndex = 87;
            lblPayment.Text = "payment";
            lblPayment.Visible = false;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQty.ForeColor = SystemColors.WindowFrame;
            lblQty.Location = new Point(812, 437);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(39, 25);
            lblQty.TabIndex = 86;
            lblQty.Text = "qty";
            lblQty.Visible = false;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblItemName.ForeColor = SystemColors.WindowFrame;
            lblItemName.Location = new Point(812, 393);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(58, 25);
            lblItemName.TabIndex = 85;
            lblItemName.Text = "name";
            lblItemName.Visible = false;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCode.ForeColor = SystemColors.WindowFrame;
            lblOrderCode.Location = new Point(812, 350);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(52, 25);
            lblOrderCode.TabIndex = 84;
            lblOrderCode.Text = "code";
            lblOrderCode.Visible = false;
            // 
            // lblPaymenTag
            // 
            lblPaymenTag.AutoSize = true;
            lblPaymenTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPaymenTag.ForeColor = SystemColors.WindowFrame;
            lblPaymenTag.Location = new Point(670, 476);
            lblPaymenTag.Name = "lblPaymenTag";
            lblPaymenTag.Size = new Size(93, 25);
            lblPaymenTag.TabIndex = 82;
            lblPaymenTag.Text = "Payment :";
            lblPaymenTag.Visible = false;
            // 
            // lblQtyTag
            // 
            lblQtyTag.AutoSize = true;
            lblQtyTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQtyTag.ForeColor = SystemColors.WindowFrame;
            lblQtyTag.Location = new Point(670, 437);
            lblQtyTag.Name = "lblQtyTag";
            lblQtyTag.Size = new Size(105, 25);
            lblQtyTag.TabIndex = 81;
            lblQtyTag.Text = "Order Qty :";
            lblQtyTag.Visible = false;
            // 
            // lblItemNameTag
            // 
            lblItemNameTag.AutoSize = true;
            lblItemNameTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblItemNameTag.ForeColor = SystemColors.WindowFrame;
            lblItemNameTag.Location = new Point(670, 393);
            lblItemNameTag.Name = "lblItemNameTag";
            lblItemNameTag.Size = new Size(113, 25);
            lblItemNameTag.TabIndex = 80;
            lblItemNameTag.Text = "Item Name :";
            lblItemNameTag.Visible = false;
            // 
            // lblOrderCodeTag
            // 
            lblOrderCodeTag.AutoSize = true;
            lblOrderCodeTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCodeTag.ForeColor = SystemColors.WindowFrame;
            lblOrderCodeTag.Location = new Point(670, 350);
            lblOrderCodeTag.Name = "lblOrderCodeTag";
            lblOrderCodeTag.Size = new Size(118, 25);
            lblOrderCodeTag.TabIndex = 78;
            lblOrderCodeTag.Text = "Order Code :";
            lblOrderCodeTag.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(513, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearch);
            panel1.Location = new Point(28, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 54);
            panel1.TabIndex = 75;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(219, 12);
            loader.Name = "loader";
            loader.Size = new Size(75, 54);
            loader.SizeMode = PictureBoxSizeMode.CenterImage;
            loader.TabIndex = 77;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // listViewRejectOrder
            // 
            listViewRejectOrder.AutoSizeTable = false;
            listViewRejectOrder.BackColor = Color.FromArgb(255, 255, 255);
            listViewRejectOrder.BorderStyle = BorderStyle.None;
            listViewRejectOrder.Columns.AddRange(new ColumnHeader[] { colOrderCode, colStatus, colTotalAmount, colOrderDate, colQty, colIsPaid });
            listViewRejectOrder.Depth = 0;
            listViewRejectOrder.FullRowSelect = true;
            listViewRejectOrder.Location = new Point(5, 137);
            listViewRejectOrder.MinimumSize = new Size(200, 100);
            listViewRejectOrder.MouseLocation = new Point(-1, -1);
            listViewRejectOrder.MouseState = MaterialSkin.MouseState.OUT;
            listViewRejectOrder.Name = "listViewRejectOrder";
            listViewRejectOrder.OwnerDraw = true;
            listViewRejectOrder.Size = new Size(658, 463);
            listViewRejectOrder.TabIndex = 74;
            listViewRejectOrder.UseCompatibleStateImageBehavior = false;
            listViewRejectOrder.View = System.Windows.Forms.View.Details;
            listViewRejectOrder.SelectedIndexChanged += listViewOrder_SelectedIndexChanged;
            // 
            // lblCustomerNameTag
            // 
            lblCustomerNameTag.AutoSize = true;
            lblCustomerNameTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCustomerNameTag.ForeColor = SystemColors.WindowFrame;
            lblCustomerNameTag.Location = new Point(670, 515);
            lblCustomerNameTag.Name = "lblCustomerNameTag";
            lblCustomerNameTag.Size = new Size(102, 25);
            lblCustomerNameTag.TabIndex = 79;
            lblCustomerNameTag.Text = "Customer :";
            lblCustomerNameTag.Visible = false;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCustomerName.ForeColor = SystemColors.WindowFrame;
            lblCustomerName.Location = new Point(819, 515);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(61, 25);
            lblCustomerName.TabIndex = 88;
            lblCustomerName.Text = "Name";
            lblCustomerName.Visible = false;
            // 
            // lblMobileNUm
            // 
            lblMobileNUm.AutoSize = true;
            lblMobileNUm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMobileNUm.ForeColor = SystemColors.WindowFrame;
            lblMobileNUm.Location = new Point(822, 554);
            lblMobileNUm.Name = "lblMobileNUm";
            lblMobileNUm.Size = new Size(145, 25);
            lblMobileNUm.TabIndex = 94;
            lblMobileNUm.Text = "Mobile Number";
            lblMobileNUm.Visible = false;
            // 
            // lblCustomerContactTag
            // 
            lblCustomerContactTag.AutoSize = true;
            lblCustomerContactTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCustomerContactTag.ForeColor = SystemColors.WindowFrame;
            lblCustomerContactTag.Location = new Point(670, 554);
            lblCustomerContactTag.Name = "lblCustomerContactTag";
            lblCustomerContactTag.Size = new Size(154, 25);
            lblCustomerContactTag.TabIndex = 93;
            lblCustomerContactTag.Text = "Mobile Number :";
            lblCustomerContactTag.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 96;
            label1.Text = "ORDER REJECT";
            // 
            // ViewRejectOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 612);
            Controls.Add(label1);
            Controls.Add(lblMobileNUm);
            Controls.Add(lblCustomerContactTag);
            Controls.Add(btnCarPdfPrint);
            Controls.Add(lblStatus);
            Controls.Add(imgItem);
            Controls.Add(lblCustomerName);
            Controls.Add(lblPayment);
            Controls.Add(lblQty);
            Controls.Add(lblItemName);
            Controls.Add(lblOrderCode);
            Controls.Add(lblPaymenTag);
            Controls.Add(lblQtyTag);
            Controls.Add(lblItemNameTag);
            Controls.Add(lblCustomerNameTag);
            Controls.Add(lblOrderCodeTag);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(loader);
            Controls.Add(listViewRejectOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewRejectOrderForm";
            Text = "ViewRejectOrderForm";
            ((System.ComponentModel.ISupportInitialize)imgItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCarPdfPrint;
        private ColumnHeader colOrderCode;
        private ColumnHeader colStatus;
        private ColumnHeader colTotalAmount;
        private ColumnHeader colOrderDate;
        private ColumnHeader colQty;
        private ColumnHeader colIsPaid;
        private TextBox texSearch;
        private Label lblStatus;
        private PictureBox imgItem;
        private Label lblPayment;
        private Label lblQty;
        private Label lblItemName;
        private Label lblOrderCode;
        private Label lblPaymenTag;
        private Label lblQtyTag;
        private Label lblItemNameTag;
        private Label lblOrderCodeTag;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox loader;
        private MaterialSkin.Controls.MaterialListView listViewRejectOrder;
        private Label lblCustomerNameTag;
        private Label lblCustomerName;
        private Label lblMobileNUm;
        private Label lblCustomerContactTag;
        private Label label1;
    }
}