namespace car_traders
{
    partial class ForgotPasswordModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordModalForm));
            texUserName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lblUserError = new Label();
            btnSubmit = new MaterialSkin.Controls.MaterialButton();
            btnChangePw = new MaterialSkin.Controls.MaterialButton();
            lblNewPassword = new Label();
            texNewPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lblOneTimePw = new Label();
            texOneTimePassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            SuspendLayout();
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
            texUserName.Hint = "User name or Email ";
            texUserName.InsertKeyMode = InsertKeyMode.Default;
            texUserName.LeadingIcon = null;
            texUserName.Location = new Point(33, 100);
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
            texUserName.Size = new Size(344, 48);
            texUserName.SkipLiterals = true;
            texUserName.TabIndex = 0;
            texUserName.TabStop = false;
            texUserName.TextAlign = HorizontalAlignment.Left;
            texUserName.TextMaskFormat = MaskFormat.IncludeLiterals;
            texUserName.TrailingIcon = null;
            texUserName.UseSystemPasswordChar = false;
            texUserName.ValidatingType = null;
            // 
            // lblUserError
            // 
            lblUserError.AutoSize = true;
            lblUserError.ForeColor = Color.ForestGreen;
            lblUserError.Location = new Point(33, 151);
            lblUserError.Name = "lblUserError";
            lblUserError.Size = new Size(249, 25);
            lblUserError.TabIndex = 1;
            lblUserError.Text = "Enter your user name or email";
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSubmit.Depth = 0;
            btnSubmit.HighEmphasis = true;
            btnSubmit.Icon = (Image)resources.GetObject("btnSubmit.Icon");
            btnSubmit.Image = (Image)resources.GetObject("btnSubmit.Image");
            btnSubmit.Location = new Point(395, 112);
            btnSubmit.Margin = new Padding(4, 6, 4, 6);
            btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NoAccentTextColor = Color.Empty;
            btnSubmit.Size = new Size(103, 36);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSubmit.UseAccentColor = false;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnChangePw
            // 
            btnChangePw.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnChangePw.Cursor = Cursors.Hand;
            btnChangePw.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnChangePw.Depth = 0;
            btnChangePw.HighEmphasis = true;
            btnChangePw.Icon = (Image)resources.GetObject("btnChangePw.Icon");
            btnChangePw.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangePw.Location = new Point(307, 359);
            btnChangePw.Margin = new Padding(4, 6, 4, 6);
            btnChangePw.MouseState = MaterialSkin.MouseState.HOVER;
            btnChangePw.Name = "btnChangePw";
            btnChangePw.NoAccentTextColor = Color.Empty;
            btnChangePw.Size = new Size(191, 36);
            btnChangePw.TabIndex = 12;
            btnChangePw.Text = "Change Password";
            btnChangePw.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnChangePw.UseAccentColor = false;
            btnChangePw.UseVisualStyleBackColor = true;
            btnChangePw.Visible = false;
            btnChangePw.Click += btnChangePw_Click;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.ForeColor = Color.Red;
            lblNewPassword.Location = new Point(33, 328);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(50, 25);
            lblNewPassword.TabIndex = 9;
            lblNewPassword.Text = "Error";
            lblNewPassword.Visible = false;
            // 
            // texNewPassword
            // 
            texNewPassword.AllowPromptAsInput = true;
            texNewPassword.AnimateReadOnly = false;
            texNewPassword.AsciiOnly = false;
            texNewPassword.BackgroundImageLayout = ImageLayout.None;
            texNewPassword.BeepOnError = false;
            texNewPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texNewPassword.Depth = 0;
            texNewPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texNewPassword.HidePromptOnLeave = false;
            texNewPassword.HideSelection = true;
            texNewPassword.Hint = "New Password";
            texNewPassword.ImeMode = ImeMode.Off;
            texNewPassword.InsertKeyMode = InsertKeyMode.Default;
            texNewPassword.LeadingIcon = null;
            texNewPassword.Location = new Point(33, 277);
            texNewPassword.Mask = "";
            texNewPassword.MaxLength = 32767;
            texNewPassword.MouseState = MaterialSkin.MouseState.OUT;
            texNewPassword.Name = "texNewPassword";
            texNewPassword.PasswordChar = '\0';
            texNewPassword.PrefixSuffixText = null;
            texNewPassword.PromptChar = '_';
            texNewPassword.ReadOnly = false;
            texNewPassword.RejectInputOnFirstFailure = false;
            texNewPassword.ResetOnPrompt = true;
            texNewPassword.ResetOnSpace = true;
            texNewPassword.RightToLeft = RightToLeft.No;
            texNewPassword.SelectedText = "";
            texNewPassword.SelectionLength = 0;
            texNewPassword.SelectionStart = 0;
            texNewPassword.ShortcutsEnabled = true;
            texNewPassword.Size = new Size(344, 48);
            texNewPassword.SkipLiterals = true;
            texNewPassword.TabIndex = 8;
            texNewPassword.TabStop = false;
            texNewPassword.TextAlign = HorizontalAlignment.Left;
            texNewPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            texNewPassword.TrailingIcon = null;
            texNewPassword.UseSystemPasswordChar = false;
            texNewPassword.ValidatingType = null;
            texNewPassword.Visible = false;
            texNewPassword.KeyPress += texNewPassword_KeyPress;
            // 
            // lblOneTimePw
            // 
            lblOneTimePw.AutoSize = true;
            lblOneTimePw.ForeColor = Color.Red;
            lblOneTimePw.Location = new Point(33, 234);
            lblOneTimePw.Name = "lblOneTimePw";
            lblOneTimePw.Size = new Size(50, 25);
            lblOneTimePw.TabIndex = 7;
            lblOneTimePw.Text = "Error";
            lblOneTimePw.Visible = false;
            // 
            // texOneTimePassword
            // 
            texOneTimePassword.AllowPromptAsInput = true;
            texOneTimePassword.AnimateReadOnly = false;
            texOneTimePassword.AsciiOnly = false;
            texOneTimePassword.BackgroundImageLayout = ImageLayout.None;
            texOneTimePassword.BeepOnError = false;
            texOneTimePassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texOneTimePassword.Depth = 0;
            texOneTimePassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texOneTimePassword.HidePromptOnLeave = false;
            texOneTimePassword.HideSelection = true;
            texOneTimePassword.Hint = "one time password";
            texOneTimePassword.InsertKeyMode = InsertKeyMode.Default;
            texOneTimePassword.LeadingIcon = null;
            texOneTimePassword.Location = new Point(33, 183);
            texOneTimePassword.Mask = "";
            texOneTimePassword.MaxLength = 32767;
            texOneTimePassword.MouseState = MaterialSkin.MouseState.OUT;
            texOneTimePassword.Name = "texOneTimePassword";
            texOneTimePassword.PasswordChar = '\0';
            texOneTimePassword.PrefixSuffixText = null;
            texOneTimePassword.PromptChar = '_';
            texOneTimePassword.ReadOnly = false;
            texOneTimePassword.RejectInputOnFirstFailure = false;
            texOneTimePassword.ResetOnPrompt = true;
            texOneTimePassword.ResetOnSpace = true;
            texOneTimePassword.RightToLeft = RightToLeft.No;
            texOneTimePassword.SelectedText = "";
            texOneTimePassword.SelectionLength = 0;
            texOneTimePassword.SelectionStart = 0;
            texOneTimePassword.ShortcutsEnabled = true;
            texOneTimePassword.Size = new Size(344, 48);
            texOneTimePassword.SkipLiterals = true;
            texOneTimePassword.TabIndex = 5;
            texOneTimePassword.TabStop = false;
            texOneTimePassword.TextAlign = HorizontalAlignment.Left;
            texOneTimePassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            texOneTimePassword.TrailingIcon = null;
            texOneTimePassword.UseSystemPasswordChar = false;
            texOneTimePassword.ValidatingType = null;
            texOneTimePassword.Visible = false;
            texOneTimePassword.Click += texOneTimePassword_Click;
            texOneTimePassword.KeyPress += texOneTimePassword_KeyPress;
            // 
            // ForgotPasswordModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 449);
            Controls.Add(btnChangePw);
            Controls.Add(texUserName);
            Controls.Add(lblNewPassword);
            Controls.Add(lblUserError);
            Controls.Add(texNewPassword);
            Controls.Add(btnSubmit);
            Controls.Add(lblOneTimePw);
            Controls.Add(texOneTimePassword);
            Name = "ForgotPasswordModalForm";
            Text = "Forgot Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox texUserName;
        private Label lblUserError;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
        private MaterialSkin.Controls.MaterialMaskedTextBox texOneTimePassword;
        private Label lblOneTimePw;
        private MaterialSkin.Controls.MaterialMaskedTextBox texNewPassword;
        private MaterialSkin.Controls.MaterialButton btnChangePw;
        private Label lblNewPassword;
    }
}