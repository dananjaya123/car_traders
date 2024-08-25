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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)imgCarPart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInputQty).BeginInit();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
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
            imgCarPart.Location = new Point(34, 37);
            imgCarPart.Name = "imgCarPart";
            imgCarPart.Size = new Size(114, 105);
            imgCarPart.TabIndex = 18;
            imgCarPart.TabStop = false;
            imgCarPart.Visible = false;
            // 
            // resultContainer
            // 
            resultContainer.Location = new Point(10, 121);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(776, 214);
            resultContainer.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(502, 13);
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
            panel1.Location = new Point(17, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 54);
            panel1.TabIndex = 15;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(564, 13);
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
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Image = (Image)resources.GetObject("btnSubmit.Image");
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(44, 365);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(20, 0, 0, 0);
            btnSubmit.Size = new Size(323, 76);
            btnSubmit.TabIndex = 26;
            btnSubmit.Text = "ADD TO CART";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Visible = false;
            btnSubmit.Click += btnSubmit_Click;
            btnSubmit.MouseLeave += btnSubmit_MouseLeave;
            btnSubmit.MouseHover += btnSubmit_MouseHover;
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
            lblPrice.Location = new Point(82, 245);
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
            lblModel.Location = new Point(234, 73);
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
            lblBrand.Location = new Point(234, 37);
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
            lblQty.Location = new Point(191, 197);
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
            lblCarPartName.Location = new Point(169, 157);
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
            lblPriceTag.Location = new Point(44, 245);
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
            lblStatus.Location = new Point(267, 245);
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
            lblCategory.Location = new Point(255, 117);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(88, 25);
            lblCategory.TabIndex = 34;
            lblCategory.Text = "Category";
            lblCategory.Visible = false;
            // 
            // numInputQty
            // 
            numInputQty.Location = new Point(44, 292);
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
            lblQtyTag.Location = new Point(39, 197);
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
            lblBranTag.Location = new Point(154, 37);
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
            lblModelTag.Location = new Point(158, 73);
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
            lblCategoryTag.Location = new Point(158, 117);
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
            lblParNameTag.Location = new Point(41, 157);
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
            lblTotalTag.Location = new Point(44, 330);
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
            label2.Location = new Point(82, 330);
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
            lblTotal.Location = new Point(144, 330);
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
            btnViewCart.Cursor = Cursors.Hand;
            btnViewCart.Image = (Image)resources.GetObject("btnViewCart.Image");
            btnViewCart.Location = new Point(17, 10);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(85, 54);
            btnViewCart.TabIndex = 45;
            btnViewCart.UseVisualStyleBackColor = false;
            btnViewCart.Click += btnViewCart_Click;
            btnViewCart.MouseLeave += btnViewCart_MouseLeave;
            btnViewCart.MouseHover += btnViewCart_MouseHover;
            // 
            // lblCartOrderCount
            // 
            lblCartOrderCount.AutoSize = true;
            lblCartOrderCount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartOrderCount.ForeColor = Color.DarkCyan;
            lblCartOrderCount.Location = new Point(103, 7);
            lblCartOrderCount.Name = "lblCartOrderCount";
            lblCartOrderCount.Size = new Size(22, 25);
            lblCartOrderCount.TabIndex = 46;
            lblCartOrderCount.Text = "0";
            lblCartOrderCount.Visible = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(imgCarPart);
            materialCard1.Controls.Add(btnSubmit);
            materialCard1.Controls.Add(lblPrice);
            materialCard1.Controls.Add(lblTotal);
            materialCard1.Controls.Add(lblCarPartName);
            materialCard1.Controls.Add(lblTotalTag);
            materialCard1.Controls.Add(lblQty);
            materialCard1.Controls.Add(label2);
            materialCard1.Controls.Add(lblBrand);
            materialCard1.Controls.Add(lblParNameTag);
            materialCard1.Controls.Add(lblModel);
            materialCard1.Controls.Add(lblCategoryTag);
            materialCard1.Controls.Add(lblPriceTag);
            materialCard1.Controls.Add(lblModelTag);
            materialCard1.Controls.Add(lblStatus);
            materialCard1.Controls.Add(lblBranTag);
            materialCard1.Controls.Add(lblCategory);
            materialCard1.Controls.Add(lblQtyTag);
            materialCard1.Controls.Add(numInputQty);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(800, 121);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(394, 463);
            materialCard1.TabIndex = 47;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(panel1);
            materialCard2.Controls.Add(loader);
            materialCard2.Controls.Add(pictureBox1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(10, 23);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(642, 80);
            materialCard2.TabIndex = 48;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(btnViewCart);
            materialCard3.Controls.Add(lblCartOrderCount);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(655, 23);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(137, 81);
            materialCard3.TabIndex = 49;
            // 
            // SearchCarPartsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1217, 607);
            ControlBox = false;
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Controls.Add(resultContainer);
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
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
    }
}