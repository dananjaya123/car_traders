namespace car_traders.View.Customer
{
    partial class CarOrderForm
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
            imgCar = new PictureBox();
            lblBrandName = new Label();
            lblModel = new Label();
            lblColor = new Label();
            lblFuelType = new Label();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)imgCar).BeginInit();
            SuspendLayout();
            // 
            // imgCar
            // 
            imgCar.Location = new Point(60, 2);
            imgCar.Name = "imgCar";
            imgCar.Size = new Size(207, 175);
            imgCar.TabIndex = 1;
            imgCar.TabStop = false;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandName.Location = new Point(2, 207);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(136, 30);
            lblBrandName.TabIndex = 2;
            lblBrandName.Text = "Brand Name";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModel.Location = new Point(2, 257);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(142, 30);
            lblModel.TabIndex = 3;
            lblModel.Text = "Model Name";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(2, 306);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(67, 30);
            lblColor.TabIndex = 4;
            lblColor.Text = "Color";
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuelType.Location = new Point(2, 348);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(108, 30);
            lblFuelType.TabIndex = 5;
            lblFuelType.Text = "Fuel Type";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(2, 395);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(62, 30);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // CarOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 607);
            ControlBox = false;
            Controls.Add(lblPrice);
            Controls.Add(lblFuelType);
            Controls.Add(lblColor);
            Controls.Add(lblModel);
            Controls.Add(lblBrandName);
            Controls.Add(imgCar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarOrderForm";
            Text = "CarOrderForm";
            ((System.ComponentModel.ISupportInitialize)imgCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox imgCar;
        private Label lblBrandName;
        private Label lblModel;
        private Label lblColor;
        private Label lblFuelType;
        private Label lblPrice;
    }
}