namespace car_traders.View.View_Customer.View_CarPart
{
    partial class CarPartControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPartControlForm));
            label1 = new Label();
            lblStatus = new Label();
            lblPrice = new Label();
            lblCarModel = new Label();
            lblBrand = new Label();
            lblQty = new Label();
            lblCarPartName = new Label();
            imgCarPart = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgCarPart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 167);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 22;
            label1.Text = "Rs :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkCyan;
            lblStatus.Location = new Point(601, 169);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 28);
            lblStatus.TabIndex = 21;
            lblStatus.Text = "status";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.Highlight;
            lblPrice.Location = new Point(291, 169);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 28);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Price";
            // 
            // lblCarModel
            // 
            lblCarModel.AutoSize = true;
            lblCarModel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarModel.Location = new Point(250, 127);
            lblCarModel.Name = "lblCarModel";
            lblCarModel.Size = new Size(70, 28);
            lblCarModel.TabIndex = 19;
            lblCarModel.Text = "model";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.Location = new Point(250, 88);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(65, 28);
            lblBrand.TabIndex = 18;
            lblBrand.Text = "brand";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(250, 50);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(41, 28);
            lblQty.TabIndex = 17;
            lblQty.Text = "qty";
            // 
            // lblCarPartName
            // 
            lblCarPartName.AutoSize = true;
            lblCarPartName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarPartName.Location = new Point(250, 12);
            lblCarPartName.Name = "lblCarPartName";
            lblCarPartName.Size = new Size(108, 28);
            lblCarPartName.TabIndex = 16;
            lblCarPartName.Text = "Part Name";
            // 
            // imgCarPart
            // 
            imgCarPart.Image = (Image)resources.GetObject("imgCarPart.Image");
            imgCarPart.Location = new Point(3, 12);
            imgCarPart.Name = "imgCarPart";
            imgCarPart.Size = new Size(241, 196);
            imgCarPart.SizeMode = PictureBoxSizeMode.CenterImage;
            imgCarPart.TabIndex = 15;
            imgCarPart.TabStop = false;
            // 
            // CarPartControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(lblPrice);
            Controls.Add(lblCarModel);
            Controls.Add(lblBrand);
            Controls.Add(lblQty);
            Controls.Add(lblCarPartName);
            Controls.Add(imgCarPart);
            Cursor = Cursors.Hand;
            Name = "CarPartControlForm";
            Size = new Size(776, 214);
            Click += CarPartControlForm_Click;
            MouseLeave += CarPartControlForm_MouseLeave;
            MouseHover += CarPartControlForm_MouseHover;
            ((System.ComponentModel.ISupportInitialize)imgCarPart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStatus;
        private Label lblPrice;
        private Label lblCarModel;
        private Label lblBrand;
        private Label lblQty;
        private Label lblCarPartName;
        private PictureBox imgCarPart;
    }
}
