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
        public CheckVerifyStatus(AccessLog log, AppLogger logger)
        {
            try
            {
                Task.Run(() =>
                {
                    if (log.VerifyStatusCode > 0)
                    {
                        var owner = new Form() { Size = new Size(0, 0) };
                        Task.Delay(TimeSpan.FromSeconds(10))
                            .ContinueWith((t) => owner.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                        var dialogRes = MessageBox.Show(owner, "", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //DialogResult result = MessageBox.Show("Are you sure you want to continue?", "Confirmation", MessageBoxButtons.OK);
                        if (dialogRes == DialogResult.OK)
                        {
                            logger.AcceptPopUp();
                        }
                        else
                        {
                            logger.AutoClosedPopUp();
                        }
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
