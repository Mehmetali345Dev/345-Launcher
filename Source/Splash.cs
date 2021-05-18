using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using _345_Launcher.Source.Localization;

namespace _345_Launcher
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();


            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            LocalizationHelper.Update();

            metroLabel1.Text = LocalizationHelper.Base.Splash_Loading;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            guna2CircleProgressBar1.Value += 1;
            if (guna2CircleProgressBar1.Value == 30)
            {
                metroLabel1.Text = LocalizationHelper.Base.Splash_Check;
            }
            if (guna2CircleProgressBar1.Value == 75)
            {
                metroLabel1.Text = LocalizationHelper.Base.Splash_Finished;

            }
            if (guna2CircleProgressBar1.Value >= 100)
            {
                if (Properties.Settings.Default.Remember == true)
                {

                    // If remember me checked auto logins
                    timer1.Stop();
                    MainForm main = new MainForm();
                    main.LabelText = Properties.Settings.Default.UserName;
                    main.Show();
                    this.Hide();

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
