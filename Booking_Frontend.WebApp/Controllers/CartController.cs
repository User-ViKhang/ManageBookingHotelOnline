using Booking_Backend.Repository.BookingCartRepo.Request;
using Booking_Frontend.APIIntegration.BookingCartService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IBookingCartClientService _bookingCart;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartController(IBookingCartClientService bookingCart, IHttpContextAccessor httpContextAccessor)
        {
            _bookingCart = bookingCart;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(AddToCartRequest request)
        {
            var addToCart = await _bookingCart.AddToCart(request);
            var languageId = CultureInfo.CurrentCulture.Name;

            return new RedirectResult($"/{languageId}/hotel/{request.HotelId}");
        }

        [HttpGet("/cart/delete/{HotelId}")]
        public async Task<IActionResult> DeleteFromCart(int HotelId)
        {
            string UserId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Client");
            var addToCart = await _bookingCart.DeleteFromCart(new AddToCartRequest { HotelId = HotelId, UserId = Guid.Parse(UserId) });
            var languageId = CultureInfo.CurrentCulture.Name;

            return Ok();
        }
    }
}
