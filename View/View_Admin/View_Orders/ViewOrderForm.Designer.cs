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
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            listViewOrder.Size = new Size(729, 427);
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
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(804, 17);
            loader.Name = "loader";
            loader.Size = new Size(137, 129);
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
            pictureBox1.Location = new Point(591, 75);
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
            panel1.Location = new Point(12, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 54);
            panel1.TabIndex = 29;
            // 
            // texSearch
            // 
            texSearch.Location = new Point(4, 11);
            texSearch.Name = "texSearch";
            texSearch.Size = new Size(566, 31);
            texSearch.TabIndex = 1;
            texSearch.Tag = "";
            texSearch.TextChanged += texSearch_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(871, 149);
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
            lblTotalAmount.Location = new Point(878, 301);
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
            lblPayment.Location = new Point(868, 262);
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
            lblQty.Location = new Point(871, 223);
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
            lblOrderCode.Location = new Point(871, 187);
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
            lblPaymenTag.Location = new Point(747, 262);
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
            lblQtyTag.Location = new Point(747, 223);
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
            lblTotalAmountTag.Location = new Point(747, 302);
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
            lblOrderCodeTag.Location = new Point(747, 187);
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
            btnPayment.Location = new Point(747, 506);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(10, 0, 0, 0);
            btnPayment.Size = new Size(246, 70);
            btnPayment.TabIndex = 74;
            btnPayment.Text = "PAY";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Visible = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(749, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(10, 0, 0, 0);
            btnCancel.Size = new Size(244, 70);
            btnCancel.TabIndex = 73;
            btnCancel.Text = "REJECT";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.CadetBlue;
            btnViewDetails.Cursor = Cursors.Hand;
            btnViewDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDetails.ForeColor = SystemColors.ButtonHighlight;
            btnViewDetails.Image = (Image)resources.GetObject("btnViewDetails.Image");
            btnViewDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewDetails.Location = new Point(750, 346);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Padding = new Padding(10, 0, 0, 0);
            btnViewDetails.Size = new Size(243, 76);
            btnViewDetails.TabIndex = 76;
            btnViewDetails.Text = "VIEW DETAILS";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Visible = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlDarkDark;
            lblTitle.Location = new Point(12, 25);
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
            btnCarPdfPrint.Location = new Point(675, 93);
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
            lblStatusTag.Location = new Point(747, 149);
            lblStatusTag.Name = "lblStatusTag";
            lblStatusTag.Size = new Size(77, 25);
            lblStatusTag.TabIndex = 79;
            lblStatusTag.Text = "Status  :";
            lblStatusTag.Visible = false;
            // 
            // ViewOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 612);
            Controls.Add(lblStatusTag);
            Controls.Add(lblTitle);
            Controls.Add(btnCarPdfPrint);
            Controls.Add(btnViewDetails);
            Controls.Add(btnPayment);
            Controls.Add(btnCancel);
            Controls.Add(lblStatus);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblPayment);
            Controls.Add(lblQty);
            Controls.Add(lblOrderCode);
            Controls.Add(lblPaymenTag);
            Controls.Add(lblQtyTag);
            Controls.Add(lblTotalAmountTag);
            Controls.Add(lblOrderCodeTag);
            Controls.Add(loader);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(listViewOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrderForm";
            Text = "ViewCustomerOrderForm";
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}