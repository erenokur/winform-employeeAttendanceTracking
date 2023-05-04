using EmployeeAttendanceTracking.Interface;
using EmployeeAttendanceTracking.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceTracking.Api
{
    class AccessLogSocket
    {

        /// <summary>
        /// This code is for socket API requests.
        /// </summary>
        /// <param name="logger"></param>
        /// <returns></returns>
        public async Task<AccessLog> GetAccessLog(AppLogger logger)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    string host = Properties.Settings.Default.API_IP;
                    int port = 80;
                    string endpoint = Properties.Settings.Default.API_ENDPOINT;
                    await client.ConnectAsync(host, port);
                    using (NetworkStream stream = client.GetStream())
                    using (StreamWriter writer = new StreamWriter(stream))
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        await writer.WriteLineAsync($"GET  {endpoint} HTTP/1.1");
                        await writer.WriteLineAsync($"Host: {host}");
                        await writer.WriteLineAsync();
                        await writer.FlushAsync();
                        string response = await reader.ReadToEndAsync();
                        AccessLog accessLog = JsonConvert.DeserializeObject<AccessLog>(response, new JsonSerializerSettings
                        {
                            ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
                        });
                        return accessLog;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogErrors(ex.ToString(), "GetAccessLog");
                return null;
            }
        }
        public async void PostUser(AccessLog log, AppLogger logger)
        {
            try
            {
                string host = Properties.Settings.Default.API_IP;
                int port = 80;
                string endpoint = Properties.Settings.Default.API_ENDPOINT;
                string postData = $"LogID={log.LogID}&Description=operator%20accepted";

                using (TcpClient client = new TcpClient(host, port))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        string request = $"POST {endpoint} HTTP/1.1\r\n" +
                                 $"Host: {host}\r\n" +
                                 $"Content-Type: application/x-www-form-urlencoded\r\n" +
                                 $"Content-Length: {postData.Length}\r\n\r\n" +
                                 $"{postData}";
                        byte[] requestBytes = Encoding.ASCII.GetBytes(request);
                        await stream.WriteAsync(requestBytes, 0, requestBytes.Length);

                        byte[] responseBytes = new byte[1024];
                        int bytesRead = await stream.ReadAsync(responseBytes, 0, responseBytes.Length);
                        string responseString = Encoding.ASCII.GetString(responseBytes, 0, bytesRead);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogErrors(ex.ToString(), "PostUser");
            }
        }
    }
}
