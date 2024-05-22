using Booking_Backend.Repository.BookingCartRepo.Request;
using Booking_Backend.Repository.BookingCartRepo.ViewModel;
using Booking_Frontend.APIIntegration.BedService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.BookingCartService
{
    public class BookingCartClientService : BaseClientService, IBookingCartClientService
    {
        public BookingCartClientService(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> AddToCart(AddToCartRequest request)
        {
            return await PostAsyncNotFile($"/api/cart", request);
        }

        public async Task<bool> DeleteFromCart(AddToCartRequest request)
        {
            return await DeleteAsync($"/api/cart/{request.UserId}/{request.HotelId}");
        }

        public async Task<List<ListBookingCartByUserIdModel>> GetAllBookingCartByUserId(Guid UserId)
        {
            return await GetAsync<List<ListBookingCartByUserIdModel>>($"/api/cart/{UserId}");
        }
    }
}
