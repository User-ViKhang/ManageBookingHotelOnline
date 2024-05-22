using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.ViewModel;
using Booking_Backend.Repository.ViewRepo.Request;
using Booking_Backend.Repository.ViewRepo.ViewModel;
using Booking_Frontend.APIIntegration.LocationService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.ViewService
{
    public class ViewClientService : BaseClientService, IViewClientService
    {
        public ViewClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<PageResult<ViewHotelViewModel>> Get(GetViewHotelRequest request)
        {
            return await GetAsync<PageResult<ViewHotelViewModel>>($"/api/viewservice?languageId={request.LanguageId}&pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&keyword={request.Keyword}");
        }
    }
}
