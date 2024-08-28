namespace car_traders
{
    partial class CustomerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainForm));
            pnlSlide = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            panel2 = new Panel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCarSearch = new MaterialSkin.Controls.MaterialButton();
            btnCarParts = new MaterialSkin.Controls.MaterialButton();
            btnViewOrder = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pnlMain = new Panel();
            pnlSlide.SuspendLayout();
            materialCard2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSlide
            // 
            pnlSlide.BackColor = Color.LightSteelBlue;
            pnlSlide.Controls.Add(materialCard2);
            pnlSlide.Controls.Add(panel1);
            pnlSlide.Controls.Add(materialCard1);
            pnlSlide.Dock = DockStyle.Left;
            pnlSlide.Location = new Point(3, 64);
            pnlSlide.Name = "pnlSlide";
            pnlSlide.Size = new Size(180, 607);
            pnlSlide.TabIndex = 1;
            pnlSlide.Paint += pnlSlide_Paint;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(panel2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(10, 173);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(156, 420);
            materialCard2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 420);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = (Image)resources.GetObject("btnLogout.Icon");
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(24, 366);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(106, 36);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "logout";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnCarSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCarParts, 0, 1);
            tableLayoutPanel1.Controls.Add(btnViewOrder, 0, 2);
            tableLayoutPanel1.Location = new Point(3, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(148, 153);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCarSearch
            // 
            btnCarSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarSearch.Cursor = Cursors.Hand;
            btnCarSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCarSearch.Depth = 0;
            btnCarSearch.Dock = DockStyle.Fill;
            btnCarSearch.HighEmphasis = true;
            btnCarSearch.Icon = (Image)resources.GetObject("btnCarSearch.Icon");
            btnCarSearch.Image = (Image)resources.GetObject("btnCarSearch.Image");
            btnCarSearch.Location = new Point(4, 6);
            btnCarSearch.Margin = new Padding(4, 6, 4, 6);
            btnCarSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnCarSearch.Name = "btnCarSearch";
            btnCarSearch.NoAccentTextColor = Color.Empty;
            btnCarSearch.Size = new Size(140, 39);
            btnCarSearch.TabIndex = 0;
            btnCarSearch.Text = "Car";
            btnCarSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCarSearch.UseAccentColor = false;
            btnCarSearch.UseVisualStyleBackColor = true;
            btnCarSearch.Click += btnCarSearch_Click;
            // 
            // btnCarParts
            // 
            btnCarParts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarParts.Cursor = Cursors.Hand;
            btnCarParts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCarParts.Depth = 0;
            btnCarParts.Dock = DockStyle.Fill;
            btnCarParts.HighEmphasis = true;
            btnCarParts.Icon = (Image)resources.GetObject("btnCarParts.Icon");
            btnCarParts.Image = (Image)resources.GetObject("btnCarParts.Image");
            btnCarParts.Location = new Point(4, 57);
            btnCarParts.Margin = new Padding(4, 6, 4, 6);
            btnCarParts.MouseState = MaterialSkin.MouseState.HOVER;
            btnCarParts.Name = "btnCarParts";
            btnCarParts.NoAccentTextColor = Color.Empty;
            btnCarParts.Size = new Size(140, 39);
            btnCarParts.TabIndex = 1;
            btnCarParts.Text = "Car Parts";
            btnCarParts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCarParts.UseAccentColor = false;
            btnCarParts.UseVisualStyleBackColor = true;
            btnCarParts.Click += btnCarParts_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewOrder.Cursor = Cursors.Hand;
            btnViewOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnViewOrder.Depth = 0;
            btnViewOrder.Dock = DockStyle.Fill;
            btnViewOrder.HighEmphasis = true;
            btnViewOrder.Icon = (Image)resources.GetObject("btnViewOrder.Icon");
            btnViewOrder.Image = (Image)resources.GetObject("btnViewOrder.Image");
            btnViewOrder.Location = new Point(4, 108);
            btnViewOrder.Margin = new Padding(4, 6, 4, 6);
            btnViewOrder.MouseState = MaterialSkin.MouseState.HOVER;
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.NoAccentTextColor = Color.Empty;
            btnViewOrder.Size = new Size(140, 39);
            btnViewOrder.TabIndex = 2;
            btnViewOrder.Text = "View Orders";
            btnViewOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnViewOrder.UseAccentColor = false;
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(10, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 137);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(10, 19);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(153, 137);
            materialCard1.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(183, 64);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1217, 607);
            pnlMain.TabIndex = 3;
            // 
            // CustomerMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 674);
            Controls.Add(pnlMain);
            Controls.Add(pnlSlide);
            Name = "CustomerMainForm";
            Text = "CAR TRADERS";
            Load += CustomerMainForm_Load;
            pnlSlide.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSlide;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnCarSearch;
        private MaterialSkin.Controls.MaterialButton btnCarParts;
        private MaterialSkin.Controls.MaterialButton btnViewOrder;
        private Panel pnlMain;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Panel panel2;
    }
}