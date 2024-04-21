using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.SendEmail;
using Booking_Frontend.APIIntegration.BookingService;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.RoomService;
using Booking_Frontend.APIIntegration.User;
using Booking_Frontend.WebApp.Models;
using Booking_Frontend.WebApp.Models.Owner;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBookingClientService _booking;
        private readonly IHotelClientService _hotel;
        private readonly IRoomClientService _room;
        private readonly IUserAPI _user;

        public BookingController(IHttpContextAccessor httpContextAccessor, IBookingClientService booking, IHotelClientService hotel, IRoomClientService room, IUserAPI user)
        {
            _httpContextAccessor = httpContextAccessor;
            _booking = booking;
            _hotel = hotel;
            _room = room;
            _user = user;
        }

        [HttpPost]
        public async Task<IActionResult> Index(BookingRequest request)
        {
            if(_httpContextAccessor.HttpContext.Session.GetString("UserId_Client") != null)
            {
                request.UserId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Client");
            }
            var result = await _booking.CreateBooking(request);
            return RedirectToAction("BookingSuccess", "Page");
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmInfo(CreateBookingRequest request)
        {
            ViewData["DateCheckIn"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkin");
            ViewData["DateCheckOut"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkout");
            ViewData["TotalPeople"] = _httpContextAccessor.HttpContext.Session.GetString("total-people");
            request.CheckIn = _httpContextAccessor.HttpContext.Session.GetString("date-checkin");
            request.CheckOut = _httpContextAccessor.HttpContext.Session.GetString("date-checkout");
            request.TotalPeople = Int16.Parse(_httpContextAccessor.HttpContext.Session.GetString("total-people"));
            if(_httpContextAccessor.HttpContext.Session.GetString("UserId_Client") != null)
            {
                var user = await _user.GetUserById(_httpContextAccessor.HttpContext.Session.GetString("UserId_Client"));
                request.fullnameCustomer = user.ResultOject.FirstName +" "+ user.ResultOject.LastName;
                request.emailCustomer = user.ResultOject.Email;
                request.phoneCustomer = user.ResultOject.PhoneNumber;
                request.nation = user.ResultOject.Nation;
            }
            if(request.RoomQuality == 0)
            {
                request.RoomQuality = 1;
            }
            return View(new BillViewModel
            {
                CreateBookingViewModel = request
            });
        }
    }
}
