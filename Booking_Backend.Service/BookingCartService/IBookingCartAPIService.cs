using Booking_Backend.Repository.BookingCartRepo.Request;
using Booking_Backend.Repository.BookingCartRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.BookingCartService
{
    public interface IBookingCartAPIService
    {
        Task<bool> AddToCart(AddToCartRequest request);
        Task<bool> DeleteFromCart(AddToCartRequest request);
        Task<List<ListBookingCartByUserIdModel>> GetAllBookingCartByUserId(Guid UserId);
    }
}
