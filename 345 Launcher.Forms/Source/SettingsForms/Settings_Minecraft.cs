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

        string javapath;

        MinecraftPath MinecraftPath;
        public void InitializeLauncher(MinecraftPath path)
        {
            MinecraftPath = path;

            string installPath = GetJavaInstallationPath();
            string filePath = System.IO.Path.Combine(installPath, "bin\\Java.exe");
            if (System.IO.File.Exists(filePath))
            {
                javapath = filePath;
            }
            else
            {
                javapath = path.Runtime;
            }

            guna2TextBox4.Text = path.BasePath;
            label6.Text = javapath;
        }

        public Settings_Minecraft()
        {
            InitializeComponent();
            guna2TextBox1.Text = Properties.Settings.Default.JVM;
            guna2TextBox2.Text = Properties.Settings.Default.ram;
            guna2TextBox3.Text = Properties.Settings.Default.mram;

            Main_Form main = new Main_Form();

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

        private string GetJavaInstallationPath()
        {
            string environmentPath = Environment.GetEnvironmentVariable("JAVA_HOME");

            if (!string.IsNullOrEmpty(environmentPath))
            {
                return environmentPath;
            }

            string javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment\\";

            using (Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(javaKey))
            {
                string currentVersion = rk.GetValue("CurrentVersion").ToString();

                using (Microsoft.Win32.RegistryKey key = rk.OpenSubKey(currentVersion))
                {
                    return key.GetValue("JavaHome").ToString();
                }
            }
        }

        private void Settings_Minecraft_Load(object sender, EventArgs e)
        {
            var defaultPath = new MinecraftPath(MinecraftPath.GetOSDefaultPath());

            InitializeLauncher(defaultPath);
        }
    }
}
