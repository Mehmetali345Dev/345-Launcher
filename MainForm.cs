using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Downloader;
using CmlLib.Core.Version;
using DiscordRPC;
using DiscordRPC.Logging;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace _345_Launcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            versiyon();
            Init_Data();
            rpc();
            cbVersion.DropDownHeight = 200;
        }


        public void Alert(string msg, string msg2, string msg3, Form_Info.enmType type)
        {
            Form_Info frm = new Form_Info();
            frm.showAlert(msg, msg2, msg3, type);
        }

        #region stringler ıvır zıvırlar
        bool useMJava = true;
        string javaPath = "java.exe";
        bool mcactive = false;

        MinecraftPath MinecraftPath;
        MVersionCollection Versions;
        MSession Session = MSession.GetOfflineSession("test_user");

        public string LabelText
        {
            get
            {
                return this.lbUsername.Text;
            }
            set
            {
                this.lbUsername.Text = value;
            }
        }

        public DiscordRpcClient client;

        #endregion
        private void rpc()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);

            client = new DiscordRpcClient("814773064671690762");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = $"v. {versionInf.FileVersion}",
                State = "Ana Menüde",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "launcher",
                    LargeImageText = $"345 Launcher v. {versionInf.FileVersion}",
                }
            });
        }

        #region update
        private void versiyon()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            uplabel.Text += $"v.{versionInfo.FileVersion}";
        }
        #endregion

        #region Launcher
        private void InitializeLauncher(MinecraftPath path)
        {
            txtPath.Text = path.BasePath;
            MinecraftPath = path;

            if (useMJava)
                lbJavaPath.Text = path.Runtime;
            refreshVersions(null);
        }

        private void refreshVersions(string showVersion)
        {
            cbVersion.Items.Clear();

            var th = new Thread(new ThreadStart(delegate
            {
                Versions = new MVersionLoader().GetVersionMetadatas(MinecraftPath);

                Invoke(new Action(() =>
                {
                    bool showVersionExist = false;
                    if(metroCheckBox1.Checked == true)
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

        private void UpdateSession(MSession session)
        {
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
            metroPanel1.AutoScroll = true;
            Modlar frm = new Modlar() { TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frm);
            frm.Show();

            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            webBrowser1.Navigate("https://launcher.mehmetali345.xyz");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (chkStartUp.Checked == true)
            {
                client.Dispose();
                this.Alert("Launcher küçültüldü", "Tekrar açmak için bildirim ", "simgesine 2 kere tıklayın.", Form_Info.enmType.minimized);
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnChangePath_Click_1(object sender, EventArgs e)
        {
            var form = new PathForm(MinecraftPath);
            form.ShowDialog();
            InitializeLauncher(form.MinecraftPath);
        }

        private void btnChangeJava_Click(object sender, EventArgs e)
        {
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
            Save_Data();
            this.Close();
            Application.Exit();
        }


        private void btnAutoRamSet_Click(object sender, EventArgs e)
        {
            var computerMemory = Util.GetMemoryMb();
            if (computerMemory == null)
            {
                MessageBox.Show("RAM bilgisi alınamadı.");
                return;
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

        private void btnForgeInstall_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                var forgeJava = "";

                if (useMJava)
                {
                    var java = new MJava();
                    java.ProgressChanged += Launcher_ProgressChanged;
                    forgeJava = java.CheckJava();
                }
                else
                    forgeJava = javaPath;

                Invoke(new Action(() =>
                {
                    var forgeForm = new ForgeInstall(MinecraftPath, forgeJava);
                    forgeForm.ShowDialog();
                    refreshVersions(forgeForm.LastInstalledVersion);
                }));
            }).Start();
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
            try
            {
                var launchOption = new MLaunchOption()
                {
                    Path = MinecraftPath,

                    MaximumRamMb = int.Parse(TxtXmx.Text),
                    Session = this.Session,


                    FullScreen = cbFullscreen.Checked,

                    ServerIp = Txt_ServerIp.Text,

                };

                if (!useMJava)
                    launchOption.JavaPath = javaPath;

                if (!string.IsNullOrEmpty(TxtXms.Text))
                    launchOption.MinimumRamMb = int.Parse(TxtXms.Text);

                if (!string.IsNullOrEmpty(Txt_ServerPort.Text))
                    launchOption.ServerPort = int.Parse(Txt_ServerPort.Text);

                if (!string.IsNullOrEmpty(Txt_ScWd.Text) && !string.IsNullOrEmpty(Txt_ScHt.Text))
                {
                    launchOption.ScreenHeight = int.Parse(Txt_ScHt.Text);
                    launchOption.ScreenWidth = int.Parse(Txt_ScWd.Text);
                }

                if (!string.IsNullOrEmpty(Txt_JavaArgs.Text))
                    launchOption.JVMArguments = Txt_JavaArgs.Text.Split(' ');

                return launchOption;
            }
            catch (Exception ex) // exceptions. like FormatException in int.Parse
            {
                MessageBox.Show("Failed to create MLaunchOption\n\n" + ex.ToString());
                this.Alert("MLaunchOption oluşamadı", "Eğer sorun devam ederse", "geri bildirim gönderin.", Form_Info.enmType.Error);
                return null;
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            mcactive = true;
            client.Dispose();
            string selected = this.cbVersion.GetItemText(this.cbVersion.SelectedItem);

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);

            client = new DiscordRpcClient("814773064671690762");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = $"v. {versionInf.FileVersion}",
                State = $"{selected} oynuyor.",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "launcher",
                    LargeImageText = $"345 Launcher v. {versionInf.FileVersion}",
                }
            }); ;

            UpdateSession(MSession.GetOfflineSession(lbUsername.Text));
            if (Session == null)
            {
                MessageBox.Show("İlk önce giriş yap");
                return;
            }

            if (cbVersion.Text == "")
            {
                MessageBox.Show("Versiyon Seç");
                return;
            }

            var launchOption = createLaunchOption();
            if (launchOption == null)
                return;

            var version = cbVersion.Text;
            var useParallel = rbParallelDownload.Checked;
            var checkHash = cbCheckFileHash.Checked;
            var downloadAssets = !cbSkipAssetsDownload.Checked;

            var th = new Thread(() =>
            {
                try
                {
                    if (useMJava) // Download Java
                    {
                        var mjava = new MJava(MinecraftPath.Runtime);
                        mjava.ProgressChanged += Launcher_ProgressChanged;

                        var javapath = mjava.CheckJava();
                        launchOption.JavaPath = javapath;
                    }

                    MVersion versionInfo = Versions.GetVersion(version); // Get Version Info
                    launchOption.StartVersion = versionInfo;

                    MDownloader downloader; // Create Downloader
                    if (useParallel)
                        downloader = new MParallelDownloader(MinecraftPath, versionInfo, 10, true);
                    else
                        downloader = new MDownloader(MinecraftPath, versionInfo);

                    downloader.ChangeFile += Launcher_FileChanged;
                    downloader.ChangeProgress += Launcher_ProgressChanged;
                    downloader.CheckHash = checkHash;
                    downloader.DownloadAll(downloadAssets);

                    var launch = new MLaunch(launchOption); // Create Arguments and Process
                    var process = launch.GetProcess();

                    StartProcess(process); // Start Process with debug options

                    // or just start process
                    // process.Start();
                }
                catch (MDownloadFileException mex) // download exception
                {
                    MessageBox.Show(
                        $"FileName : {mex.ExceptionFile.Name}\n" +
                        $"FilePath : {mex.ExceptionFile.Path}\n" +
                        $"FileUrl : {mex.ExceptionFile.Url}\n" +
                        $"FileType : {mex.ExceptionFile.Type}\n\n" +
                        mex.ToString());
                }
                catch (Win32Exception wex) // java exception
                {
                    MessageBox.Show(wex.ToString() + "\n\nJava Problemi");
                }
                catch (Exception ex) // all exception
                {
                    MessageBox.Show(ex.ToString());
                    this.Alert("Oyun başlatılamadı", "Libaryler indirilemedi veya", "birşeyler ters gitti.", Form_Info.enmType.Error);
                }
            });
            th.Start();
        }

        private void Launcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                Pb_Progress.Value = e.ProgressPercentage;
            }));
        }

        private void Launcher_FileChanged(DownloadFileChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                Pb_File.Maximum = e.TotalFileCount;
                Pb_File.Value = e.ProgressedFileCount;
                Lv_Status.Text = $"{e.FileKind.ToString()} : {e.FileName} ({e.ProgressedFileCount}/{e.TotalFileCount})";
            }));
        }

        private void StartProcess(Process process)
        {
            File.WriteAllText("Ayarlar.txt", process.StartInfo.Arguments);
            output(process.StartInfo.Arguments);

            // process options to display game log

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.EnableRaisingEvents = true;
            process.ErrorDataReceived += Process_ErrorDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            output(e.Data);
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            output(e.Data);
        }

        void output(string msg)
        {
            GameLog.AddLog(msg);
        }


        private void start(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Alert("Oyun başlatılamadı", "Libaryler indirilemedi veya", "birşeyler ters gitti.", Form_Info.enmType.Error);
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anakin Skywalker");
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mehmetali345.xyz");

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://launcher.mehmetali345.xyz");
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mehmetali345");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login login = new login(Session);
            login.ShowDialog();
            SetSession(login.Session);
        }



        #endregion

        #region notifyicon

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && chkStartUp.Checked == true)
            {
                Hide();
                notify_icon.Visible = true;
            }
        }


        #endregion

        private void Init_Data()
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
        }

        private void Save_Data() //Beni hatırla için string kaydı
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

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            Save_Data();
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void notify_icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);

            client = new DiscordRpcClient("814773064671690762");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = $"v. {versionInf.FileVersion}",
                State = "Ana Menüde",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "launcher",
                    LargeImageText = $"345 Launcher v. {versionInf.FileVersion}",
                }
            });
        }

        private void guna2TileButton6_Click(object sender, EventArgs e)
        {
            Process.Start("BugBildir.exe");
        }

        private void guna2TileButton7_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            refreshVersions(null);
        }

       
    }
}

