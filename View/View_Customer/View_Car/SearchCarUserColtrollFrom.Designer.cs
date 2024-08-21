namespace car_traders.View.Customer
{
    partial class SearchCarUserColtrollFrom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCarUserColtrollFrom));
            imgCar = new PictureBox();
            lblPrice = new Label();
            lblManufacturingYear = new Label();
            lblColor = new Label();
            lblCarName = new Label();
            lblStatus = new Label();
            label1 = new Label();
            lblCarSelingType = new Label();
            ((System.ComponentModel.ISupportInitialize)imgCar).BeginInit();
            SuspendLayout();
            // 
            // imgCar
            // 
            imgCar.Image = (Image)resources.GetObject("imgCar.Image");
            imgCar.Location = new Point(10, 9);
            imgCar.Name = "imgCar";
            imgCar.Size = new Size(241, 196);
            imgCar.SizeMode = PictureBoxSizeMode.CenterImage;
            imgCar.TabIndex = 5;
            imgCar.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.Highlight;
            lblPrice.Location = new Point(294, 157);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 28);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // lblManufacturingYear
            // 
            lblManufacturingYear.AutoSize = true;
            lblManufacturingYear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManufacturingYear.Location = new Point(257, 114);
            lblManufacturingYear.Name = "lblManufacturingYear";
            lblManufacturingYear.Size = new Size(189, 28);
            lblManufacturingYear.TabIndex = 8;
            lblManufacturingYear.Text = "Manufacturing year";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(257, 70);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(60, 28);
            lblColor.TabIndex = 7;
            lblColor.Text = "Color";
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(256, 30);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(101, 28);
            lblCarName.TabIndex = 6;
            lblCarName.Text = "Car Name";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkCyan;
            lblStatus.Location = new Point(604, 157);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 28);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 155);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 11;
            label1.Text = "Rs :";
            // 
            // lblCarSelingType
            // 
            lblCarSelingType.AutoSize = true;
            lblCarSelingType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarSelingType.ForeColor = Color.DarkCyan;
            lblCarSelingType.Location = new Point(604, 30);
            lblCarSelingType.Name = "lblCarSelingType";
            lblCarSelingType.Size = new Size(52, 28);
            lblCarSelingType.TabIndex = 12;
            lblCarSelingType.Text = "type";
            // 
            // SearchCarUserColtrollFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCarSelingType);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(lblPrice);
            Controls.Add(lblManufacturingYear);
            Controls.Add(lblColor);
            Controls.Add(lblCarName);
            Controls.Add(imgCar);
            Cursor = Cursors.Hand;
            Name = "SearchCarUserColtrollFrom";
            Size = new Size(776, 214);
            Load += SearchCarUserColtrollFrom_Load;
            Click += SearchCarUserColtrollFrom_Click;
            MouseClick += SearchCarUserColtrollFrom_MouseClick;
            MouseLeave += SearchCarUserColtrollFrom_MouseLeave;
            MouseHover += SearchCarUserColtrollFrom_MouseHover;
            MouseMove += SearchCarUserColtrollFrom_MouseMove;
            ((System.ComponentModel.ISupportInitialize)imgCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgCar;
        private Label lblPrice;
        private Label lblManufacturingYear;
        private Label lblColor;
        private Label lblCarName;
        private Label lblStatus;
        private Label label1;
        private Label lblCarSelingType;
    }
}
