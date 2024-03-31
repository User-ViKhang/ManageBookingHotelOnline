using Booking_Frontend.APIIntegration.HotelType;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Booking_Frontend.APIIntegration.LocationService
{
    public class LocationClientService : BaseClientService, ILocationClientService
    {
        public LocationClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

    }
}
