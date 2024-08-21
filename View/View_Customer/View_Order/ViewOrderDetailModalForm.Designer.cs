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
            imgItem = new PictureBox();
            lblStatus = new Label();
            numberQty = new NumericUpDown();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)imgItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberQty).BeginInit();
            SuspendLayout();
            // 
            // listViewOrderDetail
            // 
            listViewOrderDetail.AutoSizeTable = false;
            listViewOrderDetail.BackColor = Color.FromArgb(255, 255, 255);
            listViewOrderDetail.BorderStyle = BorderStyle.None;
            listViewOrderDetail.Columns.AddRange(new ColumnHeader[] { colItemName, colQty, colOrderCode, colItemType, colPrice, colId });
            listViewOrderDetail.Depth = 0;
            listViewOrderDetail.FullRowSelect = true;
            listViewOrderDetail.Location = new Point(6, 106);
            listViewOrderDetail.MinimumSize = new Size(200, 100);
            listViewOrderDetail.MouseLocation = new Point(-1, -1);
            listViewOrderDetail.MouseState = MaterialSkin.MouseState.OUT;
            listViewOrderDetail.Name = "listViewOrderDetail";
            listViewOrderDetail.OwnerDraw = true;
            listViewOrderDetail.Size = new Size(711, 396);
            listViewOrderDetail.TabIndex = 0;
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
            // imgItem
            // 
            imgItem.Image = (Image)resources.GetObject("imgItem.Image");
            imgItem.Location = new Point(723, 106);
            imgItem.Name = "imgItem";
            imgItem.Size = new Size(206, 167);
            imgItem.SizeMode = PictureBoxSizeMode.CenterImage;
            imgItem.TabIndex = 16;
            imgItem.TabStop = false;
            imgItem.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Location = new Point(739, 276);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 25);
            lblStatus.TabIndex = 17;
            lblStatus.Text = "status";
            lblStatus.Visible = false;
            // 
            // numberQty
            // 
            numberQty.Location = new Point(739, 311);
            numberQty.Name = "numberQty";
            numberQty.Size = new Size(190, 31);
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
            btnCancel.Location = new Point(739, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(20, 0, 0, 0);
            btnCancel.Size = new Size(190, 76);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            // 
            // ViewOrderDetailModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 517);
            Controls.Add(btnCancel);
            Controls.Add(numberQty);
            Controls.Add(lblStatus);
            Controls.Add(imgItem);
            Controls.Add(listViewOrderDetail);
            Name = "ViewOrderDetailModalForm";
            Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)imgItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewOrderDetail;
        private PictureBox imgItem;
        private Label lblStatus;
        private NumericUpDown numberQty;
        private Button btnCancel;
        private ColumnHeader colItemName;
        private ColumnHeader colQty;
        private ColumnHeader colOrderCode;
        private ColumnHeader colItemType;
        private ColumnHeader colPrice;
        private ColumnHeader colId;
    }
}