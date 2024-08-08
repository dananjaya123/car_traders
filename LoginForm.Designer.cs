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
            lblRegistor = new LinkLabel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblForgotPassword = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            texUserName.Location = new Point(312, 246);
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
            texUserName.Size = new Size(348, 48);
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
            texPassword.Location = new Point(312, 314);
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
            texPassword.Size = new Size(348, 48);
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
            btnLogin.ForeColor = Color.DodgerBlue;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = (Image)resources.GetObject("btnLogin.Icon");
            btnLogin.Location = new Point(568, 371);
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
            // lblRegistor
            // 
            lblRegistor.AutoSize = true;
            lblRegistor.LinkColor = Color.DodgerBlue;
            lblRegistor.Location = new Point(311, 405);
            lblRegistor.Name = "lblRegistor";
            lblRegistor.Size = new Size(105, 25);
            lblRegistor.TabIndex = 4;
            lblRegistor.TabStop = true;
            lblRegistor.Text = "Register her";
            lblRegistor.LinkClicked += lblRegistor_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 472);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(54, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(27, 258);
            label3.Name = "label3";
            label3.Size = new Size(228, 39);
            label3.TabIndex = 8;
            label3.Text = "ABC Car Readers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(27, 219);
            label2.Name = "label2";
            label2.Size = new Size(225, 39);
            label2.TabIndex = 7;
            label2.Text = "Welcome to the";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(450, 143);
            label1.Name = "label1";
            label1.Size = new Size(101, 45);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.LinkColor = Color.DodgerBlue;
            lblForgotPassword.Location = new Point(309, 371);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(146, 25);
            lblForgotPassword.TabIndex = 7;
            lblForgotPassword.TabStop = true;
            lblForgotPassword.Text = "Forgot Password";
            lblForgotPassword.LinkClicked += lblForgotPassword_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 539);
            Controls.Add(lblForgotPassword);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblRegistor);
            Controls.Add(btnLogin);
            Controls.Add(texPassword);
            Controls.Add(texUserName);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private MaterialSkin.Controls.MaterialMaskedTextBox texUserName;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private LinkLabel lblRegistor;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private LinkLabel lblForgotPassword;
    }
}