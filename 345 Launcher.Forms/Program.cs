using System;
using System.Windows.Forms;
using _345_Launcher.Source;

namespace _345_Launcher
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash_Form());
        }

    }
}
