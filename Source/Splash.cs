using System;
using System.Windows.Forms;

namespace _345_Launcher
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            guna2CircleProgressBar1.Value += 1;
            if (guna2CircleProgressBar1.Value == 30)
            {
                metroLabel1.Text = "Sunucuya Bağlanılıyor...";
            }
            if (guna2CircleProgressBar1.Value == 75)
            {
                metroLabel1.Text = "Dosyalar Doğrulanıyor...";
                if (Properties.Settings.Default.prank == true)
                {
                    timer1.Stop();
                    MessageBox.Show("Dosyalarda Hata Var", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("LOL");
                    Properties.Settings.Default.prank = false;
                    Properties.Settings.Default.Save();
                    timer1.Start();
                }
            }
            if (guna2CircleProgressBar1.Value >= 100)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    if (Properties.Settings.Default.prank == true)
                    {
                        timer1.Stop();
                        MessageBox.Show("Dosyalar Hatalı Tekrar AÇ");
                    }
                    else
                    {
                        timer1.Stop();
                        MainForm main = new MainForm();
                        main.LabelText = Properties.Settings.Default.UserName;
                        main.Show();
                        this.Hide();
                    }

                }
                else
                {
                    timer1.Stop();
                    login log = new login();
                    log.Show();
                    this.Hide();
                }

            }
        }
    }
}
