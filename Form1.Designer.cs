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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnUploadImage = new MaterialSkin.Controls.MaterialButton();
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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnPartImageUpload = new MaterialSkin.Controls.MaterialButton();
            btnPartsClear = new MaterialSkin.Controls.MaterialButton();
            btnPartsSave = new MaterialSkin.Controls.MaterialButton();
            imgBoxCarPats = new PictureBox();
            texPartsImageUrl = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox6 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartBrandName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsCarModel = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsCategory = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsQty = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsDescriptions = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsNaame = new MaterialSkin.Controls.MaterialMaskedTextBox();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBox).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxCarPats).BeginInit();
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
            tabPage2.Controls.Add(materialLabel1);
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(668, 554);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(127, 19);
            materialLabel1.TabIndex = 18;
            materialLabel1.Text = "*.jpg, *.jpeg, *.png";
            // 
            // btnUploadImage
            // 
            btnUploadImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUploadImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUploadImage.Depth = 0;
            btnUploadImage.HighEmphasis = true;
            btnUploadImage.Icon = null;
            btnUploadImage.Location = new Point(668, 579);
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
            btnClear.Location = new Point(503, 481);
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
            btnSave.Location = new Point(416, 481);
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
            tabPage3.Controls.Add(materialLabel2);
            tabPage3.Controls.Add(btnPartImageUpload);
            tabPage3.Controls.Add(btnPartsClear);
            tabPage3.Controls.Add(btnPartsSave);
            tabPage3.Controls.Add(imgBoxCarPats);
            tabPage3.Controls.Add(texPartsImageUrl);
            tabPage3.Controls.Add(materialMaskedTextBox6);
            tabPage3.Controls.Add(texPartBrandName);
            tabPage3.Controls.Add(texPartsCarModel);
            tabPage3.Controls.Add(texPartsCategory);
            tabPage3.Controls.Add(texPartsQty);
            tabPage3.Controls.Add(texPartsPrice);
            tabPage3.Controls.Add(texPartsDescriptions);
            tabPage3.Controls.Add(texPartsNaame);
            tabPage3.ImageKey = "racing.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(939, 676);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Car Parts";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(703, 490);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(127, 19);
            materialLabel2.TabIndex = 22;
            materialLabel2.Text = "*.jpg, *.jpeg, *.png";
            // 
            // btnPartImageUpload
            // 
            btnPartImageUpload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPartImageUpload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPartImageUpload.Depth = 0;
            btnPartImageUpload.HighEmphasis = true;
            btnPartImageUpload.Icon = null;
            btnPartImageUpload.Location = new Point(703, 515);
            btnPartImageUpload.Margin = new Padding(4, 6, 4, 6);
            btnPartImageUpload.MouseState = MaterialSkin.MouseState.HOVER;
            btnPartImageUpload.Name = "btnPartImageUpload";
            btnPartImageUpload.NoAccentTextColor = Color.Empty;
            btnPartImageUpload.Size = new Size(127, 36);
            btnPartImageUpload.TabIndex = 21;
            btnPartImageUpload.Text = "Upload Image";
            btnPartImageUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPartImageUpload.UseAccentColor = false;
            btnPartImageUpload.UseVisualStyleBackColor = true;
            btnPartImageUpload.Click += btnPartImageUpload_Click;
            // 
            // btnPartsClear
            // 
            btnPartsClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPartsClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPartsClear.Depth = 0;
            btnPartsClear.HighEmphasis = true;
            btnPartsClear.Icon = null;
            btnPartsClear.Location = new Point(499, 334);
            btnPartsClear.Margin = new Padding(4, 6, 4, 6);
            btnPartsClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnPartsClear.Name = "btnPartsClear";
            btnPartsClear.NoAccentTextColor = Color.Empty;
            btnPartsClear.Size = new Size(66, 36);
            btnPartsClear.TabIndex = 20;
            btnPartsClear.Text = "Clear";
            btnPartsClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPartsClear.UseAccentColor = false;
            btnPartsClear.UseVisualStyleBackColor = true;
            // 
            // btnPartsSave
            // 
            btnPartsSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPartsSave.BackColor = Color.Transparent;
            btnPartsSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPartsSave.Depth = 0;
            btnPartsSave.HighEmphasis = true;
            btnPartsSave.Icon = null;
            btnPartsSave.Location = new Point(412, 334);
            btnPartsSave.Margin = new Padding(4, 6, 4, 6);
            btnPartsSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnPartsSave.Name = "btnPartsSave";
            btnPartsSave.NoAccentTextColor = Color.Empty;
            btnPartsSave.Size = new Size(64, 36);
            btnPartsSave.TabIndex = 19;
            btnPartsSave.Text = "Save";
            btnPartsSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPartsSave.UseAccentColor = false;
            btnPartsSave.UseVisualStyleBackColor = false;
            btnPartsSave.Click += btnPartsSave_Click;
            // 
            // imgBoxCarPats
            // 
            imgBoxCarPats.Location = new Point(627, 249);
            imgBoxCarPats.Name = "imgBoxCarPats";
            imgBoxCarPats.Size = new Size(263, 232);
            imgBoxCarPats.TabIndex = 11;
            imgBoxCarPats.TabStop = false;
            // 
            // texPartsImageUrl
            // 
            texPartsImageUrl.AllowPromptAsInput = true;
            texPartsImageUrl.AnimateReadOnly = false;
            texPartsImageUrl.AsciiOnly = false;
            texPartsImageUrl.BackgroundImageLayout = ImageLayout.None;
            texPartsImageUrl.BeepOnError = false;
            texPartsImageUrl.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPartsImageUrl.Depth = 0;
            texPartsImageUrl.Enabled = false;
            texPartsImageUrl.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPartsImageUrl.HidePromptOnLeave = false;
            texPartsImageUrl.HideSelection = true;
            texPartsImageUrl.InsertKeyMode = InsertKeyMode.Default;
            texPartsImageUrl.LeadingIcon = null;
            texPartsImageUrl.Location = new Point(20, 261);
            texPartsImageUrl.Mask = "";
            texPartsImageUrl.MaxLength = 32767;
            texPartsImageUrl.MouseState = MaterialSkin.MouseState.OUT;
            texPartsImageUrl.Name = "texPartsImageUrl";
            texPartsImageUrl.PasswordChar = '\0';
            texPartsImageUrl.PrefixSuffixText = null;
            texPartsImageUrl.PromptChar = '_';
            texPartsImageUrl.ReadOnly = false;
            texPartsImageUrl.RejectInputOnFirstFailure = false;
            texPartsImageUrl.ResetOnPrompt = true;
            texPartsImageUrl.ResetOnSpace = true;
            texPartsImageUrl.RightToLeft = RightToLeft.No;
            texPartsImageUrl.SelectedText = "";
            texPartsImageUrl.SelectionLength = 0;
            texPartsImageUrl.SelectionStart = 0;
            texPartsImageUrl.ShortcutsEnabled = true;
            texPartsImageUrl.Size = new Size(556, 48);
            texPartsImageUrl.SkipLiterals = true;
            texPartsImageUrl.TabIndex = 8;
            texPartsImageUrl.TabStop = false;
            texPartsImageUrl.TextAlign = HorizontalAlignment.Left;
            texPartsImageUrl.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPartsImageUrl.TrailingIcon = null;
            texPartsImageUrl.UseSystemPasswordChar = false;
            texPartsImageUrl.ValidatingType = null;
            // 
            // materialMaskedTextBox6
            // 
            materialMaskedTextBox6.AllowPromptAsInput = true;
            materialMaskedTextBox6.AnimateReadOnly = false;
            materialMaskedTextBox6.AsciiOnly = false;
            materialMaskedTextBox6.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox6.BeepOnError = false;
            materialMaskedTextBox6.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox6.Depth = 0;
            materialMaskedTextBox6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox6.HidePromptOnLeave = false;
            materialMaskedTextBox6.HideSelection = true;
            materialMaskedTextBox6.Hint = "Name";
            materialMaskedTextBox6.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox6.LeadingIcon = null;
            materialMaskedTextBox6.Location = new Point(629, 177);
            materialMaskedTextBox6.Mask = "";
            materialMaskedTextBox6.MaxLength = 32767;
            materialMaskedTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox6.Name = "materialMaskedTextBox6";
            materialMaskedTextBox6.PasswordChar = '\0';
            materialMaskedTextBox6.PrefixSuffixText = null;
            materialMaskedTextBox6.PromptChar = '_';
            materialMaskedTextBox6.ReadOnly = false;
            materialMaskedTextBox6.RejectInputOnFirstFailure = false;
            materialMaskedTextBox6.ResetOnPrompt = true;
            materialMaskedTextBox6.ResetOnSpace = true;
            materialMaskedTextBox6.RightToLeft = RightToLeft.No;
            materialMaskedTextBox6.SelectedText = "";
            materialMaskedTextBox6.SelectionLength = 0;
            materialMaskedTextBox6.SelectionStart = 0;
            materialMaskedTextBox6.ShortcutsEnabled = true;
            materialMaskedTextBox6.Size = new Size(261, 48);
            materialMaskedTextBox6.SkipLiterals = true;
            materialMaskedTextBox6.TabIndex = 7;
            materialMaskedTextBox6.TabStop = false;
            materialMaskedTextBox6.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox6.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox6.TrailingIcon = null;
            materialMaskedTextBox6.UseSystemPasswordChar = false;
            materialMaskedTextBox6.ValidatingType = null;
            // 
            // texPartBrandName
            // 
            texPartBrandName.AllowPromptAsInput = true;
            texPartBrandName.AnimateReadOnly = false;
            texPartBrandName.AsciiOnly = false;
            texPartBrandName.BackgroundImageLayout = ImageLayout.None;
            texPartBrandName.BeepOnError = false;
            texPartBrandName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPartBrandName.Depth = 0;
            texPartBrandName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPartBrandName.HidePromptOnLeave = false;
            texPartBrandName.HideSelection = true;
            texPartBrandName.Hint = "Brand Name";
            texPartBrandName.InsertKeyMode = InsertKeyMode.Default;
            texPartBrandName.LeadingIcon = null;
            texPartBrandName.Location = new Point(315, 177);
            texPartBrandName.Mask = "";
            texPartBrandName.MaxLength = 32767;
            texPartBrandName.MouseState = MaterialSkin.MouseState.OUT;
            texPartBrandName.Name = "texPartBrandName";
            texPartBrandName.PasswordChar = '\0';
            texPartBrandName.PrefixSuffixText = null;
            texPartBrandName.PromptChar = '_';
            texPartBrandName.ReadOnly = false;
            texPartBrandName.RejectInputOnFirstFailure = false;
            texPartBrandName.ResetOnPrompt = true;
            texPartBrandName.ResetOnSpace = true;
            texPartBrandName.RightToLeft = RightToLeft.No;
            texPartBrandName.SelectedText = "";
            texPartBrandName.SelectionLength = 0;
            texPartBrandName.SelectionStart = 0;
            texPartBrandName.ShortcutsEnabled = true;
            texPartBrandName.Size = new Size(261, 48);
            texPartBrandName.SkipLiterals = true;
            texPartBrandName.TabIndex = 6;
            texPartBrandName.TabStop = false;
            texPartBrandName.TextAlign = HorizontalAlignment.Left;
            texPartBrandName.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPartBrandName.TrailingIcon = null;
            texPartBrandName.UseSystemPasswordChar = false;
            texPartBrandName.ValidatingType = null;
            // 
            // texPartsCarModel
            // 
            texPartsCarModel.AllowPromptAsInput = true;
            texPartsCarModel.AnimateReadOnly = false;
            texPartsCarModel.AsciiOnly = false;
            texPartsCarModel.BackgroundImageLayout = ImageLayout.None;
            texPartsCarModel.BeepOnError = false;
            texPartsCarModel.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPartsCarModel.Depth = 0;
            texPartsCarModel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPartsCarModel.HidePromptOnLeave = false;
            texPartsCarModel.HideSelection = true;
            texPartsCarModel.Hint = "Car Model";
            texPartsCarModel.InsertKeyMode = InsertKeyMode.Default;
            texPartsCarModel.LeadingIcon = null;
            texPartsCarModel.Location = new Point(20, 177);
            texPartsCarModel.Mask = "";
            texPartsCarModel.MaxLength = 32767;
            texPartsCarModel.MouseState = MaterialSkin.MouseState.OUT;
            texPartsCarModel.Name = "texPartsCarModel";
            texPartsCarModel.PasswordChar = '\0';
            texPartsCarModel.PrefixSuffixText = null;
            texPartsCarModel.PromptChar = '_';
            texPartsCarModel.ReadOnly = false;
            texPartsCarModel.RejectInputOnFirstFailure = false;
            texPartsCarModel.ResetOnPrompt = true;
            texPartsCarModel.ResetOnSpace = true;
            texPartsCarModel.RightToLeft = RightToLeft.No;
            texPartsCarModel.SelectedText = "";
            texPartsCarModel.SelectionLength = 0;
            texPartsCarModel.SelectionStart = 0;
            texPartsCarModel.ShortcutsEnabled = true;
            texPartsCarModel.Size = new Size(261, 48);
            texPartsCarModel.SkipLiterals = true;
            texPartsCarModel.TabIndex = 5;
            texPartsCarModel.TabStop = false;
            texPartsCarModel.TextAlign = HorizontalAlignment.Left;
            texPartsCarModel.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPartsCarModel.TrailingIcon = null;
            texPartsCarModel.UseSystemPasswordChar = false;
            texPartsCarModel.ValidatingType = null;
            // 
            // texPartsCategory
            // 
            texPartsCategory.AllowPromptAsInput = true;
            texPartsCategory.AnimateReadOnly = false;
            texPartsCategory.AsciiOnly = false;
            texPartsCategory.BackgroundImageLayout = ImageLayout.None;
            texPartsCategory.BeepOnError = false;
            texPartsCategory.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPartsCategory.Depth = 0;
            texPartsCategory.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPartsCategory.HidePromptOnLeave = false;
            texPartsCategory.HideSelection = true;
            texPartsCategory.Hint = "Category";
            texPartsCategory.InsertKeyMode = InsertKeyMode.Default;
            texPartsCategory.LeadingIcon = null;
            texPartsCategory.Location = new Point(629, 97);
            texPartsCategory.Mask = "";
            texPartsCategory.MaxLength = 32767;
            texPartsCategory.MouseState = MaterialSkin.MouseState.OUT;
            texPartsCategory.Name = "texPartsCategory";
            texPartsCategory.PasswordChar = '\0';
            texPartsCategory.PrefixSuffixText = null;
            texPartsCategory.PromptChar = '_';
            texPartsCategory.ReadOnly = false;
            texPartsCategory.RejectInputOnFirstFailure = false;
            texPartsCategory.ResetOnPrompt = true;
            texPartsCategory.ResetOnSpace = true;
            texPartsCategory.RightToLeft = RightToLeft.No;
            texPartsCategory.SelectedText = "";
            texPartsCategory.SelectionLength = 0;
            texPartsCategory.SelectionStart = 0;
            texPartsCategory.ShortcutsEnabled = true;
            texPartsCategory.Size = new Size(261, 48);
            texPartsCategory.SkipLiterals = true;
            texPartsCategory.TabIndex = 4;
            texPartsCategory.TabStop = false;
            texPartsCategory.TextAlign = HorizontalAlignment.Left;
            texPartsCategory.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPartsCategory.TrailingIcon = null;
            texPartsCategory.UseSystemPasswordChar = false;
            texPartsCategory.ValidatingType = null;
            // 
            // texPartsQty
            // 
            texPartsQty.AllowPromptAsInput = true;
            texPartsQty.AnimateReadOnly = false;
            texPartsQty.AsciiOnly = false;
            texPartsQty.BackgroundImageLayout = ImageLayout.None;
            texPartsQty.BeepOnError = false;
            texPartsQty.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPartsQty.Depth = 0;
            texPartsQty.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPartsQty.HidePromptOnLeave = false;
            texPartsQty.HideSelection = true;
            texPartsQty.Hint = "QTY";
            texPartsQty.InsertKeyMode = InsertKeyMode.Default;
            texPartsQty.LeadingIcon = null;
            texPartsQty.Location = new Point(315, 97);
            texPartsQty.Mask = "";
            texPartsQty.MaxLength = 32767;
            texPartsQty.MouseState = MaterialSkin.MouseState.OUT;
            texPartsQty.Name = "texPartsQty";
            texPartsQty.PasswordChar = '\0';
            texPartsQty.PrefixSuffixText = null;
            texPartsQty.PromptChar = '_';
            texPartsQty.ReadOnly = false;
            texPartsQty.RejectInputOnFirstFailure = false;
            texPartsQty.ResetOnPrompt = true;
            texPartsQty.ResetOnSpace = true;
            texPartsQty.RightToLeft = RightToLeft.No;
            texPartsQty.SelectedText = "";
            texPartsQty.SelectionLength = 0;
            texPartsQty.SelectionStart = 0;
            texPartsQty.ShortcutsEnabled = true;
            texPartsQty.Size = new Size(261, 48);
            texPartsQty.SkipLiterals = true;
            texPartsQty.TabIndex = 3;
            texPartsQty.TabStop = false;
            texPartsQty.TextAlign = HorizontalAlignment.Left;
            texPartsQty.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPartsQty.TrailingIcon = null;
            texPartsQty.UseSystemPasswordChar = false;
            texPartsQty.ValidatingType = null;
            // 
            // texPartsPrice
            // 
            texPartsPrice.AllowPromptAsInput = true;
            texPartsPrice.AnimateReadOnly = false;
            texPartsPrice.AsciiOnly = false;
            texPartsPrice.BackgroundImageLayout = ImageLayout.None;
            texPartsPrice.BeepOnError = false;
            texPartsPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPartsPrice.Depth = 0;
            texPartsPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPartsPrice.HidePromptOnLeave = false;
            texPartsPrice.HideSelection = true;
            texPartsPrice.Hint = "Price";
            texPartsPrice.InsertKeyMode = InsertKeyMode.Default;
            texPartsPrice.LeadingIcon = null;
            texPartsPrice.Location = new Point(20, 97);
            texPartsPrice.Mask = "";
            texPartsPrice.MaxLength = 32767;
            texPartsPrice.MouseState = MaterialSkin.MouseState.OUT;
            texPartsPrice.Name = "texPartsPrice";
            texPartsPrice.PasswordChar = '\0';
            texPartsPrice.PrefixSuffixText = null;
            texPartsPrice.PromptChar = '_';
            texPartsPrice.ReadOnly = false;
            texPartsPrice.RejectInputOnFirstFailure = false;
            texPartsPrice.ResetOnPrompt = true;
            texPartsPrice.ResetOnSpace = true;
            texPartsPrice.RightToLeft = RightToLeft.No;
            texPartsPrice.SelectedText = "";
            texPartsPrice.SelectionLength = 0;
            texPartsPrice.SelectionStart = 0;
            texPartsPrice.ShortcutsEnabled = true;
            texPartsPrice.Size = new Size(261, 48);
            texPartsPrice.SkipLiterals = true;
            texPartsPrice.TabIndex = 2;
            texPartsPrice.TabStop = false;
            texPartsPrice.TextAlign = HorizontalAlignment.Left;
            texPartsPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPartsPrice.TrailingIcon = null;
            texPartsPrice.UseSystemPasswordChar = false;
            texPartsPrice.ValidatingType = null;
            // 
            // texPartsDescriptions
            // 
            texPartsDescriptions.AllowPromptAsInput = true;
            texPartsDescriptions.AnimateReadOnly = false;
            texPartsDescriptions.AsciiOnly = false;
            texPartsDescriptions.BackgroundImageLayout = ImageLayout.None;
            texPartsDescriptions.BeepOnError = false;
            texPartsDescriptions.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPartsDescriptions.Depth = 0;
            texPartsDescriptions.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPartsDescriptions.HidePromptOnLeave = false;
            texPartsDescriptions.HideSelection = true;
            texPartsDescriptions.Hint = "Description";
            texPartsDescriptions.InsertKeyMode = InsertKeyMode.Default;
            texPartsDescriptions.LeadingIcon = null;
            texPartsDescriptions.Location = new Point(315, 25);
            texPartsDescriptions.Mask = "";
            texPartsDescriptions.MaxLength = 32767;
            texPartsDescriptions.MouseState = MaterialSkin.MouseState.OUT;
            texPartsDescriptions.Name = "texPartsDescriptions";
            texPartsDescriptions.PasswordChar = '\0';
            texPartsDescriptions.PrefixSuffixText = null;
            texPartsDescriptions.PromptChar = '_';
            texPartsDescriptions.ReadOnly = false;
            texPartsDescriptions.RejectInputOnFirstFailure = false;
            texPartsDescriptions.ResetOnPrompt = true;
            texPartsDescriptions.ResetOnSpace = true;
            texPartsDescriptions.RightToLeft = RightToLeft.No;
            texPartsDescriptions.SelectedText = "";
            texPartsDescriptions.SelectionLength = 0;
            texPartsDescriptions.SelectionStart = 0;
            texPartsDescriptions.ShortcutsEnabled = true;
            texPartsDescriptions.Size = new Size(575, 48);
            texPartsDescriptions.SkipLiterals = true;
            texPartsDescriptions.TabIndex = 1;
            texPartsDescriptions.TabStop = false;
            texPartsDescriptions.TextAlign = HorizontalAlignment.Left;
            texPartsDescriptions.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPartsDescriptions.TrailingIcon = null;
            texPartsDescriptions.UseSystemPasswordChar = false;
            texPartsDescriptions.ValidatingType = null;
            // 
            // texPartsNaame
            // 
            texPartsNaame.AllowPromptAsInput = true;
            texPartsNaame.AnimateReadOnly = false;
            texPartsNaame.AsciiOnly = false;
            texPartsNaame.BackgroundImageLayout = ImageLayout.None;
            texPartsNaame.BeepOnError = false;
            texPartsNaame.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPartsNaame.Depth = 0;
            texPartsNaame.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPartsNaame.HidePromptOnLeave = false;
            texPartsNaame.HideSelection = true;
            texPartsNaame.Hint = "Name";
            texPartsNaame.InsertKeyMode = InsertKeyMode.Default;
            texPartsNaame.LeadingIcon = null;
            texPartsNaame.Location = new Point(20, 25);
            texPartsNaame.Mask = "";
            texPartsNaame.MaxLength = 32767;
            texPartsNaame.MouseState = MaterialSkin.MouseState.OUT;
            texPartsNaame.Name = "texPartsNaame";
            texPartsNaame.PasswordChar = '\0';
            texPartsNaame.PrefixSuffixText = null;
            texPartsNaame.PromptChar = '_';
            texPartsNaame.ReadOnly = false;
            texPartsNaame.RejectInputOnFirstFailure = false;
            texPartsNaame.ResetOnPrompt = true;
            texPartsNaame.ResetOnSpace = true;
            texPartsNaame.RightToLeft = RightToLeft.No;
            texPartsNaame.SelectedText = "";
            texPartsNaame.SelectionLength = 0;
            texPartsNaame.SelectionStart = 0;
            texPartsNaame.ShortcutsEnabled = true;
            texPartsNaame.Size = new Size(261, 48);
            texPartsNaame.SkipLiterals = true;
            texPartsNaame.TabIndex = 0;
            texPartsNaame.TabStop = false;
            texPartsNaame.TextAlign = HorizontalAlignment.Left;
            texPartsNaame.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPartsNaame.TrailingIcon = null;
            texPartsNaame.UseSystemPasswordChar = false;
            texPartsNaame.ValidatingType = null;
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxCarPats).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartsNaame;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartsDescriptions;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartsPrice;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartsCategory;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartsQty;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox6;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartBrandName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartsCarModel;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartsImageUrl;
        private PictureBox imgBoxCarPats;
        private MaterialSkin.Controls.MaterialButton btnPartImageUpload;
        private MaterialSkin.Controls.MaterialButton btnPartsClear;
        private MaterialSkin.Controls.MaterialButton btnPartsSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
