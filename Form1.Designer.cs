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
            texBodyType = new MaterialSkin.Controls.MaterialMaskedTextBox();
            comboTransmission = new MaterialSkin.Controls.MaterialComboBox();
            comboFueltype = new MaterialSkin.Controls.MaterialComboBox();
            texPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texUrl = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texMileage = new MaterialSkin.Controls.MaterialMaskedTextBox();
            imgBox = new PictureBox();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            texCarModelName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texDescription = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texsellerMobileNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texSellerAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texSellerName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texManufacturingYear = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarColor = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarBrand = new MaterialSkin.Controls.MaterialMaskedTextBox();
            tabPage3 = new TabPage();
            imageList1 = new ImageList(components);
            btnUploadImage = new MaterialSkin.Controls.MaterialButton();
            materialTabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBox).BeginInit();
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
            materialTabControl1.Size = new Size(947, 719);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.ImageKey = "home.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(939, 676);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnUploadImage);
            tabPage2.Controls.Add(texBodyType);
            tabPage2.Controls.Add(comboTransmission);
            tabPage2.Controls.Add(comboFueltype);
            tabPage2.Controls.Add(texPrice);
            tabPage2.Controls.Add(texUrl);
            tabPage2.Controls.Add(texMileage);
            tabPage2.Controls.Add(imgBox);
            tabPage2.Controls.Add(btnClear);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(texCarModelName);
            tabPage2.Controls.Add(texDescription);
            tabPage2.Controls.Add(texsellerMobileNum);
            tabPage2.Controls.Add(texSellerAddress);
            tabPage2.Controls.Add(texSellerName);
            tabPage2.Controls.Add(texManufacturingYear);
            tabPage2.Controls.Add(texCarColor);
            tabPage2.Controls.Add(texCarBrand);
            tabPage2.ImageKey = "sports-car.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(939, 676);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Car";
            // 
            // texBodyType
            // 
            texBodyType.AllowPromptAsInput = true;
            texBodyType.AnimateReadOnly = false;
            texBodyType.AsciiOnly = false;
            texBodyType.BackgroundImageLayout = ImageLayout.None;
            texBodyType.BeepOnError = false;
            texBodyType.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texBodyType.Depth = 0;
            texBodyType.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texBodyType.HidePromptOnLeave = false;
            texBodyType.HideSelection = true;
            texBodyType.Hint = "Body Type";
            texBodyType.InsertKeyMode = InsertKeyMode.Default;
            texBodyType.LeadingIcon = null;
            texBodyType.Location = new Point(17, 319);
            texBodyType.Mask = "";
            texBodyType.MaxLength = 32767;
            texBodyType.MouseState = MaterialSkin.MouseState.OUT;
            texBodyType.Name = "texBodyType";
            texBodyType.PasswordChar = '\0';
            texBodyType.PrefixSuffixText = null;
            texBodyType.PromptChar = '_';
            texBodyType.ReadOnly = false;
            texBodyType.RejectInputOnFirstFailure = false;
            texBodyType.ResetOnPrompt = true;
            texBodyType.ResetOnSpace = true;
            texBodyType.RightToLeft = RightToLeft.No;
            texBodyType.SelectedText = "";
            texBodyType.SelectionLength = 0;
            texBodyType.SelectionStart = 0;
            texBodyType.ShortcutsEnabled = true;
            texBodyType.Size = new Size(263, 48);
            texBodyType.SkipLiterals = true;
            texBodyType.TabIndex = 16;
            texBodyType.TabStop = false;
            texBodyType.TextAlign = HorizontalAlignment.Left;
            texBodyType.TextMaskFormat = MaskFormat.IncludeLiterals;
            texBodyType.TrailingIcon = null;
            texBodyType.UseSystemPasswordChar = false;
            texBodyType.ValidatingType = null;
            // 
            // comboTransmission
            // 
            comboTransmission.AutoResize = false;
            comboTransmission.BackColor = Color.FromArgb(255, 255, 255);
            comboTransmission.Depth = 0;
            comboTransmission.DrawMode = DrawMode.OwnerDrawVariable;
            comboTransmission.DropDownHeight = 174;
            comboTransmission.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTransmission.DropDownWidth = 121;
            comboTransmission.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboTransmission.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboTransmission.FormattingEnabled = true;
            comboTransmission.IntegralHeight = false;
            comboTransmission.ItemHeight = 43;
            comboTransmission.Items.AddRange(new object[] { "automatic", "manual" });
            comboTransmission.Location = new Point(601, 239);
            comboTransmission.MaxDropDownItems = 4;
            comboTransmission.MouseState = MaterialSkin.MouseState.OUT;
            comboTransmission.Name = "comboTransmission";
            comboTransmission.Size = new Size(263, 49);
            comboTransmission.StartIndex = 0;
            comboTransmission.TabIndex = 15;
            // 
            // comboFueltype
            // 
            comboFueltype.AutoResize = false;
            comboFueltype.BackColor = Color.FromArgb(255, 255, 255);
            comboFueltype.Depth = 0;
            comboFueltype.DrawMode = DrawMode.OwnerDrawVariable;
            comboFueltype.DropDownHeight = 174;
            comboFueltype.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFueltype.DropDownWidth = 121;
            comboFueltype.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboFueltype.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboFueltype.FormattingEnabled = true;
            comboFueltype.IntegralHeight = false;
            comboFueltype.ItemHeight = 43;
            comboFueltype.Items.AddRange(new object[] { "petrol", "diesel", "electric" });
            comboFueltype.Location = new Point(311, 238);
            comboFueltype.MaxDropDownItems = 4;
            comboFueltype.MouseState = MaterialSkin.MouseState.OUT;
            comboFueltype.Name = "comboFueltype";
            comboFueltype.Size = new Size(263, 49);
            comboFueltype.StartIndex = 0;
            comboFueltype.TabIndex = 14;
            // 
            // texPrice
            // 
            texPrice.AllowPromptAsInput = true;
            texPrice.AnimateReadOnly = false;
            texPrice.AsciiOnly = false;
            texPrice.BackgroundImageLayout = ImageLayout.None;
            texPrice.BeepOnError = false;
            texPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPrice.Depth = 0;
            texPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPrice.HidePromptOnLeave = false;
            texPrice.HideSelection = true;
            texPrice.Hint = "Price";
            texPrice.InsertKeyMode = InsertKeyMode.Default;
            texPrice.LeadingIcon = null;
            texPrice.Location = new Point(311, 319);
            texPrice.Mask = "";
            texPrice.MaxLength = 32767;
            texPrice.MouseState = MaterialSkin.MouseState.OUT;
            texPrice.Name = "texPrice";
            texPrice.PasswordChar = '\0';
            texPrice.PrefixSuffixText = null;
            texPrice.PromptChar = '_';
            texPrice.ReadOnly = false;
            texPrice.RejectInputOnFirstFailure = false;
            texPrice.ResetOnPrompt = true;
            texPrice.ResetOnSpace = true;
            texPrice.RightToLeft = RightToLeft.No;
            texPrice.SelectedText = "";
            texPrice.SelectionLength = 0;
            texPrice.SelectionStart = 0;
            texPrice.ShortcutsEnabled = true;
            texPrice.Size = new Size(263, 48);
            texPrice.SkipLiterals = true;
            texPrice.TabIndex = 13;
            texPrice.TabStop = false;
            texPrice.TextAlign = HorizontalAlignment.Left;
            texPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPrice.TrailingIcon = null;
            texPrice.UseSystemPasswordChar = false;
            texPrice.ValidatingType = null;
            // 
            // texUrl
            // 
            texUrl.AllowPromptAsInput = true;
            texUrl.AnimateReadOnly = false;
            texUrl.AsciiOnly = false;
            texUrl.BackgroundImageLayout = ImageLayout.None;
            texUrl.BeepOnError = false;
            texUrl.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texUrl.Depth = 0;
            texUrl.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texUrl.HidePromptOnLeave = false;
            texUrl.HideSelection = true;
            texUrl.Hint = "selectImage";
            texUrl.InsertKeyMode = InsertKeyMode.Default;
            texUrl.LeadingIcon = null;
            texUrl.Location = new Point(17, 409);
            texUrl.Mask = "";
            texUrl.MaxLength = 32767;
            texUrl.MouseState = MaterialSkin.MouseState.OUT;
            texUrl.Name = "texUrl";
            texUrl.PasswordChar = '\0';
            texUrl.PrefixSuffixText = null;
            texUrl.PromptChar = '_';
            texUrl.ReadOnly = false;
            texUrl.RejectInputOnFirstFailure = false;
            texUrl.ResetOnPrompt = true;
            texUrl.ResetOnSpace = true;
            texUrl.RightToLeft = RightToLeft.No;
            texUrl.SelectedText = "";
            texUrl.SelectionLength = 0;
            texUrl.SelectionStart = 0;
            texUrl.ShortcutsEnabled = true;
            texUrl.Size = new Size(557, 48);
            texUrl.SkipLiterals = true;
            texUrl.TabIndex = 12;
            texUrl.TabStop = false;
            texUrl.TextAlign = HorizontalAlignment.Left;
            texUrl.TextMaskFormat = MaskFormat.IncludeLiterals;
            texUrl.TrailingIcon = null;
            texUrl.UseSystemPasswordChar = false;
            texUrl.ValidatingType = null;
            // 
            // texMileage
            // 
            texMileage.AllowPromptAsInput = true;
            texMileage.AnimateReadOnly = false;
            texMileage.AsciiOnly = false;
            texMileage.BackgroundImageLayout = ImageLayout.None;
            texMileage.BeepOnError = false;
            texMileage.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texMileage.Depth = 0;
            texMileage.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texMileage.HidePromptOnLeave = false;
            texMileage.HideSelection = true;
            texMileage.Hint = "Mileage";
            texMileage.InsertKeyMode = InsertKeyMode.Default;
            texMileage.LeadingIcon = null;
            texMileage.Location = new Point(17, 239);
            texMileage.Mask = "";
            texMileage.MaxLength = 32767;
            texMileage.MouseState = MaterialSkin.MouseState.OUT;
            texMileage.Name = "texMileage";
            texMileage.PasswordChar = '\0';
            texMileage.PrefixSuffixText = null;
            texMileage.PromptChar = '_';
            texMileage.ReadOnly = false;
            texMileage.RejectInputOnFirstFailure = false;
            texMileage.ResetOnPrompt = true;
            texMileage.ResetOnSpace = true;
            texMileage.RightToLeft = RightToLeft.No;
            texMileage.SelectedText = "";
            texMileage.SelectionLength = 0;
            texMileage.SelectionStart = 0;
            texMileage.ShortcutsEnabled = true;
            texMileage.Size = new Size(263, 48);
            texMileage.SkipLiterals = true;
            texMileage.TabIndex = 11;
            texMileage.TabStop = false;
            texMileage.TextAlign = HorizontalAlignment.Left;
            texMileage.TextMaskFormat = MaskFormat.IncludeLiterals;
            texMileage.TrailingIcon = null;
            texMileage.UseSystemPasswordChar = false;
            texMileage.ValidatingType = null;
            // 
            // imgBox
            // 
            imgBox.Location = new Point(601, 319);
            imgBox.Name = "imgBox";
            imgBox.Size = new Size(263, 232);
            imgBox.TabIndex = 10;
            imgBox.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(116, 515);
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
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.BackColor = Color.Transparent;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(29, 515);
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
            btnSave.Click += btnSave_Click;
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
            texCarModelName.Hint = "Car Model Name";
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
            texDescription.Hint = "Description";
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
            texDescription.TextAlign = HorizontalAlignment.Left;
            texDescription.TextMaskFormat = MaskFormat.IncludeLiterals;
            texDescription.TrailingIcon = null;
            texDescription.UseSystemPasswordChar = false;
            texDescription.ValidatingType = null;
            // 
            // texsellerMobileNum
            // 
            texsellerMobileNum.AllowPromptAsInput = true;
            texsellerMobileNum.AnimateReadOnly = false;
            texsellerMobileNum.AsciiOnly = false;
            texsellerMobileNum.BackgroundImageLayout = ImageLayout.None;
            texsellerMobileNum.BeepOnError = false;
            texsellerMobileNum.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texsellerMobileNum.Depth = 0;
            texsellerMobileNum.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texsellerMobileNum.HidePromptOnLeave = false;
            texsellerMobileNum.HideSelection = true;
            texsellerMobileNum.Hint = "Seller Mobile Number";
            texsellerMobileNum.InsertKeyMode = InsertKeyMode.Default;
            texsellerMobileNum.LeadingIcon = null;
            texsellerMobileNum.Location = new Point(601, 163);
            texsellerMobileNum.Mask = "";
            texsellerMobileNum.MaxLength = 32767;
            texsellerMobileNum.MouseState = MaterialSkin.MouseState.OUT;
            texsellerMobileNum.Name = "texsellerMobileNum";
            texsellerMobileNum.PasswordChar = '\0';
            texsellerMobileNum.PrefixSuffixText = null;
            texsellerMobileNum.PromptChar = '_';
            texsellerMobileNum.ReadOnly = false;
            texsellerMobileNum.RejectInputOnFirstFailure = false;
            texsellerMobileNum.ResetOnPrompt = true;
            texsellerMobileNum.ResetOnSpace = true;
            texsellerMobileNum.RightToLeft = RightToLeft.No;
            texsellerMobileNum.SelectedText = "";
            texsellerMobileNum.SelectionLength = 0;
            texsellerMobileNum.SelectionStart = 0;
            texsellerMobileNum.ShortcutsEnabled = true;
            texsellerMobileNum.Size = new Size(263, 48);
            texsellerMobileNum.SkipLiterals = true;
            texsellerMobileNum.TabIndex = 5;
            texsellerMobileNum.TabStop = false;
            texsellerMobileNum.TextAlign = HorizontalAlignment.Left;
            texsellerMobileNum.TextMaskFormat = MaskFormat.IncludeLiterals;
            texsellerMobileNum.TrailingIcon = null;
            texsellerMobileNum.UseSystemPasswordChar = false;
            texsellerMobileNum.ValidatingType = null;
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
            texSellerAddress.Hint = "Seller Address";
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
            texSellerName.Hint = "Seller Name";
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
            texManufacturingYear.Hint = "Manufacturing Year";
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
            texCarColor.Hint = "Color";
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
            texCarBrand.Hint = "Car Brand";
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
            tabPage3.Size = new Size(939, 676);
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
            // btnUploadImage
            // 
            btnUploadImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUploadImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUploadImage.Depth = 0;
            btnUploadImage.HighEmphasis = true;
            btnUploadImage.Icon = null;
            btnUploadImage.Location = new Point(680, 560);
            btnUploadImage.Margin = new Padding(4, 6, 4, 6);
            btnUploadImage.MouseState = MaterialSkin.MouseState.HOVER;
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.NoAccentTextColor = Color.Empty;
            btnUploadImage.Size = new Size(127, 36);
            btnUploadImage.TabIndex = 17;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUploadImage.UseAccentColor = false;
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 786);
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
            ((System.ComponentModel.ISupportInitialize)imgBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private ImageList imageList1;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialMaskedTextBox texsellerMobileNum;
        private MaterialSkin.Controls.MaterialMaskedTextBox texSellerAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox texSellerName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texManufacturingYear;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarColor;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarBrand;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarModelName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texDescription;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private PictureBox imgBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox texUrl;
        private MaterialSkin.Controls.MaterialMaskedTextBox texMileage;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPrice;
        private MaterialSkin.Controls.MaterialComboBox comboFueltype;
        private MaterialSkin.Controls.MaterialComboBox comboTransmission;
        private MaterialSkin.Controls.MaterialMaskedTextBox texBodyType;
        private MaterialSkin.Controls.MaterialButton btnUploadImage;
    }
}
