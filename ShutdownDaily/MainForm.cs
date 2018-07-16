using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ShutdownDaily
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SettingOpenForm();
        }

        private void SettingOpenForm()
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            tmCurrentTime.Start();
            dtpShutdownDaily.Format = DateTimePickerFormat.Custom;
            dtpShutdownDaily.CustomFormat = "HH:mm";

            //Properties.Settings.Default.ShutdownToday = DateTime.Now.AddDays(-1);
            //Properties.Settings.Default.Save();
            DateTime timeWillShutdown = Properties.Settings.Default.ShutdownToday;
            ShutdownUltility.SetupDailyShutdown(out timeWillShutdown);

            dtpShutdownDaily.Value = DateTime.Now.Date.AddHours(Properties.Settings.Default.DailyShudownHour).AddMinutes(Properties.Settings.Default.DailyShudownMinute);
            dtpShutdownOne.Value = lastDailyTime = timeWillShutdown;
            lblShutdownAt.Text = timeWillShutdown.ToString("HH:mm");
        }

        private void tmCurrentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        DateTime lastDailyTime;
        private void dtpTimeShutdownDaily_ValueChanged(object sender, EventArgs e)
        {
            dtpShutdownDaily.ValueChanged -= dtpTimeShutdownDaily_ValueChanged;
            switch (dtpShutdownDaily.Value.Minute)
            {
                case 1:
                case 31:
                    dtpShutdownDaily.Value = lastDailyTime.AddMinutes(30);
                    break;
                case 29:
                case 59:
                    dtpShutdownDaily.Value = lastDailyTime.AddMinutes(-30);
                    break;
            }
            dtpShutdownDaily.ValueChanged += dtpTimeShutdownDaily_ValueChanged;
            lastDailyTime = dtpShutdownDaily.Value;
        }

        DateTime lastOneTime;
        private void dtpShutdownOne_ValueChanged(object sender, EventArgs e)
        {
            dtpShutdownOne.ValueChanged -= dtpShutdownOne_ValueChanged;
            switch (dtpShutdownOne.Value.Minute)
            {
                case 1:
                case 31:
                    dtpShutdownOne.Value = lastOneTime.AddMinutes(30);
                    break;
                case 29:
                case 59:
                    dtpShutdownOne.Value = lastOneTime.AddMinutes(-30);
                    break;
            }
            dtpShutdownOne.ValueChanged += dtpShutdownOne_ValueChanged;
            lastOneTime = dtpShutdownOne.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (sender != null)
            //{
            //    ntiShutdown.Visible = false;
            //    ntiShutdown.Visible = true;
            //    this.Hide();
            //    e.Cancel = true;
            //}
        }

        private void btnShutdownDaily_Click(object sender, EventArgs e)
        {
            DateTime timeWillShutdown;
            ShutdownUltility.SetupShutdown(dtpShutdownDaily.Value.Hour, dtpShutdownDaily.Value.Minute, out timeWillShutdown);
            lblShutdownAt.Text = timeWillShutdown.ToString("HH:mm");
            ShutdownUltility.SaveSetting(timeWillShutdown, dtpShutdownDaily.Value.Hour, dtpShutdownDaily.Value.Minute);
        }
              

        private void btnShutdownOne_Click(object sender, EventArgs e)
        {
            DateTime timeWillShutdown;
            ShutdownUltility.SetupShutdown(dtpShutdownOne.Value.Hour, dtpShutdownOne.Value.Minute, out timeWillShutdown);
            lblShutdownAt.Text = timeWillShutdown.ToString("HH:mm");
            ShutdownUltility.SaveSetting(timeWillShutdown);
        }

        private void btnShutdownNow_Click(object sender, EventArgs e)
        {
            ShutdownUltility.StopShutdown();
            ShutdownUltility.ShutdownByTime(0);
        }

        private void btnStopToday_Click(object sender, EventArgs e)
        {
            ShutdownUltility.StopShutdown();
            ShutdownUltility.SaveSetting(DateTime.Now.Date.AddDays(1));
            lblShutdownAt.Text = "";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
        }

        private void lblStopShutdown_DoubleClick(object sender, EventArgs e)
        {
            ShutdownUltility.StopShutdown();
            ShutdownUltility.SaveSetting(DateTime.Now.Date.AddDays(-1));
            lblShutdownAt.Text = "";
        }
    }
}
