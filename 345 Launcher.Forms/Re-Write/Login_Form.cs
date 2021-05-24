using _345_Launcher.Re__Write.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _345_Launcher.Re_Write
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();

            InitData();
        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            // For draggeble form
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X > this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitData()
        {
            if (Properties.Settings.Default.Remember == true)
            {
                guna2CheckBox1.Checked = true;
                guna2TextBox1.Text = Properties.Settings.Default.UserName;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Main_Form main = new Main_Form();

            main.LabelText = guna2TextBox1.Text;

            main.Show();

            if (guna2CheckBox1.Checked == true)
            {
                Properties.Settings.Default.UserName = guna2TextBox1.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }

            this.Hide();
        }
    }
}
