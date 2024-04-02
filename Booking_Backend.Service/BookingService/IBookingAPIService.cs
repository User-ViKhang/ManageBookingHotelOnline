using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.BookingService
{
    public interface IBookingAPIService
    {
        Task<bool> CreateBooking(BookingRequest request);
    }
}
