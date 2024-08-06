namespace car_traders
{
    partial class CarUpdateModelForm
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
            imgBoxCar = new PictureBox();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            texBodyType = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texManufacturingYear = new MaterialSkin.Controls.MaterialMaskedTextBox();
            comboTransmission = new MaterialSkin.Controls.MaterialComboBox();
            comboFueltype = new MaterialSkin.Controls.MaterialComboBox();
            texPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texMileage = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarModelName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texDescription = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texsellerMobileNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texSellerAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texSellerName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarColor = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarBrand = new MaterialSkin.Controls.MaterialMaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxCar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(imgBoxCar);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(texBodyType);
            panel1.Controls.Add(texManufacturingYear);
            panel1.Controls.Add(comboTransmission);
            panel1.Controls.Add(comboFueltype);
            panel1.Controls.Add(texPrice);
            panel1.Controls.Add(texMileage);
            panel1.Controls.Add(texCarModelName);
            panel1.Controls.Add(texDescription);
            panel1.Controls.Add(texsellerMobileNum);
            panel1.Controls.Add(texSellerAddress);
            panel1.Controls.Add(texSellerName);
            panel1.Controls.Add(texCarColor);
            panel1.Controls.Add(texCarBrand);
            panel1.Location = new Point(19, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 691);
            panel1.TabIndex = 0;
            // 
            // imgBoxCar
            // 
            imgBoxCar.BorderStyle = BorderStyle.FixedSingle;
            imgBoxCar.Location = new Point(22, 27);
            imgBoxCar.Name = "imgBoxCar";
            imgBoxCar.Size = new Size(263, 232);
            imgBoxCar.TabIndex = 41;
            imgBoxCar.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(819, 609);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(66, 36);
            btnClear.TabIndex = 40;
            btnClear.Text = "Clear";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(732, 609);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(77, 36);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            texBodyType.Location = new Point(622, 185);
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
            texBodyType.TabIndex = 38;
            texBodyType.TabStop = false;
            texBodyType.TextAlign = HorizontalAlignment.Left;
            texBodyType.TextMaskFormat = MaskFormat.IncludeLiterals;
            texBodyType.TrailingIcon = null;
            texBodyType.UseSystemPasswordChar = false;
            texBodyType.ValidatingType = null;
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
            texManufacturingYear.Location = new Point(622, 108);
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
            texManufacturingYear.TabIndex = 28;
            texManufacturingYear.TabStop = false;
            texManufacturingYear.TextAlign = HorizontalAlignment.Left;
            texManufacturingYear.TextMaskFormat = MaskFormat.IncludeLiterals;
            texManufacturingYear.TrailingIcon = null;
            texManufacturingYear.UseSystemPasswordChar = false;
            texManufacturingYear.ValidatingType = null;
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
            comboTransmission.Location = new Point(622, 267);
            comboTransmission.MaxDropDownItems = 4;
            comboTransmission.MouseState = MaterialSkin.MouseState.OUT;
            comboTransmission.Name = "comboTransmission";
            comboTransmission.Size = new Size(263, 49);
            comboTransmission.StartIndex = 0;
            comboTransmission.TabIndex = 37;
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
            comboFueltype.Location = new Point(320, 267);
            comboFueltype.MaxDropDownItems = 4;
            comboFueltype.MouseState = MaterialSkin.MouseState.OUT;
            comboFueltype.Name = "comboFueltype";
            comboFueltype.Size = new Size(263, 49);
            comboFueltype.StartIndex = 0;
            comboFueltype.TabIndex = 36;
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
            texPrice.Location = new Point(22, 268);
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
            texPrice.TabIndex = 35;
            texPrice.TabStop = false;
            texPrice.TextAlign = HorizontalAlignment.Left;
            texPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPrice.TrailingIcon = null;
            texPrice.UseSystemPasswordChar = false;
            texPrice.ValidatingType = null;
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
            texMileage.Location = new Point(320, 185);
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
            texMileage.TabIndex = 34;
            texMileage.TabStop = false;
            texMileage.TextAlign = HorizontalAlignment.Left;
            texMileage.TextMaskFormat = MaskFormat.IncludeLiterals;
            texMileage.TrailingIcon = null;
            texMileage.UseSystemPasswordChar = false;
            texMileage.ValidatingType = null;
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
            texCarModelName.Location = new Point(320, 108);
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
            texCarModelName.TabIndex = 33;
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
            texDescription.Location = new Point(22, 528);
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
            texDescription.Size = new Size(863, 48);
            texDescription.SkipLiterals = true;
            texDescription.TabIndex = 32;
            texDescription.TabStop = false;
            texDescription.TextAlign = HorizontalAlignment.Left;
            texDescription.TextMaskFormat = MaskFormat.IncludeLiterals;
            texDescription.TrailingIcon = null;
            texDescription.UseSystemPasswordChar = false;
            texDescription.ValidatingType = null;
            texDescription.Click += texDescription_Click;
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
            texsellerMobileNum.Location = new Point(622, 351);
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
            texsellerMobileNum.Size = new Size(272, 48);
            texsellerMobileNum.SkipLiterals = true;
            texsellerMobileNum.TabIndex = 31;
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
            texSellerAddress.Location = new Point(22, 444);
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
            texSellerAddress.Size = new Size(872, 48);
            texSellerAddress.SkipLiterals = true;
            texSellerAddress.TabIndex = 30;
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
            texSellerName.Location = new Point(22, 351);
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
            texSellerName.Size = new Size(561, 48);
            texSellerName.SkipLiterals = true;
            texSellerName.TabIndex = 29;
            texSellerName.TabStop = false;
            texSellerName.TextAlign = HorizontalAlignment.Left;
            texSellerName.TextMaskFormat = MaskFormat.IncludeLiterals;
            texSellerName.TrailingIcon = null;
            texSellerName.UseSystemPasswordChar = false;
            texSellerName.ValidatingType = null;
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
            texCarColor.Location = new Point(622, 27);
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
            texCarColor.TabIndex = 27;
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
            texCarBrand.Location = new Point(320, 27);
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
            texCarBrand.TabIndex = 26;
            texCarBrand.TabStop = false;
            texCarBrand.TextAlign = HorizontalAlignment.Left;
            texCarBrand.TextMaskFormat = MaskFormat.IncludeLiterals;
            texCarBrand.TrailingIcon = null;
            texCarBrand.UseSystemPasswordChar = false;
            texCarBrand.ValidatingType = null;
            texCarBrand.Click += texCarBrand_Click;
            // 
            // CarUpdateModelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 796);
            Controls.Add(panel1);
            Name = "CarUpdateModelForm";
            Text = "Car Details Update";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox texBodyType;
        private MaterialSkin.Controls.MaterialComboBox comboTransmission;
        private MaterialSkin.Controls.MaterialComboBox comboFueltype;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPrice;
        private MaterialSkin.Controls.MaterialMaskedTextBox texMileage;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarModelName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texDescription;
        private MaterialSkin.Controls.MaterialMaskedTextBox texsellerMobileNum;
        private MaterialSkin.Controls.MaterialMaskedTextBox texSellerAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox texSellerName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texManufacturingYear;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarColor;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarBrand;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private PictureBox imgBoxCar;
    }
}