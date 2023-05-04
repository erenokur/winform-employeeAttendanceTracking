using EmployeeAttendanceTracking.Interface;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeAttendanceTracking.Tools;
using System.Collections.Generic;

namespace EmployeeAttendanceTracking.Api
{
    class AccessLogApi
    {
        /// <summary>
        /// Random user information provider.
        /// </summary>
        /// <param name="logger"></param>
        /// <returns></returns>
        public async Task<AccessLog> GetAccessLog(AppLogger logger)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var url = Properties.Settings.Default.API_ADDRESS;
                    var response = await client.GetAsync(url);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    AccessLog accessLog = JsonConvert.DeserializeObject<AccessLog>(responseContent, new JsonSerializerSettings
                    {
                        ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
                    });
                    return accessLog;
                }
            }
            catch (Exception ex)
            {
                logger.LogErrors(ex.ToString(), "GetAccesLog");
                return null;
            }
        }
        /// <summary>
        /// Can post user.
        /// </summary>
        /// <param name="log"></param>
        /// <param name="logger"></param>
        public async void PostUser(AccessLog log, AppLogger logger)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = Properties.Settings.Default.API_ADDRESS;
                    var data = new Dictionary<string, string>
                    {
                        { "LogID",log.LogID },
                        { "Description", "operator accepted" },
                    };
                    var content = new FormUrlEncodedContent(data);
                    var response = await client.PostAsync(url, content);
                    string responseString = await response.Content.ReadAsStringAsync();
                }
            }
            catch
            {

            }
        }
    }
}
