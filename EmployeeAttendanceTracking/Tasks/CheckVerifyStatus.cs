using EmployeeAttendanceTracking.Api;
using EmployeeAttendanceTracking.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAttendanceTracking.Tools
{
    class CheckVerifyStatus
    {
        /// <summary>
        /// This is new thread to show unregistered activity. 
        /// </summary>
        /// <param name="log"></param>
        /// <param name="logger"></param>
        public CheckVerifyStatus(AccessLog log, AppLogger logger)
        {
            try
            {
                Task.Run(() =>
                {
                    if (log.VerifyStatusCode > 0)
                    {
                        CheckDirection checkDirection = new CheckDirection();
                        string direction = checkDirection.CheckForString(log);
                        var owner = new Form() { Size = new Size(0, 0) };
                        Task.Delay(TimeSpan.FromSeconds(10))
                            .ContinueWith((t) => owner.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                        var dialogRes = MessageBox.Show(owner, "kullanıcı " + log.Username + " yetkisiz " + direction + " yaptı.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogRes == DialogResult.OK)
                        {
                            logger.AcceptPopUp();
                            AccessLogApi api = new AccessLogApi();
                            api.PostUser(log, logger);
                        }
                        else
                        {
                            logger.AutoClosedPopUp();
                            SendMail mailServer = new SendMail();
                            mailServer.SendEmail(log, direction, logger);
                        }
                        checkDirection.CheckForUserLogging(log, logger);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception is " + ex);

            }

        }
    }
}
