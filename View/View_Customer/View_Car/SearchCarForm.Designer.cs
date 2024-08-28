namespace car_traders
{
    partial class SearchCarForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCarForm));
            texSearchCar = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            resultContainer = new FlowLayoutPanel();
            imgCarDetail = new PictureBox();
            lblCarModel = new Label();
            lblColor = new Label();
            lblManufacturing = new Label();
            lblMileage = new Label();
            lblFuelType = new Label();
            lblBodyType = new Label();
            lblPrice = new Label();
            timerCardetail = new System.Windows.Forms.Timer(components);
            btnSubmit = new Button();
            loader = new PictureBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblYearTag = new Label();
            lblBodyTag = new Label();
            lblColortag = new Label();
            lblFuelTag = new Label();
            lblBrand = new Label();
            lblBrandTag = new Label();
            lblModelTag = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCarDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // texSearchCar
            // 
            texSearchCar.Location = new Point(13, 11);
            texSearchCar.Name = "texSearchCar";
            texSearchCar.Size = new Size(518, 31);
            texSearchCar.TabIndex = 1;
            texSearchCar.TextChanged += texSearchCar_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearchCar);
            panel1.Location = new Point(21, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 54);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(566, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // resultContainer
            // 
            resultContainer.Location = new Point(31, 118);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(776, 214);
            resultContainer.TabIndex = 4;
            // 
            // imgCarDetail
            // 
            imgCarDetail.Location = new Point(22, 10);
            imgCarDetail.Name = "imgCarDetail";
            imgCarDetail.Size = new Size(321, 202);
            imgCarDetail.TabIndex = 5;
            imgCarDetail.TabStop = false;
            imgCarDetail.Visible = false;
            // 
            // lblCarModel
            // 
            lblCarModel.AutoSize = true;
            lblCarModel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarModel.Location = new Point(107, 215);
            lblCarModel.Name = "lblCarModel";
            lblCarModel.Size = new Size(70, 28);
            lblCarModel.TabIndex = 6;
            lblCarModel.Text = "model";
            lblCarModel.Visible = false;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblColor.Location = new Point(107, 409);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(54, 25);
            lblColor.TabIndex = 7;
            lblColor.Text = "color";
            lblColor.Visible = false;
            lblColor.Click += lblColor_Click;
            // 
            // lblManufacturing
            // 
            lblManufacturing.AutoSize = true;
            lblManufacturing.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblManufacturing.Location = new Point(107, 377);
            lblManufacturing.Name = "lblManufacturing";
            lblManufacturing.Size = new Size(47, 25);
            lblManufacturing.TabIndex = 8;
            lblManufacturing.Text = "year";
            lblManufacturing.Visible = false;
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMileage.ForeColor = Color.Teal;
            lblMileage.Location = new Point(245, 218);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(68, 25);
            lblMileage.TabIndex = 9;
            lblMileage.Text = "milage";
            lblMileage.Visible = false;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuelType.Location = new Point(107, 297);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(47, 28);
            lblFuelType.TabIndex = 10;
            lblFuelType.Text = "fuel";
            lblFuelType.Visible = false;
            // 
            // lblBodyType
            // 
            lblBodyType.AutoSize = true;
            lblBodyType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBodyType.Location = new Point(107, 335);
            lblBodyType.Name = "lblBodyType";
            lblBodyType.Size = new Size(58, 28);
            lblBodyType.TabIndex = 11;
            lblBodyType.Text = "body";
            lblBodyType.Visible = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.Highlight;
            lblPrice.Location = new Point(19, 450);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 28);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "price";
            lblPrice.Visible = false;
            // 
            // timerCardetail
            // 
            timerCardetail.Enabled = true;
            timerCardetail.Tick += timerCardetail_Tick;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.CornflowerBlue;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Image = (Image)resources.GetObject("btnSubmit.Image");
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(24, 485);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(20, 0, 0, 0);
            btnSubmit.Size = new Size(333, 76);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "ORDER REQUEST";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Visible = false;
            btnSubmit.Click += btnSubmit_Click;
            btnSubmit.MouseLeave += btnSubmit_MouseLeave;
            btnSubmit.MouseHover += btnSubmit_MouseHover;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(689, 7);
            loader.Name = "loader";
            loader.Size = new Size(76, 62);
            loader.SizeMode = PictureBoxSizeMode.CenterImage;
            loader.TabIndex = 14;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblYearTag);
            materialCard1.Controls.Add(lblBodyTag);
            materialCard1.Controls.Add(lblColortag);
            materialCard1.Controls.Add(lblMileage);
            materialCard1.Controls.Add(lblFuelTag);
            materialCard1.Controls.Add(lblColor);
            materialCard1.Controls.Add(lblBrand);
            materialCard1.Controls.Add(lblManufacturing);
            materialCard1.Controls.Add(imgCarDetail);
            materialCard1.Controls.Add(btnSubmit);
            materialCard1.Controls.Add(lblBrandTag);
            materialCard1.Controls.Add(lblCarModel);
            materialCard1.Controls.Add(lblModelTag);
            materialCard1.Controls.Add(lblPrice);
            materialCard1.Controls.Add(lblBodyType);
            materialCard1.Controls.Add(lblFuelType);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(822, 23);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(369, 569);
            materialCard1.TabIndex = 0;
            // 
            // lblYearTag
            // 
            lblYearTag.AutoSize = true;
            lblYearTag.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearTag.ForeColor = Color.DimGray;
            lblYearTag.Location = new Point(19, 374);
            lblYearTag.Name = "lblYearTag";
            lblYearTag.Size = new Size(67, 28);
            lblYearTag.TabIndex = 21;
            lblYearTag.Text = "Year  :";
            lblYearTag.Visible = false;
            // 
            // lblBodyTag
            // 
            lblBodyTag.AutoSize = true;
            lblBodyTag.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBodyTag.ForeColor = Color.DimGray;
            lblBodyTag.Location = new Point(19, 335);
            lblBodyTag.Name = "lblBodyTag";
            lblBodyTag.Size = new Size(72, 28);
            lblBodyTag.TabIndex = 22;
            lblBodyTag.Text = "Type  :";
            lblBodyTag.Visible = false;
            // 
            // lblColortag
            // 
            lblColortag.AutoSize = true;
            lblColortag.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColortag.ForeColor = Color.DimGray;
            lblColortag.Location = new Point(19, 406);
            lblColortag.Name = "lblColortag";
            lblColortag.Size = new Size(77, 28);
            lblColortag.TabIndex = 20;
            lblColortag.Text = "Color  :";
            lblColortag.Visible = false;
            // 
            // lblFuelTag
            // 
            lblFuelTag.AutoSize = true;
            lblFuelTag.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuelTag.ForeColor = Color.DimGray;
            lblFuelTag.Location = new Point(19, 297);
            lblFuelTag.Name = "lblFuelTag";
            lblFuelTag.Size = new Size(67, 28);
            lblFuelTag.TabIndex = 21;
            lblFuelTag.Text = "Fuel  :";
            lblFuelTag.Visible = false;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.Location = new Point(107, 254);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(71, 28);
            lblBrand.TabIndex = 20;
            lblBrand.Text = "Brand ";
            lblBrand.Visible = false;
            // 
            // lblBrandTag
            // 
            lblBrandTag.AutoSize = true;
            lblBrandTag.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandTag.ForeColor = Color.DimGray;
            lblBrandTag.Location = new Point(19, 254);
            lblBrandTag.Name = "lblBrandTag";
            lblBrandTag.Size = new Size(82, 28);
            lblBrandTag.TabIndex = 19;
            lblBrandTag.Text = "Brand  :";
            lblBrandTag.Visible = false;
            // 
            // lblModelTag
            // 
            lblModelTag.AutoSize = true;
            lblModelTag.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelTag.ForeColor = Color.DimGray;
            lblModelTag.Location = new Point(19, 215);
            lblModelTag.Name = "lblModelTag";
            lblModelTag.Size = new Size(87, 28);
            lblModelTag.TabIndex = 18;
            lblModelTag.Text = "Model  :";
            lblModelTag.Visible = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(panel1);
            materialCard2.Controls.Add(pictureBox1);
            materialCard2.Controls.Add(loader);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(31, 26);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(776, 75);
            materialCard2.TabIndex = 15;
            materialCard2.Paint += materialCard2_Paint;
            // 
            // SearchCarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1217, 607);
            ControlBox = false;
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(resultContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchCarForm";
            Text = "CustomerSearchCarForm";
            Load += SearchCarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCarDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox texSearchCar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel resultContainer;
        private PictureBox imgCarDetail;
        private Label lblCarModel;
        private Label lblColor;
        private Label lblManufacturing;
        private Label lblMileage;
        private Label lblFuelType;
        private Label lblBodyType;
        private Label lblPrice;
        private System.Windows.Forms.Timer timerCardetail;
        private Button btnSubmit;
        private PictureBox loader;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label lblBrand;
        private Label lblBrandTag;
        private Label lblModelTag;
        private Label lblYearTag;
        private Label lblColortag;
        private Label lblBodyTag;
        private Label lblFuelTag;
    }
}