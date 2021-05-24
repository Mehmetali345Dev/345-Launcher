using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _345_Launcher.Re_Write
{
    public partial class Splash_Form : Form
    {

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        public Splash_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();

            guna2ProgressBar1.Value += 1;
            if (guna2ProgressBar1.Value == 30)
            {
                Load_Label.Text = "Dosyalar doğrulanıyor...";
            }
            else if (guna2ProgressBar1.Value == 75)
            {
                Load_Label.Text = "Sunucuya bağlanılıyor...";
                timer1.Stop();

                int Out;
                if (InternetGetConnectedState(out Out, 0) == true)
                {
                    timer1.Start();
                }
                else
                {
                    DialogResult result = MessageBox.Show("İnternet bağlantınız yok. Hala işleme devam edecekmisiniz?", "345 Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        timer1.Start();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                
                
            }
            else if (guna2ProgressBar1.Value == 100)
            {
                if(Properties.Settings.Default.Remember == true)
                {
                    Main_Form main = new Main_Form();
                    main.LabelText = Properties.Settings.Default.UserName;
                    this.Hide();
                    main.Show();
                }
                else
                {
                    timer1.Stop();
                    Login_Form login = new Login_Form();
                    login.Show();
                    this.Hide();
                }
               
            }
        }
    }
}
