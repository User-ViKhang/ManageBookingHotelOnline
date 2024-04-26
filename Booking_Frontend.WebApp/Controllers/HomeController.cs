using Booking_Frontend.APIIntegration.HotelType;
using Booking_Frontend.APIIntegration.User;
using Booking_Frontend.WebApp.Models;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Booking_Frontend.APIIntegration.BookingCartService;
using Microsoft.AspNetCore.Hosting;
using System.Drawing;
using QRCoder;
using System.Drawing.Imaging;
using System.IO;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.SendEmail;
using Booking_Frontend.APIIntegration.EmailService;
using MimeKit;
using System.Net.Mime;

namespace Booking_Frontend.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISharedCultureLocalizer _loc;
        private readonly IHotelTypeClientService _hotelType;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserAPI _user;
        private readonly IBookingCartClientService _cart;
        private readonly IWebHostEnvironment _webhost;
        private readonly IEmailServiceClient _email;

        public HomeController(ILogger<HomeController> logger, ISharedCultureLocalizer loc, IHotelTypeClientService hotelType, IHttpContextAccessor httpContextAccessor, IUserAPI user, IBookingCartClientService cart, IWebHostEnvironment webhost, IEmailServiceClient email)
        {
            _logger = logger;
            _loc = loc;
            _hotelType = hotelType;
            _httpContextAccessor = httpContextAccessor;
            _user = user;
            _cart = cart;
            _webhost = webhost;
            _email = email;
        }

        public async Task<IActionResult> Index()
        {
            //var msg = _loc.GetLocalizedString("Đà Nẳng");
            var languageId = CultureInfo.CurrentCulture.Name;
            if(_httpContextAccessor.HttpContext.Session.GetString("UserId_Client") != null)
            {
                var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Client");
                var cart = await _cart.GetAllBookingCartByUserId(Guid.Parse(userId));
                var lst = await _hotelType.GetAllHotelType(languageId);
                var user = await _user.GetUserById(userId);
                var data = new DetailViewModel()
                {
                    lstHotelTypeVM = lst,
                    UserClient = user,
                    GetAllBookingCartByUserId = cart
                };
                return View(data);
            }else
            {
                var lst = await _hotelType.GetAllHotelType(languageId);
                var data = new DetailViewModel()
                {
                    lstHotelTypeVM = lst,
                    UserClient = null
                };
                return View(data);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GenerateQRCode()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GenerateQRCode(IFormCollection formCollection)
        {
            string qrCodeString = formCollection["QRCodeString"];
            byte[] qrCodeBytes = GenerateQR(qrCodeString);
            string webRootPath = _webhost.WebRootPath;
            var fileName = $"newqrcode{new Random().Next(1001)}.png";
            string filePath = Path.Combine(webRootPath, "img", fileName);


            return View();
        }


        public byte[] GenerateQR(string data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5); // Adjust the size as needed

            // Convert the Bitmap to a byte array
            using (MemoryStream stream = new MemoryStream())
            {
                qrCodeImage.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public IActionResult SetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return LocalRedirect(returnUrl);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
