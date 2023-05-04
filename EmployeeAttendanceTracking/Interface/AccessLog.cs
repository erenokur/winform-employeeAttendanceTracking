using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceTracking.Interface
{
    /// <summary>
    /// Access log interface
    /// </summary>
    public class AccessLog : IAccessLog
    {
        public string LogID { get; set; }
        public string ComputerHash { get; set; }
        public string IPAddress { get; set; }
        public string UserID { get; set; }
        public string Username { get; set; }
        public string AccessLocation { get; set; }
        public int AccessDirection { get; set; }
        public int VerifyStatusCode { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime LogTime { get; set; }

    }
}
