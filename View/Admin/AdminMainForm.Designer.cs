namespace car_traders
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabDashboard = new TabPage();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            imageList1 = new ImageList(components);
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            panel1 = new Panel();
            lblCustomerCount = new Label();
            label4 = new Label();
            materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            panel3 = new Panel();
            lblCarCount = new Label();
            label6 = new Label();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            panel2 = new Panel();
            lblPartsCoun = new Label();
            label5 = new Label();
            tabAddCar = new TabPage();
            label7 = new Label();
            dateTimeCarManuFact = new DateTimePicker();
            label3 = new Label();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnUploadImage = new MaterialSkin.Controls.MaterialButton();
            texBodyType = new MaterialSkin.Controls.MaterialMaskedTextBox();
            comboTransmission = new MaterialSkin.Controls.MaterialComboBox();
            comboFueltype = new MaterialSkin.Controls.MaterialComboBox();
            texPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texMileage = new MaterialSkin.Controls.MaterialMaskedTextBox();
            imgBoxCar = new PictureBox();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            texCarModelName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texDescription = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texsellerMobileNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texSellerAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texSellerName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarColor = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texCarBrand = new MaterialSkin.Controls.MaterialMaskedTextBox();
            tabAddCarPats = new TabPage();
            label2 = new Label();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnPartImageUpload = new MaterialSkin.Controls.MaterialButton();
            btnPartsClear = new MaterialSkin.Controls.MaterialButton();
            btnPartsSave = new MaterialSkin.Controls.MaterialButton();
            imgBoxCarPats = new PictureBox();
            texPartBrandName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsCarModel = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsCategory = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsQty = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsDescriptions = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPartsNaame = new MaterialSkin.Controls.MaterialMaskedTextBox();
            tabViewCars = new TabPage();
            tblListViewCar = new MaterialSkin.Controls.MaterialListView();
            colCarBrand = new ColumnHeader();
            colColor = new ColumnHeader();
            colManuFactYear = new ColumnHeader();
            colModel = new ColumnHeader();
            colMileage = new ColumnHeader();
            colTransmission = new ColumnHeader();
            colBodyType = new ColumnHeader();
            colCarStatus = new ColumnHeader();
            colCarPrice = new ColumnHeader();
            colCarID = new ColumnHeader();
            texCarTableSearch = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lblCar = new Label();
            tabViewPats = new TabPage();
            carPartsListView = new MaterialSkin.Controls.MaterialListView();
            colName = new ColumnHeader();
            colPrice = new ColumnHeader();
            colQty = new ColumnHeader();
            colCategory = new ColumnHeader();
            colMode = new ColumnHeader();
            colBrand = new ColumnHeader();
            colStatus = new ColumnHeader();
            colID = new ColumnHeader();
            texSearchCarPartTabl = new MaterialSkin.Controls.MaterialMaskedTextBox();
            label1 = new Label();
            btnPrintPartList = new MaterialSkin.Controls.MaterialButton();
            materialTabControl1.SuspendLayout();
            tabDashboard.SuspendLayout();
            materialCard1.SuspendLayout();
            panel1.SuspendLayout();
            materialCard3.SuspendLayout();
            panel3.SuspendLayout();
            materialCard2.SuspendLayout();
            panel2.SuspendLayout();
            tabAddCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxCar).BeginInit();
            tabAddCarPats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxCarPats).BeginInit();
            tabViewCars.SuspendLayout();
            tabViewPats.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabDashboard);
            materialTabControl1.Controls.Add(tabAddCar);
            materialTabControl1.Controls.Add(tabAddCarPats);
            materialTabControl1.Controls.Add(tabViewCars);
            materialTabControl1.Controls.Add(tabViewPats);
            materialTabControl1.Cursor = Cursors.Hand;
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1002, 719);
            materialTabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(materialFloatingActionButton1);
            tabDashboard.Controls.Add(materialCard1);
            tabDashboard.Controls.Add(materialFloatingActionButton3);
            tabDashboard.Controls.Add(materialCard3);
            tabDashboard.Controls.Add(materialFloatingActionButton2);
            tabDashboard.Controls.Add(materialCard2);
            tabDashboard.ImageKey = "home.png";
            tabDashboard.Location = new Point(4, 39);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(994, 676);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.Click += tabDashboard_Click;
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.BackColor = Color.White;
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = Properties.Resources.dashboardPart;
            materialFloatingActionButton1.ImageIndex = 6;
            materialFloatingActionButton1.ImageList = imageList1;
            materialFloatingActionButton1.Location = new Point(243, 68);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(58, 62);
            materialFloatingActionButton1.TabIndex = 15;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "sports-car.png");
            imageList1.Images.SetKeyName(1, "home.png");
            imageList1.Images.SetKeyName(2, "racing.png");
            imageList1.Images.SetKeyName(3, "carList.png");
            imageList1.Images.SetKeyName(4, "parts.png");
            imageList1.Images.SetKeyName(5, "dashboardHumen.png");
            imageList1.Images.SetKeyName(6, "dashboardPart.png");
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(panel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(41, 37);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(233, 123);
            materialCard1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(lblCustomerCount);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 124);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.AutoSize = true;
            lblCustomerCount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerCount.ForeColor = Color.Gainsboro;
            lblCustomerCount.Location = new Point(17, 55);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new Size(0, 38);
            lblCustomerCount.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(6, 6);
            label4.Name = "label4";
            label4.Size = new Size(151, 38);
            label4.TabIndex = 13;
            label4.Text = "Customers";
            label4.Click += label4_Click;
            // 
            // materialFloatingActionButton3
            // 
            materialFloatingActionButton3.BackColor = Color.White;
            materialFloatingActionButton3.Depth = 0;
            materialFloatingActionButton3.Icon = Properties.Resources.dashBoardCar;
            materialFloatingActionButton3.ImageIndex = 0;
            materialFloatingActionButton3.ImageList = imageList1;
            materialFloatingActionButton3.Location = new Point(846, 68);
            materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            materialFloatingActionButton3.Size = new Size(58, 62);
            materialFloatingActionButton3.TabIndex = 12;
            materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            materialFloatingActionButton3.UseVisualStyleBackColor = false;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(panel3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(644, 37);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(233, 123);
            materialCard3.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumAquamarine;
            panel3.Controls.Add(lblCarCount);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 123);
            panel3.TabIndex = 18;
            // 
            // lblCarCount
            // 
            lblCarCount.AutoSize = true;
            lblCarCount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarCount.ForeColor = Color.Gainsboro;
            lblCarCount.Location = new Point(3, 44);
            lblCarCount.Name = "lblCarCount";
            lblCarCount.Size = new Size(0, 38);
            lblCarCount.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(5, 6);
            label6.Name = "label6";
            label6.Size = new Size(59, 38);
            label6.TabIndex = 15;
            label6.Text = "Car";
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.BackColor = Color.White;
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = Properties.Resources.dashboardPart;
            materialFloatingActionButton2.ImageIndex = 6;
            materialFloatingActionButton2.ImageList = imageList1;
            materialFloatingActionButton2.Location = new Point(539, 68);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(58, 62);
            materialFloatingActionButton2.TabIndex = 10;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(panel2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(337, 37);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(233, 123);
            materialCard2.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkTurquoise;
            panel2.Controls.Add(lblPartsCoun);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(-6, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 123);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // lblPartsCoun
            // 
            lblPartsCoun.AutoSize = true;
            lblPartsCoun.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPartsCoun.ForeColor = Color.Gainsboro;
            lblPartsCoun.Location = new Point(10, 55);
            lblPartsCoun.Name = "lblPartsCoun";
            lblPartsCoun.Size = new Size(0, 38);
            lblPartsCoun.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(10, 6);
            label5.Name = "label5";
            label5.Size = new Size(80, 38);
            label5.TabIndex = 14;
            label5.Text = "Parts";
            // 
            // tabAddCar
            // 
            tabAddCar.Controls.Add(label7);
            tabAddCar.Controls.Add(dateTimeCarManuFact);
            tabAddCar.Controls.Add(label3);
            tabAddCar.Controls.Add(materialLabel1);
            tabAddCar.Controls.Add(btnUploadImage);
            tabAddCar.Controls.Add(texBodyType);
            tabAddCar.Controls.Add(comboTransmission);
            tabAddCar.Controls.Add(comboFueltype);
            tabAddCar.Controls.Add(texPrice);
            tabAddCar.Controls.Add(texMileage);
            tabAddCar.Controls.Add(imgBoxCar);
            tabAddCar.Controls.Add(btnClear);
            tabAddCar.Controls.Add(btnSave);
            tabAddCar.Controls.Add(texCarModelName);
            tabAddCar.Controls.Add(texDescription);
            tabAddCar.Controls.Add(texsellerMobileNum);
            tabAddCar.Controls.Add(texSellerAddress);
            tabAddCar.Controls.Add(texSellerName);
            tabAddCar.Controls.Add(texCarColor);
            tabAddCar.Controls.Add(texCarBrand);
            tabAddCar.ImageKey = "sports-car.png";
            tabAddCar.Location = new Point(4, 39);
            tabAddCar.Name = "tabAddCar";
            tabAddCar.Padding = new Padding(3);
            tabAddCar.Size = new Size(994, 676);
            tabAddCar.TabIndex = 1;
            tabAddCar.Text = "Add Car";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(602, 99);
            label7.Name = "label7";
            label7.Size = new Size(164, 25);
            label7.TabIndex = 55;
            label7.Text = "Manufacturing Year";
            // 
            // dateTimeCarManuFact
            // 
            dateTimeCarManuFact.Location = new Point(601, 66);
            dateTimeCarManuFact.Name = "dateTimeCarManuFact";
            dateTimeCarManuFact.Size = new Size(300, 31);
            dateTimeCarManuFact.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(17, 17);
            label3.Name = "label3";
            label3.Size = new Size(179, 25);
            label3.TabIndex = 24;
            label3.Text = "ADD CAR DETAILS |";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(668, 598);
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
            btnUploadImage.Location = new Point(668, 623);
            btnUploadImage.Margin = new Padding(4, 6, 4, 6);
            btnUploadImage.MouseState = MaterialSkin.MouseState.HOVER;
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.NoAccentTextColor = Color.Empty;
            btnUploadImage.Size = new Size(128, 36);
            btnUploadImage.TabIndex = 17;
            btnUploadImage.Text = "Choose Image";
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
            texBodyType.Location = new Point(17, 363);
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
            comboTransmission.Location = new Point(601, 283);
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
            comboFueltype.Location = new Point(311, 282);
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
            texPrice.Location = new Point(311, 363);
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
            texMileage.Location = new Point(17, 283);
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
            // imgBoxCar
            // 
            imgBoxCar.BorderStyle = BorderStyle.FixedSingle;
            imgBoxCar.Location = new Point(601, 363);
            imgBoxCar.Name = "imgBoxCar";
            imgBoxCar.Size = new Size(263, 232);
            imgBoxCar.TabIndex = 10;
            imgBoxCar.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(492, 460);
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
            btnSave.Location = new Point(405, 460);
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
            texCarModelName.Location = new Point(17, 136);
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
            texDescription.Location = new Point(311, 136);
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
            texsellerMobileNum.Location = new Point(601, 207);
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
            texSellerAddress.Location = new Point(311, 207);
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
            texSellerName.Location = new Point(17, 207);
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
            texCarColor.Location = new Point(311, 66);
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
            texCarBrand.Location = new Point(17, 66);
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
            // tabAddCarPats
            // 
            tabAddCarPats.Controls.Add(label2);
            tabAddCarPats.Controls.Add(materialLabel2);
            tabAddCarPats.Controls.Add(btnPartImageUpload);
            tabAddCarPats.Controls.Add(btnPartsClear);
            tabAddCarPats.Controls.Add(btnPartsSave);
            tabAddCarPats.Controls.Add(imgBoxCarPats);
            tabAddCarPats.Controls.Add(texPartBrandName);
            tabAddCarPats.Controls.Add(texPartsCarModel);
            tabAddCarPats.Controls.Add(texPartsCategory);
            tabAddCarPats.Controls.Add(texPartsQty);
            tabAddCarPats.Controls.Add(texPartsPrice);
            tabAddCarPats.Controls.Add(texPartsDescriptions);
            tabAddCarPats.Controls.Add(texPartsNaame);
            tabAddCarPats.ImageKey = "racing.png";
            tabAddCarPats.Location = new Point(4, 39);
            tabAddCarPats.Name = "tabAddCarPats";
            tabAddCarPats.Size = new Size(994, 676);
            tabAddCarPats.TabIndex = 2;
            tabAddCarPats.Text = "Add Car Parts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(23, 23);
            label2.Name = "label2";
            label2.Size = new Size(240, 25);
            label2.TabIndex = 23;
            label2.Text = "ADD CAR PARTS DETAILS |";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(713, 479);
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
            btnPartImageUpload.Location = new Point(713, 504);
            btnPartImageUpload.Margin = new Padding(4, 6, 4, 6);
            btnPartImageUpload.MouseState = MaterialSkin.MouseState.HOVER;
            btnPartImageUpload.Name = "btnPartImageUpload";
            btnPartImageUpload.NoAccentTextColor = Color.Empty;
            btnPartImageUpload.Size = new Size(128, 36);
            btnPartImageUpload.TabIndex = 21;
            btnPartImageUpload.Text = "Choose Image";
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
            btnPartsClear.Location = new Point(502, 394);
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
            btnPartsClear.Click += btnPartsClear_Click;
            // 
            // btnPartsSave
            // 
            btnPartsSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPartsSave.BackColor = Color.Transparent;
            btnPartsSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPartsSave.Depth = 0;
            btnPartsSave.HighEmphasis = true;
            btnPartsSave.Icon = null;
            btnPartsSave.Location = new Point(415, 394);
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
            imgBoxCarPats.BorderStyle = BorderStyle.FixedSingle;
            imgBoxCarPats.Location = new Point(632, 237);
            imgBoxCarPats.Name = "imgBoxCarPats";
            imgBoxCarPats.Size = new Size(263, 232);
            imgBoxCarPats.TabIndex = 11;
            imgBoxCarPats.TabStop = false;
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
            texPartBrandName.Location = new Point(318, 237);
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
            texPartsCarModel.Location = new Point(23, 237);
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
            texPartsCategory.Location = new Point(632, 157);
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
            texPartsQty.Location = new Point(318, 157);
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
            texPartsPrice.Location = new Point(23, 157);
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
            texPartsDescriptions.Location = new Point(318, 85);
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
            texPartsNaame.Location = new Point(23, 85);
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
            // tabViewCars
            // 
            tabViewCars.Controls.Add(tblListViewCar);
            tabViewCars.Controls.Add(texCarTableSearch);
            tabViewCars.Controls.Add(lblCar);
            tabViewCars.ImageKey = "carList.png";
            tabViewCars.Location = new Point(4, 39);
            tabViewCars.Name = "tabViewCars";
            tabViewCars.Size = new Size(994, 676);
            tabViewCars.TabIndex = 3;
            tabViewCars.Text = "View Cars";
            // 
            // tblListViewCar
            // 
            tblListViewCar.AutoSizeTable = false;
            tblListViewCar.BackColor = Color.FromArgb(255, 255, 255);
            tblListViewCar.BorderStyle = BorderStyle.None;
            tblListViewCar.Columns.AddRange(new ColumnHeader[] { colCarBrand, colColor, colManuFactYear, colModel, colMileage, colTransmission, colBodyType, colCarStatus, colCarPrice, colCarID });
            tblListViewCar.Depth = 0;
            tblListViewCar.FullRowSelect = true;
            tblListViewCar.Location = new Point(22, 162);
            tblListViewCar.MinimumSize = new Size(200, 100);
            tblListViewCar.MouseLocation = new Point(-1, -1);
            tblListViewCar.MouseState = MaterialSkin.MouseState.OUT;
            tblListViewCar.Name = "tblListViewCar";
            tblListViewCar.OwnerDraw = true;
            tblListViewCar.Size = new Size(924, 477);
            tblListViewCar.TabIndex = 3;
            tblListViewCar.UseCompatibleStateImageBehavior = false;
            tblListViewCar.View = System.Windows.Forms.View.Details;
            tblListViewCar.SelectedIndexChanged += tblListViewCar_SelectedIndexChanged;
            // 
            // colCarBrand
            // 
            colCarBrand.Text = "Brand Name";
            colCarBrand.Width = 150;
            // 
            // colColor
            // 
            colColor.Text = "Color";
            // 
            // colManuFactYear
            // 
            colManuFactYear.Text = "Year";
            colManuFactYear.Width = 80;
            // 
            // colModel
            // 
            colModel.Text = "Model Name";
            // 
            // colMileage
            // 
            colMileage.Text = "Mileage";
            colMileage.Width = 100;
            // 
            // colTransmission
            // 
            colTransmission.Text = "Transmission";
            colTransmission.Width = 100;
            // 
            // colBodyType
            // 
            colBodyType.Text = "Body type";
            colBodyType.Width = 100;
            // 
            // colCarStatus
            // 
            colCarStatus.Text = "Status";
            colCarStatus.Width = 90;
            // 
            // colCarPrice
            // 
            colCarPrice.DisplayIndex = 9;
            colCarPrice.Text = "Price";
            colCarPrice.Width = 1500;
            // 
            // colCarID
            // 
            colCarID.DisplayIndex = 8;
            colCarID.Text = "carId";
            colCarID.Width = 0;
            // 
            // texCarTableSearch
            // 
            texCarTableSearch.AllowPromptAsInput = true;
            texCarTableSearch.AnimateReadOnly = false;
            texCarTableSearch.AsciiOnly = false;
            texCarTableSearch.BackgroundImageLayout = ImageLayout.None;
            texCarTableSearch.BeepOnError = false;
            texCarTableSearch.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texCarTableSearch.Depth = 0;
            texCarTableSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texCarTableSearch.HidePromptOnLeave = false;
            texCarTableSearch.HideSelection = true;
            texCarTableSearch.Hint = "Search ";
            texCarTableSearch.InsertKeyMode = InsertKeyMode.Default;
            texCarTableSearch.LeadingIcon = null;
            texCarTableSearch.Location = new Point(670, 73);
            texCarTableSearch.Mask = "";
            texCarTableSearch.MaxLength = 32767;
            texCarTableSearch.MouseState = MaterialSkin.MouseState.OUT;
            texCarTableSearch.Name = "texCarTableSearch";
            texCarTableSearch.PasswordChar = '\0';
            texCarTableSearch.PrefixSuffixText = null;
            texCarTableSearch.PromptChar = '_';
            texCarTableSearch.ReadOnly = false;
            texCarTableSearch.RejectInputOnFirstFailure = false;
            texCarTableSearch.ResetOnPrompt = true;
            texCarTableSearch.ResetOnSpace = true;
            texCarTableSearch.RightToLeft = RightToLeft.No;
            texCarTableSearch.SelectedText = "";
            texCarTableSearch.SelectionLength = 0;
            texCarTableSearch.SelectionStart = 0;
            texCarTableSearch.ShortcutsEnabled = true;
            texCarTableSearch.Size = new Size(276, 48);
            texCarTableSearch.SkipLiterals = true;
            texCarTableSearch.TabIndex = 2;
            texCarTableSearch.TabStop = false;
            texCarTableSearch.TextAlign = HorizontalAlignment.Left;
            texCarTableSearch.TextMaskFormat = MaskFormat.IncludeLiterals;
            texCarTableSearch.TrailingIcon = null;
            texCarTableSearch.UseSystemPasswordChar = false;
            texCarTableSearch.ValidatingType = null;
            texCarTableSearch.KeyUp += searchCarTableLoadData;
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.BackColor = SystemColors.Control;
            lblCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCar.ForeColor = Color.SlateGray;
            lblCar.Location = new Point(22, 15);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(100, 25);
            lblCar.TabIndex = 0;
            lblCar.Text = "CAR LIST |";
            // 
            // tabViewPats
            // 
            tabViewPats.Controls.Add(btnPrintPartList);
            tabViewPats.Controls.Add(carPartsListView);
            tabViewPats.Controls.Add(texSearchCarPartTabl);
            tabViewPats.Controls.Add(label1);
            tabViewPats.ImageKey = "parts.png";
            tabViewPats.Location = new Point(4, 39);
            tabViewPats.Name = "tabViewPats";
            tabViewPats.Size = new Size(994, 676);
            tabViewPats.TabIndex = 4;
            tabViewPats.Text = "View Parts";
            tabViewPats.Click += tabViewPats_Click;
            // 
            // carPartsListView
            // 
            carPartsListView.AutoSizeTable = false;
            carPartsListView.BackColor = Color.FromArgb(255, 255, 255);
            carPartsListView.BorderStyle = BorderStyle.None;
            carPartsListView.Columns.AddRange(new ColumnHeader[] { colName, colPrice, colQty, colCategory, colMode, colBrand, colStatus, colID });
            carPartsListView.Depth = 0;
            carPartsListView.FullRowSelect = true;
            carPartsListView.Location = new Point(14, 137);
            carPartsListView.MinimumSize = new Size(200, 100);
            carPartsListView.MouseLocation = new Point(-1, -1);
            carPartsListView.MouseState = MaterialSkin.MouseState.OUT;
            carPartsListView.Name = "carPartsListView";
            carPartsListView.OwnerDraw = true;
            carPartsListView.Size = new Size(942, 478);
            carPartsListView.TabIndex = 34;
            carPartsListView.UseCompatibleStateImageBehavior = false;
            carPartsListView.View = System.Windows.Forms.View.Details;
            carPartsListView.SelectedIndexChanged += carPartListViewRowSelect;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 150;
            // 
            // colPrice
            // 
            colPrice.Text = "Price";
            colPrice.Width = 100;
            // 
            // colQty
            // 
            colQty.Text = "Qty";
            colQty.Width = 80;
            // 
            // colCategory
            // 
            colCategory.Text = "Category";
            colCategory.Width = 100;
            // 
            // colMode
            // 
            colMode.Text = "Car Model";
            colMode.Width = 150;
            // 
            // colBrand
            // 
            colBrand.Text = "Brand";
            colBrand.Width = 150;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 100;
            // 
            // colID
            // 
            colID.Text = "id";
            colID.Width = 0;
            // 
            // texSearchCarPartTabl
            // 
            texSearchCarPartTabl.AllowPromptAsInput = true;
            texSearchCarPartTabl.AnimateReadOnly = false;
            texSearchCarPartTabl.AsciiOnly = false;
            texSearchCarPartTabl.BackgroundImageLayout = ImageLayout.None;
            texSearchCarPartTabl.BeepOnError = false;
            texSearchCarPartTabl.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texSearchCarPartTabl.Depth = 0;
            texSearchCarPartTabl.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texSearchCarPartTabl.HidePromptOnLeave = false;
            texSearchCarPartTabl.HideSelection = true;
            texSearchCarPartTabl.Hint = "Search";
            texSearchCarPartTabl.InsertKeyMode = InsertKeyMode.Default;
            texSearchCarPartTabl.LeadingIcon = null;
            texSearchCarPartTabl.Location = new Point(567, 72);
            texSearchCarPartTabl.Mask = "";
            texSearchCarPartTabl.MaxLength = 32767;
            texSearchCarPartTabl.MouseState = MaterialSkin.MouseState.OUT;
            texSearchCarPartTabl.Name = "texSearchCarPartTabl";
            texSearchCarPartTabl.PasswordChar = '\0';
            texSearchCarPartTabl.PrefixSuffixText = null;
            texSearchCarPartTabl.PromptChar = '_';
            texSearchCarPartTabl.ReadOnly = false;
            texSearchCarPartTabl.RejectInputOnFirstFailure = false;
            texSearchCarPartTabl.ResetOnPrompt = true;
            texSearchCarPartTabl.ResetOnSpace = true;
            texSearchCarPartTabl.RightToLeft = RightToLeft.No;
            texSearchCarPartTabl.SelectedText = "";
            texSearchCarPartTabl.SelectionLength = 0;
            texSearchCarPartTabl.SelectionStart = 0;
            texSearchCarPartTabl.ShortcutsEnabled = true;
            texSearchCarPartTabl.Size = new Size(375, 48);
            texSearchCarPartTabl.SkipLiterals = true;
            texSearchCarPartTabl.TabIndex = 4;
            texSearchCarPartTabl.TabStop = false;
            texSearchCarPartTabl.TextAlign = HorizontalAlignment.Left;
            texSearchCarPartTabl.TextMaskFormat = MaskFormat.IncludeLiterals;
            texSearchCarPartTabl.TrailingIcon = null;
            texSearchCarPartTabl.UseSystemPasswordChar = false;
            texSearchCarPartTabl.ValidatingType = null;
            texSearchCarPartTabl.KeyUp += searchTableCarParts;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateGray;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 1;
            label1.Text = "CAR PARTS LIST |";
            // 
            // btnPrintPartList
            // 
            btnPrintPartList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrintPartList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPrintPartList.Depth = 0;
            btnPrintPartList.HighEmphasis = true;
            btnPrintPartList.Icon = (Image)resources.GetObject("btnPrintPartList.Icon");
            btnPrintPartList.Image = (Image)resources.GetObject("btnPrintPartList.Image");
            btnPrintPartList.Location = new Point(17, 84);
            btnPrintPartList.Margin = new Padding(4, 6, 4, 6);
            btnPrintPartList.MouseState = MaterialSkin.MouseState.HOVER;
            btnPrintPartList.Name = "btnPrintPartList";
            btnPrintPartList.NoAccentTextColor = Color.Empty;
            btnPrintPartList.Size = new Size(64, 36);
            btnPrintPartList.TabIndex = 35;
            btnPrintPartList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPrintPartList.UseAccentColor = false;
            btnPrintPartList.UseVisualStyleBackColor = true;
            btnPrintPartList.Click += btnPrintPartList_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 786);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "AdminMainForm";
            Text = "CAR TRADERS";
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialCard3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            materialCard2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabAddCar.ResumeLayout(false);
            tabAddCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxCar).EndInit();
            tabAddCarPats.ResumeLayout(false);
            tabAddCarPats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxCarPats).EndInit();
            tabViewCars.ResumeLayout(false);
            tabViewCars.PerformLayout();
            tabViewPats.ResumeLayout(false);
            tabViewPats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabDashboard;
        private ImageList imageList1;
        private TabPage tabAddCarPats;
        private TabPage tabAddCar;
        private MaterialSkin.Controls.MaterialMaskedTextBox texsellerMobileNum;
        private MaterialSkin.Controls.MaterialMaskedTextBox texSellerAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox texSellerName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarColor;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarBrand;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarModelName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texDescription;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private PictureBox imgBoxCar;
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
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartBrandName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPartsCarModel;
        private PictureBox imgBoxCarPats;
        private MaterialSkin.Controls.MaterialButton btnPartImageUpload;
        private MaterialSkin.Controls.MaterialButton btnPartsClear;
        private MaterialSkin.Controls.MaterialButton btnPartsSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TabPage tabViewCars;
        private TabPage tabViewPats;
        private Label lblCar;
        private Label label2;
        private Label label1;
        private Label label3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblCarCount;
        private Label lblPartsCoun;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblCustomerCount;
        private MaterialSkin.Controls.MaterialMaskedTextBox texCarTableSearch;
        private MaterialSkin.Controls.MaterialMaskedTextBox texSearchCarPartTabl;
        private MaterialSkin.Controls.MaterialListView carPartsListView;
        private ColumnHeader colName;
        private ColumnHeader colPrice;
        private ColumnHeader colQty;
        private ColumnHeader colCategory;
        private ColumnHeader colMode;
        private ColumnHeader colBrand;
        private ColumnHeader colStatus;
        private ColumnHeader colID;
        private MaterialSkin.Controls.MaterialListView tblListViewCar;
        private ColumnHeader colCarBrand;
        private ColumnHeader colColor;
        private ColumnHeader colManuFactYear;
        private ColumnHeader colModel;
        private ColumnHeader colMileage;
        private ColumnHeader colTransmission;
        private ColumnHeader colBodyType;
        private ColumnHeader colCarStatus;
        private ColumnHeader colCarID;
        private ColumnHeader colCarPrice;
        private DateTimePicker dateTimeCarManuFact;
        private Label label7;
        private MaterialSkin.Controls.MaterialButton btnPrintPartList;
    }
}
