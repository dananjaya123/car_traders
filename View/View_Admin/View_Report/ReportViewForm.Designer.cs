namespace car_traders.View.View_Admin.View_Report
{
    partial class ReportViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewForm));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnSearch = new Button();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            dateTo = new DateTimePicker();
            panel2 = new Panel();
            dateFrom = new DateTimePicker();
            panel1 = new Panel();
            texSearch = new TextBox();
            btnCarPdfPrint = new MaterialSkin.Controls.MaterialButton();
            lblTitle = new Label();
            listViewReport = new MaterialSkin.Controls.MaterialListView();
            colOrderCode = new ColumnHeader();
            colStatus = new ColumnHeader();
            colTotalAmount = new ColumnHeader();
            colOrderDate = new ColumnHeader();
            colQty = new ColumnHeader();
            colIsPaid = new ColumnHeader();
            colUserCode = new ColumnHeader();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            panel4 = new Panel();
            totalAmount = new Label();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            loader = new PictureBox();
            pnlEmptyMs = new Panel();
            btnEmptyMsBoxClose = new Button();
            lblEmptyValueMs = new Label();
            pictureBox1 = new PictureBox();
            materialCard1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            pnlEmptyMs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnSearch);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(panel3);
            materialCard1.Controls.Add(panel2);
            materialCard1.Controls.Add(panel1);
            materialCard1.Controls.Add(btnCarPdfPrint);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(21, 43);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1296, 97);
            materialCard1.TabIndex = 85;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.ForeColor = Color.CornflowerBlue;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(1103, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 60);
            btnSearch.TabIndex = 84;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 9);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 83;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 82;
            label1.Text = "From";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(dateTo);
            panel3.Location = new Point(376, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 54);
            panel3.TabIndex = 81;
            // 
            // dateTo
            // 
            dateTo.Format = DateTimePickerFormat.Short;
            dateTo.Location = new Point(6, 14);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(300, 31);
            dateTo.TabIndex = 78;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dateFrom);
            panel2.Location = new Point(31, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 54);
            panel2.TabIndex = 80;
            // 
            // dateFrom
            // 
            dateFrom.Format = DateTimePickerFormat.Short;
            dateFrom.Location = new Point(6, 14);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(300, 31);
            dateFrom.TabIndex = 78;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearch);
            panel1.Location = new Point(718, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 54);
            panel1.TabIndex = 29;
            // 
            // texSearch
            // 
            texSearch.Location = new Point(16, 11);
            texSearch.Name = "texSearch";
            texSearch.Size = new Size(339, 31);
            texSearch.TabIndex = 1;
            texSearch.Tag = "";
            // 
            // btnCarPdfPrint
            // 
            btnCarPdfPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarPdfPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCarPdfPrint.Depth = 0;
            btnCarPdfPrint.HighEmphasis = true;
            btnCarPdfPrint.Icon = (Image)resources.GetObject("btnCarPdfPrint.Icon");
            btnCarPdfPrint.Image = (Image)resources.GetObject("btnCarPdfPrint.Image");
            btnCarPdfPrint.Location = new Point(1216, 35);
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlDarkDark;
            lblTitle.Location = new Point(20, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(90, 30);
            lblTitle.TabIndex = 84;
            lblTitle.Text = "REPORT";
            // 
            // listViewReport
            // 
            listViewReport.AutoSizeTable = false;
            listViewReport.BackColor = Color.FromArgb(255, 255, 255);
            listViewReport.BorderStyle = BorderStyle.None;
            listViewReport.Columns.AddRange(new ColumnHeader[] { colOrderCode, colStatus, colTotalAmount, colOrderDate, colQty, colIsPaid, colUserCode });
            listViewReport.Depth = 0;
            listViewReport.FullRowSelect = true;
            listViewReport.Location = new Point(23, 147);
            listViewReport.MinimumSize = new Size(200, 100);
            listViewReport.MouseLocation = new Point(-1, -1);
            listViewReport.MouseState = MaterialSkin.MouseState.OUT;
            listViewReport.Name = "listViewReport";
            listViewReport.OwnerDraw = true;
            listViewReport.Size = new Size(1017, 482);
            listViewReport.TabIndex = 83;
            listViewReport.UseCompatibleStateImageBehavior = false;
            listViewReport.View = System.Windows.Forms.View.Details;
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
            // colUserCode
            // 
            colUserCode.Text = "User Code";
            colUserCode.Width = 150;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(1055, 171);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(260, 66);
            materialCard2.TabIndex = 86;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(41, 12);
            label3.Name = "label3";
            label3.Size = new Size(189, 38);
            label3.TabIndex = 0;
            label3.Text = "Total Amount";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSeaGreen;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(1055, 170);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 67);
            panel4.TabIndex = 0;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmount.ForeColor = Color.FromArgb(64, 64, 64);
            totalAmount.Location = new Point(18, 14);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(113, 38);
            totalAmount.TabIndex = 1;
            totalAmount.Text = "000000";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(totalAmount);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(1057, 253);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(260, 76);
            materialCard3.TabIndex = 88;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(1075, 365);
            loader.Name = "loader";
            loader.Size = new Size(226, 226);
            loader.SizeMode = PictureBoxSizeMode.Zoom;
            loader.TabIndex = 89;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // pnlEmptyMs
            // 
            pnlEmptyMs.BackColor = Color.WhiteSmoke;
            pnlEmptyMs.Controls.Add(btnEmptyMsBoxClose);
            pnlEmptyMs.Controls.Add(lblEmptyValueMs);
            pnlEmptyMs.Controls.Add(pictureBox1);
            pnlEmptyMs.Location = new Point(335, 287);
            pnlEmptyMs.Name = "pnlEmptyMs";
            pnlEmptyMs.Size = new Size(451, 127);
            pnlEmptyMs.TabIndex = 90;
            pnlEmptyMs.Visible = false;
            // 
            // btnEmptyMsBoxClose
            // 
            btnEmptyMsBoxClose.Location = new Point(327, 86);
            btnEmptyMsBoxClose.Name = "btnEmptyMsBoxClose";
            btnEmptyMsBoxClose.Size = new Size(112, 34);
            btnEmptyMsBoxClose.TabIndex = 2;
            btnEmptyMsBoxClose.Text = "Close";
            btnEmptyMsBoxClose.UseVisualStyleBackColor = true;
            btnEmptyMsBoxClose.Click += btnEmptyMsBoxClose_Click;
            // 
            // lblEmptyValueMs
            // 
            lblEmptyValueMs.AutoSize = true;
            lblEmptyValueMs.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmptyValueMs.ForeColor = Color.FromArgb(0, 192, 192);
            lblEmptyValueMs.Location = new Point(154, 14);
            lblEmptyValueMs.Name = "lblEmptyValueMs";
            lblEmptyValueMs.Size = new Size(202, 32);
            lblEmptyValueMs.TabIndex = 1;
            lblEmptyValueMs.Text = "Values is empty !.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ReportViewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 639);
            Controls.Add(pnlEmptyMs);
            Controls.Add(loader);
            Controls.Add(materialCard3);
            Controls.Add(panel4);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(lblTitle);
            Controls.Add(listViewReport);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportViewForm";
            Text = "ReportViewForm";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            pnlEmptyMs.ResumeLayout(false);
            pnlEmptyMs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Panel panel1;
        private TextBox texSearch;
        private MaterialSkin.Controls.MaterialButton btnCarPdfPrint;
        private Label lblTitle;
        private MaterialSkin.Controls.MaterialListView listViewReport;
        private ColumnHeader colOrderCode;
        private ColumnHeader colStatus;
        private ColumnHeader colTotalAmount;
        private ColumnHeader colOrderDate;
        private ColumnHeader colQty;
        private ColumnHeader colIsPaid;
        private Panel panel3;
        private DateTimePicker dateTo;
        private Panel panel2;
        private Label label1;
        private DateTimePicker dateFrom;
        private Label label2;
        private ColumnHeader colUserCode;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label label3;
        private Panel panel4;
        private Label totalAmount;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private PictureBox loader;
        private Button btnSearch;
        private Panel pnlEmptyMs;
        private PictureBox pictureBox1;
        private Label lblEmptyValueMs;
        private Button btnEmptyMsBoxClose;
    }
}