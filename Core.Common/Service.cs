using Core.Domain.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace Core.Common
{
    public static  class Service
    {
        public static object RestApiController(RestApiType restApiType,string url,object input,string JWT =null)
        {
            using (var client = new HttpClient())
            {
                if (JWT != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",JWT);

                HttpResponseMessage respone = null;
                
                switch(restApiType)
                {
                    case RestApiType.Get:
                        respone = client.GetAsync(url).Result;
                        break;
                    case RestApiType.Post:
                        respone = client.PostAsync(url,new StringContent(JsonConvert.SerializeObject(input),Encoding.UTF8,"applocation/json")
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
