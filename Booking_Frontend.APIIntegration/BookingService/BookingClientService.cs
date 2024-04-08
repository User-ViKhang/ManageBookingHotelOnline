using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Frontend.APIIntegration.ExtensionRoom;
using FluentValidation.Resources;
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

        public async Task<bool> ChangeStatusBooking(int Id, UpdateStatusBookingRequest request)
        {
            return await PatchAsyncNotFile<UpdateStatusBookingRequest>($"/api/update-state/{Id}", request);
        }

        public async Task<bool> ConfirmBooking(int Id, ConfirmBookingRequest request)
        {
            return await PostAsyncNotFile<ConfirmBookingRequest>($"/api/booking/confirm/{Id}", request);
        }

        public async Task<bool> CreateBooking(BookingRequest request)
        {
            return await PostAsyncNotFile<BookingRequest>($"/api/booking", request);
        }

        public async Task<List<BookingOwnerViewModel>> GetAllBookingOwner(int hotelId, string LanguageId)
        {
            return await GetAsync<List<BookingOwnerViewModel>>($"/api/booking/{LanguageId}/booking-hotel/{hotelId}");
        }

        public async Task<BookingOwnerViewModel> GetBookingOwnerById(int bookingId, string LanguageId)
        {
            return await GetAsync<BookingOwnerViewModel>($"/api/booking/{LanguageId}/detail-booking/{bookingId}");
        }

        public async Task<APIResult<string>> SendEmailAsync(MailData mailData)
        {
            return await SendMail<MailData>($"/api/sendmail", mailData);
        }
    }
}
