using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.SendEmail;
using Booking_Frontend.APIIntegration.BookingService;
using Booking_Frontend.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBookingClientService _booking;

        public BookingController(IHttpContextAccessor httpContextAccessor, IBookingClientService booking)
        {
            _httpContextAccessor = httpContextAccessor;
            _booking = booking;
        }

        [HttpPost]
        public async Task<IActionResult> Index(BookingRequest request)
        {
            var result = await _booking.CreateBooking(request);
            return RedirectToAction("BookingSuccess", "Page");
        }

        [HttpPost]
        public IActionResult ConfirmInfo(CreateBookingRequest request)
        {
            ViewData["DateCheckIn"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkin");
            ViewData["DateCheckOut"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkout");
            ViewData["TotalPeople"] = _httpContextAccessor.HttpContext.Session.GetString("total-people");
            request.CheckIn = _httpContextAccessor.HttpContext.Session.GetString("date-checkin");
            request.CheckOut = _httpContextAccessor.HttpContext.Session.GetString("date-checkout");
            request.TotalPeople = Int16.Parse(_httpContextAccessor.HttpContext.Session.GetString("total-people"));
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
