using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace bayshoreeyecare.Controllers
{
    class API 
    {

        public static string GetPhoneNumbers()
        {
            try
            {
                string update = "false";

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var uri = new Uri("https://bayshoreeyecare.azurewebsites.net/api/getphonenumbers");

                    HttpResponseMessage response = client.GetAsync(uri).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body.
                        var data = response.Content.ReadAsStringAsync().Result;
                        if (!string.IsNullOrEmpty(data))
                        {
                           return JsonConvert.DeserializeObject<string>(data);

                        }
                        
                    }

                    return update;
                }
            }
            catch (Exception ex)
            {
                return "false";
            }
        }
    }
}
