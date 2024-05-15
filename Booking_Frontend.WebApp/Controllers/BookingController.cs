using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.BookingRepo.ViewModel;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.SendEmail;
using Booking_Frontend.APIIntegration.BookingService;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.RoomService;
using Booking_Frontend.APIIntegration.User;
using Booking_Frontend.WebApp.Helper;
using Booking_Frontend.WebApp.Hubs;
using Booking_Frontend.WebApp.Models;
using Booking_Frontend.WebApp.Models.Owner;
using Booking_Frontend.WebApp.Service.VnPayService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Globalization;
using System.Linq;
using System.Text.Json;
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
        private readonly IVnPayService _vnpay;
        private readonly IHubContext<NotificationHub> _hubContext;

        public BookingController(IHttpContextAccessor httpContextAccessor, IBookingClientService booking, IHotelClientService hotel, IRoomClientService room, IUserAPI user, IVnPayService vnpay, IHubContext<NotificationHub> hubContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _booking = booking;
            _hotel = hotel;
            _room = room;
            _user = user;
            _vnpay = vnpay;
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Index(BookingRequest request, Payment payment)
        {
            if (_httpContextAccessor.HttpContext.Session.GetString("UserId_Client") != null)
            {
                request.UserId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Client");
            }

            if (payment == Payment.VNPay)
            {
                var vnPayModel = new VnPaymentRequestModel
                {
                    Amount = double.Parse(request.Sum.ToString()),
                    //CreatedDate = DateTime.Now,
                    Description = $"{request.FullName} {request.PhoneNumber}",
                    FullName = request.FullName,
                    OrderId = Guid.NewGuid(),
                };
                TempData["bookingrequest"] = JsonSerializer.Serialize(request);
                return Redirect(_vnpay.CreatePaymentUrl(HttpContext, vnPayModel));
            }

            var result = await _booking.CreateBooking(request, Payment.COD);
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", request.HotelId.ToString(), "Thông báo mới: Khách hàng đã đặt phòng.");
            return RedirectToAction("BookingSuccess", "Page");
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmInfo(CreateBookingRequest request)
        {
            ViewData["DateCheckIn"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkin");
            ViewData["DateCheckOut"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkout");
            ViewData["TotalPeople"] = _httpContextAccessor.HttpContext.Session.GetString("total-people");
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
            int dayCheckin = DateTime.Parse(ViewData["DateCheckIn"].ToString()).Day;
            int dayCheckout = DateTime.Parse(ViewData["DateCheckOut"].ToString()).Day;
            int totalDate = dayCheckout - dayCheckin;
            decimal totalPrice = request.Price * totalDate;
            request.TotalPrice = totalPrice;
            return View(new BillViewModel
            {
                CreateBookingViewModel = request
            });
        }

        public IActionResult PaymentFail()
        {
            return View();
        }

        public async Task<IActionResult> PaymentCallBackAsync()
        {
            var response = _vnpay.PaymentExecute(Request.Query);
            if(response == null || response.VnPayResponseCode != "00")
            {
                TempData["Message"] = $"Lỗi thanh toán VNPay: {response.VnPayResponseCode}";
                return RedirectToAction("PaymentFail");
            }

            string jsonData = TempData["bookingrequest"] as string;
            var bookingRequest = JsonSerializer.Deserialize<BookingRequest>(jsonData);
            var result = await _booking.CreateBooking(bookingRequest, Payment.VNPay);
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", bookingRequest.HotelId.ToString(), "Thông báo mới: Khách hàng đã đặt phòng.");
            return RedirectToAction("BookingSuccess", "Page");

        }
    }
}
