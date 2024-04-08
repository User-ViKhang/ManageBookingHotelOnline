using Booking_Backend.Repository.Common.Languages;
using Booking_Backend.Repository.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Booking_Backend.Repository.Users.ViewModel;
using System.Text;

namespace Booking_Frontend.APIIntegration
{
    public class BaseClientService
    {
        private readonly IHttpClientFactory _httpClientfactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;

        public BaseClientService(IHttpClientFactory httpClientfactory, IHttpContextAccessor httpContextAccessor
            , IConfiguration config)
        {
            _httpClientfactory = httpClientfactory;
            _httpContextAccessor = httpContextAccessor;
            _config = config;
        }

        public async Task<TRespone> GetAsync<TRespone>(string url)
        {
            string encodedUrl = Uri.EscapeUriString(url);
            var client = _httpClientfactory.CreateClient();
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.BaseAddress = new Uri(_config["HostServer"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var response = await client.GetAsync(encodedUrl);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                TRespone myDeserialzedObjectList = (TRespone)JsonConvert.DeserializeObject(body, typeof(TRespone));
                return myDeserialzedObjectList;
            }
            return JsonConvert.DeserializeObject<TRespone>(body);
        }

        public async Task<bool> DeleteAsync(string url)
        {
            var client = _httpClientfactory.CreateClient();
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.BaseAddress = new Uri(_config["HostServer"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var response = await client.DeleteAsync(url);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode) return true;
            return false;
        }

        public async Task<HttpResponseMessage> PutAsync(string url, HttpContent content)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            return await client.PutAsync(url, content);
        }

        public async Task<bool> PutAsyncNotFile<TRespone>(string url, TRespone T)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var json = JsonConvert.SerializeObject(T);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }
        
        public async Task<bool> PatchAsyncNotFile<TRespone>(string url, TRespone T)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var json = JsonConvert.SerializeObject(T);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PatchAsync(url, httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }

        public async Task<bool> PostAsyncNotFile<TRespone>(string url, TRespone T)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var json = JsonConvert.SerializeObject(T);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }
        
        public async Task<APIResult<string>> SendMail<TRespone>(string url, TRespone T)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var json = JsonConvert.SerializeObject(T);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return new APIResult_Success<string>();
            return new APIResult_Error<string>("Error sendmail");
        }

        public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            var client = _httpClientfactory.CreateClient();
            client.BaseAddress = new Uri(_config["HostServer"]);
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            return await client.PostAsync(url, content);
        }
    }
}