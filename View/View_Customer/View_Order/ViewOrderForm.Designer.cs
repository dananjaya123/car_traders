namespace car_traders.View.View_Customer.View_Order
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            texSearch = new TextBox();
            loader = new PictureBox();
            lblOrderCodeTag = new Label();
            lblTotalAmountTag = new Label();
            lblQtyTag = new Label();
            lblPaymenTag = new Label();
            btnCancel = new Button();
            lblOrderCode = new Label();
            lblQty = new Label();
            lblPayment = new Label();
            lblTotalAmount = new Label();
            lblStatus = new Label();
            btnViewDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
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
            listViewOrder.Location = new Point(12, 102);
            listViewOrder.MinimumSize = new Size(200, 100);
            listViewOrder.MouseLocation = new Point(-1, -1);
            listViewOrder.MouseState = MaterialSkin.MouseState.OUT;
            listViewOrder.Name = "listViewOrder";
            listViewOrder.OwnerDraw = true;
            listViewOrder.Size = new Size(825, 381);
            listViewOrder.TabIndex = 0;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = System.Windows.Forms.View.Details;
            listViewOrder.SelectedIndexChanged += listViewOrder_SelectedIndexChanged;
            // 
            // colOrderCode
            // 
            colOrderCode.Text = "Order Code";
            colOrderCode.Width = 150;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 150;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(604, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearch);
            panel1.Location = new Point(12, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 54);
            panel1.TabIndex = 17;
            // 
            // texSearch
            // 
            texSearch.Location = new Point(8, 11);
            texSearch.Name = "texSearch";
            texSearch.Size = new Size(578, 31);
            texSearch.TabIndex = 1;
            texSearch.Tag = "";
            texSearch.TextChanged += texSearchCarPart_TextChanged;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(666, 32);
            loader.Name = "loader";
            loader.Size = new Size(75, 54);
            loader.SizeMode = PictureBoxSizeMode.CenterImage;
            loader.TabIndex = 28;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // lblOrderCodeTag
            // 
            lblOrderCodeTag.AutoSize = true;
            lblOrderCodeTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCodeTag.ForeColor = SystemColors.WindowFrame;
            lblOrderCodeTag.Location = new Point(855, 150);
            lblOrderCodeTag.Name = "lblOrderCodeTag";
            lblOrderCodeTag.Size = new Size(118, 25);
            lblOrderCodeTag.TabIndex = 40;
            lblOrderCodeTag.Text = "Order Code :";
            lblOrderCodeTag.Visible = false;
            // 
            // lblTotalAmountTag
            // 
            lblTotalAmountTag.AutoSize = true;
            lblTotalAmountTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotalAmountTag.ForeColor = SystemColors.WindowFrame;
            lblTotalAmountTag.Location = new Point(855, 265);
            lblTotalAmountTag.Name = "lblTotalAmountTag";
            lblTotalAmountTag.Size = new Size(134, 25);
            lblTotalAmountTag.TabIndex = 41;
            lblTotalAmountTag.Text = "Total Amount :";
            lblTotalAmountTag.Visible = false;
            // 
            // lblQtyTag
            // 
            lblQtyTag.AutoSize = true;
            lblQtyTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQtyTag.ForeColor = SystemColors.WindowFrame;
            lblQtyTag.Location = new Point(855, 186);
            lblQtyTag.Name = "lblQtyTag";
            lblQtyTag.Size = new Size(105, 25);
            lblQtyTag.TabIndex = 44;
            lblQtyTag.Text = "Order Qty :";
            lblQtyTag.Visible = false;
            // 
            // lblPaymenTag
            // 
            lblPaymenTag.AutoSize = true;
            lblPaymenTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPaymenTag.ForeColor = SystemColors.WindowFrame;
            lblPaymenTag.Location = new Point(855, 225);
            lblPaymenTag.Name = "lblPaymenTag";
            lblPaymenTag.Size = new Size(93, 25);
            lblPaymenTag.TabIndex = 45;
            lblPaymenTag.Text = "Payment :";
            lblPaymenTag.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(855, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(20, 0, 0, 0);
            btnCancel.Size = new Size(266, 76);
            btnCancel.TabIndex = 46;
            btnCancel.Text = "ORDER CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCode.ForeColor = SystemColors.WindowFrame;
            lblOrderCode.Location = new Point(979, 150);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(52, 25);
            lblOrderCode.TabIndex = 47;
            lblOrderCode.Text = "code";
            lblOrderCode.Visible = false;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQty.ForeColor = SystemColors.WindowFrame;
            lblQty.Location = new Point(979, 186);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(39, 25);
            lblQty.TabIndex = 50;
            lblQty.Text = "qty";
            lblQty.Visible = false;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPayment.ForeColor = SystemColors.WindowFrame;
            lblPayment.Location = new Point(979, 225);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(103, 25);
            lblPayment.TabIndex = 51;
            lblPayment.Text = "Is payment";
            lblPayment.Visible = false;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotalAmount.ForeColor = SystemColors.WindowFrame;
            lblTotalAmount.Location = new Point(986, 264);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(80, 25);
            lblTotalAmount.TabIndex = 52;
            lblTotalAmount.Text = "Amount";
            lblTotalAmount.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(855, 112);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 25);
            lblStatus.TabIndex = 54;
            lblStatus.Text = "status";
            lblStatus.Visible = false;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.CornflowerBlue;
            btnViewDetails.Cursor = Cursors.Hand;
            btnViewDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDetails.ForeColor = SystemColors.ButtonHighlight;
            btnViewDetails.Image = (Image)resources.GetObject("btnViewDetails.Image");
            btnViewDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewDetails.Location = new Point(855, 309);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Padding = new Padding(20, 0, 0, 0);
            btnViewDetails.Size = new Size(266, 76);
            btnViewDetails.TabIndex = 55;
            btnViewDetails.Text = "VIEW DETAILS";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Visible = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // ViewOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1133, 495);
            Controls.Add(btnViewDetails);
            Controls.Add(lblStatus);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblPayment);
            Controls.Add(lblQty);
            Controls.Add(lblOrderCode);
            Controls.Add(btnCancel);
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
            Text = "ViewOrderForm";
            Load += ViewOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
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
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox texSearch;
        private PictureBox loader;
        private Label lblOrderCodeTag;
        private Label lblTotalAmountTag;
        private Label lblQtyTag;
        private Label lblPaymenTag;
        private Button btnCancel;
        private Label lblOrderCode;
        private Label lblQty;
        private Label lblPayment;
        private Label lblTotalAmount;
        private Label lblStatus;
        private Button btnViewDetails;
    }
}