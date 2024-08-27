namespace car_traders.View.View_Customer.View_CarPart
{
    partial class CarPartsCartViewModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPartsCartViewModalForm));
            listViewCart = new MaterialSkin.Controls.MaterialListView();
            colName = new ColumnHeader();
            colQty = new ColumnHeader();
            colPrice = new ColumnHeader();
            lblPartsName = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            loader = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loader).BeginInit();
            SuspendLayout();
            // 
            // listViewCart
            // 
            listViewCart.AutoSizeTable = false;
            listViewCart.BackColor = Color.FromArgb(255, 255, 255);
            listViewCart.BorderStyle = BorderStyle.None;
            listViewCart.Columns.AddRange(new ColumnHeader[] { colName, colQty, colPrice });
            listViewCart.Depth = 0;
            listViewCart.FullRowSelect = true;
            listViewCart.Location = new Point(15, 146);
            listViewCart.MinimumSize = new Size(200, 100);
            listViewCart.MouseLocation = new Point(-1, -1);
            listViewCart.MouseState = MaterialSkin.MouseState.OUT;
            listViewCart.Name = "listViewCart";
            listViewCart.OwnerDraw = true;
            listViewCart.Size = new Size(537, 350);
            listViewCart.TabIndex = 0;
            listViewCart.UseCompatibleStateImageBehavior = false;
            listViewCart.View = System.Windows.Forms.View.Details;
            listViewCart.SelectedIndexChanged += listViewCart_SelectedIndexChanged;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 200;
            // 
            // colQty
            // 
            colQty.Text = "Qty";
            colQty.Width = 100;
            // 
            // colPrice
            // 
            colPrice.Text = "Price";
            colPrice.Width = 200;
            // 
            // lblPartsName
            // 
            lblPartsName.AutoSize = true;
            lblPartsName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPartsName.Location = new Point(19, 115);
            lblPartsName.Name = "lblPartsName";
            lblPartsName.Size = new Size(61, 25);
            lblPartsName.TabIndex = 1;
            lblPartsName.Text = "Name";
            lblPartsName.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.CornflowerBlue;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Image = (Image)resources.GetObject("btnSubmit.Image");
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(295, 502);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(20, 0, 0, 0);
            btnSubmit.Size = new Size(257, 76);
            btnSubmit.TabIndex = 27;
            btnSubmit.Text = "ORDER REQUEST";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            btnSubmit.MouseLeave += btnSubmit_MouseLeave;
            btnSubmit.MouseHover += btnSubmit_MouseHover;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(15, 502);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(10, 0, 0, 0);
            btnCancel.Size = new Size(175, 76);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
            btnCancel.MouseHover += btnCancel_MouseHover;
            // 
            // loader
            // 
            loader.Image = (Image)resources.GetObject("loader.Image");
            loader.Location = new Point(147, 209);
            loader.Name = "loader";
            loader.Size = new Size(210, 210);
            loader.SizeMode = PictureBoxSizeMode.Zoom;
            loader.TabIndex = 29;
            loader.TabStop = false;
            loader.Visible = false;
            loader.Click += loader_Click;
            // 
            // CarPartsCartViewModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 604);
            Controls.Add(loader);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(lblPartsName);
            Controls.Add(listViewCart);
            Name = "CarPartsCartViewModalForm";
            Text = "View Cart";
            ((System.ComponentModel.ISupportInitialize)loader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewCart;
        private Label lblPartsName;
        private Button btnSubmit;
        private Button btnCancel;
        private ColumnHeader colName;
        private ColumnHeader colQty;
        private ColumnHeader colPrice;
        private PictureBox loader;
    }
}