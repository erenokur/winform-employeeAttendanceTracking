using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceTracking.Tools
{
    class CheckSetting
    {
        /// <summary>
        /// Check if user saved email settings
        /// </summary>
        /// <returns></returns>
        public bool CheckMailSettingDone()
        {
            if ((new[] { Properties.Settings.Default.SMTP_SERVER, Properties.Settings.Default.SMTP_PORT, Properties.Settings.Default.SMTP_USERNAME, Properties.Settings.Default.SMTP_PASSWORD, Properties.Settings.Default.ADMIN_EMAIL }).Any(string.IsNullOrEmpty))
            {
                return false;
            }
            return true;
        }
    }
}
