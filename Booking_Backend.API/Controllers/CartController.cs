using Booking_Backend.Repository.BookingCartRepo.Request;
using Booking_Backend.Service.BookingCartService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Booking_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IBookingCartAPIService _bookingCart;

        public CartController(IBookingCartAPIService bookingCart)
        {
            _bookingCart = bookingCart;
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(AddToCartRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var isAddToCart = await _bookingCart.AddToCart(request);
            return Ok();
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> AddToCart(Guid Id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var isAddToCart = await _bookingCart.GetAllBookingCartByUserId(Id);
            return Ok(isAddToCart);
        }

        [HttpDelete("{UserId}/{HotelId}")]
        public async Task<IActionResult> DeleteFromCart([FromRoute] AddToCartRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var isDeleteToCart = await _bookingCart.DeleteFromCart(request);
            return Ok(isDeleteToCart);
        }
    }
}
