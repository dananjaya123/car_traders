namespace car_traders.View.View_Admin.View_Customer
{
    partial class ViewCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomerForm));
            label1 = new Label();
            btnPdfPrint = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            texSearch = new TextBox();
            loader = new PictureBox();
            listViewCustomer = new MaterialSkin.Controls.MaterialListView();
            colUserCode = new ColumnHeader();
            colName = new ColumnHeader();
            colMobile = new ColumnHeader();
            colEmail = new ColumnHeader();
            colAddress = new ColumnHeader();
            colUserName = new ColumnHeader();
            colRole = new ColumnHeader();
            btnAddCustomer = new MaterialSkin.Controls.MaterialButton();
            btnReload = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 140;
            label1.Text = "CUSTOMERS";
            // 
            // btnPdfPrint
            // 
            btnPdfPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPdfPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPdfPrint.Depth = 0;
            btnPdfPrint.HighEmphasis = true;
            btnPdfPrint.Icon = (Image)resources.GetObject("btnPdfPrint.Icon");
            btnPdfPrint.Image = (Image)resources.GetObject("btnPdfPrint.Image");
            btnPdfPrint.Location = new Point(869, 130);
            btnPdfPrint.Margin = new Padding(4, 6, 4, 6);
            btnPdfPrint.MouseState = MaterialSkin.MouseState.HOVER;
            btnPdfPrint.Name = "btnPdfPrint";
            btnPdfPrint.NoAccentTextColor = Color.Empty;
            btnPdfPrint.Size = new Size(64, 36);
            btnPdfPrint.TabIndex = 139;
            btnPdfPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPdfPrint.UseAccentColor = false;
            btnPdfPrint.UseVisualStyleBackColor = true;
            btnPdfPrint.Click += btnPdfPrint_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(661, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 137;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearch);
            panel1.Location = new Point(12, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 54);
            panel1.TabIndex = 136;
            // 
            // texSearch
            // 
            texSearch.Location = new Point(4, 11);
            texSearch.Name = "texSearch";
            texSearch.Size = new Size(637, 31);
            texSearch.TabIndex = 1;
            texSearch.Tag = "";
            texSearch.TextChanged += texSearch_TextChanged;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(195, 15);
            loader.Name = "loader";
            loader.Size = new Size(75, 54);
            loader.SizeMode = PictureBoxSizeMode.CenterImage;
            loader.TabIndex = 138;
            loader.TabStop = false;
            loader.Visible = false;
            // 
            // listViewCustomer
            // 
            listViewCustomer.AutoSizeTable = false;
            listViewCustomer.BackColor = Color.FromArgb(255, 255, 255);
            listViewCustomer.BorderStyle = BorderStyle.None;
            listViewCustomer.Columns.AddRange(new ColumnHeader[] { colUserCode, colName, colMobile, colEmail, colAddress, colUserName, colRole });
            listViewCustomer.Depth = 0;
            listViewCustomer.FullRowSelect = true;
            listViewCustomer.Location = new Point(7, 175);
            listViewCustomer.MinimumSize = new Size(200, 100);
            listViewCustomer.MouseLocation = new Point(-1, -1);
            listViewCustomer.MouseState = MaterialSkin.MouseState.OUT;
            listViewCustomer.Name = "listViewCustomer";
            listViewCustomer.OwnerDraw = true;
            listViewCustomer.Size = new Size(959, 463);
            listViewCustomer.TabIndex = 135;
            listViewCustomer.UseCompatibleStateImageBehavior = false;
            listViewCustomer.View = System.Windows.Forms.View.Details;
            listViewCustomer.SelectedIndexChanged += listViewCustomer_SelectedIndexChanged;
            // 
            // colUserCode
            // 
            colUserCode.Text = "User Code";
            colUserCode.Width = 100;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 100;
            // 
            // colMobile
            // 
            colMobile.Text = "Contact Number";
            colMobile.Width = 120;
            // 
            // colEmail
            // 
            colEmail.Text = "Email";
            colEmail.Width = 150;
            // 
            // colAddress
            // 
            colAddress.Text = "Adress";
            colAddress.Width = 150;
            // 
            // colUserName
            // 
            colUserName.Text = "User Name";
            colUserName.Width = 150;
            // 
            // colRole
            // 
            colRole.Text = "Role";
            colRole.Width = 120;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddCustomer.Depth = 0;
            btnAddCustomer.HighEmphasis = true;
            btnAddCustomer.Icon = (Image)resources.GetObject("btnAddCustomer.Icon");
            btnAddCustomer.Image = (Image)resources.GetObject("btnAddCustomer.Image");
            btnAddCustomer.Location = new Point(797, 130);
            btnAddCustomer.Margin = new Padding(4, 6, 4, 6);
            btnAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.NoAccentTextColor = Color.Empty;
            btnAddCustomer.Size = new Size(64, 36);
            btnAddCustomer.TabIndex = 141;
            btnAddCustomer.Text = "  ";
            btnAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddCustomer.UseAccentColor = false;
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnReload
            // 
            btnReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReload.Depth = 0;
            btnReload.HighEmphasis = true;
            btnReload.Icon = (Image)resources.GetObject("btnReload.Icon");
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.Location = new Point(725, 130);
            btnReload.Margin = new Padding(4, 6, 4, 6);
            btnReload.MouseState = MaterialSkin.MouseState.HOVER;
            btnReload.Name = "btnReload";
            btnReload.NoAccentTextColor = Color.Empty;
            btnReload.Size = new Size(64, 36);
            btnReload.TabIndex = 142;
            btnReload.Text = "  ";
            btnReload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReload.UseAccentColor = false;
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // ViewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 677);
            Controls.Add(btnReload);
            Controls.Add(btnAddCustomer);
            Controls.Add(label1);
            Controls.Add(btnPdfPrint);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(loader);
            Controls.Add(listViewCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewCustomerForm";
            Text = "ViewCustomerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnPdfPrint;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox loader;
        private MaterialSkin.Controls.MaterialListView listViewCustomer;
        private ColumnHeader colUserCode;
        private ColumnHeader colName;
        private ColumnHeader colMobile;
        private ColumnHeader colEmail;
        private ColumnHeader colAddress;
        private ColumnHeader colUserName;
        private ColumnHeader colRole;
        private MaterialSkin.Controls.MaterialButton btnAddCustomer;
        private TextBox texSearch;
        private MaterialSkin.Controls.MaterialButton btnReload;
    }
}