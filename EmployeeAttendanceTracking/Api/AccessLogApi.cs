using EmployeeAttendanceTracking.Interface;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeAttendanceTracking.Tools;

namespace EmployeeAttendanceTracking.Api
{
    class AccessLogApi
    {
        /// <summary>
        /// Random user information provider.
        /// </summary>
        /// <param name="logger"></param>
        /// <returns></returns>
        public async Task<AccessLog> GetAccesLog(AppLogger logger)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var url = Properties.Settings.Default.API_ADDRESS;
                    // Send a GET request and wait for the response
                    var response = await client.GetAsync(url);
                    // Read the response content as a string
                    var responseContent = await response.Content.ReadAsStringAsync();
                    //dynamic jsonObject = JsonConvert.DeserializeObject(responseContent);
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
    }
}
