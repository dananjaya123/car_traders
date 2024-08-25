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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblError = new Label();
            lblTotalAmount = new Label();
            btnSubmit = new Button();
            texPaidAmount = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lblAmountTag = new Label();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblError);
            materialCard1.Controls.Add(lblTotalAmount);
            materialCard1.Controls.Add(btnSubmit);
            materialCard1.Controls.Add(texPaidAmount);
            materialCard1.Controls.Add(lblAmountTag);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(361, 257);
            materialCard1.TabIndex = 0;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(12, 139);
            lblError.Name = "lblError";
            lblError.Size = new Size(50, 25);
            lblError.TabIndex = 9;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.SteelBlue;
            lblTotalAmount.Location = new Point(165, 37);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 28);
            lblTotalAmount.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.CornflowerBlue;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Image = (Image)resources.GetObject("btnSubmit.Image");
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(12, 172);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(20, 0, 0, 0);
            btnSubmit.Size = new Size(341, 64);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            btnSubmit.MouseLeave += btnSubmit_MouseLeave;
            btnSubmit.MouseHover += btnSubmit_MouseHover;
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
            texPaidAmount.Location = new Point(12, 88);
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
            texPaidAmount.TabIndex = 6;
            texPaidAmount.TabStop = false;
            texPaidAmount.TextAlign = HorizontalAlignment.Left;
            texPaidAmount.TextMaskFormat = MaskFormat.IncludeLiterals;
            texPaidAmount.TrailingIcon = null;
            texPaidAmount.UseSystemPasswordChar = false;
            texPaidAmount.ValidatingType = null;
            // 
            // lblAmountTag
            // 
            lblAmountTag.AutoSize = true;
            lblAmountTag.Location = new Point(22, 37);
            lblAmountTag.Name = "lblAmountTag";
            lblAmountTag.Size = new Size(128, 25);
            lblAmountTag.TabIndex = 5;
            lblAmountTag.Text = "Total Amount :";
            // 
            // PaymentModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 352);
            Controls.Add(materialCard1);
            Name = "PaymentModalForm";
            Text = "Payment";
            Load += PaymentModalForm_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblError;
        private Label lblTotalAmount;
        private Button btnSubmit;
        private MaterialSkin.Controls.MaterialMaskedTextBox texPaidAmount;
        private Label lblAmountTag;
    }
}