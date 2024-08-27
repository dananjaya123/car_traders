namespace car_traders.View.View_Admin.View_Report
{
    partial class ViewReportMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReportMainForm));
            panel1 = new Panel();
            btnPaidOrderReport = new MaterialSkin.Controls.MaterialButton();
            btnRejectOrderReport = new MaterialSkin.Controls.MaterialButton();
            btnCancelOrderReport = new MaterialSkin.Controls.MaterialButton();
            btnOrderRequestReport = new MaterialSkin.Controls.MaterialButton();
            pnlMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnPaidOrderReport);
            panel1.Controls.Add(btnRejectOrderReport);
            panel1.Controls.Add(btnCancelOrderReport);
            panel1.Controls.Add(btnOrderRequestReport);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1414, 62);
            panel1.TabIndex = 1;
            // 
            // btnPaidOrderReport
            // 
            btnPaidOrderReport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaidOrderReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPaidOrderReport.Depth = 0;
            btnPaidOrderReport.HighEmphasis = true;
            btnPaidOrderReport.Icon = (Image)resources.GetObject("btnPaidOrderReport.Icon");
            btnPaidOrderReport.Location = new Point(525, 15);
            btnPaidOrderReport.Margin = new Padding(4, 6, 4, 6);
            btnPaidOrderReport.MouseState = MaterialSkin.MouseState.HOVER;
            btnPaidOrderReport.Name = "btnPaidOrderReport";
            btnPaidOrderReport.NoAccentTextColor = Color.Empty;
            btnPaidOrderReport.Size = new Size(141, 36);
            btnPaidOrderReport.TabIndex = 4;
            btnPaidOrderReport.Text = "Paid orders";
            btnPaidOrderReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPaidOrderReport.UseAccentColor = false;
            btnPaidOrderReport.UseVisualStyleBackColor = true;
            btnPaidOrderReport.Click += btnPaidOrderReport_Click;
            // 
            // btnRejectOrderReport
            // 
            btnRejectOrderReport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRejectOrderReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRejectOrderReport.Depth = 0;
            btnRejectOrderReport.HighEmphasis = true;
            btnRejectOrderReport.Icon = (Image)resources.GetObject("btnRejectOrderReport.Icon");
            btnRejectOrderReport.Location = new Point(365, 15);
            btnRejectOrderReport.Margin = new Padding(4, 6, 4, 6);
            btnRejectOrderReport.MouseState = MaterialSkin.MouseState.HOVER;
            btnRejectOrderReport.Name = "btnRejectOrderReport";
            btnRejectOrderReport.NoAccentTextColor = Color.Empty;
            btnRejectOrderReport.Size = new Size(152, 36);
            btnRejectOrderReport.TabIndex = 3;
            btnRejectOrderReport.Text = "Reject order";
            btnRejectOrderReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRejectOrderReport.UseAccentColor = false;
            btnRejectOrderReport.UseVisualStyleBackColor = true;
            btnRejectOrderReport.Click += btnRejectOrderReport_Click;
            // 
            // btnCancelOrderReport
            // 
            btnCancelOrderReport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelOrderReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelOrderReport.Depth = 0;
            btnCancelOrderReport.HighEmphasis = true;
            btnCancelOrderReport.Icon = (Image)resources.GetObject("btnCancelOrderReport.Icon");
            btnCancelOrderReport.Location = new Point(193, 15);
            btnCancelOrderReport.Margin = new Padding(4, 6, 4, 6);
            btnCancelOrderReport.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelOrderReport.Name = "btnCancelOrderReport";
            btnCancelOrderReport.NoAccentTextColor = Color.Empty;
            btnCancelOrderReport.Size = new Size(164, 36);
            btnCancelOrderReport.TabIndex = 2;
            btnCancelOrderReport.Text = "Cancel Orders";
            btnCancelOrderReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelOrderReport.UseAccentColor = false;
            btnCancelOrderReport.UseVisualStyleBackColor = true;
            btnCancelOrderReport.Click += btnCancelOrderReport_Click;
            // 
            // btnOrderRequestReport
            // 
            btnOrderRequestReport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOrderRequestReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOrderRequestReport.Depth = 0;
            btnOrderRequestReport.HighEmphasis = true;
            btnOrderRequestReport.Icon = (Image)resources.GetObject("btnOrderRequestReport.Icon");
            btnOrderRequestReport.Location = new Point(13, 15);
            btnOrderRequestReport.Margin = new Padding(4, 6, 4, 6);
            btnOrderRequestReport.MouseState = MaterialSkin.MouseState.HOVER;
            btnOrderRequestReport.Name = "btnOrderRequestReport";
            btnOrderRequestReport.NoAccentTextColor = Color.Empty;
            btnOrderRequestReport.Size = new Size(172, 36);
            btnOrderRequestReport.TabIndex = 1;
            btnOrderRequestReport.Text = "Request Orders";
            btnOrderRequestReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOrderRequestReport.UseAccentColor = false;
            btnOrderRequestReport.UseVisualStyleBackColor = true;
            btnOrderRequestReport.Click += btnOrderRequestReport_Click;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 62);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1414, 577);
            pnlMain.TabIndex = 2;
            // 
            // ViewReportMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 639);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewReportMainForm";
            Text = "ViewReportMainForm";
            Load += ViewReportMainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnPaidOrderReport;
        private MaterialSkin.Controls.MaterialButton btnRejectOrderReport;
        private MaterialSkin.Controls.MaterialButton btnCancelOrderReport;
        private MaterialSkin.Controls.MaterialButton btnOrderRequestReport;
        private Panel pnlMain;
    }
}