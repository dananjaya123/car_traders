namespace car_traders.View.View_Admin.View_Orders
{
    partial class ViewOrderMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderMainForm));
            panel1 = new Panel();
            btnPaidOrderView = new MaterialSkin.Controls.MaterialButton();
            btnRejectOrderView = new MaterialSkin.Controls.MaterialButton();
            btnCancelOrderView = new MaterialSkin.Controls.MaterialButton();
            btnOrderRequestView = new MaterialSkin.Controls.MaterialButton();
            pnlMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnPaidOrderView);
            panel1.Controls.Add(btnRejectOrderView);
            panel1.Controls.Add(btnCancelOrderView);
            panel1.Controls.Add(btnOrderRequestView);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1414, 62);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnPaidOrderView
            // 
            btnPaidOrderView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaidOrderView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPaidOrderView.Depth = 0;
            btnPaidOrderView.HighEmphasis = true;
            btnPaidOrderView.Icon = (Image)resources.GetObject("btnPaidOrderView.Icon");
            btnPaidOrderView.Location = new Point(525, 15);
            btnPaidOrderView.Margin = new Padding(4, 6, 4, 6);
            btnPaidOrderView.MouseState = MaterialSkin.MouseState.HOVER;
            btnPaidOrderView.Name = "btnPaidOrderView";
            btnPaidOrderView.NoAccentTextColor = Color.Empty;
            btnPaidOrderView.Size = new Size(141, 36);
            btnPaidOrderView.TabIndex = 4;
            btnPaidOrderView.Text = "Paid orders";
            btnPaidOrderView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPaidOrderView.UseAccentColor = false;
            btnPaidOrderView.UseVisualStyleBackColor = true;
            btnPaidOrderView.Click += btnPaidOrderView_Click;
            // 
            // btnRejectOrderView
            // 
            btnRejectOrderView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRejectOrderView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRejectOrderView.Depth = 0;
            btnRejectOrderView.HighEmphasis = true;
            btnRejectOrderView.Icon = (Image)resources.GetObject("btnRejectOrderView.Icon");
            btnRejectOrderView.Location = new Point(365, 15);
            btnRejectOrderView.Margin = new Padding(4, 6, 4, 6);
            btnRejectOrderView.MouseState = MaterialSkin.MouseState.HOVER;
            btnRejectOrderView.Name = "btnRejectOrderView";
            btnRejectOrderView.NoAccentTextColor = Color.Empty;
            btnRejectOrderView.Size = new Size(152, 36);
            btnRejectOrderView.TabIndex = 3;
            btnRejectOrderView.Text = "Reject order";
            btnRejectOrderView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRejectOrderView.UseAccentColor = false;
            btnRejectOrderView.UseVisualStyleBackColor = true;
            btnRejectOrderView.Click += btnRejectOrderView_Click;
            // 
            // btnCancelOrderView
            // 
            btnCancelOrderView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelOrderView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelOrderView.Depth = 0;
            btnCancelOrderView.HighEmphasis = true;
            btnCancelOrderView.Icon = (Image)resources.GetObject("btnCancelOrderView.Icon");
            btnCancelOrderView.Location = new Point(193, 15);
            btnCancelOrderView.Margin = new Padding(4, 6, 4, 6);
            btnCancelOrderView.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelOrderView.Name = "btnCancelOrderView";
            btnCancelOrderView.NoAccentTextColor = Color.Empty;
            btnCancelOrderView.Size = new Size(164, 36);
            btnCancelOrderView.TabIndex = 2;
            btnCancelOrderView.Text = "Cancel Orders";
            btnCancelOrderView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelOrderView.UseAccentColor = false;
            btnCancelOrderView.UseVisualStyleBackColor = true;
            btnCancelOrderView.Click += btnCancelOrderView_Click;
            // 
            // btnOrderRequestView
            // 
            btnOrderRequestView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOrderRequestView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOrderRequestView.Depth = 0;
            btnOrderRequestView.HighEmphasis = true;
            btnOrderRequestView.Icon = (Image)resources.GetObject("btnOrderRequestView.Icon");
            btnOrderRequestView.Location = new Point(13, 15);
            btnOrderRequestView.Margin = new Padding(4, 6, 4, 6);
            btnOrderRequestView.MouseState = MaterialSkin.MouseState.HOVER;
            btnOrderRequestView.Name = "btnOrderRequestView";
            btnOrderRequestView.NoAccentTextColor = Color.Empty;
            btnOrderRequestView.Size = new Size(172, 36);
            btnOrderRequestView.TabIndex = 1;
            btnOrderRequestView.Text = "Request Orders";
            btnOrderRequestView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOrderRequestView.UseAccentColor = false;
            btnOrderRequestView.UseVisualStyleBackColor = true;
            btnOrderRequestView.Click += btnOrderRequestView_Click;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 62);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1414, 639);
            pnlMain.TabIndex = 1;
            // 
            // ViewOrderMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 701);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrderMainForm";
            Text = "ViewOrderMainForm";
            Load += ViewOrderMainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnCancelOrderView;
        private MaterialSkin.Controls.MaterialButton btnOrderRequestView;
        private MaterialSkin.Controls.MaterialButton btnRejectOrderView;
        private Panel pnlMain;
        private MaterialSkin.Controls.MaterialButton btnPaidOrderView;
    }
}