using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _345_Launcher
{
    public partial class Form_Info : Form
    {
        public Form_Info()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Error,
            minimized,
            Info
                // For exporting types
        }
        private Form_Info.enmAction action;

        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case Form_Info.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Form_Info.enmAction.wait;
                        }
                    }
                    break;

                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;

                    // This for animation of Update and other things.
            }
        }

        public void showAlert(string msg, string msg2, string msg3, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Info frm = (Form_Info)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {   // Info notification(like Update is availble, etc.)
                case enmType.Info:
                    this.pictureBox1.Image = Properties.Resources.icons8_info_96px;
                    this.BackColor = Color.RoyalBlue;
                    break;
                // Minimized notification
                case enmType.minimized:
                    this.pictureBox1.Image = Properties.Resources._345launcher;
                    this.BackColor = Color.DimGray;
                    break;
                    // Error notification
                case enmType.Error:
                    this.pictureBox1.Image = Properties.Resources.icons8_error_64px;
                    this.BackColor = Color.Red;
                    break;
            }


            this.label1.Text = msg;
            this.label2.Text = msg2;
            this.label3.Text = msg3;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

    }
}
