using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
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

        public LocationController(IHotelClientService hotelClientService, IHttpContextAccessor httpContextAccessor, IHotelTypeClientService hotelType, IUserAPI user)
        {
            _hotelClientService = hotelClientService;
            _httpContextAccessor = httpContextAccessor;
            _hotelType = hotelType;
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SearchResult(string locationName, DateTime dateCheckIn, DateTime dateCheckOut, int totalPeople)
        {
            _httpContextAccessor.HttpContext.Session.SetString("date-checkin", dateCheckIn.ToString("dd/MM/yyyy"));
            _httpContextAccessor.HttpContext.Session.SetString("date-checkout", dateCheckOut.ToString("dd/MM/yyyy"));
            _httpContextAccessor.HttpContext.Session.SetString("total-people", totalPeople.ToString());
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserIdClient");
            var lst = await _hotelType.GetAllHotelType(languageId);
            var user = await _user.GetUserById(userId);
            var request = new GetHotelByLocationRequest()
            {
                PageIndex = 1,
                PageSize = 10,
                LanguageId = CultureInfo.CurrentCulture.Name,
                LocationName = locationName,
                DateCheckIn = DateTime.Parse(_httpContextAccessor.HttpContext.Session.GetString("date-checkin")),
                DateCheckOut = DateTime.Parse(_httpContextAccessor.HttpContext.Session.GetString("date-checkout")),
                TotalPeople = totalPeople
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
                    UserClient = user
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
