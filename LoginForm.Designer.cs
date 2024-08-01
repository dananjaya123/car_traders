namespace car_traders
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            texUserName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            texPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            lblRegistor = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
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
            texUserName.Location = new Point(26, 227);
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
            texUserName.Size = new Size(410, 48);
            texUserName.SkipLiterals = true;
            texUserName.TabIndex = 0;
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
            texPassword.Location = new Point(26, 305);
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
            texPassword.Size = new Size(410, 48);
            texPassword.SkipLiterals = true;
            texPassword.TabIndex = 1;
            texPassword.TabStop = false;
            texPassword.TextAlign = HorizontalAlignment.Left;
            texPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPassword.TrailingIcon = null;
            texPassword.UseSystemPasswordChar = false;
            texPassword.ValidatingType = null;
            texPassword.Click += texPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = (Image)resources.GetObject("btnLogin.Icon");
            btnLogin.Location = new Point(344, 397);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(92, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += materialButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblRegistor
            // 
            lblRegistor.AutoSize = true;
            lblRegistor.LinkColor = Color.Teal;
            lblRegistor.Location = new Point(344, 356);
            lblRegistor.Name = "lblRegistor";
            lblRegistor.Size = new Size(105, 25);
            lblRegistor.TabIndex = 4;
            lblRegistor.TabStop = true;
            lblRegistor.Text = "Register her";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 467);
            Controls.Add(lblRegistor);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(texPassword);
            Controls.Add(texUserName);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private MaterialSkin.Controls.MaterialMaskedTextBox texUserName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private PictureBox pictureBox1;
        private LinkLabel lblRegistor;
    }
}