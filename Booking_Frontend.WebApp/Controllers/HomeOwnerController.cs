using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Repository.Bill;
using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Backend.Repository.RoomRepo.Request;
using Booking_Backend.Repository.RoomRepo.ViewModel;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.SendEmail;
using Booking_Frontend.APIIntegration.BedService;
using Booking_Frontend.APIIntegration.BookingService;
using Booking_Frontend.APIIntegration.ExtensionRoom;
using Booking_Frontend.APIIntegration.ExtensionTypeRoom;
using Booking_Frontend.APIIntegration.FormatMoney;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.RoomService;
using Booking_Frontend.APIIntegration.RoomType;
using Booking_Frontend.WebApp.Models.Owner;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using OfficeOpenXml;
using System.Threading.Tasks;
using System.Collections.Generic;
using SendGrid;
using OfficeOpenXml.Style;
using Booking_Frontend.APIIntegration.User;
using Booking_Backend.Repository.Users.Request;
using Booking_Frontend.APIIntegration.Profile;

namespace Booking_Frontend.WebApp.Controllers
{
    public class HomeOwnerController : Controller
    {
        private readonly IHotelClientService _hotel;
        private readonly IBookingClientService _booking;
        private readonly IRoomClientService _room;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IRoomTypeClientService _roomType;
        private readonly IBedClientService _bed;
        private readonly IFormatMoney _format;
        private readonly IExtensionTypeRoomClientService _extension;
        private readonly IExtensionRoomClientService _ex;
        private readonly IUserAPI _user;
        private readonly IProfileClientService _profile;

        public HomeOwnerController(IHotelClientService hotel, IBookingClientService booking, IRoomClientService room, IHttpContextAccessor httpContextAccessor, IRoomTypeClientService roomType, IBedClientService bed, IFormatMoney format, IExtensionTypeRoomClientService extension, IExtensionRoomClientService ex, IUserAPI user, IProfileClientService profile)
        {
            _hotel = hotel;
            _booking = booking;
            _room = room;
            _httpContextAccessor = httpContextAccessor;
            _roomType = roomType;
            _bed = bed;
            _format = format;
            _extension = extension;
            _ex = ex;
            _user = user;
            _profile = profile;
        }

        public async Task<IActionResult> Index(string Id)
        {
            HttpContext.Session.SetString("UserId_Owner", Id); // xét ID chủ sở hữu vào session
            string UserId_Owner = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var languageId = CultureInfo.CurrentCulture.Name;
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(UserId_Owner), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId, StatusBooking.Checked);
            return View(new NotifyBookingViewModel()
            {
                UserId = UserId_Owner,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking
            });
        }

        [HttpGet("booking/feed")]
        public async Task<IActionResult> Feed()
        {
            string UserId_Owner = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var languageId = CultureInfo.CurrentCulture.Name;
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(UserId_Owner), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId, StatusBooking.Pedding);
            var extensiongroup = await _extension.GetExtensionGroup(languageId);
            return View(new NotifyBookingViewModel()
            {
                UserId = UserId_Owner,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking
            });
        }

        [HttpPost("booking/room")]
        public async Task<IActionResult> CreateRoom(CreateRoomRequest request) 
        {
            if (!ModelState.IsValid) return BadRequest();
            var createRoom = await _room.CreateRoom(request);
            if(!createRoom) return NotFound();
            return new RedirectResult($"/stateroom-price/{request.HotelId}");
        }

        [HttpPost("booking/statistical")]
        public async Task<IActionResult> Statistical(List<StatisticalRequest> statisticalRequests) 
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Tổng doanh thu");

                worksheet.Cells["A1"].Value = "STT";
                worksheet.Cells["B1"].Value = "Mã phòng";
                worksheet.Cells["C1"].Value = "Số phòng";
                worksheet.Cells["D1"].Value = "Loại kiểu phòng";
                worksheet.Cells["E1"].Value = "Loại kiểu giường";
                worksheet.Cells["F1"].Value = "Số khách";
                worksheet.Cells["G1"].Value = "Số ngày ở";
                worksheet.Cells["H1"].Value = "Khách hàng";
                worksheet.Cells["I1"].Value = "Phụ thu";
                worksheet.Cells["J1"].Value = "Giá phòng";
                worksheet.Cells["K1"].Value = "Tổng cộng";
                worksheet.Cells["L1"].Value = "Ngày tạo";

                int row = 2;
                foreach (var item in statisticalRequests)
                {
                    worksheet.Cells["A" + row].Value = item.STT;
                    worksheet.Cells["B" + row].Value = item.BookingId;
                    worksheet.Cells["C" + row].Value = item.RoomCode;
                    worksheet.Cells["D" + row].Value = item.RoomTypeName;
                    worksheet.Cells["E" + row].Value = item.BedName;
                    worksheet.Cells["F" + row].Value = item.TotalPeople;
                    worksheet.Cells["G" + row].Value = item.DayNumber;
                    worksheet.Cells["H" + row].Value = item.UserName;
                    worksheet.Cells["I" + row].Value = item.Phuthu;
                    worksheet.Cells["J" + row].Value = item.Price;
                    worksheet.Cells["K" + row].Value = item.TotalPrice;
                    worksheet.Cells["L" + row].Value = item.Create;
                    row++;
                }

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                var tableRange = worksheet.Cells[worksheet.Dimension.Address];

                // Tạo viền cho bảng
                var tableBorder = tableRange.Style.Border;
                tableBorder.Top.Style = tableBorder.Left.Style = tableBorder.Bottom.Style = tableBorder.Right.Style = ExcelBorderStyle.Thin;

                byte[] excelBytes = excelPackage.GetAsByteArray();

                // Trả về tệp Excel dưới dạng phản hồi HTTP
                return File(excelBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"Tổng doanh thu (xuất {DateTime.Now.ToString("dd-MM-yyyy")}).xlsx");
            }
        }


        [HttpGet("booking/room")]
        public async Task<IActionResult> CreateRoom()
        {
            string UserId_Owner = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var languageId = CultureInfo.CurrentCulture.Name;
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(UserId_Owner), languageId);
            var extensiongroup = await _extension.GetExtensionGroup(languageId);
            var lstRoomType = await _roomType.GetRoomType(new GetRoomTypeRequest
            {
                Keyword = "",
                LanguageId = languageId,
                PageIndex = 1,  
                PageSize = 20
            });
            var lstBed = await _bed.Get(new GetBedRequest
            {
                Language_Id = languageId,
                PageIndex = 1,
                PageSize= 20
            });
            return View(new NotifyBookingViewModel()
            {
                UserId = UserId_Owner,
                HotelViewModel = hotel,
                ExtensionGroupViewModel = extensiongroup,
                ListAllRoomType = lstRoomType,
                BedOwnerViewModel = lstBed
            });
        }

        [HttpGet("detail-booking/{Id}")]        
        public async Task<IActionResult> DetailBooking(int Id)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetBookingOwnerById(Id, languageId);
            
            return View(new NotifyBookingViewModel() 
            {
                UserId = userId,
                BookingOwnerDetailViewModel = booking,
                HotelViewModel = hotel,
            });
        }

        [HttpPost("detail-booking/confirm/{Id}")]        
        public async Task<IActionResult> ConfirmBooking([FromRoute] int Id, ConfirmBookingRequest request)
        {
            var changeState = await _booking.ConfirmBooking(Id, request);
            if (!changeState) return BadRequest();
            return new RedirectResult("/booking/feed");
        }

        [HttpGet("booking/check-out")]
        public async Task<IActionResult> CheckoutBooking()
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId, StatusBooking.Success);
            var rooms = await _room.GetAllRoomByHotelId(hotel.Id, languageId);
            return View(new NotifyBookingViewModel
            {
                UserId = userId,
                HotelViewModel = hotel,
                BookingOwnerViewModel = booking,
                RoomOwnerViewModel = rooms

            });
        }


        [HttpGet("stateroom-price/{hotelId}")]
        public async Task<IActionResult> StateRoomPrice(int hotelId)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            //var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId, null);
            var rooms = await _room.GetAllRoomByHotelId(hotelId, languageId);
            return View(new NotifyBookingViewModel
            {
                UserId = userId,
                HotelViewModel = hotel,
                //BookingOwnerViewModel = booking,
                RoomOwnerViewModel = rooms
            });
        }

        [HttpGet("stateroom-price/get-room/{roomId}")]
        public async Task<IActionResult> UpdateRoom(int roomId)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            //var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId, null);

            var roomTypequest = new GetRoomTypeRequest
            {
                Keyword = "",
                LanguageId = languageId,
                PageIndex = 1,
                PageSize = 20
            };
            var bedquest = new GetBedRequest
            {
                Keyword = "",
                Language_Id = languageId,
                PageIndex = 1,
                PageSize = 20
            };
            var roomType = await _roomType.GetRoomType(roomTypequest);
            var bed = await _bed.Get(bedquest);

            var room = await _room.GetRoomByRoomId(roomId, languageId);
            return View(new NotifyBookingViewModel
            {
                UserId = userId,
                HotelViewModel = hotel,
                //BookingOwnerViewModel = booking,
                RoomDetailOwnerViewModel = room,
                RoomTypeOwnerViewModel = roomType,
                BedOwnerViewModel = bed,
            });
        }

        [HttpPost("stateroom-price/update-room/{roomId}")]
        public async Task<IActionResult> UpdateRoom(int roomId, RoomViewModel request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var updateRoom = await _room.UpdateRoom(roomId, request);
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            //var booking = await _booking.GetAllBookingOwner(hotel.Id, languageId, null);

            var roomTypequest = new GetRoomTypeRequest
            {
                Keyword = "",
                LanguageId = languageId,
                PageIndex = 1,
                PageSize = 20
            };
            var bedquest = new GetBedRequest
            {
                Keyword = "",
                Language_Id = languageId,
                PageIndex = 1,
                PageSize = 20
            };
            var roomType = await _roomType.GetRoomType(roomTypequest);
            var bed = await _bed.Get(bedquest);

            var room = await _room.GetRoomByRoomId(roomId, languageId);
            return View(new NotifyBookingViewModel
            {
                UserId = userId,
                HotelViewModel = hotel,
                //BookingOwnerViewModel = booking,
                RoomDetailOwnerViewModel = room,
                RoomTypeOwnerViewModel = roomType,
                BedOwnerViewModel = bed,
            });
        }
        
        [HttpPost("check-out/bill")]
        public async Task<IActionResult> DisplayBill(CheckoutRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var client = await _booking.BillClient(request.BookingId, languageId);
            return View(new NotifyBookingViewModel
            {
                UserId = userId,
                HotelViewModel = hotel,
                BillClientViewModel = client
            });
        }
        
        [HttpPost("check-out/bill/confirm")]
        public async Task<IActionResult> ConfirmCheckout(int BookingId, int RoomId)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var request = new CheckoutRequest
            {
                BookingId = BookingId,
                RoomId = RoomId,
            };
            var checkout = await _booking.Bill(request);
            return new RedirectResult("/booking/check-out");
        }

        [HttpGet("/owner/profile")]        
        public async Task<IActionResult> ProfileOwner()
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var hotel = await _hotel.GetHotelByUserId(Guid.Parse(userId), languageId);
            var user = await _user.GetUserById(userId);
            return View(new NotifyBookingViewModel
            {
                UserId = userId,
                HotelViewModel = hotel,
                UserViewModel = user.ResultOject
            });
        }

        [HttpPost("/owner/profile"), Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateUser(UpdateProfileRequest request)
        {
            var userId = _httpContextAccessor.HttpContext.Session.GetString("UserId_Owner");
            var upddateUser = await _profile.UpdateProfile(userId, request);
            return new RedirectResult("/owner/profile");
        }


    }
}
