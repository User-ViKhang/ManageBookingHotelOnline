using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Backend.Repository.ExtensionRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.BookingService
{
    public interface IBookingClientService
    {
        Task<bool> CreateBooking(BookingRequest request);
    }
}
