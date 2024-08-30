namespace car_traders.View.View_Customer.View_Profile
{
    partial class ViewProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProfileForm));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pwView = new PictureBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblUserName = new Label();
            lblAddress = new Label();
            lblMobileNum = new Label();
            lblName = new Label();
            texUserName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texContactNum = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pwView).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pwView);
            materialCard1.Controls.Add(lblPassword);
            materialCard1.Controls.Add(lblEmail);
            materialCard1.Controls.Add(lblUserName);
            materialCard1.Controls.Add(lblAddress);
            materialCard1.Controls.Add(lblMobileNum);
            materialCard1.Controls.Add(lblName);
            materialCard1.Controls.Add(texUserName);
            materialCard1.Controls.Add(texPassword);
            materialCard1.Controls.Add(texEmail);
            materialCard1.Controls.Add(texAddress);
            materialCard1.Controls.Add(texContactNum);
            materialCard1.Controls.Add(texName);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(23, 44);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1072, 380);
            materialCard1.TabIndex = 0;
            // 
            // pwView
            // 
            pwView.Image = (Image)resources.GetObject("pwView.Image");
            pwView.Location = new Point(984, 224);
            pwView.Name = "pwView";
            pwView.Size = new Size(34, 34);
            pwView.SizeMode = PictureBoxSizeMode.CenterImage;
            pwView.TabIndex = 40;
            pwView.TabStop = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.Red;
            lblPassword.Location = new Point(552, 261);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(50, 25);
            lblPassword.TabIndex = 39;
            lblPassword.Text = "Error";
            lblPassword.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.Red;
            lblEmail.Location = new Point(17, 261);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 25);
            lblEmail.TabIndex = 38;
            lblEmail.Text = "Error";
            lblEmail.Visible = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.ForeColor = Color.Red;
            lblUserName.Location = new Point(552, 170);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(50, 25);
            lblUserName.TabIndex = 37;
            lblUserName.Text = "Error";
            lblUserName.Visible = false;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = Color.Red;
            lblAddress.Location = new Point(17, 170);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(50, 25);
            lblAddress.TabIndex = 36;
            lblAddress.Text = "Error";
            lblAddress.Visible = false;
            // 
            // lblMobileNum
            // 
            lblMobileNum.AutoSize = true;
            lblMobileNum.ForeColor = Color.Red;
            lblMobileNum.Location = new Point(552, 91);
            lblMobileNum.Name = "lblMobileNum";
            lblMobileNum.Size = new Size(50, 25);
            lblMobileNum.TabIndex = 35;
            lblMobileNum.Text = "Error";
            lblMobileNum.Visible = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.Red;
            lblName.Location = new Point(17, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 25);
            lblName.TabIndex = 34;
            lblName.Text = "Error";
            lblName.Visible = false;
            // 
            // texUserName
            // 
            texUserName.AllowPromptAsInput = true;
            texUserName.AnimateReadOnly = false;
            texUserName.AsciiOnly = false;
            texUserName.BackgroundImageLayout = ImageLayout.None;
            texUserName.BeepOnError = false;
            texUserName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texUserName.Depth = 0;
            texUserName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texUserName.HidePromptOnLeave = false;
            texUserName.HideSelection = true;
            texUserName.Hint = "User Name";
            texUserName.InsertKeyMode = InsertKeyMode.Default;
            texUserName.LeadingIcon = null;
            texUserName.Location = new Point(552, 119);
            texUserName.Mask = "";
            texUserName.MaxLength = 32767;
            texUserName.MouseState = MaterialSkin.MouseState.OUT;
            texUserName.Name = "texUserName";
            texUserName.PasswordChar = '\0';
            texUserName.PrefixSuffixText = null;
            texUserName.PromptChar = '_';
            texUserName.ReadOnly = false;
            texUserName.RejectInputOnFirstFailure = false;
            texUserName.ResetOnPrompt = true;
            texUserName.ResetOnSpace = true;
            texUserName.RightToLeft = RightToLeft.No;
            texUserName.SelectedText = "";
            texUserName.SelectionLength = 0;
            texUserName.SelectionStart = 0;
            texUserName.ShortcutsEnabled = true;
            texUserName.Size = new Size(503, 48);
            texUserName.SkipLiterals = true;
            texUserName.TabIndex = 33;
            texUserName.TabStop = false;
            texUserName.TextAlign = HorizontalAlignment.Left;
            texUserName.TextMaskFormat = MaskFormat.IncludeLiterals;
            texUserName.TrailingIcon = null;
            texUserName.UseSystemPasswordChar = false;
            texUserName.ValidatingType = null;
            // 
            // texPassword
            // 
            texPassword.AllowPromptAsInput = true;
            texPassword.AnimateReadOnly = false;
            texPassword.AsciiOnly = false;
            texPassword.BackgroundImageLayout = ImageLayout.None;
            texPassword.BeepOnError = false;
            texPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPassword.Depth = 0;
            texPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPassword.HidePromptOnLeave = false;
            texPassword.HideSelection = true;
            texPassword.Hint = "Password";
            texPassword.InsertKeyMode = InsertKeyMode.Default;
            texPassword.LeadingIcon = null;
            texPassword.Location = new Point(552, 210);
            texPassword.Mask = "";
            texPassword.MaxLength = 32767;
            texPassword.MouseState = MaterialSkin.MouseState.OUT;
            texPassword.Name = "texPassword";
            texPassword.PasswordChar = '\0';
            texPassword.PrefixSuffixText = null;
            texPassword.PromptChar = '_';
            texPassword.ReadOnly = false;
            texPassword.RejectInputOnFirstFailure = false;
            texPassword.ResetOnPrompt = true;
            texPassword.ResetOnSpace = true;
            texPassword.RightToLeft = RightToLeft.No;
            texPassword.SelectedText = "";
            texPassword.SelectionLength = 0;
            texPassword.SelectionStart = 0;
            texPassword.ShortcutsEnabled = true;
            texPassword.Size = new Size(426, 48);
            texPassword.SkipLiterals = true;
            texPassword.TabIndex = 32;
            texPassword.TabStop = false;
            texPassword.TextAlign = HorizontalAlignment.Left;
            texPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPassword.TrailingIcon = null;
            texPassword.UseSystemPasswordChar = false;
            texPassword.ValidatingType = null;
            // 
            // texEmail
            // 
            texEmail.AllowPromptAsInput = true;
            texEmail.AnimateReadOnly = false;
            texEmail.AsciiOnly = false;
            texEmail.BackgroundImageLayout = ImageLayout.None;
            texEmail.BeepOnError = false;
            texEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texEmail.Depth = 0;
            texEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texEmail.HidePromptOnLeave = false;
            texEmail.HideSelection = true;
            texEmail.Hint = "Email";
            texEmail.InsertKeyMode = InsertKeyMode.Default;
            texEmail.LeadingIcon = null;
            texEmail.Location = new Point(17, 210);
            texEmail.Mask = "";
            texEmail.MaxLength = 32767;
            texEmail.MouseState = MaterialSkin.MouseState.OUT;
            texEmail.Name = "texEmail";
            texEmail.PasswordChar = '\0';
            texEmail.PrefixSuffixText = null;
            texEmail.PromptChar = '_';
            texEmail.ReadOnly = false;
            texEmail.RejectInputOnFirstFailure = false;
            texEmail.ResetOnPrompt = true;
            texEmail.ResetOnSpace = true;
            texEmail.RightToLeft = RightToLeft.No;
            texEmail.SelectedText = "";
            texEmail.SelectionLength = 0;
            texEmail.SelectionStart = 0;
            texEmail.ShortcutsEnabled = true;
            texEmail.Size = new Size(503, 48);
            texEmail.SkipLiterals = true;
            texEmail.TabIndex = 31;
            texEmail.TabStop = false;
            texEmail.TextAlign = HorizontalAlignment.Left;
            texEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            texEmail.TrailingIcon = null;
            texEmail.UseSystemPasswordChar = false;
            texEmail.ValidatingType = null;
            // 
            // texAddress
            // 
            texAddress.AllowPromptAsInput = true;
            texAddress.AnimateReadOnly = false;
            texAddress.AsciiOnly = false;
            texAddress.BackgroundImageLayout = ImageLayout.None;
            texAddress.BeepOnError = false;
            texAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texAddress.Depth = 0;
            texAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texAddress.HidePromptOnLeave = false;
            texAddress.HideSelection = true;
            texAddress.Hint = "Address";
            texAddress.InsertKeyMode = InsertKeyMode.Default;
            texAddress.LeadingIcon = null;
            texAddress.Location = new Point(17, 119);
            texAddress.Mask = "";
            texAddress.MaxLength = 32767;
            texAddress.MouseState = MaterialSkin.MouseState.OUT;
            texAddress.Name = "texAddress";
            texAddress.PasswordChar = '\0';
            texAddress.PrefixSuffixText = null;
            texAddress.PromptChar = '_';
            texAddress.ReadOnly = false;
            texAddress.RejectInputOnFirstFailure = false;
            texAddress.ResetOnPrompt = true;
            texAddress.ResetOnSpace = true;
            texAddress.RightToLeft = RightToLeft.No;
            texAddress.SelectedText = "";
            texAddress.SelectionLength = 0;
            texAddress.SelectionStart = 0;
            texAddress.ShortcutsEnabled = true;
            texAddress.Size = new Size(503, 48);
            texAddress.SkipLiterals = true;
            texAddress.TabIndex = 30;
            texAddress.TabStop = false;
            texAddress.TextAlign = HorizontalAlignment.Left;
            texAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            texAddress.TrailingIcon = null;
            texAddress.UseSystemPasswordChar = false;
            texAddress.ValidatingType = null;
            // 
            // texContactNum
            // 
            texContactNum.AllowPromptAsInput = true;
            texContactNum.AnimateReadOnly = false;
            texContactNum.AsciiOnly = false;
            texContactNum.BackgroundImageLayout = ImageLayout.None;
            texContactNum.BeepOnError = false;
            texContactNum.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texContactNum.Depth = 0;
            texContactNum.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texContactNum.HidePromptOnLeave = false;
            texContactNum.HideSelection = true;
            texContactNum.Hint = "Mobile Number";
            texContactNum.InsertKeyMode = InsertKeyMode.Default;
            texContactNum.LeadingIcon = null;
            texContactNum.Location = new Point(552, 40);
            texContactNum.Mask = "";
            texContactNum.MaxLength = 32767;
            texContactNum.MouseState = MaterialSkin.MouseState.OUT;
            texContactNum.Name = "texContactNum";
            texContactNum.PasswordChar = '\0';
            texContactNum.PrefixSuffixText = null;
            texContactNum.PromptChar = '_';
            texContactNum.ReadOnly = false;
            texContactNum.RejectInputOnFirstFailure = false;
            texContactNum.ResetOnPrompt = true;
            texContactNum.ResetOnSpace = true;
            texContactNum.RightToLeft = RightToLeft.No;
            texContactNum.SelectedText = "";
            texContactNum.SelectionLength = 0;
            texContactNum.SelectionStart = 0;
            texContactNum.ShortcutsEnabled = true;
            texContactNum.Size = new Size(503, 48);
            texContactNum.SkipLiterals = true;
            texContactNum.TabIndex = 29;
            texContactNum.TabStop = false;
            texContactNum.TextAlign = HorizontalAlignment.Left;
            texContactNum.TextMaskFormat = MaskFormat.IncludeLiterals;
            texContactNum.TrailingIcon = null;
            texContactNum.UseSystemPasswordChar = false;
            texContactNum.ValidatingType = null;
            // 
            // texName
            // 
            texName.AllowPromptAsInput = true;
            texName.AnimateReadOnly = false;
            texName.AsciiOnly = false;
            texName.BackgroundImageLayout = ImageLayout.None;
            texName.BeepOnError = false;
            texName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texName.Depth = 0;
            texName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texName.HidePromptOnLeave = false;
            texName.HideSelection = true;
            texName.Hint = "Name";
            texName.InsertKeyMode = InsertKeyMode.Default;
            texName.LeadingIcon = null;
            texName.Location = new Point(17, 40);
            texName.Mask = "";
            texName.MaxLength = 32767;
            texName.MouseState = MaterialSkin.MouseState.OUT;
            texName.Name = "texName";
            texName.PasswordChar = '\0';
            texName.PrefixSuffixText = null;
            texName.PromptChar = '_';
            texName.ReadOnly = false;
            texName.RejectInputOnFirstFailure = false;
            texName.ResetOnPrompt = true;
            texName.ResetOnSpace = true;
            texName.RightToLeft = RightToLeft.No;
            texName.SelectedText = "";
            texName.SelectionLength = 0;
            texName.SelectionStart = 0;
            texName.ShortcutsEnabled = true;
            texName.Size = new Size(503, 48);
            texName.SkipLiterals = true;
            texName.TabIndex = 28;
            texName.TabStop = false;
            texName.TextAlign = HorizontalAlignment.Left;
            texName.TextMaskFormat = MaskFormat.IncludeLiterals;
            texName.TrailingIcon = null;
            texName.UseSystemPasswordChar = false;
            texName.ValidatingType = null;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = (Image)resources.GetObject("btnUpdate.Icon");
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(990, 444);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(105, 36);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ViewProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1133, 495);
            Controls.Add(btnUpdate);
            Controls.Add(materialCard1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewProfileForm";
            Text = "ViewProfileForm";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pwView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private PictureBox pwView;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblUserName;
        private Label lblAddress;
        private Label lblMobileNum;
        private Label lblName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texUserName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox texEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox texAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox texContactNum;
        private MaterialSkin.Controls.MaterialMaskedTextBox texName;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
    }
}