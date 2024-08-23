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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)imgCar).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // imgCar
            // 
            imgCar.Image = (Image)resources.GetObject("imgCar.Image");
            imgCar.Location = new Point(2, 2);
            imgCar.Name = "imgCar";
            imgCar.Size = new Size(230, 203);
            imgCar.SizeMode = PictureBoxSizeMode.CenterImage;
            imgCar.TabIndex = 5;
            imgCar.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.Highlight;
            lblPrice.Location = new Point(280, 153);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 28);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // lblManufacturingYear
            // 
            lblManufacturingYear.AutoSize = true;
            lblManufacturingYear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManufacturingYear.Location = new Point(243, 110);
            lblManufacturingYear.Name = "lblManufacturingYear";
            lblManufacturingYear.Size = new Size(189, 28);
            lblManufacturingYear.TabIndex = 8;
            lblManufacturingYear.Text = "Manufacturing year";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(243, 66);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(60, 28);
            lblColor.TabIndex = 7;
            lblColor.Text = "Color";
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarName.Location = new Point(242, 26);
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
            lblStatus.Location = new Point(590, 153);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 28);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 151);
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
            lblCarSelingType.Location = new Point(590, 26);
            lblCarSelingType.Name = "lblCarSelingType";
            lblCarSelingType.Size = new Size(52, 28);
            lblCarSelingType.TabIndex = 12;
            lblCarSelingType.Text = "type";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(imgCar);
            materialCard1.Controls.Add(lblCarSelingType);
            materialCard1.Controls.Add(lblCarName);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(lblColor);
            materialCard1.Controls.Add(lblStatus);
            materialCard1.Controls.Add(lblManufacturingYear);
            materialCard1.Controls.Add(lblPrice);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(12, 5);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(734, 205);
            materialCard1.TabIndex = 13;
            materialCard1.Click += SearchCarUserColtrollFrom_Click;
            materialCard1.MouseLeave += SearchCarUserColtrollFrom_MouseLeave;
            materialCard1.MouseHover += SearchCarUserColtrollFrom_MouseHover;
            // 
            // SearchCarUserColtrollFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Cursor = Cursors.Hand;
            Name = "SearchCarUserColtrollFrom";
            Size = new Size(776, 214);
            ((System.ComponentModel.ISupportInitialize)imgCar).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
