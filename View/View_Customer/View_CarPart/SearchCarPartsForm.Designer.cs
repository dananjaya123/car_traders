namespace car_traders.View.Customer
{
    partial class SearchCarPartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCarPartsForm));
            texSearchCarPart = new TextBox();
            imgCarPart = new PictureBox();
            resultContainer = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            loader = new PictureBox();
            btnSubmit = new Button();
            timerCarPart = new System.Windows.Forms.Timer(components);
            lblPrice = new Label();
            lblModel = new Label();
            lblBrand = new Label();
            lblQty = new Label();
            lblCarPartName = new Label();
            lblPriceTag = new Label();
            lblStatus = new Label();
            lblCategory = new Label();
            numInputQty = new NumericUpDown();
            lblQtyTag = new Label();
            lblBranTag = new Label();
            lblModelTag = new Label();
            lblCategoryTag = new Label();
            lblParNameTag = new Label();
            lblTotalTag = new Label();
            label2 = new Label();
            lblTotal = new Label();
            btnViewCart = new Button();
            lblCartOrderCount = new Label();
            ((System.ComponentModel.ISupportInitialize)imgCarPart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInputQty).BeginInit();
            SuspendLayout();
            // 
            // texSearchCarPart
            // 
            texSearchCarPart.Location = new Point(8, 11);
            texSearchCarPart.Name = "texSearchCarPart";
            texSearchCarPart.Size = new Size(474, 31);
            texSearchCarPart.TabIndex = 1;
            texSearchCarPart.TextChanged += texSearchCarPart_TextChanged;
            // 
            // imgCarPart
            // 
            imgCarPart.Location = new Point(811, 58);
            imgCarPart.Name = "imgCarPart";
            imgCarPart.Size = new Size(114, 105);
            imgCarPart.TabIndex = 18;
            imgCarPart.TabStop = false;
            imgCarPart.Visible = false;
            // 
            // resultContainer
            // 
            resultContainer.Location = new Point(10, 80);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(776, 214);
            resultContainer.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(496, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearchCarPart);
            panel1.Location = new Point(11, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 54);
            panel1.TabIndex = 15;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(558, 10);
            loader.Name = "loader";
            loader.Size = new Size(66, 54);
            loader.SizeMode = PictureBoxSizeMode.CenterImage;
            loader.TabIndex = 27;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.CornflowerBlue;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Image = (Image)resources.GetObject("btnSubmit.Image");
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(821, 386);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(20, 0, 0, 0);
            btnSubmit.Size = new Size(323, 76);
            btnSubmit.TabIndex = 26;
            btnSubmit.Text = "ADD TO CART";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Visible = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // timerCarPart
            // 
            timerCarPart.Enabled = true;
            timerCarPart.Tick += timerCarPart_Tick;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.Highlight;
            lblPrice.Location = new Point(859, 266);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 28);
            lblPrice.TabIndex = 25;
            lblPrice.Text = "price";
            lblPrice.Visible = false;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblModel.ForeColor = SystemColors.WindowFrame;
            lblModel.Location = new Point(1011, 94);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(65, 25);
            lblModel.TabIndex = 31;
            lblModel.Text = "model";
            lblModel.Visible = false;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBrand.ForeColor = SystemColors.WindowFrame;
            lblBrand.Location = new Point(1011, 58);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(61, 25);
            lblBrand.TabIndex = 30;
            lblBrand.Text = "brand";
            lblBrand.Visible = false;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQty.ForeColor = SystemColors.WindowFrame;
            lblQty.Location = new Point(968, 218);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(39, 25);
            lblQty.TabIndex = 29;
            lblQty.Text = "qty";
            lblQty.Visible = false;
            // 
            // lblCarPartName
            // 
            lblCarPartName.AutoSize = true;
            lblCarPartName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCarPartName.ForeColor = SystemColors.WindowFrame;
            lblCarPartName.Location = new Point(946, 178);
            lblCarPartName.Name = "lblCarPartName";
            lblCarPartName.Size = new Size(100, 25);
            lblCarPartName.TabIndex = 28;
            lblCarPartName.Text = "Part Name";
            lblCarPartName.Visible = false;
            // 
            // lblPriceTag
            // 
            lblPriceTag.AutoSize = true;
            lblPriceTag.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceTag.ForeColor = SystemColors.WindowFrame;
            lblPriceTag.Location = new Point(821, 266);
            lblPriceTag.Name = "lblPriceTag";
            lblPriceTag.Size = new Size(44, 28);
            lblPriceTag.TabIndex = 32;
            lblPriceTag.Text = "Rs :";
            lblPriceTag.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkCyan;
            lblStatus.Location = new Point(1044, 266);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 28);
            lblStatus.TabIndex = 33;
            lblStatus.Text = "status";
            lblStatus.Visible = false;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCategory.ForeColor = SystemColors.WindowFrame;
            lblCategory.Location = new Point(1032, 138);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(88, 25);
            lblCategory.TabIndex = 34;
            lblCategory.Text = "Category";
            lblCategory.Visible = false;
            // 
            // numInputQty
            // 
            numInputQty.Location = new Point(821, 313);
            numInputQty.Name = "numInputQty";
            numInputQty.Size = new Size(302, 31);
            numInputQty.TabIndex = 36;
            numInputQty.Visible = false;
            numInputQty.ValueChanged += numInputQty_ValueChanged;
            // 
            // lblQtyTag
            // 
            lblQtyTag.AutoSize = true;
            lblQtyTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblQtyTag.ForeColor = SystemColors.WindowFrame;
            lblQtyTag.Location = new Point(816, 218);
            lblQtyTag.Name = "lblQtyTag";
            lblQtyTag.Size = new Size(139, 25);
            lblQtyTag.TabIndex = 37;
            lblQtyTag.Text = "Available QTY : ";
            lblQtyTag.Visible = false;
            lblQtyTag.Click += label1_Click;
            // 
            // lblBranTag
            // 
            lblBranTag.AutoSize = true;
            lblBranTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBranTag.ForeColor = SystemColors.WindowFrame;
            lblBranTag.Location = new Point(931, 58);
            lblBranTag.Name = "lblBranTag";
            lblBranTag.Size = new Size(70, 25);
            lblBranTag.TabIndex = 38;
            lblBranTag.Text = "brand :";
            lblBranTag.Visible = false;
            // 
            // lblModelTag
            // 
            lblModelTag.AutoSize = true;
            lblModelTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblModelTag.ForeColor = SystemColors.WindowFrame;
            lblModelTag.Location = new Point(935, 94);
            lblModelTag.Name = "lblModelTag";
            lblModelTag.Size = new Size(75, 25);
            lblModelTag.TabIndex = 39;
            lblModelTag.Text = "Model :";
            lblModelTag.Visible = false;
            lblModelTag.Click += label1_Click_1;
            // 
            // lblCategoryTag
            // 
            lblCategoryTag.AutoSize = true;
            lblCategoryTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCategoryTag.ForeColor = SystemColors.WindowFrame;
            lblCategoryTag.Location = new Point(935, 138);
            lblCategoryTag.Name = "lblCategoryTag";
            lblCategoryTag.Size = new Size(97, 25);
            lblCategoryTag.TabIndex = 40;
            lblCategoryTag.Text = "Category :";
            lblCategoryTag.Visible = false;
            // 
            // lblParNameTag
            // 
            lblParNameTag.AutoSize = true;
            lblParNameTag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblParNameTag.ForeColor = SystemColors.WindowFrame;
            lblParNameTag.Location = new Point(818, 178);
            lblParNameTag.Name = "lblParNameTag";
            lblParNameTag.Size = new Size(109, 25);
            lblParNameTag.TabIndex = 41;
            lblParNameTag.Text = "Part Name :";
            lblParNameTag.Visible = false;
            // 
            // lblTotalTag
            // 
            lblTotalTag.AutoSize = true;
            lblTotalTag.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTag.ForeColor = SystemColors.WindowFrame;
            lblTotalTag.Location = new Point(821, 351);
            lblTotalTag.Name = "lblTotalTag";
            lblTotalTag.Size = new Size(93, 28);
            lblTotalTag.TabIndex = 43;
            lblTotalTag.Text = "Total Rs :";
            lblTotalTag.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(859, 351);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 42;
            label2.Text = "price";
            label2.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.Highlight;
            lblTotal.Location = new Point(921, 351);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 28);
            lblTotal.TabIndex = 44;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            lblTotal.Visible = false;
            // 
            // btnViewCart
            // 
            btnViewCart.BackColor = Color.DarkCyan;
            btnViewCart.Image = (Image)resources.GetObject("btnViewCart.Image");
            btnViewCart.Location = new Point(651, 9);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(85, 54);
            btnViewCart.TabIndex = 45;
            btnViewCart.UseVisualStyleBackColor = false;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // lblCartOrderCount
            // 
            lblCartOrderCount.AutoSize = true;
            lblCartOrderCount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartOrderCount.ForeColor = Color.DarkCyan;
            lblCartOrderCount.Location = new Point(737, 6);
            lblCartOrderCount.Name = "lblCartOrderCount";
            lblCartOrderCount.Size = new Size(22, 25);
            lblCartOrderCount.TabIndex = 46;
            lblCartOrderCount.Text = "0";
            lblCartOrderCount.Visible = false;
            // 
            // SearchCarPartsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1217, 607);
            ControlBox = false;
            Controls.Add(lblCartOrderCount);
            Controls.Add(btnViewCart);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalTag);
            Controls.Add(label2);
            Controls.Add(lblParNameTag);
            Controls.Add(lblCategoryTag);
            Controls.Add(lblModelTag);
            Controls.Add(lblBranTag);
            Controls.Add(lblQtyTag);
            Controls.Add(numInputQty);
            Controls.Add(lblCategory);
            Controls.Add(lblStatus);
            Controls.Add(lblPriceTag);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(lblQty);
            Controls.Add(lblCarPartName);
            Controls.Add(lblPrice);
            Controls.Add(imgCarPart);
            Controls.Add(resultContainer);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(loader);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchCarPartsForm";
            Text = "SearchCarPartsForm";
            Load += SearchCarPartsForm_Load;
            ((System.ComponentModel.ISupportInitialize)imgCarPart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInputQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texSearchCarPart;
        private PictureBox imgCarPart;
        private FlowLayoutPanel resultContainer;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox loader;
        private Button btnSubmit;
        private System.Windows.Forms.Timer timerCarPart;
        private Label lblPrice;
        private Label lblModel;
        private Label lblBrand;
        private Label lblQty;
        private Label lblCarPartName;
        private Label lblPriceTag;
        private Label lblStatus;
        private Label lblCategory;
        private NumericUpDown numInputQty;
        private Label lblQtyTag;
        private Label lblBranTag;
        private Label lblModelTag;
        private Label lblCategoryTag;
        private Label lblParNameTag;
        private Label lblTotalTag;
        private Label label2;
        private Label lblTotal;
        private Button btnViewCart;
        private Label lblCartOrderCount;
    }
}