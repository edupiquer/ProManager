using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProManager.Core.Models;
using ProManager.Core.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.FakePersonData.Services
{
    public class FakePersonService : IFakePersonService
    {
        public async Task<FakePerson> GetFakePerson()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://randomuser.me/api/");
                string jsonResponse = await response.Content.ReadAsStringAsync();

                var jsonPerson = JObject.Parse(jsonResponse);
                FakePerson fakeperson = JsonConvert.DeserializeObject<FakePerson>(jsonPerson["results"][0]["name"].ToString());
                return fakeperson;
            }
        }
    }
}
