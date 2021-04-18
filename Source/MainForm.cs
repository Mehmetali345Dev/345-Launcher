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
using System.Runtime.CompilerServices;
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
            updenetle();
            Init_Data();
            cbVersion.DropDownHeight = 200;
            if (Properties.Settings.Default.rpc == true)
            {
                rpc();
            }
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }


        public void Alert(string msg, string msg2, string msg3, Form_Info.enmType type)
        {
            Form_Info frm = new Form_Info();
            frm.showAlert(msg, msg2, msg3, type);
        }

        public void updenetle()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);
            string v = versionInf.FileVersion;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            timer1.Start();
            string hedef = "https://launcher.mehmetali345.xyz/assets/update.html";
            WebRequest istek = HttpWebRequest.Create(hedef);
            WebResponse yanit;
            yanit = istek.GetResponse();
            StreamReader bilgiler = new StreamReader(yanit.GetResponseStream());
            string gelen = bilgiler.ReadToEnd();
            int baslangic = gelen.IndexOf("<p>") + 3;
            int bitis = gelen.Substring(baslangic).IndexOf("</p>");
            string gelenbilgileri = gelen.Substring(baslangic, bitis);
            v = Convert.ToString(gelenbilgileri);

            if (v == versionInf.FileVersion)
            {
                uplabel.Text = v;
            }
            else
            {
                if (MessageBox.Show("Güncelleme mevcut indirilsinmi?", "345 Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    using (var client = new WebClient())
                    {
                        Update up = new Update();
                        up.Show();
                    }
                else
                {
                    this.Alert("Güncelleme Mevcut", "Lütfen son deneyim için", "güncellemeyi indirin.", Form_Info.enmType.Info);
                }
            }
        }

        #region stringler ıvır zıvırlar
        bool useMJava = true;
        string javaPath = "java.exe";
        private const int cGrip = 16;
        private const int cCaption = 32;
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

        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if(pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if(pos.X > this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion
        private void rpc()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);

            client = new DiscordRpcClient("814773064671690762");
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

            //uplabel.Text += $"v.{versionInfo.FileVersion}";
            uplabel.Text += versionInfo.FileVersion;

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
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                var th = new Thread(new ThreadStart(delegate
                {
                    Versions = new MVersionLoader().GetVersionMetadatas(MinecraftPath);

                    Invoke(new Action(() =>
                    {
                        bool showVersionExist = false;
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

            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            webBrowser1.Navigate("https://launcher.mehmetali345.xyz/launcher.html");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (chkStartUp.Checked == true)
            {
                if (guna2CheckBox1.Checked == true)
                {
                    client.Dispose();
                }
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
                this.Alert("MLaunchOption oluşamadı", "Eğer sorun devam ederse", "geri bildirim gönderin.", Form_Info.enmType.Error);
                return null;
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            string selected = this.cbVersion.GetItemText(this.cbVersion.SelectedItem);

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInf = FileVersionInfo.GetVersionInfo(assembly.Location);

            if (guna2CheckBox1.Checked == true)
            {
                client.UpdateState($"{selected} oynuyor.");
            }

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
                    if (useMJava)
                    {
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
                    MessageBox.Show(wex.ToString() + "\n\nJava Problemi");
                }
                catch (Exception ex)
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
            File.WriteAllText(path + @"\Argümanlar.txt", process.StartInfo.Arguments);
            output(process.StartInfo.Arguments);

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
            if (Properties.Settings.Default.rpc == true)
            {
                guna2CheckBox1.Checked = true;
            }
            else
            {
                guna2CheckBox1.Checked = false;
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
            if (guna2CheckBox1.Checked == true)
            {
                client.UpdateState("Anamenüde");
            }
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


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.Visible == false)
            {
                metroTabControl1.Visible = true;
                guna2Button2.Text = "Ana Ekran";
                guna2Button2.Font = new Font(guna2Button2.Font.FontFamily, 10);
                guna2Button2.Image = Properties.Resources.icons8_globe_48px;
            }
            else
            {
                metroTabControl1.Visible = false;
                guna2Button2.Text = "Ayarlar";
                guna2Button2.Image = Properties.Resources.icons8_settings_48px;
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
    }
}

