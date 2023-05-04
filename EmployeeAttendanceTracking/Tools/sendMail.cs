using EmployeeAttendanceTracking.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceTracking.Tools
{
    class SendMail
    {
        /// <summary>
        /// SMTP mail server. 
        /// </summary>
        /// <param name="log"></param>
        /// <param name="direction"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        public bool SendEmail(AccessLog log, string direction, AppLogger logger)
        {
            try
            {
                var fromAddress = new MailAddress(Properties.Settings.Default.SMTP_USERNAME, "Sender");
                var toAddress = new MailAddress(Properties.Settings.Default.ADMIN_EMAIL, "Recipient");
                var smtpClient = new SmtpClient
                {
                    Host = Properties.Settings.Default.SMTP_SERVER,
                    Port = int.Parse(Properties.Settings.Default.SMTP_PORT),
                    EnableSsl = Properties.Settings.Default.SSL_ENABLED,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, Properties.Settings.Default.SMTP_PASSWORD)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = "Onaylanmamış Kullanıcı Geçişi",
                    Body = log.Username.ToString() + " yetkisiz " + direction + " yaptı.",
                    IsBodyHtml = true
                })
                {
                    smtpClient.Send(message);
                }

                return true;
            }
            catch (Exception ex)
            {
                logger.LogErrors(ex.Message, "SendEmail");
                return false;
            }
        }
    }
}
