using _345_Launcher.Source.Localization;
using _345_Launcher.Source.Utils;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Downloader;
using CmlLib.Core.Version;
using DiscordRPC;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace _345_Launcher
{

    public partial class MainForm : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        public DiscordRpcClient client;

        public MainForm()
        {
            InitializeComponent();
            upcheck();
            Init_Data();
            cbVersion.DropDownHeight = 200;
            if (Properties.Settings.Default.rpc == true)
            {
                rpc();
            }
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        #region strings and etc.

        public void Alert(string msg, string msg2, Form_Info.enmType type)
        {
            //Notification alert
            Form_Info frm = new Form_Info();
            frm.showAlert(msg, msg2, type);
        }

        public void upcheck()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);
            string v = versionInf.FileVersion;

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            string target = "https://launcher.mehmetali345.xyz/assets/update.html";
            WebRequest request = HttpWebRequest.Create(target);
            WebResponse response;
            response = request.GetResponse();
            StreamReader gets = new StreamReader(response.GetResponseStream());
            string vinf = gets.ReadToEnd();
            int starts = vinf.IndexOf("<p>") + 3;
            int ends = vinf.Substring(starts).IndexOf("</p>");
            string getinf = vinf.Substring(starts, ends);
            v = Convert.ToString(getinf);


            if (v == versionInf.FileVersion)
            {
                uplabel.Text = v;
            }
            else
            {

                if (MessageBox.Show(LocalizationHelper.Base.Update_Answer, "345 Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    using (var client = new WebClient())
                    {
                        Update up = new Update();
                        up.Show();
                    }
                else
                {
                    // Notification
                    this.Alert(LocalizationHelper.Base.Alert_Update, LocalizationHelper.Base.Alert_Update_Text, Form_Info.enmType.Info);
                }

            }
        }

        bool useMJava = true;
        string javaPath = "java.exe";
        private const int cGrip = 16;
        private const int cCaption = 32;
        MinecraftPath MinecraftPath;
        MVersionCollection Versions;
        MSession Session = MSession.GetOfflineSession("345 Launcher User");

        public string LabelText
        {
            get
            {
                //Loling textbox value is comes here
                return this.lbUsername.Text;
            }
            set
            {
                this.lbUsername.Text = value;
            }
        }

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


        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && chkStartUp.Checked == true)
            {
                Hide();
                notify_icon.Visible = true;
            }
        }
        public void lang()
        {
            metroTextBox1.Text = LocalizationHelper.Base.Main_AboutMeText;
            btnLaunch.Text = LocalizationHelper.Base.Main_PlayButton;
            setButton.Text = LocalizationHelper.Base.Main_SettingsButton;
            guna2Button1.Text = LocalizationHelper.Base.Main_SignOut;
            snapbox.Text = LocalizationHelper.Base.Main_SnapshotBox;
            Lv_Status.Text = LocalizationHelper.Base.Main_Status;
            label3.Text = LocalizationHelper.Base.Main_WelcomeLabel;
            guna2Button4.Text = LocalizationHelper.Base.Main_DonateButton;
            Hakkında.Text = LocalizationHelper.Base.Main_About;
            groupadvance.Text = LocalizationHelper.Base.Main_AdvancedSettings;
            jvmarglbl.Text = LocalizationHelper.Base.Main_JvmArgsLBL;
            maxiramlbl.Text = LocalizationHelper.Base.Main_MaximumRamLBL;
            minimramlbl.Text = LocalizationHelper.Base.Main_MinimumRamLBL;
            cbFullscreen.Text = LocalizationHelper.Base.Main_FullScreenCheckBox;
            rbSequenceDownload.Text = LocalizationHelper.Base.Main_SequenceCheckBox;
            rbParallelDownload.Text = LocalizationHelper.Base.Main_ParallelCheckBox;
            groupdownload.Text = LocalizationHelper.Base.Main_Download;
            groupinstall.Text = LocalizationHelper.Base.Main_Install;
            installpathlbl.Text = LocalizationHelper.Base.Main_InstallPathLBL;
            btnChangePath.Text = LocalizationHelper.Base.Main_ChangePathButton;
            javapathlbl.Text = LocalizationHelper.Base.Main_JavaPathLBL;
            label4.Text = LocalizationHelper.Base.Main_MinimizeLabel;
            chkStartUp.Text = LocalizationHelper.Base.Main_MinimizeCheckBox;
            label7.Text = LocalizationHelper.Base.Main_LanguageLabel;
            guna2TileButton5.Text = LocalizationHelper.Base.Main_SaveButton;
            guna2TileButton7.Text = LocalizationHelper.Base.Main_UpdateButton;
            metroTabPage2.Text = LocalizationHelper.Base.Main_SettingsTab;
            metroTabPage4.Text = LocalizationHelper.Base.Main_LauncherSetTab;

        }
        #endregion

        #region Launcher
        private void InitializeLauncher(MinecraftPath path)
        {
            //initilizes mc path
            txtPath.Text = path.BasePath;
            MinecraftPath = path;

            if (useMJava)
                lbJavaPath.Text = path.Runtime;
            refreshVersions(null);
        }

        private void refreshVersions(string showVersion)
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
                                if (showVersion == null || !showVersionExist)
                                    btnSetLastVersion_Click(null, null);
                                else
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
                                if (showVersion == null || !showVersionExist)
                                    btnSetLastVersion_Click(null, null);
                                else
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
                            if (showVersion == null || !showVersionExist)
                                btnSetLastVersion_Click(null, null);
                            else
                                cbVersion.Text = showVersion;
                        }
                    }));
                }));
                th.Start();
            }
        }

        private void UpdateSession(MSession session)
        {
            //Session update blabla

            this.Session = session;
        }

        private void SetSession(MSession session)
        {
            lbUsername.Text = session.Username;
            this.Session = session;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var defaultPath = new MinecraftPath(MinecraftPath.GetOSDefaultPath());
            InitializeLauncher(defaultPath);
            Modlar frm = new Modlar() { TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frm);
            frm.Show();

            #region UpdateBrowser
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            webBrowser1.Navigate("https://launcher.mehmetali345.xyz/launcher.html");
            webBrowser1.ScriptErrorsSuppressed = true;
            #endregion

            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            LocalizationHelper.Update();

            lang();

            settings();
        }
        public void settings()
        {
            var settings = Settings.LoadSettings();

            var languages = LocalizationHelper.GetLanguages();
            languageCombo.Items.Clear();
            foreach (var language in languages)
            {
                languageCombo.Items.Add(language);
            }

            if (string.IsNullOrEmpty(settings.Language))
            {
                var defaultLanguage = languageCombo.Items.Add("Default (Build-in English)");
                languageCombo.SelectedIndex = defaultLanguage;
            }
            else
            {
                var index = languageCombo.Items.IndexOf(settings.Language);
                languageCombo.SelectedIndex = index;
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (chkStartUp.Checked == true)
            {
                if (guna2CheckBox1.Checked == true)
                {
                    client.Dispose();
                }

                this.Alert(LocalizationHelper.Base.Alert_Minimize, LocalizationHelper.Base.Alert_Minimize_Text, Form_Info.enmType.Info);

            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            //Not works but useful
            var form = new PathForm(MinecraftPath);
            form.ShowDialog();
            InitializeLauncher(form.MinecraftPath);
        }

        private void btnChangeJava_Click(object sender, EventArgs e)
        {
            // not works but useful

            var form = new JavaForm(useMJava, MinecraftPath.Runtime, javaPath);
            form.ShowDialog();

            useMJava = form.UseMJava;
            MinecraftPath.Runtime = form.MJavaDirectory;
            javaPath = form.JavaBinaryPath;

            if (useMJava)
                lbJavaPath.Text = form.MJavaDirectory;
            else
                lbJavaPath.Text = form.JavaBinaryPath;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            //Exit button
            Properties.Settings.Default.Save();
            Save_Data();
            this.Close();
            Application.Exit();

            var settings = new Settings
            {
                Language = languageCombo.Text,
            };

            Settings.SaveSettings(settings);
        }


        private void btnAutoRamSet_Click(object sender, EventArgs e)
        {
            // Auto ram set
            var computerMemory = Util.GetMemoryMb();
            if (computerMemory == null)
            {
                MessageBox.Show("RAM information could not be retrieved.");

            }

            var max = computerMemory / 2;
            if (max < 1024)
                max = 1024;
            else if (max > 8192)
                max = 8192;

            var min = max / 10;

            TxtXmx.Text = max.ToString();
            TxtXmx.Text = min.ToString();
        }


        private void btnRefreshVersion_Click(object sender, EventArgs e)
        {
            refreshVersions(null);
        }

        private void btnSetLastVersion_Click(object sender, EventArgs e)
        {
            cbVersion.Text = Versions.LatestReleaseVersion?.Name;
        }

        private MLaunchOption createLaunchOption()
        {
            //Sets launch options
            try
            {
                var launchOption = new MLaunchOption()
                {
                    Path = MinecraftPath,

                    MaximumRamMb = int.Parse(TxtXmx.Text),
                    Session = this.Session,
                    FullScreen = cbFullscreen.Checked,
                };

                if (!useMJava)
                    launchOption.JavaPath = javaPath;

                if (!string.IsNullOrEmpty(TxtXms.Text))
                    launchOption.MinimumRamMb = int.Parse(TxtXms.Text);

                if (!string.IsNullOrEmpty(Txt_JavaArgs.Text))
                    launchOption.JVMArguments = Txt_JavaArgs.Text.Split(' ');

                return launchOption;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create MLaunchOption\n\n" + ex.ToString());
                return null;
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            //Launches game

            string selected = this.cbVersion.GetItemText(this.cbVersion.SelectedItem);

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);

            if (Properties.Settings.Default.rpc == true)
            {
                client.UpdateState($"Playing {selected}.");
            }

            UpdateSession(MSession.GetOfflineSession(lbUsername.Text));
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
            var useParallel = rbParallelDownload.Checked;
            var checkHash = cbCheckFileHash.Checked;
            var downloadAssets = !cbSkipAssetsDownload.Checked;

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
                    if (useParallel)
                        downloader = new MParallelDownloader(MinecraftPath, versionInfo, 10, true);
                    else
                        downloader = new MDownloader(MinecraftPath, versionInfo);

                    downloader.ChangeFile += Launcher_FileChanged;
                    downloader.ChangeProgress += Launcher_ProgressChanged;
                    downloader.CheckHash = checkHash;
                    downloader.DownloadAll(downloadAssets);

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

        private void Launcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Progress bar
            Invoke(new Action(() =>
            {
                sa.Value = e.ProgressPercentage;
            }));
        }

        private void Launcher_FileChanged(DownloadFileChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                Pb_Progress.Value = e.TotalFileCount;
                Pb_Progress.Value = e.ProgressedFileCount;
                Lv_Status.Text = $"{e.FileKind.ToString()} : {e.FileName} ({e.ProgressedFileCount}/{e.TotalFileCount})";
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


        private void start(string url)
        {
            // error
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //log out
            login login = new login(Session);
            login.ShowDialog();
            SetSession(login.Session);
        }



        #endregion



        private void Init_Data() // Initting Ram or other settings data
        {
            if (Properties.Settings.Default.ram == "")
            {
                TxtXmx.Text = "1512";
            }
            else
            {
                TxtXmx.Text = Properties.Settings.Default.ram;
            }
            if (Properties.Settings.Default.mram == "")
            {
                TxtXms.Text = "1024";
            }
            else
            {
                TxtXms.Text = Properties.Settings.Default.mram;
            }

            if (Properties.Settings.Default.minimize == true)
            {
                chkStartUp.Checked = true;
            }
            else
            {
                chkStartUp.Checked = false;
            }
            if (Properties.Settings.Default.rpc == true)
            {
                guna2CheckBox1.Checked = true;
            }
            else
            {
                guna2CheckBox1.Checked = false;
            }

        }

        private void Save_Data() // Saving Options
        {
            Properties.Settings.Default.ram = TxtXmx.Text;
            Properties.Settings.Default.mram = TxtXms.Text;

            if (chkStartUp.Checked == true)
            {
                Properties.Settings.Default.minimize = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.minimize = false;
                Properties.Settings.Default.Save();
            }
            Properties.Settings.Default.Save();

        }

        #region Other buttons etc.
        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            Save_Data();
            var settings = new Settings
            {
                Language = languageCombo.Text,
            };

            Settings.SaveSettings(settings);
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            upcheck();
        }

        private void notify_icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            if (Properties.Settings.Default.rpc == true)
            {
                client.UpdateState("Main Screen");
            }
        }

        private void guna2TileButton7_Click(object sender, EventArgs e)
        {
            upcheck();
        }

        private void setbutton_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.Visible == false)
            {
                webBrowser1.Visible = false;
                metroTabControl1.Visible = true;
                setButton.Font = new Font(setButton.Font.FontFamily, 10);
                setButton.Image = Properties.Resources.icons8_globe_48px;
            }
            else
            {
                webBrowser1.Visible = true;
                metroTabControl1.Visible = false;            
                setButton.Image = Properties.Resources.icons8_settings_48px;
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                rpc();
            }
            else
            {
                client.Dispose();
            }
        }

        private void snapbox_CheckedChanged(object sender, EventArgs e)
        {
            refreshVersions(null);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mehmetali345.xyz");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mehmetali345.xyz/donate");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mehmetali345Dev");
        }


        private void guna2Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/syprbuqGSw");
        }
        #endregion

        private void lbJavaPath_Click(object sender, EventArgs e)
        {

        }
    }
}

