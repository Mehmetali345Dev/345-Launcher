using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Downloader;
using Figgle;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _345_Launcher__Core
{
    class Program
    {
        public bool islogin = true;
        static void Main()
        {

            var p = new Program();

            p.menu();

        }

        public MSession session;
        public void menu()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("345 Launcher"));

            var p = new Program();

            if (islogin == true)
            {
                session = p.OfflineLogin();
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz " + session.Username);
            }

            Console.WriteLine("Oyun[1]\tAyarlar[2]\tHakkında[3]");

            string menu;

            const int MaxLength = 1;

            menu = Console.ReadLine();
            if (menu.Contains("1") || menu.Contains("2") || menu.Contains("3"))
            {
                menu.Substring(0, MaxLength);

                if (menu == "1")
                {
                    p.Start(session).GetAwaiter().GetResult();
                }
                else if (menu == "2")
                {

                }
                else if (menu == "3")
                {
                    p.about();
                }
            }
            else
            {
                Console.WriteLine("Hata!!!\nLütfen geçerli bir sayı girin");
            }
        }

        public void about()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("Mehmetali345Dev"));
            Console.WriteLine("tarafından geliştirildi.");
            Console.WriteLine("Geri dönmek için Enter tuşuna basın.");
          if(Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                var p = new Program();

                p.menu();
            }
        }

        MSession OfflineLogin()
        {
            Console.WriteLine("Kullanıcı Adı Seçin:");

            string username;

            username = Console.ReadLine();

            return MSession.GetOfflineSession(username);

            Console.WriteLine("Hoşgeldiniz " + username);

            islogin = false;

        }

        async Task Start(MSession session)
        {

            var path = MinecraftPath.GetOSDefaultPath();
            var game = new MinecraftPath(path);

            // Create CMLauncher instance
            var launcher = new CMLauncher(game);

            // if you want to download with parallel downloader, add below code :
            System.Net.ServicePointManager.DefaultConnectionLimit = 256;

            launcher.ProgressChanged += Downloader_ChangeProgress;
            launcher.FileChanged += Downloader_ChangeFile;

            Console.WriteLine($"Initialized in {launcher.MinecraftPath.BasePath}");

            // Get all installed profiles and load all profiles from mojang server
            var versions = await launcher.GetAllVersionsAsync();

            foreach (var item in versions) // Display all profiles 
            {
                // You can filter snapshots and old versions to add if statement : 
                if (item.MType == CmlLib.Core.Version.MVersionType.Release || item.MType == CmlLib.Core.Version.MVersionType.Custom)
                {
                    List<string> list = new List<string> { item.Type + " " + item.Name };

                    list.ForEach(i => Console.Write("{0}\n", i));
                }


            }

            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 1024,
                Session = session,
            };


            Console.WriteLine("input version (example: 1.12.2) : ");
            var process = await launcher.CreateProcessAsync(Console.ReadLine(), launchOption);

            //var process = launcher.CreateProcess("1.16.2", "33.0.5", launchOption);
            Console.WriteLine(process.StartInfo.Arguments);

            // Below codes are print game logs in Console.
            var processUtil = new CmlLib.Utils.ProcessUtil(process);
            processUtil.OutputReceived += (s, e) => Console.WriteLine(e);
            processUtil.StartWithEvents();
            process.WaitForExit();

            // or just start it without print logs
            // process.Start();

            Console.ReadLine();
            return;
        }

        #region QuickStart

        // this code is from README.md

        #endregion


        #region Pretty event handler

        int endTop = -1;

        private void Downloader_ChangeProgress(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Console.SetCursorPosition(0, endTop);

            Console.Write("{0}%       ", e.ProgressPercentage);

            Console.SetCursorPosition(0, endTop);
        }

        private void Downloader_ChangeFile(DownloadFileChangedEventArgs e)
        {
            // https://github.com/AlphaBs/CmlLib.Core/wiki/Handling-Events#downloadfilechangedeventargs

            Console.WriteLine("[{0}] ({2}/{3}) {1}   ", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount);

            endTop = Console.CursorTop;
        }

        #endregion

        #region Simple event handler
        //private void Downloader_ChangeProgress(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        //{
        //    Console.WriteLine("{0}%", e.ProgressPercentage);
        //}

        //private void Downloader_ChangeFile(DownloadFileChangedEventArgs e)
        //{
        //    Console.WriteLine("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount);
        //}
        #endregion
    }
}