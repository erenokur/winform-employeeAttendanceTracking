using EmployeeAttendanceTracking.Enums;
using EmployeeAttendanceTracking.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceTracking.Tools
{
    class CheckDirection
    {
        /// <summary>
        /// This function get sting for GUI information
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public string CheckForString(AccessLog log)
        {
            if (log.AccessDirection == 0)
            {
                return "çıkış";
            }
            else
            {
                return "giriş";
            }
        }
        /// <summary>
        /// This function log user direction when unregistered activity happend
        /// </summary>
        /// <param name="log"></param>
        /// <param name="logger"></param>
        public void CheckForUserLogging(AccessLog log, AppLogger logger)
        {
            if (log.AccessDirection == 0)
            {
                logger.LogEmployeeLeft(log.Username);
            }
            else
            {
                logger.LogEmployeeEntered(log.Username);
            }
        }
    }
}
