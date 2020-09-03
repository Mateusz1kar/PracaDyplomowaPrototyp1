using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SIoIMwElblaguMobileAndorid.Models;

namespace SIoIMwElblaguMobileAndorid.Services
{
    public class ApiService
    {

        public static async Task<List<Event>> GetAllEvent(int pageNumber=0, int pageSize=5)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(AppSettings.ApiUrl + AppSettings.GetAllEventApiPath + String.Format("?pagenumber={0}&pageSize={1}", pageNumber, pageSize));
            return JsonConvert.DeserializeObject<List<Event>>(response);
        }
        public static async Task<Event> GetEventDetail(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(AppSettings.ApiUrl + AppSettings.GetEventDetailApiPath + id);
            return JsonConvert.DeserializeObject<Event>(response);
        }
    }
}
