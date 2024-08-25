namespace car_traders.View.View_Customer.View_Order
{
    partial class ViewOrderDetailModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderDetailModalForm));
            listViewOrderDetail = new MaterialSkin.Controls.MaterialListView();
            colItemName = new ColumnHeader();
            colQty = new ColumnHeader();
            colOrderCode = new ColumnHeader();
            colItemType = new ColumnHeader();
            colPrice = new ColumnHeader();
            colId = new ColumnHeader();
            colDetailID = new ColumnHeader();
            imgItem = new PictureBox();
            numberQty = new NumericUpDown();
            btnCancel = new Button();
            lblExist = new Label();
            lblOrderDetailID = new Label();
            lblType = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)imgItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberQty).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewOrderDetail
            // 
            listViewOrderDetail.AutoSizeTable = false;
            listViewOrderDetail.BackColor = Color.FromArgb(255, 255, 255);
            listViewOrderDetail.BorderStyle = BorderStyle.None;
            listViewOrderDetail.Columns.AddRange(new ColumnHeader[] { colItemName, colQty, colOrderCode, colItemType, colPrice, colId, colDetailID });
            listViewOrderDetail.Depth = 0;
            listViewOrderDetail.FullRowSelect = true;
            listViewOrderDetail.Location = new Point(6, 106);
            listViewOrderDetail.MinimumSize = new Size(200, 100);
            listViewOrderDetail.MouseLocation = new Point(-1, -1);
            listViewOrderDetail.MouseState = MaterialSkin.MouseState.OUT;
            listViewOrderDetail.Name = "listViewOrderDetail";
            listViewOrderDetail.OwnerDraw = true;
            listViewOrderDetail.Size = new Size(735, 325);
            listViewOrderDetail.TabIndex = 0;
            listViewOrderDetail.UseCompatibleStateImageBehavior = false;
            listViewOrderDetail.View = System.Windows.Forms.View.Details;
            listViewOrderDetail.SelectedIndexChanged += listViewOrderDetail_SelectedIndexChanged;
            // 
            // colItemName
            // 
            colItemName.Text = "Name";
            colItemName.Width = 180;
            // 
            // colQty
            // 
            colQty.Text = "Qty";
            colQty.Width = 100;
            // 
            // colOrderCode
            // 
            colOrderCode.Text = "Order Code";
            colOrderCode.Width = 150;
            // 
            // colItemType
            // 
            colItemType.Text = "Item Type";
            colItemType.Width = 100;
            // 
            // colPrice
            // 
            colPrice.Text = "Price";
            colPrice.Width = 200;
            // 
            // colId
            // 
            colId.Text = "Id";
            colId.Width = 0;
            // 
            // colDetailID
            // 
            colDetailID.Text = "id";
            colDetailID.TextAlign = HorizontalAlignment.Center;
            colDetailID.Width = 0;
            // 
            // imgItem
            // 
            imgItem.Image = (Image)resources.GetObject("imgItem.Image");
            imgItem.Location = new Point(17, 11);
            imgItem.Name = "imgItem";
            imgItem.Size = new Size(206, 167);
            imgItem.SizeMode = PictureBoxSizeMode.CenterImage;
            imgItem.TabIndex = 16;
            imgItem.TabStop = false;
            imgItem.Visible = false;
            // 
            // numberQty
            // 
            numberQty.Location = new Point(17, 189);
            numberQty.Name = "numberQty";
            numberQty.Size = new Size(206, 31);
            numberQty.TabIndex = 18;
            numberQty.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(17, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(20, 0, 0, 0);
            btnCancel.Size = new Size(206, 76);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseLeave += btnCancel_MouseLeave;
            btnCancel.MouseHover += btnCancel_MouseHover;
            // 
            // lblExist
            // 
            lblExist.AutoSize = true;
            lblExist.Location = new Point(792, 87);
            lblExist.Name = "lblExist";
            lblExist.Size = new Size(22, 25);
            lblExist.TabIndex = 28;
            lblExist.Text = "0";
            lblExist.Visible = false;
            // 
            // lblOrderDetailID
            // 
            lblOrderDetailID.AutoSize = true;
            lblOrderDetailID.Location = new Point(839, 87);
            lblOrderDetailID.Name = "lblOrderDetailID";
            lblOrderDetailID.Size = new Size(27, 25);
            lblOrderDetailID.TabIndex = 29;
            lblOrderDetailID.Text = "id";
            lblOrderDetailID.Visible = false;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(891, 87);
            lblType.Name = "lblType";
            lblType.Size = new Size(47, 25);
            lblType.TabIndex = 30;
            lblType.Text = "type";
            lblType.Visible = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(imgItem);
            materialCard1.Controls.Add(numberQty);
            materialCard1.Controls.Add(btnCancel);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(749, 115);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(246, 316);
            materialCard1.TabIndex = 31;
            // 
            // ViewOrderDetailModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 451);
            Controls.Add(materialCard1);
            Controls.Add(lblType);
            Controls.Add(listViewOrderDetail);
            Controls.Add(lblExist);
            Controls.Add(lblOrderDetailID);
            Name = "ViewOrderDetailModalForm";
            Text = "Order Details";
            Load += ViewOrderDetailModalForm_Load;
            ((System.ComponentModel.ISupportInitialize)imgItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberQty).EndInit();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewOrderDetail;
        private PictureBox imgItem;
        private NumericUpDown numberQty;
        private Button btnCancel;
        private ColumnHeader colItemName;
        private ColumnHeader colQty;
        private ColumnHeader colOrderCode;
        private ColumnHeader colItemType;
        private ColumnHeader colPrice;
        private ColumnHeader colId;
        private Label lblExist;
        private ColumnHeader colDetailID;
        private Label lblOrderDetailID;
        private Label lblType;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}