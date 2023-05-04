using NLog;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EmployeeAttendanceTracking.Tools
{
    class AppLogger
    {
        readonly string logFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "logs");
        readonly Logger logger;
        public AppLogger()
        {
            logger = LogManager.GetLogger("app_logger");
        }

        public void LogAppStartDate()
        {
            logger.Info("App started..");
        }

        public void LogEmployeeEntered(string name)
        {
            logger.Info("Employee " + name + " entered without permission!");
        }

        public void LogEmployeeLeft(string name)
        {
            logger.Info("Employee " + name + " left without permission!");
        }

        public void AcceptPopUp()
        {
            logger.Info("Popup closed by operator");
        }
        public void AutoClosedPopUp()
        {
            logger.Info("Popup not closed by operator");
        }

        public void LogErrors(string error, string functionName)
        {
            logger.Error(functionName + " gived : " + error);
        }

    }
}
