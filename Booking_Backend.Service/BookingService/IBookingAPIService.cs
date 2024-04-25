using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.Bill;
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
        Task<bool> CreateBooking(BookingRequest request, Payment payment);
        Task<List<BookingOwnerViewModel>> GetAllBookingOwner(int hoteId, string LanguageId, StatusBooking? status);
        Task<BookingOwnerViewModel> GetBookingOwnerById(int bookingId, string LanguageId);
        Task<bool> ConfirmBooking(int Id, ConfirmBookingRequest request);
        Task<bool> ChangeStatusBooking(int Id, StatusBooking state);
        Task<bool> CheckoutBooking(CheckoutRequest request);
        Task<bool> DeleteBooking(int roomId, int bookingId);
        Task<BillClientViewModel> BillClient(int bookingId, string languageId);
    }
}
