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
            lblFelType = new Label();
            lblBodyType = new Label();
            lblPrice = new Label();
            timerCardetail = new System.Windows.Forms.Timer(components);
            btnSubmit = new Button();
            loader = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCarDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            SuspendLayout();
            // 
            // texSearchCar
            // 
            texSearchCar.Location = new Point(8, 11);
            texSearchCar.Name = "texSearchCar";
            texSearchCar.Size = new Size(474, 31);
            texSearchCar.TabIndex = 1;
            texSearchCar.TextChanged += texSearchCar_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearchCar);
            panel1.Location = new Point(138, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 54);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(623, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // resultContainer
            // 
            resultContainer.Location = new Point(31, 95);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(776, 214);
            resultContainer.TabIndex = 4;
            // 
            // imgCarDetail
            // 
            imgCarDetail.Location = new Point(832, 73);
            imgCarDetail.Name = "imgCarDetail";
            imgCarDetail.Size = new Size(114, 105);
            imgCarDetail.TabIndex = 5;
            imgCarDetail.TabStop = false;
            imgCarDetail.Visible = false;
            // 
            // lblCarModel
            // 
            lblCarModel.AutoSize = true;
            lblCarModel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarModel.Location = new Point(839, 212);
            lblCarModel.Name = "lblCarModel";
            lblCarModel.Size = new Size(70, 28);
            lblCarModel.TabIndex = 6;
            lblCarModel.Text = "model";
            lblCarModel.Visible = false;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 9F);
            lblColor.Location = new Point(952, 74);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(52, 25);
            lblColor.TabIndex = 7;
            lblColor.Text = "color";
            lblColor.Visible = false;
            lblColor.Click += lblColor_Click;
            // 
            // lblManufacturing
            // 
            lblManufacturing.AutoSize = true;
            lblManufacturing.Font = new Font("Segoe UI", 9F);
            lblManufacturing.Location = new Point(952, 111);
            lblManufacturing.Name = "lblManufacturing";
            lblManufacturing.Size = new Size(45, 25);
            lblManufacturing.TabIndex = 8;
            lblManufacturing.Text = "year";
            lblManufacturing.Visible = false;
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Font = new Font("Segoe UI", 9F);
            lblMileage.Location = new Point(952, 153);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(65, 25);
            lblMileage.TabIndex = 9;
            lblMileage.Text = "milage";
            lblMileage.Visible = false;
            // 
            // lblFelType
            // 
            lblFelType.AutoSize = true;
            lblFelType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFelType.Location = new Point(839, 251);
            lblFelType.Name = "lblFelType";
            lblFelType.Size = new Size(47, 28);
            lblFelType.TabIndex = 10;
            lblFelType.Text = "fuel";
            lblFelType.Visible = false;
            // 
            // lblBodyType
            // 
            lblBodyType.AutoSize = true;
            lblBodyType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBodyType.Location = new Point(839, 291);
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
            lblPrice.Location = new Point(839, 346);
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
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(832, 429);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(333, 76);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "ORDER REQUEST";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Visible = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(966, 511);
            loader.Name = "loader";
            loader.Size = new Size(81, 73);
            loader.SizeMode = PictureBoxSizeMode.CenterImage;
            loader.TabIndex = 14;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // SearchCarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1217, 607);
            ControlBox = false;
            Controls.Add(loader);
            Controls.Add(btnSubmit);
            Controls.Add(lblPrice);
            Controls.Add(lblBodyType);
            Controls.Add(lblFelType);
            Controls.Add(lblMileage);
            Controls.Add(lblManufacturing);
            Controls.Add(lblColor);
            Controls.Add(lblCarModel);
            Controls.Add(imgCarDetail);
            Controls.Add(resultContainer);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchCarForm";
            Text = "CustomerSearchCarForm";
            Load += SearchCarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCarDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblFelType;
        private Label lblBodyType;
        private Label lblPrice;
        private System.Windows.Forms.Timer timerCardetail;
        private Button btnSubmit;
        private PictureBox loader;
    }
}