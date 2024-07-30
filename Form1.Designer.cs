namespace car_traders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            texCarModelName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texDescription = new MaterialSkin.Controls.MaterialMaskedTextBox();
            sellerMobileNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texSellerAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texSellerName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texManufacturingYear = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarColor = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarBrand = new MaterialSkin.Controls.MaterialMaskedTextBox();
            tabPage3 = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Cursor = Cursors.Hand;
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(947, 533);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.ImageKey = "home.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(939, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnClear);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(texCarModelName);
            tabPage2.Controls.Add(texDescription);
            tabPage2.Controls.Add(sellerMobileNum);
            tabPage2.Controls.Add(texSellerAddress);
            tabPage2.Controls.Add(texSellerName);
            tabPage2.Controls.Add(texManufacturingYear);
            tabPage2.Controls.Add(texCarColor);
            tabPage2.Controls.Add(texCarBrand);
            tabPage2.ImageKey = "sports-car.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(939, 490);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Car";
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(798, 239);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(66, 36);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.BackColor = Color.Transparent;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(713, 239);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // texCarModelName
            // 
            texCarModelName.AllowPromptAsInput = true;
            texCarModelName.AnimateReadOnly = false;
            texCarModelName.AsciiOnly = false;
            texCarModelName.BackgroundImageLayout = ImageLayout.None;
            texCarModelName.BeepOnError = false;
            texCarModelName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texCarModelName.Depth = 0;
            texCarModelName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texCarModelName.HidePromptOnLeave = false;
            texCarModelName.HideSelection = true;
            texCarModelName.InsertKeyMode = InsertKeyMode.Default;
            texCarModelName.LeadingIcon = null;
            texCarModelName.Location = new Point(17, 92);
            texCarModelName.Mask = "";
            texCarModelName.MaxLength = 32767;
            texCarModelName.MouseState = MaterialSkin.MouseState.OUT;
            texCarModelName.Name = "texCarModelName";
            texCarModelName.PasswordChar = '\0';
            texCarModelName.PrefixSuffixText = null;
            texCarModelName.PromptChar = '_';
            texCarModelName.ReadOnly = false;
            texCarModelName.RejectInputOnFirstFailure = false;
            texCarModelName.ResetOnPrompt = true;
            texCarModelName.ResetOnSpace = true;
            texCarModelName.RightToLeft = RightToLeft.No;
            texCarModelName.SelectedText = "";
            texCarModelName.SelectionLength = 0;
            texCarModelName.SelectionStart = 0;
            texCarModelName.ShortcutsEnabled = true;
            texCarModelName.Size = new Size(263, 48);
            texCarModelName.SkipLiterals = true;
            texCarModelName.TabIndex = 7;
            texCarModelName.TabStop = false;
            texCarModelName.Text = "Car Model Name";
            texCarModelName.TextAlign = HorizontalAlignment.Left;
            texCarModelName.TextMaskFormat = MaskFormat.IncludeLiterals;
            texCarModelName.TrailingIcon = null;
            texCarModelName.UseSystemPasswordChar = false;
            texCarModelName.ValidatingType = null;
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
            texDescription.InsertKeyMode = InsertKeyMode.Default;
            texDescription.LeadingIcon = null;
            texDescription.Location = new Point(311, 92);
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
            texDescription.Size = new Size(553, 48);
            texDescription.SkipLiterals = true;
            texDescription.TabIndex = 6;
            texDescription.TabStop = false;
            texDescription.Text = "Description";
            texDescription.TextAlign = HorizontalAlignment.Left;
            texDescription.TextMaskFormat = MaskFormat.IncludeLiterals;
            texDescription.TrailingIcon = null;
            texDescription.UseSystemPasswordChar = false;
            texDescription.ValidatingType = null;
            // 
            // sellerMobileNum
            // 
            sellerMobileNum.AllowPromptAsInput = true;
            sellerMobileNum.AnimateReadOnly = false;
            sellerMobileNum.AsciiOnly = false;
            sellerMobileNum.BackgroundImageLayout = ImageLayout.None;
            sellerMobileNum.BeepOnError = false;
            sellerMobileNum.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            sellerMobileNum.Depth = 0;
            sellerMobileNum.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            sellerMobileNum.HidePromptOnLeave = false;
            sellerMobileNum.HideSelection = true;
            sellerMobileNum.InsertKeyMode = InsertKeyMode.Default;
            sellerMobileNum.LeadingIcon = null;
            sellerMobileNum.Location = new Point(601, 163);
            sellerMobileNum.Mask = "";
            sellerMobileNum.MaxLength = 32767;
            sellerMobileNum.MouseState = MaterialSkin.MouseState.OUT;
            sellerMobileNum.Name = "sellerMobileNum";
            sellerMobileNum.PasswordChar = '\0';
            sellerMobileNum.PrefixSuffixText = null;
            sellerMobileNum.PromptChar = '_';
            sellerMobileNum.ReadOnly = false;
            sellerMobileNum.RejectInputOnFirstFailure = false;
            sellerMobileNum.ResetOnPrompt = true;
            sellerMobileNum.ResetOnSpace = true;
            sellerMobileNum.RightToLeft = RightToLeft.No;
            sellerMobileNum.SelectedText = "";
            sellerMobileNum.SelectionLength = 0;
            sellerMobileNum.SelectionStart = 0;
            sellerMobileNum.ShortcutsEnabled = true;
            sellerMobileNum.Size = new Size(263, 48);
            sellerMobileNum.SkipLiterals = true;
            sellerMobileNum.TabIndex = 5;
            sellerMobileNum.TabStop = false;
            sellerMobileNum.Text = "Seller Mobile Number";
            sellerMobileNum.TextAlign = HorizontalAlignment.Left;
            sellerMobileNum.TextMaskFormat = MaskFormat.IncludeLiterals;
            sellerMobileNum.TrailingIcon = null;
            sellerMobileNum.UseSystemPasswordChar = false;
            sellerMobileNum.ValidatingType = null;
            // 
            // texSellerAddress
            // 
            texSellerAddress.AllowPromptAsInput = true;
            texSellerAddress.AnimateReadOnly = false;
            texSellerAddress.AsciiOnly = false;
            texSellerAddress.BackgroundImageLayout = ImageLayout.None;
            texSellerAddress.BeepOnError = false;
            texSellerAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texSellerAddress.Depth = 0;
            texSellerAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texSellerAddress.HidePromptOnLeave = false;
            texSellerAddress.HideSelection = true;
            texSellerAddress.InsertKeyMode = InsertKeyMode.Default;
            texSellerAddress.LeadingIcon = null;
            texSellerAddress.Location = new Point(311, 163);
            texSellerAddress.Mask = "";
            texSellerAddress.MaxLength = 32767;
            texSellerAddress.MouseState = MaterialSkin.MouseState.OUT;
            texSellerAddress.Name = "texSellerAddress";
            texSellerAddress.PasswordChar = '\0';
            texSellerAddress.PrefixSuffixText = null;
            texSellerAddress.PromptChar = '_';
            texSellerAddress.ReadOnly = false;
            texSellerAddress.RejectInputOnFirstFailure = false;
            texSellerAddress.ResetOnPrompt = true;
            texSellerAddress.ResetOnSpace = true;
            texSellerAddress.RightToLeft = RightToLeft.No;
            texSellerAddress.SelectedText = "";
            texSellerAddress.SelectionLength = 0;
            texSellerAddress.SelectionStart = 0;
            texSellerAddress.ShortcutsEnabled = true;
            texSellerAddress.Size = new Size(263, 48);
            texSellerAddress.SkipLiterals = true;
            texSellerAddress.TabIndex = 4;
            texSellerAddress.TabStop = false;
            texSellerAddress.Text = "Seller Address";
            texSellerAddress.TextAlign = HorizontalAlignment.Left;
            texSellerAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            texSellerAddress.TrailingIcon = null;
            texSellerAddress.UseSystemPasswordChar = false;
            texSellerAddress.ValidatingType = null;
            // 
            // texSellerName
            // 
            texSellerName.AllowPromptAsInput = true;
            texSellerName.AnimateReadOnly = false;
            texSellerName.AsciiOnly = false;
            texSellerName.BackgroundImageLayout = ImageLayout.None;
            texSellerName.BeepOnError = false;
            texSellerName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texSellerName.Depth = 0;
            texSellerName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texSellerName.HidePromptOnLeave = false;
            texSellerName.HideSelection = true;
            texSellerName.InsertKeyMode = InsertKeyMode.Default;
            texSellerName.LeadingIcon = null;
            texSellerName.Location = new Point(17, 163);
            texSellerName.Mask = "";
            texSellerName.MaxLength = 32767;
            texSellerName.MouseState = MaterialSkin.MouseState.OUT;
            texSellerName.Name = "texSellerName";
            texSellerName.PasswordChar = '\0';
            texSellerName.PrefixSuffixText = null;
            texSellerName.PromptChar = '_';
            texSellerName.ReadOnly = false;
            texSellerName.RejectInputOnFirstFailure = false;
            texSellerName.ResetOnPrompt = true;
            texSellerName.ResetOnSpace = true;
            texSellerName.RightToLeft = RightToLeft.No;
            texSellerName.SelectedText = "";
            texSellerName.SelectionLength = 0;
            texSellerName.SelectionStart = 0;
            texSellerName.ShortcutsEnabled = true;
            texSellerName.Size = new Size(263, 48);
            texSellerName.SkipLiterals = true;
            texSellerName.TabIndex = 3;
            texSellerName.TabStop = false;
            texSellerName.Text = "Seller Name";
            texSellerName.TextAlign = HorizontalAlignment.Left;
            texSellerName.TextMaskFormat = MaskFormat.IncludeLiterals;
            texSellerName.TrailingIcon = null;
            texSellerName.UseSystemPasswordChar = false;
            texSellerName.ValidatingType = null;
            // 
            // texManufacturingYear
            // 
            texManufacturingYear.AllowPromptAsInput = true;
            texManufacturingYear.AnimateReadOnly = false;
            texManufacturingYear.AsciiOnly = false;
            texManufacturingYear.BackgroundImageLayout = ImageLayout.None;
            texManufacturingYear.BeepOnError = false;
            texManufacturingYear.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texManufacturingYear.Depth = 0;
            texManufacturingYear.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texManufacturingYear.HidePromptOnLeave = false;
            texManufacturingYear.HideSelection = true;
            texManufacturingYear.InsertKeyMode = InsertKeyMode.Default;
            texManufacturingYear.LeadingIcon = null;
            texManufacturingYear.Location = new Point(601, 22);
            texManufacturingYear.Mask = "";
            texManufacturingYear.MaxLength = 32767;
            texManufacturingYear.MouseState = MaterialSkin.MouseState.OUT;
            texManufacturingYear.Name = "texManufacturingYear";
            texManufacturingYear.PasswordChar = '\0';
            texManufacturingYear.PrefixSuffixText = null;
            texManufacturingYear.PromptChar = '_';
            texManufacturingYear.ReadOnly = false;
            texManufacturingYear.RejectInputOnFirstFailure = false;
            texManufacturingYear.ResetOnPrompt = true;
            texManufacturingYear.ResetOnSpace = true;
            texManufacturingYear.RightToLeft = RightToLeft.No;
            texManufacturingYear.SelectedText = "";
            texManufacturingYear.SelectionLength = 0;
            texManufacturingYear.SelectionStart = 0;
            texManufacturingYear.ShortcutsEnabled = true;
            texManufacturingYear.Size = new Size(263, 48);
            texManufacturingYear.SkipLiterals = true;
            texManufacturingYear.TabIndex = 2;
            texManufacturingYear.TabStop = false;
            texManufacturingYear.Text = "Manufacturing Year";
            texManufacturingYear.TextAlign = HorizontalAlignment.Left;
            texManufacturingYear.TextMaskFormat = MaskFormat.IncludeLiterals;
            texManufacturingYear.TrailingIcon = null;
            texManufacturingYear.UseSystemPasswordChar = false;
            texManufacturingYear.ValidatingType = null;
            // 
            // texCarColor
            // 
            texCarColor.AllowPromptAsInput = true;
            texCarColor.AnimateReadOnly = false;
            texCarColor.AsciiOnly = false;
            texCarColor.BackgroundImageLayout = ImageLayout.None;
            texCarColor.BeepOnError = false;
            texCarColor.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texCarColor.Depth = 0;
            texCarColor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texCarColor.HidePromptOnLeave = false;
            texCarColor.HideSelection = true;
            texCarColor.InsertKeyMode = InsertKeyMode.Default;
            texCarColor.LeadingIcon = null;
            texCarColor.Location = new Point(311, 22);
            texCarColor.Mask = "";
            texCarColor.MaxLength = 32767;
            texCarColor.MouseState = MaterialSkin.MouseState.OUT;
            texCarColor.Name = "texCarColor";
            texCarColor.PasswordChar = '\0';
            texCarColor.PrefixSuffixText = null;
            texCarColor.PromptChar = '_';
            texCarColor.ReadOnly = false;
            texCarColor.RejectInputOnFirstFailure = false;
            texCarColor.ResetOnPrompt = true;
            texCarColor.ResetOnSpace = true;
            texCarColor.RightToLeft = RightToLeft.No;
            texCarColor.SelectedText = "";
            texCarColor.SelectionLength = 0;
            texCarColor.SelectionStart = 0;
            texCarColor.ShortcutsEnabled = true;
            texCarColor.Size = new Size(263, 48);
            texCarColor.SkipLiterals = true;
            texCarColor.TabIndex = 1;
            texCarColor.TabStop = false;
            texCarColor.Text = "Color";
            texCarColor.TextAlign = HorizontalAlignment.Left;
            texCarColor.TextMaskFormat = MaskFormat.IncludeLiterals;
            texCarColor.TrailingIcon = null;
            texCarColor.UseSystemPasswordChar = false;
            texCarColor.ValidatingType = null;
            // 
            // texCarBrand
            // 
            texCarBrand.AllowPromptAsInput = true;
            texCarBrand.AnimateReadOnly = false;
            texCarBrand.AsciiOnly = false;
            texCarBrand.BackgroundImageLayout = ImageLayout.None;
            texCarBrand.BeepOnError = false;
            texCarBrand.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texCarBrand.Depth = 0;
            texCarBrand.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texCarBrand.HidePromptOnLeave = false;
            texCarBrand.HideSelection = true;
            texCarBrand.InsertKeyMode = InsertKeyMode.Default;
            texCarBrand.LeadingIcon = null;
            texCarBrand.Location = new Point(17, 22);
            texCarBrand.Mask = "";
            texCarBrand.MaxLength = 32767;
            texCarBrand.MouseState = MaterialSkin.MouseState.OUT;
            texCarBrand.Name = "texCarBrand";
            texCarBrand.PasswordChar = '\0';
            texCarBrand.PrefixSuffixText = null;
            texCarBrand.PromptChar = '_';
            texCarBrand.ReadOnly = false;
            texCarBrand.RejectInputOnFirstFailure = false;
            texCarBrand.ResetOnPrompt = true;
            texCarBrand.ResetOnSpace = true;
            texCarBrand.RightToLeft = RightToLeft.No;
            texCarBrand.SelectedText = "";
            texCarBrand.SelectionLength = 0;
            texCarBrand.SelectionStart = 0;
            texCarBrand.ShortcutsEnabled = true;
            texCarBrand.Size = new Size(263, 48);
            texCarBrand.SkipLiterals = true;
            texCarBrand.TabIndex = 0;
            texCarBrand.TabStop = false;
            texCarBrand.Text = "Car Brand";
            texCarBrand.TextAlign = HorizontalAlignment.Left;
            texCarBrand.TextMaskFormat = MaskFormat.IncludeLiterals;
            texCarBrand.TrailingIcon = null;
            texCarBrand.UseSystemPasswordChar = false;
            texCarBrand.ValidatingType = null;
            // 
            // tabPage3
            // 
            tabPage3.ImageKey = "racing.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(939, 490);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Car Pats";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "sports-car.png");
            imageList1.Images.SetKeyName(1, "home.png");
            imageList1.Images.SetKeyName(2, "racing.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 600);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "Form1";
            Text = "CAR TRADERS";
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private ImageList imageList1;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialMaskedTextBox sellerMobileNum;
        private MaterialSkin.Controls.MaterialMaskedTextBox texSellerAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox texSellerName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texManufacturingYear;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarColor;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarBrand;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarModelName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texDescription;
        private MaterialSkin.Controls.MaterialButton btnClear;
    }
}
