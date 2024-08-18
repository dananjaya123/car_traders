namespace car_traders.View.View_Admin.View_Orders
{
    partial class ViewRequestOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRequestOrderForm));
            lblStatus = new Label();
            imgItem = new PictureBox();
            lblTotalAmount = new Label();
            lblPayment = new Label();
            lblQty = new Label();
            lblItemName = new Label();
            lblOrderCode = new Label();
            btnCancel = new Button();
            lblPaymenTag = new Label();
            lblQtyTag = new Label();
            lblItemNameTag = new Label();
            lblTotalAmountTag = new Label();
            lblOrderCodeTag = new Label();
            texSearch = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            colIsPaid = new ColumnHeader();
            colQty = new ColumnHeader();
            colOrderDate = new ColumnHeader();
            colTotalAmount = new ColumnHeader();
            colStatus = new ColumnHeader();
            colOrderCode = new ColumnHeader();
            loader = new PictureBox();
            listViewOrder = new MaterialSkin.Controls.MaterialListView();
            btnPayment = new Button();
            btnCarPdfPrint = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(707, 249);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 25);
            lblStatus.TabIndex = 71;
            lblStatus.Text = "status";
            lblStatus.Visible = false;
            // 
            // imgItem
            // 
            imgItem.Location = new Point(689, 23);
            imgItem.Name = "imgItem";
            imgItem.Size = new Size(264, 217);
            imgItem.TabIndex = 70;
            imgItem.TabStop = false;
            imgItem.Visible = false;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotalAmount.ForeColor = SystemColors.WindowFrame;
            lblTotalAmount.Location = new Point(838, 452);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(80, 25);
            lblTotalAmount.TabIndex = 69;
            lblTotalAmount.Text = "Amount";
            lblTotalAmount.Visible = false;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPayment.ForeColor = SystemColors.WindowFrame;
            lblPayment.Location = new Point(831, 413);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(85, 25);
            lblPayment.TabIndex = 68;
            lblPayment.Text = "payment";
            lblPayment.Visible = false;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQty.ForeColor = SystemColors.WindowFrame;
            lblQty.Location = new Point(831, 374);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(39, 25);
            lblQty.TabIndex = 67;
            lblQty.Text = "qty";
            lblQty.Visible = false;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblItemName.ForeColor = SystemColors.WindowFrame;
            lblItemName.Location = new Point(831, 330);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(58, 25);
            lblItemName.TabIndex = 66;
            lblItemName.Text = "name";
            lblItemName.Visible = false;
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCode.ForeColor = SystemColors.WindowFrame;
            lblOrderCode.Location = new Point(831, 287);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(52, 25);
            lblOrderCode.TabIndex = 65;
            lblOrderCode.Text = "code";
            lblOrderCode.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(722, 494);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(213, 51);
            btnCancel.TabIndex = 64;
            btnCancel.Text = "REJECT";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPaymenTag
            // 
            lblPaymenTag.AutoSize = true;
            lblPaymenTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPaymenTag.ForeColor = SystemColors.WindowFrame;
            lblPaymenTag.Location = new Point(707, 413);
            lblPaymenTag.Name = "lblPaymenTag";
            lblPaymenTag.Size = new Size(93, 25);
            lblPaymenTag.TabIndex = 63;
            lblPaymenTag.Text = "Payment :";
            lblPaymenTag.Visible = false;
            // 
            // lblQtyTag
            // 
            lblQtyTag.AutoSize = true;
            lblQtyTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQtyTag.ForeColor = SystemColors.WindowFrame;
            lblQtyTag.Location = new Point(707, 374);
            lblQtyTag.Name = "lblQtyTag";
            lblQtyTag.Size = new Size(105, 25);
            lblQtyTag.TabIndex = 62;
            lblQtyTag.Text = "Order Qty :";
            lblQtyTag.Visible = false;
            // 
            // lblItemNameTag
            // 
            lblItemNameTag.AutoSize = true;
            lblItemNameTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblItemNameTag.ForeColor = SystemColors.WindowFrame;
            lblItemNameTag.Location = new Point(707, 330);
            lblItemNameTag.Name = "lblItemNameTag";
            lblItemNameTag.Size = new Size(113, 25);
            lblItemNameTag.TabIndex = 61;
            lblItemNameTag.Text = "Item Name :";
            lblItemNameTag.Visible = false;
            // 
            // lblTotalAmountTag
            // 
            lblTotalAmountTag.AutoSize = true;
            lblTotalAmountTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotalAmountTag.ForeColor = SystemColors.WindowFrame;
            lblTotalAmountTag.Location = new Point(707, 453);
            lblTotalAmountTag.Name = "lblTotalAmountTag";
            lblTotalAmountTag.Size = new Size(134, 25);
            lblTotalAmountTag.TabIndex = 60;
            lblTotalAmountTag.Text = "Total Amount :";
            lblTotalAmountTag.Visible = false;
            // 
            // lblOrderCodeTag
            // 
            lblOrderCodeTag.AutoSize = true;
            lblOrderCodeTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblOrderCodeTag.ForeColor = SystemColors.WindowFrame;
            lblOrderCodeTag.Location = new Point(707, 287);
            lblOrderCodeTag.Name = "lblOrderCodeTag";
            lblOrderCodeTag.Size = new Size(118, 25);
            lblOrderCodeTag.TabIndex = 59;
            lblOrderCodeTag.Text = "Order Code :";
            lblOrderCodeTag.Visible = false;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(511, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearch);
            panel1.Location = new Point(23, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 54);
            panel1.TabIndex = 56;
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
            // colOrderDate
            // 
            colOrderDate.Text = "Order Date";
            colOrderDate.Width = 150;
            // 
            // colTotalAmount
            // 
            colTotalAmount.Text = "Amount";
            colTotalAmount.Width = 150;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 100;
            // 
            // colOrderCode
            // 
            colOrderCode.Text = "Order Code";
            colOrderCode.Width = 100;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(214, 23);
            loader.Name = "loader";
            loader.Size = new Size(75, 54);
            loader.SizeMode = PictureBoxSizeMode.CenterImage;
            loader.TabIndex = 58;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // listViewOrder
            // 
            listViewOrder.AutoSizeTable = false;
            listViewOrder.BackColor = Color.FromArgb(255, 255, 255);
            listViewOrder.BorderStyle = BorderStyle.None;
            listViewOrder.Columns.AddRange(new ColumnHeader[] { colOrderCode, colStatus, colTotalAmount, colOrderDate, colQty, colIsPaid });
            listViewOrder.Depth = 0;
            listViewOrder.FullRowSelect = true;
            listViewOrder.Location = new Point(12, 168);
            listViewOrder.MinimumSize = new Size(200, 100);
            listViewOrder.MouseLocation = new Point(-1, -1);
            listViewOrder.MouseState = MaterialSkin.MouseState.OUT;
            listViewOrder.Name = "listViewOrder";
            listViewOrder.OwnerDraw = true;
            listViewOrder.Size = new Size(658, 432);
            listViewOrder.TabIndex = 55;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            listViewOrder.View = System.Windows.Forms.View.Details;
            listViewOrder.SelectedIndexChanged += listViewOrder_SelectedIndexChanged;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.CornflowerBlue;
            btnPayment.Cursor = Cursors.Hand;
            btnPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = SystemColors.ButtonHighlight;
            btnPayment.Location = new Point(722, 551);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(213, 51);
            btnPayment.TabIndex = 72;
            btnPayment.Text = "PAY";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Visible = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnCarPdfPrint
            // 
            btnCarPdfPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarPdfPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCarPdfPrint.Depth = 0;
            btnCarPdfPrint.HighEmphasis = true;
            btnCarPdfPrint.Icon = (Image)resources.GetObject("btnCarPdfPrint.Icon");
            btnCarPdfPrint.Image = (Image)resources.GetObject("btnCarPdfPrint.Image");
            btnCarPdfPrint.Location = new Point(595, 104);
            btnCarPdfPrint.Margin = new Padding(4, 6, 4, 6);
            btnCarPdfPrint.MouseState = MaterialSkin.MouseState.HOVER;
            btnCarPdfPrint.Name = "btnCarPdfPrint";
            btnCarPdfPrint.NoAccentTextColor = Color.Empty;
            btnCarPdfPrint.Size = new Size(64, 36);
            btnCarPdfPrint.TabIndex = 73;
            btnCarPdfPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCarPdfPrint.UseAccentColor = false;
            btnCarPdfPrint.UseVisualStyleBackColor = true;
            btnCarPdfPrint.Click += btnCarPdfPrint_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 74;
            label1.Text = "ORDER REQUEST ";
            // 
            // ViewRequestOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 612);
            Controls.Add(label1);
            Controls.Add(btnCarPdfPrint);
            Controls.Add(btnPayment);
            Controls.Add(lblStatus);
            Controls.Add(imgItem);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblPayment);
            Controls.Add(lblQty);
            Controls.Add(lblItemName);
            Controls.Add(lblOrderCode);
            Controls.Add(btnCancel);
            Controls.Add(lblPaymenTag);
            Controls.Add(lblQtyTag);
            Controls.Add(lblItemNameTag);
            Controls.Add(lblTotalAmountTag);
            Controls.Add(lblOrderCodeTag);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(loader);
            Controls.Add(listViewOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewRequestOrderForm";
            ShowInTaskbar = false;
            Text = "ViewOrderForm";
            Load += ViewRequestOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)imgItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private PictureBox imgItem;
        private Label lblTotalAmount;
        private Label lblPayment;
        private Label lblQty;
        private Label lblItemName;
        private Label lblOrderCode;
        private Button btnCancel;
        private Label lblPaymenTag;
        private Label lblQtyTag;
        private Label lblItemNameTag;
        private Label lblTotalAmountTag;
        private Label lblOrderCodeTag;
        private TextBox texSearch;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ColumnHeader colIsPaid;
        private ColumnHeader colQty;
        private ColumnHeader colOrderDate;
        private ColumnHeader colTotalAmount;
        private ColumnHeader colStatus;
        private ColumnHeader colOrderCode;
        private PictureBox loader;
        private MaterialSkin.Controls.MaterialListView listViewOrder;
        private Button btnPayment;
        private MaterialSkin.Controls.MaterialButton btnCarPdfPrint;
        private Label label1;
    }
}