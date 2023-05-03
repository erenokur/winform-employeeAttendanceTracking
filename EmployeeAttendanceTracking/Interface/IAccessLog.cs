using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceTracking.Interface
{
    public interface IAccessLog
    {
        string LogID { get; set; }
        string ComputerHash { get; set; }
        string IPAddress { get; set; }
        string UserID { get; set; }
        string Username { get; set; }
        string AccessLocation { get; set; }
        int AccessDirection { get; set; }
        int VerifyStatusCode { get; set; }
        string AdditionalInfo { get; set; }
        DateTime LogTime { get; set; }
    }
}
