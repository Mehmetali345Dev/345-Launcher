using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core.Auth;
using Guna.UI2.WinForms;

namespace _345_Launcher
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            Init_Data();
            versiyon();
        }
        public MSession Session;

        private void versiyon()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            uplabel.Text += $"v. {versionInfo.FileVersion}";
        }

        public login(MSession session)
        {
            this.Session = session;
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            UpdateSession(Session);
        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    txtUsername.Text = Properties.Settings.Default.UserName;
                    metroCheckBox1.Checked = true;
                }
                else
                {
                    txtUsername.Text = Properties.Settings.Default.UserName;
                }
            }
        }// beni hatırla için otomatik doldurma

        private void Save_Data() //Beni hatırla için string kaydı
        {
            if (metroCheckBox1.Checked)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Boş geçilemez.");
            }
            else
            {
                MainForm main = new MainForm();
                main.Show();
                main.LabelText = this.txtUsername.Text;
                UpdateSession(MSession.GetOfflineSession(txtUsername.Text));
                this.Hide();
                Save_Data();
            }
        }

        private void UpdateSession(MSession session)
        {
            this.Session = session;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mehmetali345.xyz");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

    }
}
