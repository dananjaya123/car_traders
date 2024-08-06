namespace car_traders
{
    partial class PartUpdateModel
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
            panel1 = new Panel();
            lblErrorUpdatePartPrice = new Label();
            lblErrorPartQty = new Label();
            lblErrorUpadatePartName = new Label();
            btnUpdateCarParts = new MaterialSkin.Controls.MaterialButton();
            btnClearCarParts = new MaterialSkin.Controls.MaterialButton();
            texDescription = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texBrandName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarMode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texUpdatePartPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texUpdatePartQty = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            imgUpdateCarPart = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUpdateCarPart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblErrorUpdatePartPrice);
            panel1.Controls.Add(lblErrorPartQty);
            panel1.Controls.Add(lblErrorUpadatePartName);
            panel1.Controls.Add(btnUpdateCarParts);
            panel1.Controls.Add(btnClearCarParts);
            panel1.Controls.Add(texDescription);
            panel1.Controls.Add(texBrandName);
            panel1.Controls.Add(texCarMode);
            panel1.Controls.Add(texUpdatePartPrice);
            panel1.Controls.Add(texUpdatePartQty);
            panel1.Controls.Add(texPartName);
            panel1.Controls.Add(imgUpdateCarPart);
            panel1.Location = new Point(29, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 544);
            panel1.TabIndex = 0;
            // 
            // lblErrorUpdatePartPrice
            // 
            lblErrorUpdatePartPrice.AutoSize = true;
            lblErrorUpdatePartPrice.BackColor = Color.Transparent;
            lblErrorUpdatePartPrice.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorUpdatePartPrice.ForeColor = Color.Red;
            lblErrorUpdatePartPrice.Location = new Point(324, 234);
            lblErrorUpdatePartPrice.Name = "lblErrorUpdatePartPrice";
            lblErrorUpdatePartPrice.Size = new Size(0, 21);
            lblErrorUpdatePartPrice.TabIndex = 35;
            lblErrorUpdatePartPrice.Visible = false;
            // 
            // lblErrorPartQty
            // 
            lblErrorPartQty.AutoSize = true;
            lblErrorPartQty.BackColor = Color.Transparent;
            lblErrorPartQty.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorPartQty.ForeColor = Color.Red;
            lblErrorPartQty.Location = new Point(324, 146);
            lblErrorPartQty.Name = "lblErrorPartQty";
            lblErrorPartQty.Size = new Size(0, 21);
            lblErrorPartQty.TabIndex = 34;
            lblErrorPartQty.Visible = false;
            // 
            // lblErrorUpadatePartName
            // 
            lblErrorUpadatePartName.AutoSize = true;
            lblErrorUpadatePartName.BackColor = Color.Transparent;
            lblErrorUpadatePartName.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorUpadatePartName.ForeColor = Color.Red;
            lblErrorUpadatePartName.Location = new Point(324, 69);
            lblErrorUpadatePartName.Name = "lblErrorUpadatePartName";
            lblErrorUpadatePartName.Size = new Size(0, 21);
            lblErrorUpadatePartName.TabIndex = 33;
            lblErrorUpadatePartName.Visible = false;
            // 
            // btnUpdateCarParts
            // 
            btnUpdateCarParts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateCarParts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateCarParts.Depth = 0;
            btnUpdateCarParts.HighEmphasis = true;
            btnUpdateCarParts.Icon = null;
            btnUpdateCarParts.Location = new Point(430, 482);
            btnUpdateCarParts.Margin = new Padding(4, 6, 4, 6);
            btnUpdateCarParts.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateCarParts.Name = "btnUpdateCarParts";
            btnUpdateCarParts.NoAccentTextColor = Color.Empty;
            btnUpdateCarParts.Size = new Size(77, 36);
            btnUpdateCarParts.TabIndex = 32;
            btnUpdateCarParts.Text = "Update";
            btnUpdateCarParts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateCarParts.UseAccentColor = false;
            btnUpdateCarParts.UseVisualStyleBackColor = true;
            btnUpdateCarParts.Click += btnUpdateCarParts_Click;
            // 
            // btnClearCarParts
            // 
            btnClearCarParts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClearCarParts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClearCarParts.Depth = 0;
            btnClearCarParts.HighEmphasis = true;
            btnClearCarParts.Icon = null;
            btnClearCarParts.Location = new Point(538, 482);
            btnClearCarParts.Margin = new Padding(4, 6, 4, 6);
            btnClearCarParts.MouseState = MaterialSkin.MouseState.HOVER;
            btnClearCarParts.Name = "btnClearCarParts";
            btnClearCarParts.NoAccentTextColor = Color.Empty;
            btnClearCarParts.Size = new Size(66, 36);
            btnClearCarParts.TabIndex = 31;
            btnClearCarParts.Text = "Clear";
            btnClearCarParts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClearCarParts.UseAccentColor = false;
            btnClearCarParts.UseVisualStyleBackColor = true;
            // 
            // texDescription
            // 
            texDescription.AllowPromptAsInput = true;
            texDescription.AnimateReadOnly = false;
            texDescription.AsciiOnly = false;
            texDescription.BackgroundImageLayout = ImageLayout.None;
            texDescription.BeepOnError = false;
            texDescription.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texDescription.Depth = 0;
            texDescription.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texDescription.HidePromptOnLeave = false;
            texDescription.HideSelection = true;
            texDescription.Hint = "Description";
            texDescription.InsertKeyMode = InsertKeyMode.Default;
            texDescription.LeadingIcon = null;
            texDescription.Location = new Point(30, 411);
            texDescription.Mask = "";
            texDescription.MaxLength = 32767;
            texDescription.MouseState = MaterialSkin.MouseState.OUT;
            texDescription.Name = "texDescription";
            texDescription.PasswordChar = '\0';
            texDescription.PrefixSuffixText = null;
            texDescription.PromptChar = '_';
            texDescription.ReadOnly = false;
            texDescription.RejectInputOnFirstFailure = false;
            texDescription.ResetOnPrompt = true;
            texDescription.ResetOnSpace = true;
            texDescription.RightToLeft = RightToLeft.No;
            texDescription.SelectedText = "";
            texDescription.SelectionLength = 0;
            texDescription.SelectionStart = 0;
            texDescription.ShortcutsEnabled = true;
            texDescription.Size = new Size(577, 48);
            texDescription.SkipLiterals = true;
            texDescription.TabIndex = 30;
            texDescription.TabStop = false;
            texDescription.TextAlign = HorizontalAlignment.Left;
            texDescription.TextMaskFormat = MaskFormat.IncludeLiterals;
            texDescription.TrailingIcon = null;
            texDescription.UseSystemPasswordChar = false;
            texDescription.ValidatingType = null;
            // 
            // texBrandName
            // 
            texBrandName.AllowPromptAsInput = true;
            texBrandName.AnimateReadOnly = false;
            texBrandName.AsciiOnly = false;
            texBrandName.BackgroundImageLayout = ImageLayout.None;
            texBrandName.BeepOnError = false;
            texBrandName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texBrandName.Depth = 0;
            texBrandName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texBrandName.HidePromptOnLeave = false;
            texBrandName.HideSelection = true;
            texBrandName.Hint = "Brand Name";
            texBrandName.InsertKeyMode = InsertKeyMode.Default;
            texBrandName.LeadingIcon = null;
            texBrandName.Location = new Point(316, 18);
            texBrandName.Mask = "";
            texBrandName.MaxLength = 32767;
            texBrandName.MouseState = MaterialSkin.MouseState.OUT;
            texBrandName.Name = "texBrandName";
            texBrandName.PasswordChar = '\0';
            texBrandName.PrefixSuffixText = null;
            texBrandName.PromptChar = '_';
            texBrandName.ReadOnly = false;
            texBrandName.RejectInputOnFirstFailure = false;
            texBrandName.ResetOnPrompt = true;
            texBrandName.ResetOnSpace = true;
            texBrandName.RightToLeft = RightToLeft.No;
            texBrandName.SelectedText = "";
            texBrandName.SelectionLength = 0;
            texBrandName.SelectionStart = 0;
            texBrandName.ShortcutsEnabled = true;
            texBrandName.Size = new Size(291, 48);
            texBrandName.SkipLiterals = true;
            texBrandName.TabIndex = 29;
            texBrandName.TabStop = false;
            texBrandName.TextAlign = HorizontalAlignment.Left;
            texBrandName.TextMaskFormat = MaskFormat.IncludeLiterals;
            texBrandName.TrailingIcon = null;
            texBrandName.UseSystemPasswordChar = false;
            texBrandName.ValidatingType = null;
            // 
            // texCarMode
            // 
            texCarMode.AllowPromptAsInput = true;
            texCarMode.AnimateReadOnly = false;
            texCarMode.AsciiOnly = false;
            texCarMode.BackgroundImageLayout = ImageLayout.None;
            texCarMode.BeepOnError = false;
            texCarMode.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texCarMode.Depth = 0;
            texCarMode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texCarMode.HidePromptOnLeave = false;
            texCarMode.HideSelection = true;
            texCarMode.Hint = "Car Model";
            texCarMode.InsertKeyMode = InsertKeyMode.Default;
            texCarMode.LeadingIcon = null;
            texCarMode.Location = new Point(319, 264);
            texCarMode.Mask = "";
            texCarMode.MaxLength = 32767;
            texCarMode.MouseState = MaterialSkin.MouseState.OUT;
            texCarMode.Name = "texCarMode";
            texCarMode.PasswordChar = '\0';
            texCarMode.PrefixSuffixText = null;
            texCarMode.PromptChar = '_';
            texCarMode.ReadOnly = false;
            texCarMode.RejectInputOnFirstFailure = false;
            texCarMode.ResetOnPrompt = true;
            texCarMode.ResetOnSpace = true;
            texCarMode.RightToLeft = RightToLeft.No;
            texCarMode.SelectedText = "";
            texCarMode.SelectionLength = 0;
            texCarMode.SelectionStart = 0;
            texCarMode.ShortcutsEnabled = true;
            texCarMode.Size = new Size(291, 48);
            texCarMode.SkipLiterals = true;
            texCarMode.TabIndex = 28;
            texCarMode.TabStop = false;
            texCarMode.TextAlign = HorizontalAlignment.Left;
            texCarMode.TextMaskFormat = MaskFormat.IncludeLiterals;
            texCarMode.TrailingIcon = null;
            texCarMode.UseSystemPasswordChar = false;
            texCarMode.ValidatingType = null;
            // 
            // texUpdatePartPrice
            // 
            texUpdatePartPrice.AllowPromptAsInput = true;
            texUpdatePartPrice.AnimateReadOnly = false;
            texUpdatePartPrice.AsciiOnly = false;
            texUpdatePartPrice.BackgroundImageLayout = ImageLayout.None;
            texUpdatePartPrice.BeepOnError = false;
            texUpdatePartPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texUpdatePartPrice.Depth = 0;
            texUpdatePartPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texUpdatePartPrice.HidePromptOnLeave = false;
            texUpdatePartPrice.HideSelection = true;
            texUpdatePartPrice.Hint = "Price";
            texUpdatePartPrice.InsertKeyMode = InsertKeyMode.Default;
            texUpdatePartPrice.LeadingIcon = null;
            texUpdatePartPrice.Location = new Point(319, 179);
            texUpdatePartPrice.Mask = "";
            texUpdatePartPrice.MaxLength = 32767;
            texUpdatePartPrice.MouseState = MaterialSkin.MouseState.OUT;
            texUpdatePartPrice.Name = "texUpdatePartPrice";
            texUpdatePartPrice.PasswordChar = '\0';
            texUpdatePartPrice.PrefixSuffixText = null;
            texUpdatePartPrice.PromptChar = '_';
            texUpdatePartPrice.ReadOnly = false;
            texUpdatePartPrice.RejectInputOnFirstFailure = false;
            texUpdatePartPrice.ResetOnPrompt = true;
            texUpdatePartPrice.ResetOnSpace = true;
            texUpdatePartPrice.RightToLeft = RightToLeft.No;
            texUpdatePartPrice.SelectedText = "";
            texUpdatePartPrice.SelectionLength = 0;
            texUpdatePartPrice.SelectionStart = 0;
            texUpdatePartPrice.ShortcutsEnabled = true;
            texUpdatePartPrice.Size = new Size(291, 48);
            texUpdatePartPrice.SkipLiterals = true;
            texUpdatePartPrice.TabIndex = 27;
            texUpdatePartPrice.TabStop = false;
            texUpdatePartPrice.TextAlign = HorizontalAlignment.Left;
            texUpdatePartPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            texUpdatePartPrice.TrailingIcon = null;
            texUpdatePartPrice.UseSystemPasswordChar = false;
            texUpdatePartPrice.ValidatingType = null;
            // 
            // texUpdatePartQty
            // 
            texUpdatePartQty.AllowPromptAsInput = true;
            texUpdatePartQty.AnimateReadOnly = false;
            texUpdatePartQty.AsciiOnly = false;
            texUpdatePartQty.BackgroundImageLayout = ImageLayout.None;
            texUpdatePartQty.BeepOnError = false;
            texUpdatePartQty.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texUpdatePartQty.Depth = 0;
            texUpdatePartQty.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texUpdatePartQty.HidePromptOnLeave = false;
            texUpdatePartQty.HideSelection = true;
            texUpdatePartQty.Hint = "Qty";
            texUpdatePartQty.InsertKeyMode = InsertKeyMode.Default;
            texUpdatePartQty.LeadingIcon = null;
            texUpdatePartQty.Location = new Point(319, 94);
            texUpdatePartQty.Mask = "";
            texUpdatePartQty.MaxLength = 32767;
            texUpdatePartQty.MouseState = MaterialSkin.MouseState.OUT;
            texUpdatePartQty.Name = "texUpdatePartQty";
            texUpdatePartQty.PasswordChar = '\0';
            texUpdatePartQty.PrefixSuffixText = null;
            texUpdatePartQty.PromptChar = '_';
            texUpdatePartQty.ReadOnly = false;
            texUpdatePartQty.RejectInputOnFirstFailure = false;
            texUpdatePartQty.ResetOnPrompt = true;
            texUpdatePartQty.ResetOnSpace = true;
            texUpdatePartQty.RightToLeft = RightToLeft.No;
            texUpdatePartQty.SelectedText = "";
            texUpdatePartQty.SelectionLength = 0;
            texUpdatePartQty.SelectionStart = 0;
            texUpdatePartQty.ShortcutsEnabled = true;
            texUpdatePartQty.Size = new Size(291, 48);
            texUpdatePartQty.SkipLiterals = true;
            texUpdatePartQty.TabIndex = 26;
            texUpdatePartQty.TabStop = false;
            texUpdatePartQty.TextAlign = HorizontalAlignment.Left;
            texUpdatePartQty.TextMaskFormat = MaskFormat.IncludeLiterals;
            texUpdatePartQty.TrailingIcon = null;
            texUpdatePartQty.UseSystemPasswordChar = false;
            texUpdatePartQty.ValidatingType = null;
            // 
            // texPartName
            // 
            texPartName.AllowPromptAsInput = true;
            texPartName.AnimateReadOnly = false;
            texPartName.AsciiOnly = false;
            texPartName.BackgroundImageLayout = ImageLayout.None;
            texPartName.BeepOnError = false;
            texPartName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPartName.Depth = 0;
            texPartName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPartName.HidePromptOnLeave = false;
            texPartName.HideSelection = true;
            texPartName.Hint = "Part Name";
            texPartName.InsertKeyMode = InsertKeyMode.Default;
            texPartName.LeadingIcon = null;
            texPartName.Location = new Point(30, 333);
            texPartName.Mask = "";
            texPartName.MaxLength = 32767;
            texPartName.MouseState = MaterialSkin.MouseState.OUT;
            texPartName.Name = "texPartName";
            texPartName.PasswordChar = '\0';
            texPartName.PrefixSuffixText = null;
            texPartName.PromptChar = '_';
            texPartName.ReadOnly = false;
            texPartName.RejectInputOnFirstFailure = false;
            texPartName.ResetOnPrompt = true;
            texPartName.ResetOnSpace = true;
            texPartName.RightToLeft = RightToLeft.No;
            texPartName.SelectedText = "";
            texPartName.SelectionLength = 0;
            texPartName.SelectionStart = 0;
            texPartName.ShortcutsEnabled = true;
            texPartName.Size = new Size(577, 48);
            texPartName.SkipLiterals = true;
            texPartName.TabIndex = 25;
            texPartName.TabStop = false;
            texPartName.TextAlign = HorizontalAlignment.Left;
            texPartName.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPartName.TrailingIcon = null;
            texPartName.UseSystemPasswordChar = false;
            texPartName.ValidatingType = null;
            // 
            // imgUpdateCarPart
            // 
            imgUpdateCarPart.BorderStyle = BorderStyle.FixedSingle;
            imgUpdateCarPart.Location = new Point(33, 22);
            imgUpdateCarPart.Name = "imgUpdateCarPart";
            imgUpdateCarPart.Size = new Size(263, 232);
            imgUpdateCarPart.TabIndex = 24;
            imgUpdateCarPart.TabStop = false;
            // 
            // PartUpdateModel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 673);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PartUpdateModel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Part Update";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUpdateCarPart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox imgUpdateCarPart;
        private MaterialSkin.Controls.MaterialMaskedTextBox texDescription;
        private MaterialSkin.Controls.MaterialMaskedTextBox texBrandName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarMode;
        private MaterialSkin.Controls.MaterialMaskedTextBox texUpdatePartPrice;
        private MaterialSkin.Controls.MaterialMaskedTextBox texUpdatePartQty;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartName;
        private MaterialSkin.Controls.MaterialButton btnUpdateCarParts;
        private MaterialSkin.Controls.MaterialButton btnClearCarParts;
        private Label lblErrorUpadatePartName;
        private Label lblErrorPartQty;
        private Label lblErrorUpdatePartPrice;
    }
}