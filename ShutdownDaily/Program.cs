using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShutdownDaily
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Count() > 0 && !string.IsNullOrEmpty(args[0]) && args[0].ToLower().Contains("startup"))
            {
                DateTime timeWillShutdown = Properties.Settings.Default.ShutdownToday;
                ShutdownUltility.SetupDailyShutdown(out timeWillShutdown);
                //MessageBox.Show(string.Format("OK - {0}", timeWillShutdown.ToString("HH:mm")));
                Application.Exit();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
