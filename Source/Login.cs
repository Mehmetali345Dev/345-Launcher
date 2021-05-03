using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if(Properties.Settings.Default.langtr == false)
            {
                metroCheckBox1.Text = "Remember me";
                guna2Button1.Text = "Login ->";
                label3.Text = "Username";
                // For English Language
            }
        }
        public MSession Session;

        private void versiyon()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            uplabel.Text += $"v. {versionInfo.FileVersion}";

            //Version label 
        }

        public login(MSession session)
        {
            //Setting session for MainForm
            this.Session = session;
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //Session Update
            UpdateSession(Session);
        }

        private void Init_Data() // Remember me autofill
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
        }

        private void Save_Data() //Remember me save
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
            Regex regex = new Regex(@"[a-zA-Z0-9]_");
            Match match = regex.Match(txtUsername.Text);
            
            if ( txtUsername.Text == "" || txtUsername.Text.Length <= 3 || txtUsername.Text.Length >= 16)
                // || !match.Success)
            {
                MessageBox.Show("Boşluk olmadan ve sadece ingilizce harf kullanarak giriş yapın!");
                // If username contains illegal character or empty
            }
            else
            {
                MainForm main = new MainForm();
                main.Show();

                //Username Label on MainForm gets this textboxes value
                main.LabelText = this.txtUsername.Text;

                UpdateSession(MSession.GetOfflineSession(txtUsername.Text));
                //Updating MainForm Session

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
            //My websites link
            System.Diagnostics.Process.Start("https://mehmetali345.xyz");
        }

    }
}
