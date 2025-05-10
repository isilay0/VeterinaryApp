using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VeterinaryApp.Exceptions;
using VeterinaryApp.Http.Model;
using VeterinaryApp.Model;

namespace VeterinaryApp.Http
{
    public class Api : IHttpApi
    {
        //private readonly HttpClient httpClient;
        private readonly JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
        public Api()
        {
            //httpClient = new HttpClient()
            //{
            //    BaseAddress = new Uri("https://localhost:7189"),
            //    Timeout = TimeSpan.FromSeconds(30)
            //};
            serializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
            serializerSettings.NullValueHandling = NullValueHandling.Ignore;
        }

        public async Task<TRes> Delete<TRes>(string ep)
        {
            using (HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7189"),
                Timeout = TimeSpan.FromSeconds(30)
            })
            {
                HttpResponseMessage res = await client.DeleteAsync(ep);
                ResponseModel resData = JsonConvert.DeserializeObject<ResponseModel>(await res.Content.ReadAsStringAsync());
                if (res.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<TRes>(JsonConvert.SerializeObject(resData.Result));
                }
                else if (res.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return default;
                }
                else
                {
                    throw new BadRequestException(res.StatusCode, resData.Message);
                }
            }
        }

        public async Task<TRes> Get<TRes>(string ep)
        {
            using (HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7189"),
                Timeout = TimeSpan.FromSeconds(30)
            })
            {
                HttpResponseMessage res = await client.GetAsync(ep);
                ResponseModel resData = JsonConvert.DeserializeObject<ResponseModel>(await res.Content.ReadAsStringAsync());
                if (res.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<TRes>(JsonConvert.SerializeObject(resData.Result));
                }
                else if (res.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return default;
                }
                else 
                {
                    throw new BadRequestException(res.StatusCode, resData.Message);
                }
            }
        }
        public async Task<TRes> Post<TBody, TRes>(string ep, TBody body)
        {
            using (HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7189"),
                Timeout = TimeSpan.FromSeconds(30)
            })
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
                HttpResponseMessage res = await client.PostAsync(ep, content);
                ResponseModel resData = JsonConvert.DeserializeObject<ResponseModel>(await res.Content.ReadAsStringAsync());
                if (res.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<TRes>(JsonConvert.SerializeObject(resData.Result));
                }
                else
                {
                    throw new BadRequestException(res.StatusCode, resData.Message);
                }
            }
        }

        public async Task<TRes> Put<TBody, TRes>(string ep, TBody body)
        {
            using (HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7189"),
                Timeout = TimeSpan.FromSeconds(30)
            })
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
                HttpResponseMessage res = await client.PutAsync(ep, content);
                ResponseModel resData = JsonConvert.DeserializeObject<ResponseModel>(await res.Content.ReadAsStringAsync());
                if (res.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<TRes>(JsonConvert.SerializeObject(resData.Result));
                }
                else
                {
                    throw new BadRequestException(res.StatusCode, resData.Message);
                }
            }
        }
    }
}
