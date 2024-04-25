using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.Bill;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Backend.Repository.ExtensionRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.SendMail.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.BookingService
{
    public interface IBookingClientService
    {
        Task<bool> CreateBooking(BookingRequest request, Payment payment);
        Task<List<BookingOwnerViewModel>> GetAllBookingOwner(int hoteId, string LanguageId, StatusBooking? status);
        Task<BookingOwnerViewModel> GetBookingOwnerById(int bookingId, string LanguageId);
        Task<bool> ChangeStatusBooking(int Id, UpdateStatusBookingRequest request);
        Task<APIResult<string>> SendEmailAsync(MailData mailData);
        Task<bool> ConfirmBooking(int Id, ConfirmBookingRequest request);
        Task<bool> Bill(CheckoutRequest request);
        Task<BillClientViewModel> BillClient(int bookingId, string languageId);


    }
}
