using _345_Launcher.Re_Write.SettingsForms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Downloader;
using CmlLib.Core.Version;
using DiscordRPC;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace _345_Launcher.Re_Write
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            rpc();
        }

        #region Bools strings etc.

        private const int cGrip = 16;
        private const int cCaption = 32;
        public MinecraftPath MinecraftPath;
        MVersionCollection Versions;
        private bool befmenu;
        string javapath;
        public string mcpathbase;
        bool useMJava = true;
        MSession Session = MSession.GetOfflineSession("345 Launcher User");
        public DiscordRpcClient client;


        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        public string LabelText
        {
            get
            {
                //Loling textbox value is comes here
                return this.username_lbl.Text;
            }
            set
            {
                this.username_lbl.Text = value;
            }
        }

        #endregion

        #region Button etc. events

        private void Main_Form_Load(object sender, EventArgs e)
        {
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                webBrowser1.Navigate("https://launcher.mehmetali345.xyz/launcher.html");
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.IsWebBrowserContextMenuEnabled = false;
                UserHead();
            }
            else
            {
                userhead.Image = Properties.Resources.steve;
                noint_picturebox.Visible = true;
                noint_picturebox.Image = Properties.Resources.nointbg;
            }

            var defaultPath = new MinecraftPath(MinecraftPath.GetOSDefaultPath());

            InitializeLauncher(defaultPath);

            cbVersion.DropDownHeight = 200;

        }


        private void snapbox_CheckedChanged(object sender, EventArgs e)
        {
            refreshVersions(null);
        }

        private void set_button_Click(object sender, EventArgs e)
        {
            if (pnl_settings.Visible == false)
                guna2Transition1.ShowSync(pnl_settings, false);
            else
            {
                pnl_settings.Visible = false;
                pnl_settings_show.Controls.Clear();
                pnl_settings_show.Visible = false;
            }
            befmenu = false;
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            if (pnl_settings_show.Visible == false)
            {
                Settings_Info frm = new Settings_Info() { TopLevel = false, TopMost = true };

                this.pnl_settings_show.Controls.Add(frm);

                frm.Show();

                guna2Transition1.ShowSync(pnl_settings_show, false);

                befmenu = true;
            }
            else
            {
                if (befmenu == true)
                {
                    Settings_Info frm = new Settings_Info() { TopLevel = false, TopMost = true };

                    this.pnl_settings_show.Controls.Add(frm);

                    frm.Show();

                    guna2Transition1.ShowSync(pnl_settings_show, false);

                    befmenu = true;
                }
                else
                {
                    pnl_settings_show.Visible = false;

                    pnl_settings_show.Controls.Clear();

                    befmenu = false;
                }


            }


        }

        private void btn_Launch_Click(object sender, EventArgs e)
        {
            string selected = this.cbVersion.GetItemText(this.cbVersion.SelectedItem);

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);

            client.UpdateState($"Playing {selected}.");


            UpdateSession(MSession.GetOfflineSession(username_lbl.Text));

            if (Session == null)
            {
                MessageBox.Show("İlk önce giriş yap");
                return;
            }

            if (cbVersion.Text == "")
            {
                MessageBox.Show("Versiyon Seç / Select Version");
                return;
            }

            var launchOption = createLaunchOption();
            if (launchOption == null)
                return;
            //Creates launch options
            var version = cbVersion.Text;

            var th = new Thread(() =>
            {
                try
                {
                    if (useMJava)
                    {
                        //Minecraft custom java
                        var mjava = new MJava(MinecraftPath.Runtime);
                        mjava.ProgressChanged += Launcher_ProgressChanged;

                        var javapath = mjava.CheckJava();
                        launchOption.JavaPath = javapath;
                    }

                    MVersion versionInfo = Versions.GetVersion(version);
                    launchOption.StartVersion = versionInfo;

                    MDownloader downloader;
                    downloader = new MDownloader(MinecraftPath, versionInfo);

                    downloader.ChangeFile += Launcher_FileChanged;
                    downloader.ChangeProgress += Launcher_ProgressChanged;
                    downloader.CheckHash = true;
                    downloader.DownloadAll();

                    var launch = new MLaunch(launchOption);
                    var process = launch.GetProcess();

                    StartProcess(process);


                }
                catch (MDownloadFileException mex)
                {
                    MessageBox.Show(
                        $"FileName : {mex.ExceptionFile.Name}\n" +
                        $"FilePath : {mex.ExceptionFile.Path}\n" +
                        $"FileUrl : {mex.ExceptionFile.Url}\n" +
                        $"FileType : {mex.ExceptionFile.Type}\n\n" +
                        mex.ToString());
                }
                catch (Win32Exception wex)
                {
                    MessageBox.Show(wex.ToString() + "\n\nJava Problem");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
            th.Start();
        }

        private void mcset_button_Click(object sender, EventArgs e)
        {
            if (pnl_settings_show.Visible == false)
            {
                pnl_settings_show.Controls.Clear();

                Settings_Minecraft frm = new Settings_Minecraft() { TopLevel = false, TopMost = true };

                this.pnl_settings_show.Controls.Add(frm);

                frm.Show();

                guna2Transition1.ShowSync(pnl_settings_show, false);

                befmenu = true;
            }
            else
            {
                if (befmenu == true)
                {
                    pnl_settings_show.Controls.Clear();

                    Settings_Minecraft frm = new Settings_Minecraft() { TopLevel = false, TopMost = true };

                    this.pnl_settings_show.Controls.Add(frm);

                    frm.Show();

                    guna2Transition1.ShowSync(pnl_settings_show, false);

                    befmenu = true;
                }
                else
                {
                    pnl_settings_show.Visible = false;

                    pnl_settings_show.Controls.Clear();

                    befmenu = false;
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Other events

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

        private void UserHead()
        {
            var request = WebRequest.Create("https://minotar.net/helm/" + username_lbl.Text);

            using (var response = request.GetResponse())

            using (var stream = response.GetResponseStream())
            {
                userhead.Image = Bitmap.FromStream(stream);
            }

        }

        private void rpc()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);

            client = new DiscordRpcClient("844116191697043507");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = $"v. {versionInf.FileVersion}",
                State = "Main Screen",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "launcher",
                    LargeImageText = $"345 Launcher v. {versionInf.FileVersion}",
                }
            });

        }

        #endregion


        #region GameEvents

        private void UpdateSession(MSession session)
        {
            //Session update blabla

            this.Session = session;
        }
        public void refreshVersions(string showVersion)
        {
            // Gets Minecraft Versions

            cbVersion.Items.Clear();
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                //if user have internet connections
                var th = new Thread(new ThreadStart(delegate
                {
                    Versions = new MVersionLoader().GetVersionMetadatas(MinecraftPath);

                    Invoke(new Action(() =>
                    {
                        bool showVersionExist = false;
                        //Snapshot checkbox
                        if (snapbox.Checked == true)
                        {
                            foreach (var item in Versions)
                            {
                                if (item.IsLocalVersion || item.MType == MVersionType.Snapshot)
                                {
                                    showVersionExist = true;
                                    cbVersion.Items.Add(item.Name);
                                }
                                if (showVersion != null || showVersionExist)
                                    cbVersion.Text = showVersion;

                            }
                        }
                        else
                        {
                            foreach (var item in Versions)
                            {
                                if (item.IsLocalVersion || item.MType == MVersionType.Release)
                                {
                                    showVersionExist = true;
                                    cbVersion.Items.Add(item.Name);
                                }
                                if (showVersion != null || showVersionExist)
                                    cbVersion.Text = showVersion;

                            }
                        }

                    }));
                }));
                th.Start();
            }
            else
            {
                //if user don't have a internet connection

                var th = new Thread(new ThreadStart(delegate
                {
                    Versions = new MVersionLoader().GetVersionMetadatasFromLocal(MinecraftPath);

                    Invoke(new Action(() =>
                    {
                        bool showVersionExist = false;

                        foreach (var item in Versions)
                        {
                            if (item.IsLocalVersion)
                            {
                                MVersion version = Versions.GetVersion(item);
                                showVersionExist = true;
                                cbVersion.Items.Add(item.Name);
                            }
                            if (showVersion != null || showVersionExist)
                                cbVersion.Text = showVersion;
                        }
                    }));
                }));
                th.Start();
            }

        }

        public void InitializeLauncher(MinecraftPath path)
        {
            MinecraftPath = path;


            if (useMJava)
                javapath = path.Runtime;


            refreshVersions(null);

            mcpathbase = path.BasePath;

        }

        private MLaunchOption createLaunchOption()
        {
            //Sets launch options
            try
            {
                var launchOption = new MLaunchOption()
                {
                    Path = MinecraftPath,

                    MaximumRamMb = int.Parse(Properties.Settings.Default.ram),
                    Session = this.Session,
                    FullScreen = Properties.Settings.Default.fs,
                };


                if (!string.IsNullOrEmpty(Properties.Settings.Default.ram))
                    launchOption.MinimumRamMb = int.Parse(Properties.Settings.Default.mram);

                if (!string.IsNullOrEmpty(Properties.Settings.Default.JVM))
                    launchOption.JVMArguments = Properties.Settings.Default.JVM.Split(' ');

                return launchOption;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create MLaunchOption\n\n" + ex.ToString());
                return null;
            }
        }

        private void Launcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Progress bar
            Invoke(new Action(() =>
            {

                progressBar1.Value = e.ProgressPercentage;

            }));
        }

        private void Launcher_FileChanged(DownloadFileChangedEventArgs e)
        {

            Invoke(new Action(() =>
            {
                label3.Text = $"{e.FileKind.ToString()} : {e.FileName} ({e.ProgressedFileCount}/{e.TotalFileCount})";
            }));
        }

        private void StartProcess(Process process)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".345launcher");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllText(path + @"\Arguments.txt", process.StartInfo.Arguments);

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.EnableRaisingEvents = true;

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            //Arguments text
        }
        #endregion





    }
}
