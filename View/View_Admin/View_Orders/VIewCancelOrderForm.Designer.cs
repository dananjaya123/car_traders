namespace car_traders.View.View_Admin.View_Orders
{
    partial class VIewCancelOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIewCancelOrderForm));
            lblMobileNUm = new Label();
            lblCustomerContactTag = new Label();
            texSearch = new TextBox();
            colIsPaid = new ColumnHeader();
            colQty = new ColumnHeader();
            btnPdfPrint = new MaterialSkin.Controls.MaterialButton();
            lblStatus = new Label();
            imgItem = new PictureBox();
            lblCustomerName = new Label();
            lblPayment = new Label();
            lblQty = new Label();
            lblItemName = new Label();
            colOrderDate = new ColumnHeader();
            lblOrderCode = new Label();
            lblPaymenTag = new Label();
            lblQtyTag = new Label();
            lblItemNameTag = new Label();
            lblCustomerNameTag = new Label();
            lblOrderCodeTag = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            loader = new PictureBox();
            listViewCancelOrder = new MaterialSkin.Controls.MaterialListView();
            colOrderCode = new ColumnHeader();
            colStatus = new ColumnHeader();
            colTotalAmount = new ColumnHeader();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            SuspendLayout();
            // 
            // lblMobileNUm
            // 
            lblMobileNUm.AutoSize = true;
            lblMobileNUm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMobileNUm.ForeColor = SystemColors.WindowFrame;
            lblMobileNUm.Location = new Point(830, 555);
            lblMobileNUm.Name = "lblMobileNUm";
            lblMobileNUm.Size = new Size(145, 25);
            lblMobileNUm.TabIndex = 113;
            lblMobileNUm.Text = "Mobile Number";
            lblMobileNUm.Visible = false;
            // 
            // lblCustomerContactTag
            // 
            lblCustomerContactTag.AutoSize = true;
            lblCustomerContactTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCustomerContactTag.ForeColor = SystemColors.WindowFrame;
            lblCustomerContactTag.Location = new Point(678, 555);
            lblCustomerContactTag.Name = "lblCustomerContactTag";
            lblCustomerContactTag.Size = new Size(154, 25);
            lblCustomerContactTag.TabIndex = 112;
            lblCustomerContactTag.Text = "Mobile Number :";
            lblCustomerContactTag.Visible = false;
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
            // colIsPaid
            // 
            colIsPaid.Text = "Is Payment";
            colIsPaid.Width = 150;
            // 
            // colQty
            // 
            colQty.Text = "QTY";
            // 
            // btnPdfPrint
            // 
            btnPdfPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPdfPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPdfPrint.Depth = 0;
            btnPdfPrint.HighEmphasis = true;
            btnPdfPrint.Icon = (Image)resources.GetObject("btnPdfPrint.Icon");
            btnPdfPrint.Image = (Image)resources.GetObject("btnPdfPrint.Image");
            btnPdfPrint.Location = new Point(607, 93);
            btnPdfPrint.Margin = new Padding(4, 6, 4, 6);
            btnPdfPrint.MouseState = MaterialSkin.MouseState.HOVER;
            btnPdfPrint.Name = "btnPdfPrint";
            btnPdfPrint.NoAccentTextColor = Color.Empty;
            btnPdfPrint.Size = new Size(64, 36);
            btnPdfPrint.TabIndex = 111;
            btnPdfPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPdfPrint.UseAccentColor = false;
            btnPdfPrint.UseVisualStyleBackColor = true;
            btnPdfPrint.Click += btnCarPdfPrint_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.OrangeRed;
            lblStatus.Location = new Point(686, 313);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 25);
            lblStatus.TabIndex = 110;
            lblStatus.Text = "status";
            lblStatus.Visible = false;
            // 
            // imgItem
            // 
            imgItem.Location = new Point(678, 93);
            imgItem.Name = "imgItem";
            imgItem.Size = new Size(264, 217);
            imgItem.TabIndex = 109;
            imgItem.TabStop = false;
            imgItem.Visible = false;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCustomerName.ForeColor = SystemColors.WindowFrame;
            lblCustomerName.Location = new Point(827, 516);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(61, 25);
            lblCustomerName.TabIndex = 108;
            lblCustomerName.Text = "Name";
            lblCustomerName.Visible = false;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPayment.ForeColor = SystemColors.WindowFrame;
            lblPayment.Location = new Point(820, 477);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(85, 25);
            lblPayment.TabIndex = 107;
            lblPayment.Text = "payment";
            lblPayment.Visible = false;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQty.ForeColor = SystemColors.WindowFrame;
            lblQty.Location = new Point(820, 438);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(39, 25);
            lblQty.TabIndex = 106;
            lblQty.Text = "qty";
            lblQty.Visible = false;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblItemName.ForeColor = SystemColors.WindowFrame;
            lblItemName.Location = new Point(820, 394);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(58, 25);
            lblItemName.TabIndex = 105;
            lblItemName.Text = "name";
            lblItemName.Visible = false;
            // 
            // colOrderDate
            // 
            colOrderDate.Text = "Order Date";
            colOrderDate.Width = 150;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCode.ForeColor = SystemColors.WindowFrame;
            lblOrderCode.Location = new Point(820, 351);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(52, 25);
            lblOrderCode.TabIndex = 104;
            lblOrderCode.Text = "code";
            lblOrderCode.Visible = false;
            // 
            // lblPaymenTag
            // 
            lblPaymenTag.AutoSize = true;
            lblPaymenTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPaymenTag.ForeColor = SystemColors.WindowFrame;
            lblPaymenTag.Location = new Point(678, 477);
            lblPaymenTag.Name = "lblPaymenTag";
            lblPaymenTag.Size = new Size(93, 25);
            lblPaymenTag.TabIndex = 103;
            lblPaymenTag.Text = "Payment :";
            lblPaymenTag.Visible = false;
            // 
            // lblQtyTag
            // 
            lblQtyTag.AutoSize = true;
            lblQtyTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQtyTag.ForeColor = SystemColors.WindowFrame;
            lblQtyTag.Location = new Point(678, 438);
            lblQtyTag.Name = "lblQtyTag";
            lblQtyTag.Size = new Size(105, 25);
            lblQtyTag.TabIndex = 102;
            lblQtyTag.Text = "Order Qty :";
            lblQtyTag.Visible = false;
            // 
            // lblItemNameTag
            // 
            lblItemNameTag.AutoSize = true;
            lblItemNameTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblItemNameTag.ForeColor = SystemColors.WindowFrame;
            lblItemNameTag.Location = new Point(678, 394);
            lblItemNameTag.Name = "lblItemNameTag";
            lblItemNameTag.Size = new Size(113, 25);
            lblItemNameTag.TabIndex = 101;
            lblItemNameTag.Text = "Item Name :";
            lblItemNameTag.Visible = false;
            // 
            // lblCustomerNameTag
            // 
            lblCustomerNameTag.AutoSize = true;
            lblCustomerNameTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCustomerNameTag.ForeColor = SystemColors.WindowFrame;
            lblCustomerNameTag.Location = new Point(678, 516);
            lblCustomerNameTag.Name = "lblCustomerNameTag";
            lblCustomerNameTag.Size = new Size(102, 25);
            lblCustomerNameTag.TabIndex = 100;
            lblCustomerNameTag.Text = "Customer :";
            lblCustomerNameTag.Visible = false;
            // 
            // lblOrderCodeTag
            // 
            lblOrderCodeTag.AutoSize = true;
            lblOrderCodeTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCodeTag.ForeColor = SystemColors.WindowFrame;
            lblOrderCodeTag.Location = new Point(678, 351);
            lblOrderCodeTag.Name = "lblOrderCodeTag";
            lblOrderCodeTag.Size = new Size(118, 25);
            lblOrderCodeTag.TabIndex = 99;
            lblOrderCodeTag.Text = "Order Code :";
            lblOrderCodeTag.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(513, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearch);
            panel1.Location = new Point(28, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 54);
            panel1.TabIndex = 96;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(211, 2);
            loader.Name = "loader";
            loader.Size = new Size(75, 54);
            loader.SizeMode = PictureBoxSizeMode.CenterImage;
            loader.TabIndex = 98;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // listViewCancelOrder
            // 
            listViewCancelOrder.AutoSizeTable = false;
            listViewCancelOrder.BackColor = Color.FromArgb(255, 255, 255);
            listViewCancelOrder.BorderStyle = BorderStyle.None;
            listViewCancelOrder.Columns.AddRange(new ColumnHeader[] { colOrderCode, colStatus, colTotalAmount, colOrderDate, colQty, colIsPaid });
            listViewCancelOrder.Depth = 0;
            listViewCancelOrder.FullRowSelect = true;
            listViewCancelOrder.Location = new Point(13, 138);
            listViewCancelOrder.MinimumSize = new Size(200, 100);
            listViewCancelOrder.MouseLocation = new Point(-1, -1);
            listViewCancelOrder.MouseState = MaterialSkin.MouseState.OUT;
            listViewCancelOrder.Name = "listViewCancelOrder";
            listViewCancelOrder.OwnerDraw = true;
            listViewCancelOrder.Size = new Size(658, 463);
            listViewCancelOrder.TabIndex = 95;
            listViewCancelOrder.UseCompatibleStateImageBehavior = false;
            listViewCancelOrder.View = System.Windows.Forms.View.Details;
            listViewCancelOrder.SelectedIndexChanged += listViewRejectOrder_SelectedIndexChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 134;
            label1.Text = "ORDER CANCEL";
            // 
            // VIewCancelOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 612);
            Controls.Add(label1);
            Controls.Add(lblMobileNUm);
            Controls.Add(lblCustomerContactTag);
            Controls.Add(btnPdfPrint);
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
            Controls.Add(listViewCancelOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VIewCancelOrderForm";
            Text = "VIewCancelOrderForm";
            ((System.ComponentModel.ISupportInitialize)imgItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMobileNUm;
        private Label lblCustomerContactTag;
        private TextBox texSearch;
        private ColumnHeader colIsPaid;
        private ColumnHeader colQty;
        private MaterialSkin.Controls.MaterialButton btnPdfPrint;
        private Label lblStatus;
        private PictureBox imgItem;
        private Label lblCustomerName;
        private Label lblPayment;
        private Label lblQty;
        private Label lblItemName;
        private ColumnHeader colOrderDate;
        private Label lblOrderCode;
        private Label lblPaymenTag;
        private Label lblQtyTag;
        private Label lblItemNameTag;
        private Label lblCustomerNameTag;
        private Label lblOrderCodeTag;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox loader;
        private MaterialSkin.Controls.MaterialListView listViewCancelOrder;
        private ColumnHeader colOrderCode;
        private ColumnHeader colStatus;
        private ColumnHeader colTotalAmount;
        private Label label1;
    }
}