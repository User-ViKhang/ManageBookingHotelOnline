using Booking_Backend.Repository.Common.Languages;
using Booking_Backend.Repository.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service
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
            var client = _httpClientfactory.CreateClient();
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.BaseAddress = new Uri(_config["HostServer"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var response = await client.GetAsync(url);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                TRespone myDeserialzedObjectList = (TRespone)JsonConvert.DeserializeObject(body, typeof(TRespone));
                return myDeserialzedObjectList;
            }
            return JsonConvert.DeserializeObject<TRespone>(body);
        }
    }
}