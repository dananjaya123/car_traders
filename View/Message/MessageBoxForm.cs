using car_traders.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traders.View.Message
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        public enum enumType
        {
            Success,
            Warning,
            Error,
            Info
        }

        public enum enumAction
        {
            wait,
            start,
            close
        }
        private MessageBoxForm.enumAction action;

        
        public void showAlert(string msg, enumType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.CenterScreen; // Set the StartPosition to CenterScreen

            // Set the form position to the center of the screen
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );

            // Type-wise message box customization
            switch (type)
            {
                case enumType.Success:
                    pictureBox1.Image = Resources.icon_success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enumType.Error:
                    pictureBox1.Image = Resources.icons_close;
                    this.BackColor = Color.DarkRed;
                    break;
                case enumType.Warning:
                    pictureBox1.Image = Resources.icons_warning;
                    this.BackColor = Color.DarkOrange;
                    break;
                case enumType.Info:
                    pictureBox1.Image = Resources.icons_warning;
                    this.BackColor = Color.RoyalBlue;
                    break;
            }

            lblMessage.Text = msg;
            this.Show();
            action = enumAction.start;
            this.timerMs.Interval = 1;
            timerMs.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerMs.Interval = 1;
            action = enumAction.close;
        }

        private void timerMs_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case enumAction.wait:
                    timerMs.Interval = 8000;
                    action = enumAction.close;
                    break;
                case enumAction.start:
                    timerMs.Interval = 1;
                    Opacity += 0.1;
                        if (Opacity == 1.0)
                        {
                            action = enumAction.wait;
                        }
                break;
                    
                    case enumAction.close:
                    timerMs.Interval = 1;
                    Opacity -=0.1;

                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}
