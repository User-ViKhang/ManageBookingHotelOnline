using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Frontend.APIIntegration.ExtensionRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.BookingService
{
    public class BookingClientService : BaseClientService, IBookingClientService
    {
        public BookingClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> CreateBooking(BookingRequest request)
        {
            return await PostAsyncNotFile<BookingRequest>($"/api/booking", request);
        }
    }
}
