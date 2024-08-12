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
            lblManufacturingYear.Location = new Point(294, 113);
            lblManufacturingYear.Name = "lblManufacturingYear";
            lblManufacturingYear.Size = new Size(189, 28);
            lblManufacturingYear.TabIndex = 8;
            lblManufacturingYear.Text = "Manufacturing year";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(294, 70);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(60, 28);
            lblColor.TabIndex = 7;
            lblColor.Text = "Color";
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(294, 29);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(101, 28);
            lblCarName.TabIndex = 6;
            lblCarName.Text = "Car Name";
            // 
            // SearchCarUserColtrollFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrice);
            Controls.Add(lblManufacturingYear);
            Controls.Add(lblColor);
            Controls.Add(lblCarName);
            Controls.Add(imgCar);
            Cursor = Cursors.Hand;
            Name = "SearchCarUserColtrollFrom";
            Size = new Size(776, 214);
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
    }
}
