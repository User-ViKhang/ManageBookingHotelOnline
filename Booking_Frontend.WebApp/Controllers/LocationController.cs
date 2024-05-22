using Booking_Backend.Repository.BookingCartRepo.ViewModel;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.ViewModel;
using Booking_Frontend.APIIntegration.BookingCartService;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.HotelType;
using Booking_Frontend.APIIntegration.User;
using Booking_Frontend.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp.Controllers
{
    public class LocationController : Controller
    {
        private readonly IHotelClientService _hotelClientService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHotelTypeClientService _hotelType;
        private readonly IUserAPI _user;
        private readonly IBookingCartClientService _cart;

        public LocationController(IHotelClientService hotelClientService, IHttpContextAccessor httpContextAccessor, IHotelTypeClientService hotelType, IUserAPI user, IBookingCartClientService cart)
        {
            _hotelClientService = hotelClientService;
            _httpContextAccessor = httpContextAccessor;
            _hotelType = hotelType;
            _user = user;
            _cart = cart;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SearchResult(int HotelTypeId, string locationName, DateTime dateCheckIn, DateTime dateCheckOut, int totalPeople, bool isHightFeedBack, bool isLowPrice)
        {
            _httpContextAccessor.HttpContext.Session.SetString("date-checkin", dateCheckIn.ToString("dd/MM/yyyy"));
            _httpContextAccessor.HttpContext.Session.SetString("date-checkout", dateCheckOut.ToString("dd/MM/yyyy"));
            _httpContextAccessor.HttpContext.Session.SetString("total-people", totalPeople.ToString());
            _httpContextAccessor.HttpContext.Session.SetString("locationName", locationName.ToString());
            ViewData["date-checkin"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkin");
            ViewData["date-checkout"] = _httpContextAccessor.HttpContext.Session.GetString("date-checkout");
            ViewData["total-people"] = _httpContextAccessor.HttpContext.Session.GetString("total-people");
            ViewData["locationName"] = _httpContextAccessor.HttpContext.Session.GetString("locationName");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var languageId = CultureInfo.CurrentCulture.Name;
            var lst = await _hotelType.GetAllHotelType(languageId);
            APIResult<UserViewModel> user = null;
            List<ListBookingCartByUserIdModel> cart = null;
            if(_httpContextAccessor.HttpContext.Session.GetString("UserId_Client") != null)
            {
                var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Client");
                cart = await _cart.GetAllBookingCartByUserId(Guid.Parse(userId));
                user = await _user.GetUserById(userId);
            }
            var request = new GetHotelByLocationRequest()
            {
                PageIndex = 1,
                PageSize = 10,
                LanguageId = CultureInfo.CurrentCulture.Name,
                LocationName = locationName,
                DateCheckIn = DateTime.Parse(_httpContextAccessor.HttpContext.Session.GetString("date-checkin")),
                DateCheckOut = DateTime.Parse(_httpContextAccessor.HttpContext.Session.GetString("date-checkout")),
                TotalPeople = totalPeople,
                IsHightFeedBack = isHightFeedBack,
                isLowPrice = isLowPrice,
                HotelTypeId = HotelTypeId
            };
            var hotelTypes = await _hotelType.GetAllHotelType(CultureInfo.CurrentCulture.Name);
            var data = await _hotelClientService.GetHotelByLocation(request);
            if(data.TotalRecord > 0)
            {
                var hotelLocationViewModel = new LocationViewModel()
                {
                    ListHotelByLocation = data,
                    ListHotelType = hotelTypes,
                    lstHotelTypeVM = lst,
                    UserClient = user,
                    GetAllBookingCartByUserId = cart
                };
                hotelLocationViewModel.ListHotelByLocation.Items.FirstOrDefault().Area = locationName;
                hotelLocationViewModel.ListHotelByLocation.Items.FirstOrDefault().CheckIn = request.DateCheckIn;
                hotelLocationViewModel.ListHotelByLocation.Items.FirstOrDefault().CheckOut = request.DateCheckOut;
                return View(hotelLocationViewModel);

            }
            else
            {
                var hotelLocationViewModel = new LocationViewModel()
                {
                    ListHotelByLocation = new PageResult<HotelViewModel>()
                    {
                        Items = new List<HotelViewModel>()
                        {
                            new HotelViewModel
                            {
                                Area = locationName,
                            }
                        },
                        TotalRecord = 0
                    }
                };
               return View(hotelLocationViewModel);
            }
        }
        
        [HttpGet("{culture}/location")]
        public async Task<IActionResult> SearchResult(string locationName, string culture)
        {
            _httpContextAccessor.HttpContext.Session.SetString("date-checkin", DateTime.UtcNow.ToString());
            _httpContextAccessor.HttpContext.Session.SetString("date-checkout", DateTime.UtcNow.ToString());
            _httpContextAccessor.HttpContext.Session.SetString("total-people", 2.ToString());
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var request = new GetHotelByLocationRequest()
            {
                PageIndex = 1,
                PageSize = 10,
                LanguageId = culture,
                LocationName = locationName,
                DateCheckIn = DateTime.Parse(_httpContextAccessor.HttpContext.Session.GetString("date-checkin")),
                DateCheckOut = DateTime.Parse(_httpContextAccessor.HttpContext.Session.GetString("date-checkout")),
                TotalPeople = 2
            };
            var hotelTypes = await _hotelType.GetAllHotelType(culture);
            var data = await _hotelClientService.GetHotelByLocation(request);
            if(data.TotalRecord > 0)
            {
                var hotelLocationViewModel = new LocationViewModel()
                {
                    ListHotelByLocation = data,
                    ListHotelType = hotelTypes,
                };
                hotelLocationViewModel.ListHotelByLocation.Items.FirstOrDefault().Area = locationName;
                hotelLocationViewModel.ListHotelByLocation.Items.FirstOrDefault().CheckIn = request.DateCheckIn;
                hotelLocationViewModel.ListHotelByLocation.Items.FirstOrDefault().CheckOut = request.DateCheckOut;
                return View(hotelLocationViewModel);

            }
            else
            {
                var hotelLocationViewModel = new LocationViewModel()
                {
                    ListHotelByLocation = new PageResult<HotelViewModel>()
                    {
                        Items = new List<HotelViewModel>()
                        {
                            new HotelViewModel
                            {
                                Area = locationName,
                            }
                        },
                        TotalRecord = 0
                    },
                    ListHotelType = hotelTypes,
                };
               return View(hotelLocationViewModel);
            }
        }
    }
}
