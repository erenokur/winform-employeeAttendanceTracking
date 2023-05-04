using EmployeeAttendanceTracking.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAttendanceTracking.Tasks;
using EmployeeAttendanceTracking.Lists;
using EmployeeAttendanceTracking.Interface;
using EmployeeAttendanceTracking.Forms;
using System.Threading;
using EmployeeAttendanceTracking.Api;

namespace EmployeeAttendanceTracking
{
    public partial class MainForm : Form
    {
        AppLogger logger = new AppLogger();
        RequestAccessLog requestTask = new RequestAccessLog();
        AccessLogQueue<AccessLog> accessQueue = new AccessLogQueue<AccessLog>();
        CheckSetting checkSetting = new CheckSetting();
        private bool processStarted = false;
        public MainForm()
        {
            InitializeComponent();
            logger.LogAppStartDate();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// If settings are right process start or give error.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (checkSetting.CheckMailSettingDone())
            {
                processStarted = true;
                statusLabel.Text = "Mail ayarları yapılmış. Uygulama çalışıyor.";
                requestTask.StartRequesting(accessQueue, logger, dataGridView1);
            }
            else
            {
                statusLabel.Text = "Mail ayarları yapılmadan uygulama kullanılmamalıdır.";
            }
        }
        /// <summary>
        /// Settings form will be shown here
        /// </summary>
        private void showSettings()
        {
            SettingsForm settings = new SettingsForm();
            settings.FormClosed += new FormClosedEventHandler(SettingsFormClosed);
            settings.BringToFront();
            settings.Focus();
            settings.Show();
        }
        /// <summary>
        /// When setting form closed. Process checks settings and existing process.
        /// If existing process running or mail settings are not valid system is not going to start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsFormClosed(object sender, FormClosedEventArgs e)
        {
            if (checkSetting.CheckMailSettingDone() && !processStarted)
            {
                processStarted = true;
                requestTask.StartRequesting(accessQueue, logger, dataGridView1);
            }
        }
        /// <summary>
        /// Settings button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_Click(object sender, EventArgs e)
        {
            showSettings();
        }
    }
}
