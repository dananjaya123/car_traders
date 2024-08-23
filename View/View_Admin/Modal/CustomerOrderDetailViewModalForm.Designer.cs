namespace car_traders.View.View_Admin.Modal
{
    partial class CustomerOrderDetailViewModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderDetailViewModalForm));
            listViewOrderDetail = new MaterialSkin.Controls.MaterialListView();
            colItemName = new ColumnHeader();
            colQty = new ColumnHeader();
            colOrderCode = new ColumnHeader();
            colItemType = new ColumnHeader();
            colPrice = new ColumnHeader();
            colId = new ColumnHeader();
            colDetailID = new ColumnHeader();
            imgItem = new PictureBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)imgItem).BeginInit();
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
            listViewOrderDetail.Location = new Point(9, 100);
            listViewOrderDetail.MinimumSize = new Size(200, 100);
            listViewOrderDetail.MouseLocation = new Point(-1, -1);
            listViewOrderDetail.MouseState = MaterialSkin.MouseState.OUT;
            listViewOrderDetail.Name = "listViewOrderDetail";
            listViewOrderDetail.OwnerDraw = true;
            listViewOrderDetail.Size = new Size(751, 280);
            listViewOrderDetail.TabIndex = 31;
            listViewOrderDetail.UseCompatibleStateImageBehavior = false;
            listViewOrderDetail.View = System.Windows.Forms.View.Details;
            listViewOrderDetail.SelectedIndexChanged += listViewOrderDetail_SelectedIndexChanged;
            // 
            // colItemName
            // 
            colItemName.Text = "Name";
            colItemName.Width = 200;
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
            imgItem.Location = new Point(17, 17);
            imgItem.Name = "imgItem";
            imgItem.Size = new Size(304, 246);
            imgItem.SizeMode = PictureBoxSizeMode.CenterImage;
            imgItem.TabIndex = 32;
            imgItem.TabStop = false;
            imgItem.Visible = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(imgItem);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(774, 100);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(338, 280);
            materialCard1.TabIndex = 33;
            // 
            // CustomerOrderDetailViewModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 397);
            Controls.Add(materialCard1);
            Controls.Add(listViewOrderDetail);
            Name = "CustomerOrderDetailViewModalForm";
            Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)imgItem).EndInit();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewOrderDetail;
        private ColumnHeader colItemName;
        private ColumnHeader colQty;
        private ColumnHeader colOrderCode;
        private ColumnHeader colItemType;
        private ColumnHeader colPrice;
        private ColumnHeader colId;
        private ColumnHeader colDetailID;
        private PictureBox imgItem;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}