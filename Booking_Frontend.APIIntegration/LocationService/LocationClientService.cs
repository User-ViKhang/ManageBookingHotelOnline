using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.LocationRepo.ViewModel;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using Booking_Frontend.APIIntegration.HotelType;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.LocationService
{
    public class LocationClientService : BaseClientService, ILocationClientService
    {
        public LocationClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<List<LocationViewModel>> GetLocations(string Language_Id)
        {
            return await GetAsync<List<LocationViewModel>>($"/api/location/{Language_Id}");
        }
    }
}
