using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _345_Launcher.Source;
using CmlLib.Core;

namespace _345_Launcher.Source.SettingsForms
{
    public partial class Settings_Minecraft : Form
    {
        public Settings_Minecraft()
        {
            InitializeComponent();
            guna2TextBox1.Text = Properties.Settings.Default.JVM;
            guna2TextBox2.Text = Properties.Settings.Default.ram;
            guna2TextBox3.Text = Properties.Settings.Default.mram;

            Main_Form main = new Main_Form();

            guna2TextBox4.Text = main.mcpathbase;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

            save();

        }

        private void save()
        {
            Properties.Settings.Default.ram = guna2TextBox2.Text;
            Properties.Settings.Default.mram = guna2TextBox3.Text;
            Properties.Settings.Default.JVM = guna2TextBox1.Text;

            Properties.Settings.Default.Save();
        }

    }
}
