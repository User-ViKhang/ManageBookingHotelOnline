using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Common.Languages;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.Language
{
    public class LanguageClientService : BaseClientService, ILanguageClientService
    {
        public LanguageClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<APIResult<List<LanguageViewModel>>> GetAllLanguage()
        {
            return await GetAsync<APIResult<List<LanguageViewModel>>>("/api/languages");
        }
    }
}