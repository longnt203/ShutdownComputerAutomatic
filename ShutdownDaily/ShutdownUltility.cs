using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace ShutdownDaily
{
    public static class ShutdownUltility
    {
        public static void SetupShutdown(int hour, int minute, out DateTime timeWillShutdown)
        {
            timeWillShutdown = DateTime.Now.Date.AddHours(hour).AddMinutes(minute);
            StopShutdown();
            Thread.Sleep(1000);
            if (timeWillShutdown < DateTime.Now)
                timeWillShutdown = timeWillShutdown.AddDays(1);
            int SecondsTimeShutdown = Convert.ToInt32((timeWillShutdown - DateTime.Now).TotalSeconds);
            ShutdownByTime(SecondsTimeShutdown);
        }

        public static void StopShutdown()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = @"C:\Windows\System32\shutdown.exe";
            startInfo.Arguments = "/a";
            process.StartInfo = startInfo;
            process.Start();
        }
        /// <summary>
        /// Tắt máy tự động
        /// </summary>
        /// <param name="interval">tính bằng giây</param>
        public static void ShutdownByTime(int interval)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = @"C:\Windows\System32\shutdown.exe";
            startInfo.Arguments = string.Format("/s /f /t {0}", interval);
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void SetupDailyShutdown(out DateTime timeWillShutdown)
        {
            timeWillShutdown = Properties.Settings.Default.ShutdownToday;
            if (Properties.Settings.Default.ShutdownToday < DateTime.Now)
            {
                SetupShutdown(Properties.Settings.Default.DailyShudownHour, Properties.Settings.Default.DailyShudownMinute, out timeWillShutdown);
                SaveSetting(timeWillShutdown);
            }
        }
        public static void SaveSetting(DateTime timeWillShutdown, int? DailyHour = null, int? dailyMinute = null)
        {
            Properties.Settings.Default.ShutdownToday = timeWillShutdown;
            if (DailyHour.HasValue) Properties.Settings.Default.DailyShudownHour = DailyHour.Value;
            if (dailyMinute.HasValue) Properties.Settings.Default.DailyShudownMinute = dailyMinute.Value;
            Properties.Settings.Default.Save();
        }
    }
}
