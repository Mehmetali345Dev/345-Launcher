using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _345_Launcher.Re_Write.SettingsForms
{
    public partial class Settings_Info : Form
    {
        public Settings_Info()
        {
            InitializeComponent();
        }

        private void Settings_Info_Load(object sender, EventArgs e)
        {
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mehmetali345.xyz");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mehmetali345Dev");
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mehmetali345.xyz/donate");
        }
    }
}
