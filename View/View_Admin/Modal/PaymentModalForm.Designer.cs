namespace car_traders.View.View_Admin.Modal
{
    partial class PaymentModalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentModalForm));
            lblAmountTag = new Label();
            texPaidAmount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnSubmit = new Button();
            lblTotalAmount = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblAmountTag
            // 
            lblAmountTag.AutoSize = true;
            lblAmountTag.Location = new Point(16, 97);
            lblAmountTag.Name = "lblAmountTag";
            lblAmountTag.Size = new Size(128, 25);
            lblAmountTag.TabIndex = 0;
            lblAmountTag.Text = "Total Amount :";
            // 
            // texPaidAmount
            // 
            texPaidAmount.AllowPromptAsInput = true;
            texPaidAmount.AnimateReadOnly = false;
            texPaidAmount.AsciiOnly = false;
            texPaidAmount.BackgroundImageLayout = ImageLayout.None;
            texPaidAmount.BeepOnError = false;
            texPaidAmount.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            texPaidAmount.Depth = 0;
            texPaidAmount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            texPaidAmount.HidePromptOnLeave = false;
            texPaidAmount.HideSelection = true;
            texPaidAmount.Hint = "Paid Amount";
            texPaidAmount.InsertKeyMode = InsertKeyMode.Default;
            texPaidAmount.LeadingIcon = null;
            texPaidAmount.Location = new Point(22, 148);
            texPaidAmount.Mask = "";
            texPaidAmount.MaxLength = 32767;
            texPaidAmount.MouseState = MaterialSkin.MouseState.OUT;
            texPaidAmount.Name = "texPaidAmount";
            texPaidAmount.PasswordChar = '\0';
            texPaidAmount.PrefixSuffixText = null;
            texPaidAmount.PromptChar = '_';
            texPaidAmount.ReadOnly = false;
            texPaidAmount.RejectInputOnFirstFailure = false;
            texPaidAmount.ResetOnPrompt = true;
            texPaidAmount.ResetOnSpace = true;
            texPaidAmount.RightToLeft = RightToLeft.No;
            texPaidAmount.SelectedText = "";
            texPaidAmount.SelectionLength = 0;
            texPaidAmount.SelectionStart = 0;
            texPaidAmount.ShortcutsEnabled = true;
            texPaidAmount.Size = new Size(341, 48);
            texPaidAmount.SkipLiterals = true;
            texPaidAmount.TabIndex = 1;
            texPaidAmount.TabStop = false;
            texPaidAmount.TextAlign = HorizontalAlignment.Left;
            texPaidAmount.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPaidAmount.TrailingIcon = null;
            texPaidAmount.UseSystemPasswordChar = false;
            texPaidAmount.ValidatingType = null;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.CornflowerBlue;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Image = (Image)resources.GetObject("btnSubmit.Image");
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(95, 232);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(155, 60);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.SteelBlue;
            lblTotalAmount.Location = new Point(159, 97);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 28);
            lblTotalAmount.TabIndex = 3;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(22, 199);
            lblError.Name = "lblError";
            lblError.Size = new Size(50, 25);
            lblError.TabIndex = 4;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // PaymentModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 352);
            Controls.Add(lblError);
            Controls.Add(lblTotalAmount);
            Controls.Add(btnSubmit);
            Controls.Add(texPaidAmount);
            Controls.Add(lblAmountTag);
            Name = "PaymentModalForm";
            Text = "Payment";
            Load += PaymentModalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmountTag;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPaidAmount;
        private Button btnSubmit;
        private Label lblTotalAmount;
        private Label lblError;
    }
}