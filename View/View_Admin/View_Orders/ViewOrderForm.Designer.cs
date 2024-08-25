namespace car_traders.View.View_Admin.View_Orders
{
    partial class ViewOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderForm));
            listViewOrder = new MaterialSkin.Controls.MaterialListView();
            colOrderCode = new ColumnHeader();
            colStatus = new ColumnHeader();
            colTotalAmount = new ColumnHeader();
            colOrderDate = new ColumnHeader();
            colQty = new ColumnHeader();
            colIsPaid = new ColumnHeader();
            loader = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            texSearch = new TextBox();
            lblStatus = new Label();
            lblTotalAmount = new Label();
            lblPayment = new Label();
            lblQty = new Label();
            lblOrderCode = new Label();
            lblPaymenTag = new Label();
            lblQtyTag = new Label();
            lblTotalAmountTag = new Label();
            lblOrderCodeTag = new Label();
            btnPayment = new Button();
            btnCancel = new Button();
            btnViewDetails = new Button();
            lblTitle = new Label();
            btnCarPdfPrint = new MaterialSkin.Controls.MaterialButton();
            lblStatusTag = new Label();
            pnlOrderLoad = new MaterialSkin.Controls.MaterialCard();
            pnlCustomerData = new MaterialSkin.Controls.MaterialCard();
            lblAddress = new Label();
            lblUserCode = new Label();
            lblAddressTag = new Label();
            lblUserCodeTag = new Label();
            lblMobileNumber = new Label();
            lblMobileTag = new Label();
            lblUserName = new Label();
            lblUserNameTag = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnlOrderLoad.SuspendLayout();
            pnlCustomerData.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewOrder
            // 
            listViewOrder.AutoSizeTable = false;
            listViewOrder.BackColor = Color.FromArgb(255, 255, 255);
            listViewOrder.BorderStyle = BorderStyle.None;
            listViewOrder.Columns.AddRange(new ColumnHeader[] { colOrderCode, colStatus, colTotalAmount, colOrderDate, colQty, colIsPaid });
            listViewOrder.Depth = 0;
            listViewOrder.FullRowSelect = true;
            listViewOrder.Location = new Point(12, 149);
            listViewOrder.MinimumSize = new Size(200, 100);
            listViewOrder.MouseLocation = new Point(-1, -1);
            listViewOrder.MouseState = MaterialSkin.MouseState.OUT;
            listViewOrder.Name = "listViewOrder";
            listViewOrder.OwnerDraw = true;
            listViewOrder.Size = new Size(901, 482);
            listViewOrder.TabIndex = 1;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = System.Windows.Forms.View.Details;
            listViewOrder.SelectedIndexChanged += listViewOrder_SelectedIndexChanged;
            // 
            // colOrderCode
            // 
            colOrderCode.Text = "Order Code";
            colOrderCode.Width = 110;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 150;
            // 
            // colTotalAmount
            // 
            colTotalAmount.Text = "Amount";
            colTotalAmount.TextAlign = HorizontalAlignment.Center;
            colTotalAmount.Width = 200;
            // 
            // colOrderDate
            // 
            colOrderDate.Text = "Order Date";
            colOrderDate.Width = 150;
            // 
            // colQty
            // 
            colQty.Text = "QTY";
            colQty.TextAlign = HorizontalAlignment.Center;
            colQty.Width = 100;
            // 
            // colIsPaid
            // 
            colIsPaid.Text = "Is Payment";
            colIsPaid.Width = 150;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(365, 301);
            loader.Name = "loader";
            loader.Size = new Size(164, 152);
            loader.SizeMode = PictureBoxSizeMode.Zoom;
            loader.TabIndex = 31;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(729, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearch);
            panel1.Location = new Point(28, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 54);
            panel1.TabIndex = 29;
            // 
            // texSearch
            // 
            texSearch.Location = new Point(11, 11);
            texSearch.Name = "texSearch";
            texSearch.Size = new Size(676, 31);
            texSearch.TabIndex = 1;
            texSearch.Tag = "";
            texSearch.TextChanged += texSearch_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(141, 14);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 25);
            lblStatus.TabIndex = 63;
            lblStatus.Text = "status";
            lblStatus.Visible = false;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotalAmount.ForeColor = SystemColors.WindowFrame;
            lblTotalAmount.Location = new Point(148, 166);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(80, 25);
            lblTotalAmount.TabIndex = 62;
            lblTotalAmount.Text = "Amount";
            lblTotalAmount.Visible = false;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPayment.ForeColor = SystemColors.WindowFrame;
            lblPayment.Location = new Point(138, 127);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(103, 25);
            lblPayment.TabIndex = 61;
            lblPayment.Text = "Is payment";
            lblPayment.Visible = false;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQty.ForeColor = SystemColors.WindowFrame;
            lblQty.Location = new Point(141, 88);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(39, 25);
            lblQty.TabIndex = 60;
            lblQty.Text = "qty";
            lblQty.Visible = false;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCode.ForeColor = SystemColors.WindowFrame;
            lblOrderCode.Location = new Point(141, 52);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(52, 25);
            lblOrderCode.TabIndex = 59;
            lblOrderCode.Text = "code";
            lblOrderCode.Visible = false;
            // 
            // lblPaymenTag
            // 
            lblPaymenTag.AutoSize = true;
            lblPaymenTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPaymenTag.ForeColor = SystemColors.WindowFrame;
            lblPaymenTag.Location = new Point(6, 127);
            lblPaymenTag.Name = "lblPaymenTag";
            lblPaymenTag.Size = new Size(93, 25);
            lblPaymenTag.TabIndex = 58;
            lblPaymenTag.Text = "Payment :";
            lblPaymenTag.Visible = false;
            // 
            // lblQtyTag
            // 
            lblQtyTag.AutoSize = true;
            lblQtyTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQtyTag.ForeColor = SystemColors.WindowFrame;
            lblQtyTag.Location = new Point(6, 88);
            lblQtyTag.Name = "lblQtyTag";
            lblQtyTag.Size = new Size(105, 25);
            lblQtyTag.TabIndex = 57;
            lblQtyTag.Text = "Order Qty :";
            lblQtyTag.Visible = false;
            // 
            // lblTotalAmountTag
            // 
            lblTotalAmountTag.AutoSize = true;
            lblTotalAmountTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotalAmountTag.ForeColor = SystemColors.WindowFrame;
            lblTotalAmountTag.Location = new Point(4, 167);
            lblTotalAmountTag.Name = "lblTotalAmountTag";
            lblTotalAmountTag.Size = new Size(134, 25);
            lblTotalAmountTag.TabIndex = 56;
            lblTotalAmountTag.Text = "Total Amount :";
            lblTotalAmountTag.Visible = false;
            // 
            // lblOrderCodeTag
            // 
            lblOrderCodeTag.AutoSize = true;
            lblOrderCodeTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCodeTag.ForeColor = SystemColors.WindowFrame;
            lblOrderCodeTag.Location = new Point(5, 52);
            lblOrderCodeTag.Name = "lblOrderCodeTag";
            lblOrderCodeTag.Size = new Size(118, 25);
            lblOrderCodeTag.TabIndex = 55;
            lblOrderCodeTag.Text = "Order Code :";
            lblOrderCodeTag.Visible = false;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.CornflowerBlue;
            btnPayment.Cursor = Cursors.Hand;
            btnPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = SystemColors.ButtonHighlight;
            btnPayment.Image = (Image)resources.GetObject("btnPayment.Image");
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(926, 555);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(10, 0, 0, 0);
            btnPayment.Size = new Size(421, 70);
            btnPayment.TabIndex = 74;
            btnPayment.Text = "PAY";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Visible = false;
            btnPayment.Click += btnPayment_Click;
            btnPayment.MouseLeave += btnPayment_MouseLeave;
            btnPayment.MouseHover += btnPayment_MouseHover;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(924, 473);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(10, 0, 0, 0);
            btnCancel.Size = new Size(210, 76);
            btnCancel.TabIndex = 73;
            btnCancel.Text = "REJECT";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
            btnCancel.MouseHover += btnCancel_MouseHover;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.CadetBlue;
            btnViewDetails.Cursor = Cursors.Hand;
            btnViewDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDetails.ForeColor = SystemColors.ButtonHighlight;
            btnViewDetails.Image = (Image)resources.GetObject("btnViewDetails.Image");
            btnViewDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewDetails.Location = new Point(1139, 473);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Padding = new Padding(10, 0, 0, 0);
            btnViewDetails.Size = new Size(208, 76);
            btnViewDetails.TabIndex = 76;
            btnViewDetails.Text = "VIEW";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Visible = false;
            btnViewDetails.Click += btnViewDetails_Click;
            btnViewDetails.MouseLeave += btnViewDetails_MouseLeave;
            btnViewDetails.MouseHover += btnViewDetails_MouseHover;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlDarkDark;
            lblTitle.Location = new Point(12, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 30);
            lblTitle.TabIndex = 78;
            lblTitle.Text = "ORDER";
            lblTitle.Click += label1_Click;
            // 
            // btnCarPdfPrint
            // 
            btnCarPdfPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarPdfPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCarPdfPrint.Depth = 0;
            btnCarPdfPrint.HighEmphasis = true;
            btnCarPdfPrint.Icon = (Image)resources.GetObject("btnCarPdfPrint.Icon");
            btnCarPdfPrint.Image = (Image)resources.GetObject("btnCarPdfPrint.Image");
            btnCarPdfPrint.Location = new Point(830, 52);
            btnCarPdfPrint.Margin = new Padding(4, 6, 4, 6);
            btnCarPdfPrint.MouseState = MaterialSkin.MouseState.HOVER;
            btnCarPdfPrint.Name = "btnCarPdfPrint";
            btnCarPdfPrint.NoAccentTextColor = Color.Empty;
            btnCarPdfPrint.Size = new Size(64, 36);
            btnCarPdfPrint.TabIndex = 77;
            btnCarPdfPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCarPdfPrint.UseAccentColor = false;
            btnCarPdfPrint.UseVisualStyleBackColor = true;
            btnCarPdfPrint.Click += btnCarPdfPrint_Click;
            // 
            // lblStatusTag
            // 
            lblStatusTag.AutoSize = true;
            lblStatusTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatusTag.ForeColor = SystemColors.WindowFrame;
            lblStatusTag.Location = new Point(5, 14);
            lblStatusTag.Name = "lblStatusTag";
            lblStatusTag.Size = new Size(77, 25);
            lblStatusTag.TabIndex = 79;
            lblStatusTag.Text = "Status  :";
            lblStatusTag.Visible = false;
            // 
            // pnlOrderLoad
            // 
            pnlOrderLoad.BackColor = Color.FromArgb(255, 255, 255);
            pnlOrderLoad.Controls.Add(lblStatusTag);
            pnlOrderLoad.Controls.Add(lblOrderCodeTag);
            pnlOrderLoad.Controls.Add(lblTotalAmountTag);
            pnlOrderLoad.Controls.Add(lblQtyTag);
            pnlOrderLoad.Controls.Add(lblPaymenTag);
            pnlOrderLoad.Controls.Add(lblOrderCode);
            pnlOrderLoad.Controls.Add(lblQty);
            pnlOrderLoad.Controls.Add(lblStatus);
            pnlOrderLoad.Controls.Add(lblPayment);
            pnlOrderLoad.Controls.Add(lblTotalAmount);
            pnlOrderLoad.Depth = 0;
            pnlOrderLoad.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnlOrderLoad.Location = new Point(924, 249);
            pnlOrderLoad.Margin = new Padding(14);
            pnlOrderLoad.MouseState = MaterialSkin.MouseState.HOVER;
            pnlOrderLoad.Name = "pnlOrderLoad";
            pnlOrderLoad.Padding = new Padding(14);
            pnlOrderLoad.Size = new Size(421, 220);
            pnlOrderLoad.TabIndex = 80;
            // 
            // pnlCustomerData
            // 
            pnlCustomerData.BackColor = Color.FromArgb(255, 255, 255);
            pnlCustomerData.Controls.Add(lblAddress);
            pnlCustomerData.Controls.Add(lblUserCode);
            pnlCustomerData.Controls.Add(lblAddressTag);
            pnlCustomerData.Controls.Add(lblUserCodeTag);
            pnlCustomerData.Controls.Add(lblMobileNumber);
            pnlCustomerData.Controls.Add(lblMobileTag);
            pnlCustomerData.Controls.Add(lblUserName);
            pnlCustomerData.Controls.Add(lblUserNameTag);
            pnlCustomerData.Depth = 0;
            pnlCustomerData.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnlCustomerData.Location = new Point(924, 47);
            pnlCustomerData.Margin = new Padding(14);
            pnlCustomerData.MouseState = MaterialSkin.MouseState.HOVER;
            pnlCustomerData.Name = "pnlCustomerData";
            pnlCustomerData.Padding = new Padding(14);
            pnlCustomerData.Size = new Size(420, 197);
            pnlCustomerData.TabIndex = 81;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAddress.ForeColor = SystemColors.WindowFrame;
            lblAddress.Location = new Point(102, 126);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 25);
            lblAddress.TabIndex = 87;
            lblAddress.Text = "Address";
            lblAddress.Visible = false;
            // 
            // lblUserCode
            // 
            lblUserCode.AutoSize = true;
            lblUserCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUserCode.ForeColor = SystemColors.WindowFrame;
            lblUserCode.Location = new Point(121, 91);
            lblUserCode.Name = "lblUserCode";
            lblUserCode.Size = new Size(55, 25);
            lblUserCode.TabIndex = 86;
            lblUserCode.Text = "U000";
            lblUserCode.Visible = false;
            // 
            // lblAddressTag
            // 
            lblAddressTag.AutoSize = true;
            lblAddressTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAddressTag.ForeColor = SystemColors.WindowFrame;
            lblAddressTag.Location = new Point(8, 126);
            lblAddressTag.Name = "lblAddressTag";
            lblAddressTag.Size = new Size(88, 25);
            lblAddressTag.TabIndex = 85;
            lblAddressTag.Text = "Address :";
            lblAddressTag.Visible = false;
            // 
            // lblUserCodeTag
            // 
            lblUserCodeTag.AutoSize = true;
            lblUserCodeTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUserCodeTag.ForeColor = SystemColors.WindowFrame;
            lblUserCodeTag.Location = new Point(8, 91);
            lblUserCodeTag.Name = "lblUserCodeTag";
            lblUserCodeTag.Size = new Size(107, 25);
            lblUserCodeTag.TabIndex = 84;
            lblUserCodeTag.Text = "User Code :";
            lblUserCodeTag.Visible = false;
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMobileNumber.ForeColor = SystemColors.WindowFrame;
            lblMobileNumber.Location = new Point(168, 51);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(72, 25);
            lblMobileNumber.TabIndex = 83;
            lblMobileNumber.Text = "077000";
            lblMobileNumber.Visible = false;
            // 
            // lblMobileTag
            // 
            lblMobileTag.AutoSize = true;
            lblMobileTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMobileTag.ForeColor = SystemColors.WindowFrame;
            lblMobileTag.Location = new Point(8, 51);
            lblMobileTag.Name = "lblMobileTag";
            lblMobileTag.Size = new Size(154, 25);
            lblMobileTag.TabIndex = 82;
            lblMobileTag.Text = "Mobile Number :";
            lblMobileTag.Visible = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUserName.ForeColor = SystemColors.WindowFrame;
            lblUserName.Location = new Point(89, 14);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(58, 25);
            lblUserName.TabIndex = 81;
            lblUserName.Text = "name";
            lblUserName.Visible = false;
            // 
            // lblUserNameTag
            // 
            lblUserNameTag.AutoSize = true;
            lblUserNameTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUserNameTag.ForeColor = SystemColors.WindowFrame;
            lblUserNameTag.Location = new Point(8, 14);
            lblUserNameTag.Name = "lblUserNameTag";
            lblUserNameTag.Size = new Size(75, 25);
            lblUserNameTag.TabIndex = 80;
            lblUserNameTag.Text = "Name  :";
            lblUserNameTag.Visible = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(panel1);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(btnCarPdfPrint);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(12, 47);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(903, 97);
            materialCard1.TabIndex = 82;
            // 
            // ViewOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 639);
            Controls.Add(materialCard1);
            Controls.Add(pnlCustomerData);
            Controls.Add(pnlOrderLoad);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(btnViewDetails);
            Controls.Add(btnPayment);
            Controls.Add(loader);
            Controls.Add(listViewOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrderForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "ViewCustomerOrderForm";
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlOrderLoad.ResumeLayout(false);
            pnlOrderLoad.PerformLayout();
            pnlCustomerData.ResumeLayout(false);
            pnlCustomerData.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewOrder;
        private ColumnHeader colOrderCode;
        private ColumnHeader colStatus;
        private ColumnHeader colTotalAmount;
        private ColumnHeader colOrderDate;
        private ColumnHeader colQty;
        private ColumnHeader colIsPaid;
        private PictureBox loader;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox texSearch;
        private Label lblStatus;
        private Label lblTotalAmount;
        private Label lblPayment;
        private Label lblQty;
        private Label lblOrderCode;
        private Label lblPaymenTag;
        private Label lblQtyTag;
        private Label lblTotalAmountTag;
        private Label lblOrderCodeTag;
        private Button btnPayment;
        private Button btnCancel;
        private Button btnViewDetails;
        private Label lblTitle;
        private MaterialSkin.Controls.MaterialButton btnCarPdfPrint;
        private Label lblStatusTag;
        private MaterialSkin.Controls.MaterialCard pnlOrderLoad;
        private MaterialSkin.Controls.MaterialCard pnlCustomerData;
        private Label lblAddress;
        private Label lblUserCode;
        private Label lblAddressTag;
        private Label lblUserCodeTag;
        private Label lblMobileNumber;
        private Label lblMobileTag;
        private Label lblUserName;
        private Label lblUserNameTag;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}