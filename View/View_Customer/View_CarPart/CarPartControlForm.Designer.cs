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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)imgCarPart).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 159);
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
            lblStatus.Location = new Point(610, 161);
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
            lblPrice.Location = new Point(300, 161);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 28);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Price";
            // 
            // lblCarModel
            // 
            lblCarModel.AutoSize = true;
            lblCarModel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarModel.Location = new Point(259, 119);
            lblCarModel.Name = "lblCarModel";
            lblCarModel.Size = new Size(70, 28);
            lblCarModel.TabIndex = 19;
            lblCarModel.Text = "model";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.Location = new Point(259, 80);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(65, 28);
            lblBrand.TabIndex = 18;
            lblBrand.Text = "brand";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(259, 42);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(41, 28);
            lblQty.TabIndex = 17;
            lblQty.Text = "qty";
            // 
            // lblCarPartName
            // 
            lblCarPartName.AutoSize = true;
            lblCarPartName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarPartName.Location = new Point(259, 4);
            lblCarPartName.Name = "lblCarPartName";
            lblCarPartName.Size = new Size(108, 28);
            lblCarPartName.TabIndex = 16;
            lblCarPartName.Text = "Part Name";
            // 
            // imgCarPart
            // 
            imgCarPart.Image = (Image)resources.GetObject("imgCarPart.Image");
            imgCarPart.Location = new Point(0, 0);
            imgCarPart.Name = "imgCarPart";
            imgCarPart.Size = new Size(233, 192);
            imgCarPart.SizeMode = PictureBoxSizeMode.CenterImage;
            imgCarPart.TabIndex = 15;
            imgCarPart.TabStop = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(imgCarPart);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(lblCarPartName);
            materialCard1.Controls.Add(lblStatus);
            materialCard1.Controls.Add(lblQty);
            materialCard1.Controls.Add(lblPrice);
            materialCard1.Controls.Add(lblBrand);
            materialCard1.Controls.Add(lblCarModel);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(12, 9);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(741, 192);
            materialCard1.TabIndex = 23;
            materialCard1.Click += CarPartControlForm_Click;
            materialCard1.MouseLeave += CarPartControlForm_MouseLeave;
            materialCard1.MouseHover += CarPartControlForm_MouseHover;
            // 
            // CarPartControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Cursor = Cursors.Hand;
            Name = "CarPartControlForm";
            Size = new Size(776, 214);
            ((System.ComponentModel.ISupportInitialize)imgCarPart).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
