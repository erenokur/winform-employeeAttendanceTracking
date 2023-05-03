using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAttendanceTracking.Api;
using EmployeeAttendanceTracking.Interface;
using EmployeeAttendanceTracking.Lists;
using EmployeeAttendanceTracking.Tools;

namespace EmployeeAttendanceTracking.Tasks
{
    class RequestAccessLog
    {
        private readonly AccessLogApi api = new AccessLogApi();
        public void StartRequesting(AccessLogQueue<AccessLog> queue, AppLogger logger, DataGridView grid)
        {
            var task = Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        AccessLog accessLog = await api.GetAccesLog(logger);
                        queue.Push(accessLog);
                        grid.Invoke(new Action(() =>
                        {
                            grid.DataSource = queue.GetAll();
                        }));
                        CheckVerifyStatus statusCheck = new CheckVerifyStatus(accessLog, logger);
                        await Task.Delay(40000);
                    }
                    catch (Exception ex)
                    {
                        logger.LogErrors(ex.Message, "AccessLogApi");
                        await Task.Delay(40000);
                    }
                }
            });


        }
    }
}
