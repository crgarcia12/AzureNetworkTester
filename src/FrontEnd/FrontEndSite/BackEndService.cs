using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEndSite
{
    public class BackEndService
    {
        public static HttpClient client = new HttpClient();

        public async Task<int> GetFireworksCounter()
        {
            HttpResponseMessage returnMessage = await client.GetAsync(SettingsManager.Instance.BackEndUrl);
            string value = await returnMessage.Content.ReadAsStringAsync();
            return Int32.Parse(value);
        }
    }
}
