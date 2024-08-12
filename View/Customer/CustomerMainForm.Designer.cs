namespace car_traders
{
    partial class CustomerMainForm
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
            pnlSlide = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCarSearch = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            pnlLeftSlide = new Panel();
            pnlMain = new Panel();
            pnlSlide.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSlide
            // 
            pnlSlide.Controls.Add(tableLayoutPanel1);
            pnlSlide.Dock = DockStyle.Left;
            pnlSlide.Location = new Point(3, 64);
            pnlSlide.Name = "pnlSlide";
            pnlSlide.Size = new Size(220, 607);
            pnlSlide.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnCarSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(materialButton2, 0, 1);
            tableLayoutPanel1.Controls.Add(materialButton3, 0, 2);
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(217, 153);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCarSearch
            // 
            btnCarSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCarSearch.Depth = 0;
            btnCarSearch.Dock = DockStyle.Fill;
            btnCarSearch.HighEmphasis = true;
            btnCarSearch.Icon = null;
            btnCarSearch.Location = new Point(4, 6);
            btnCarSearch.Margin = new Padding(4, 6, 4, 6);
            btnCarSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnCarSearch.Name = "btnCarSearch";
            btnCarSearch.NoAccentTextColor = Color.Empty;
            btnCarSearch.Size = new Size(209, 39);
            btnCarSearch.TabIndex = 0;
            btnCarSearch.Text = "Car";
            btnCarSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCarSearch.UseAccentColor = false;
            btnCarSearch.UseVisualStyleBackColor = true;
            btnCarSearch.Click += btnCarSearch_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Dock = DockStyle.Fill;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(4, 57);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(209, 39);
            materialButton2.TabIndex = 1;
            materialButton2.Text = "materialButton2";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.Dock = DockStyle.Fill;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(4, 108);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(209, 39);
            materialButton3.TabIndex = 2;
            materialButton3.Text = "materialButton3";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // pnlLeftSlide
            // 
            pnlLeftSlide.Dock = DockStyle.Right;
            pnlLeftSlide.Location = new Point(1068, 64);
            pnlLeftSlide.Name = "pnlLeftSlide";
            pnlLeftSlide.Size = new Size(332, 607);
            pnlLeftSlide.TabIndex = 2;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(223, 64);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(845, 607);
            pnlMain.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 674);
            Controls.Add(pnlMain);
            Controls.Add(pnlLeftSlide);
            Controls.Add(pnlSlide);
            Name = "Form2";
            Text = "CAR TRADERS";
            pnlSlide.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSlide;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnCarSearch;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private Panel pnlLeftSlide;
        private Panel pnlMain;
    }
}