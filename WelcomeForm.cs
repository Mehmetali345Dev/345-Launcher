using System;
using System.Windows.Forms;

namespace _345_Launcher
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            prograssbar1.Value = 0;
            Properties.Settings.Default.wlcome = false;
            Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prograssbar1.Value += 1;
            prograssbar1.Text = prograssbar1.Value.ToString() + "%";

            if (prograssbar1.Value == 100)
            {
                timer1.Enabled = false;
                login se_form = new login();
                se_form.Show();
                this.Hide();
            }
            if (prograssbar1.Value == 15)
            {
                label3.Text = "Bloklar kırılıyor...";
            }
            if (prograssbar1.Value == 50)
            {
                label3.Text = "Elmaslar bulunuyor...";
            }
            if (prograssbar1.Value == 75)
            {
                label3.Text = "Bitti bitecek...";
            }
        }

    }
}
