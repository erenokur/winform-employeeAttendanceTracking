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
using System.Threading;

namespace EmployeeAttendanceTracking
{
    public partial class Form1 : Form
    {
        AppLogger logger = new AppLogger();
        RequestAccessLog requestTask = new RequestAccessLog();
        AccessLogQueue<AccessLog> accessQueue = new AccessLogQueue<AccessLog>();
        public Form1()
        {
            InitializeComponent();
            logger.LogAppStartDate();
            requestTask.StartRequesting(accessQueue, logger, dataGridView1);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}
