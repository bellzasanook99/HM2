using Core.Domain.Enum;
using Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Core.Services
{
    public class ToolsService: IToolsService
    {


  


        public object RestApiController(RestApiType restApiType, string url, object input, string JWT = null)
        {
            using (var client = new HttpClient())
            {
                if (JWT != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT);

                HttpResponseMessage respone = null;

                switch (restApiType)
                {
                    case RestApiType.Get:
                        respone = client.GetAsync(url).Result;
                        break;
                    case RestApiType.Post:
                        respone = client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "applocation/json")
                            ).Result;
                        break;
                }

                if (respone.IsSuccessStatusCode)
                    return JsonConvert.DeserializeObject<object>(respone.Content.ReadAsStringAsync().Result);
                else
                    throw new HttpResponseException(respone);

            }

        }
    }
}
