namespace car_traders
{
    partial class SearchCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCarForm));
            texSearchCar = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            resultContainer = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // texSearchCar
            // 
            texSearchCar.Location = new Point(8, 11);
            texSearchCar.Name = "texSearchCar";
            texSearchCar.Size = new Size(474, 31);
            texSearchCar.TabIndex = 1;
            texSearchCar.TextChanged += texSearchCar_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(texSearchCar);
            panel1.Location = new Point(138, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 54);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(623, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // resultContainer
            // 
            resultContainer.Location = new Point(31, 95);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(776, 214);
            resultContainer.TabIndex = 4;
            // 
            // SearchCarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(845, 607);
            ControlBox = false;
            Controls.Add(resultContainer);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchCarForm";
            Text = "CustomerSearchCarForm";
            Load += SearchCarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox texSearchCar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel resultContainer;
    }
}