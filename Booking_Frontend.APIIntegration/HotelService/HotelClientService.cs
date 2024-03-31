using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Frontend.APIIntegration.ExtensionRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Booking_Frontend.APIIntegration.HotelService
{
    public class HotelClientService : BaseClientService, IHotelClientService
    {
        public HotelClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<HotelDetailViewModel> GetHotelById(int Id, string LanguageId)
        {
            return await GetAsync<HotelDetailViewModel>($"/api/hotel/{LanguageId}/{Id}");
        }

        public async Task<PageResult<HotelViewModel>> GetHotelByLocation(GetHotelByLocationRequest request)
        {
            return await GetAsync<PageResult<HotelViewModel>>($"/api/Hotel?LanguageId={request.LanguageId}&LocationName={request.LocationName}&DateCheckIn={request.DateCheckIn.ToString("MM-dd-yyyy")}&DateCheckOut={request.DateCheckOut.ToString("MM-dd-yyyy")}&TotalPeople={request.TotalPeople}&PageIndex={request.PageIndex}&PageSize={request.PageSize}");
                                                                                              //https://localhost:5001/api/Hotel?LanguageId=vi-VN&LocationName=Da%20Lat&DateCheckIn=11-11-2024&DateCheckOut=11-11-2024&TotalPeople=2&PageIndex=1&PageSize=10
        }
    }
}
