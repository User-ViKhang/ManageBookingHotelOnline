using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RateRepo;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Backend.Service.Files;
using Booking_Backend.Service.Images;
using Booking_Backend.Service.SendEmail;
using Booking_Backend.Service.Users;
using Booking_Backend.Utilities.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.Hotels
{
    public class HotelAPIService : IHotelAPIService
    {
        private readonly BookingContext _context;
        private readonly IImageService _image;
        private readonly IStorageService _storage;
        private readonly IEmailService _emailService;
        private readonly IUserService _user;

        public HotelAPIService(BookingContext context, IImageService image, IStorageService storage, IEmailService emailService, IUserService user)
        {
            _context = context;
            _image = image;
            _storage = storage;
            _emailService = emailService;
            _user = user;
        }

        public async Task<bool> CreateImageHotel(int Id, CreateImageHotelRequest request)
        {
            var hotel = await _context.Hotels.FindAsync(Id);
            if (hotel == null) return false;

            if (hotel.Images == null)
            {
                hotel.Images = new List<Image>();
            }

            var image = new Image
            {
                Caption = $"Initial image hotel at " + DateTime.UtcNow.ToString(),
                Created = DateTime.UtcNow,
                ImageSize = request.Image.Length,
                ImageUrl = await _image.SaveFile(request.Image),
                Hotel_Id = hotel.Id
            };

            hotel.Images.Add(image);
            _context.Images.Add(image);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CreateImageThumbnailHotel(int Id, CreateImageHotelRequest request)
        {
            var hotel = await _context.Hotels.FindAsync(Id);

            if (hotel == null) return false;
            if(hotel.Thumbnail != null)
            {
                await _storage.DeleteFileAsync(hotel.Thumbnail);
                hotel.Thumbnail = await _image.SaveFile(request.Image);
                _context.Hotels.Update(hotel);
                await _context.SaveChangesAsync();
            } else
            {
                hotel.Thumbnail = await _image.SaveFile(request.Image);
                _context.Hotels.Update(hotel);
                await _context.SaveChangesAsync();
            }
            return true;
        }

        public async Task<HotelDetailViewModel> GetHotelById(int Id, string LanguageId)
        {
            var hotel = await _context.Hotels
                .Include(h => h.HotelTranslations)
                .Include(h => h.Images)
                .Include(h => h.HotelType)
                .Include(h => h.HotelType.HotelTypeTranslations)
                .Include(h => h.ViewHotel)
                .Include(h => h.ViewHotel.ViewHotelTranslations)
                .Include(h => h.Rooms)
                    .ThenInclude(r => r.RoomType)
                        .ThenInclude(rt => rt.RoomTypeTranslations)
                .Include(h => h.Rooms)
                    .ThenInclude(r => r.Bed)
                        .ThenInclude(b => b.BedTranslations)
                .FirstOrDefaultAsync(h => h.Id == Id);


            if (hotel == null)
            {
                throw new BookingException("Hotel not found");
            }

            var data = new HotelDetailViewModel
            {
                CountFeedback = hotel.CountFeedBack,
                StaffScore = hotel.StaffScore,
                CleanlinessScores = hotel.CleanlinessScores,
                ComfortScore = hotel.ComfortScore,
                FacilitiesScore = hotel.FacilitiesScore,    
                LocationScore = hotel.LocationScore,
                ValueScore = hotel.ValueScore,
                Score = hotel.Score,
                Id = hotel.Id,
                Hotline = hotel.Hotline,
                Establish = hotel.Establish,
                Latitude = hotel.Latitude,
                Longitude = hotel.Longitude,
                Thumbnail = hotel.Thumbnail,
                Images = hotel.Images.Select(i => new Image
                {
                    Id = i.Id,
                    Caption = i.Caption,
                    ImageSize = i.ImageSize,
                    ImageUrl = i.ImageUrl,
                    Created = i.Created,
                }).ToList(),
                HotelTranslations = hotel.HotelTranslations.Where(ht => ht.Language_Id == LanguageId).Select(ht => new HotelTranslation
                {
                    Id = ht.Id,
                    Address = ht.Address,
                    Area = ht.Area,
                    Description = ht.Description,
                    Name = ht.Name,
                    ShortDescription = ht.ShortDescription,
                }).ToList(),
                Rooms = hotel.Rooms.Where(x => x.Status == StatusRoom.Empty).Select(ht => new Room
                {
                    Id = ht.Id,
                    RoomCode = ht.RoomCode,
                    Maximum = ht.Maximum,
                    Status = ht.Status,
                    PriceOverNight = ht.PriceOverNight,
                    Room_Extensions = _context.Room_Extensions
                    .Where(re => re.Room_Id == ht.Id)
                    .Select(re => new Room_Extension
                    {
                        Quantity = re.Quantity,
                        Extension = new Extension
                        {
                            Id = re.Extension.Id,
                            ExtensionTranslations = re.Extension.ExtensionTranslations
                                .Where(et => et.Language_Id == LanguageId)
                                .Select(et => new ExtensionTranslation
                                {
                                    Name = et.Name
                                }).ToList()
                        }
                    }).ToList(),
                    RoomType = new RoomType
                    {
                        Id = ht.RoomType.Id,
                        RoomTypeTranslations = ht.RoomType.RoomTypeTranslations
                            .Where(rt => rt.Language_Id == LanguageId)
                            .Select(rt => new RoomTypeTranslation
                            {
                                Name = rt.Name
                            })
                            .ToList()
                    },
                    Bed = new Bed
                    {
                        Id = ht.Bed.Id,
                        BedTranslations = ht.Bed.BedTranslations
                            .Where(b => b.Language_Id == LanguageId)
                            .Select(rt => new BedTranslation
                            {
                                Name = rt.Name,
                                Description = rt.Description
                            })
                            .ToList()
                    }
                }).ToList(),
                HotelType = new HotelType
                {
                    HotelTypeTranslations = hotel.HotelType.HotelTypeTranslations.Where(ht => ht.Language_Id == LanguageId).Select(ht => new HotelTypeTranslation
                    {
                        Name = ht.Name,
                    }).ToList()
                },
                ViewHotel = new ViewHotel
                {
                    ViewHotelTranslations = hotel.ViewHotel.ViewHotelTranslations.Where(ht => ht.Language_Id == LanguageId).Select(vt => new ViewHotelTranslation
                    {
                        Name = vt.Name
                    }).ToList()
                },
            };

            return data;
        }

        public async Task<PageResult<HotelViewModel>> GetHotelByLocation(GetHotelByLocationRequest request)
        {
            var locationTranslation = await _context.LocationTranslations.FirstOrDefaultAsync(x => x.Name == request.LocationName);

            if (locationTranslation == null) throw new BookingException("Không tim thấy địa chỉ");
            var locationId = locationTranslation.Location_Id;
            var query = from hotel in _context.Hotels
                        where hotel.Location_Id == locationId
                        join hotelTranslation in _context.HotelTranslations on hotel.Id equals hotelTranslation.Hotel_Id
                        where hotelTranslation.Language_Id == request.LanguageId
                        join hotelType in _context.HotelTypes on hotel.HotelType_Id equals hotelType.Id
                        join hotelTypeTranslation in _context.HotelTypeTranslations on hotelType.Id equals hotelTypeTranslation.HotelType_Id
                        where hotelTypeTranslation.Language_Id == request.LanguageId
                        join viewHotel in _context.ViewHotels on hotel.ViewHotel_Id equals viewHotel.Id
                        join viewHotelTranslation in _context.ViewHotelTranslations on viewHotel.Id equals viewHotelTranslation.ViewHotel_Id
                        where viewHotelTranslation.Language_Id == request.LanguageId
                        select new { hotel, hotelTranslation, hotelTypeTranslation, viewHotelTranslation };
            if(request.IsHightFeedBack == true)
            {
                query = query.OrderByDescending(x => x.hotel.Score);
            }
            if(request.isLowPrice == true)
            {
                query = query.OrderBy(x => x.hotel.PriceDefault);
            }
            if(request.HotelTypeId != 0)
            {
                query = query.Where(x => x.hotelTypeTranslation.HotelType_Id == request.HotelTypeId).AsQueryable();
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new HotelViewModel()
            {
                Id = x.hotel.Id,
                CountFeedback = x.hotel.CountFeedBack,
                Name = x.hotelTranslation.Name,
                Address = x.hotelTranslation.Address,
                HotelTypeName = x.hotelTypeTranslation.Name,
                ShortDescription = x.hotelTranslation.ShortDescription,
                Thumbnail = x.hotel.Thumbnail,
                Preview = x.hotel.Preview,
                Score = x.hotel.Score,
                PriceDefault = x.hotel.PriceDefault,
            }).ToListAsync();
            var PagedResult = new PageResult<HotelViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return PagedResult;
        }

        public async Task<HotelOwnerViewModel> GetHotelByUserId(Guid Id, string LanguageId)
        {
            var userId = await _context.Users.Where(x => x.Id == Id).Select(x => x.Id).FirstOrDefaultAsync();
            if (userId == Guid.Empty) throw new BookingException("Người dùng không tồn tại");
            var hotel = _context.Hotels.Where(x => x.User_Id == userId).FirstOrDefault();
            var hotelTranslation = _context.HotelTranslations.Where(x => x.Hotel_Id == hotel.Id && x.Language_Id == LanguageId).FirstOrDefault();
            if (hotel == null) throw new BookingException("Chỗ nghĩ không tồn tại");
            var hotelOwnerViewModel = new HotelOwnerViewModel()
            {
                Id = hotel.Id,
                Hotline = hotel.Hotline,
                Establish = hotel.Establish,
                Latitude = hotel.Latitude,
                Longitude = hotel.Longitude,
                Thumbnail = hotel.Thumbnail,
                Name = hotelTranslation.Name,
                Area = hotelTranslation.Area,
                Address = hotelTranslation.Address,
                Description = hotelTranslation.Description,
                ShortDescription = hotelTranslation.ShortDescription,
                Language_Id = hotelTranslation.Language_Id,
                LocationId = hotel.Location_Id,
                HotelTypeId = hotel.HotelType_Id,
                ViewHotelId = hotel.ViewHotel_Id,
                Price = hotel.PriceDefault
            };
            return hotelOwnerViewModel;
        }

        public async Task<List<Image>> GetListImageHotel(int Id)
        {
            var images = await _context.Images.Where(x => x.Hotel_Id == Id).ToListAsync();
            return images;
        }

        public async Task<bool> DeleteHotelImage(int Id)
        {
            var img = await _context.Images.FindAsync(Id);
            if (img == null) return false;
            var remove = _context.Images.Remove(img);
            await _storage.DeleteFileAsync(img.ImageUrl);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<HotelViewViewModel>> GetHotelByView(string languageId, int viewId)
        {
            var view = _context.ViewHotels.FindAsync(viewId);
            if (view == null) return null;
            var hotel = _context.Hotels.Where(x => x.ViewHotel_Id == viewId).Select(x => new HotelViewViewModel
            {
                Id = x.Id,
                ImageHotel = x.Thumbnail,
                HotelName = x.HotelTranslations.FirstOrDefault(x => x.Language_Id == languageId).Name,
                StartPrice = 0,
                Address = x.HotelTranslations.FirstOrDefault(x => x.Language_Id == languageId).Address
            }).ToList();
            return hotel;
        }

        public async Task<bool> RegisterHotel(InfoOwnerRegisterViewModel request)
        {
            var createHotel = new Hotel
            {
                Hotline = "",
                Establish = DateTime.UtcNow,
                Latitude = 0,
                Longitude = 0,
                HotelType_Id = request.HotelTypeId,
                ViewHotel_Id = 1,
                Location_Id = request.LocationId,
                User_Id = Guid.Parse(request.UserId),
                HotelTranslations = new List<HotelTranslation>()
                {
                    new HotelTranslation {Name = request.HotelNameVI, Language_Id = "vi-VN"},
                    new HotelTranslation {Name = request.HotelNameEN, Language_Id = "en-US"},
                }
            };
            var changeRole = await _user.ChangeRoleOwner(request.UserId);
            var user = await _user.GetUserById(request.UserId);
            var mailContent = new MailData
            {
                ReceiverEmail = user.ResultOject.Email,
                ReceiverName = user.ResultOject.UserName,
                Title = "Gonow.net - Xác nhận yêu cầu bán phòng",
                Body =
                                   $"<br/>Xin chào {user.ResultOject.UserName},\n\n" +
                                   $"<br/>Chúc mừng! Yêu cầu đăng kí bán phòng của bạn đã được chấp nhận!\n" +
                                   $"<br/><a href='https://localhost:5000/vi-VN/auth/login'>Nhấp chọn vào đây để bắt đầu đăng tin</a>\n" +
                                   $"<br/> Trân trọng,\nGonow.net"
            };
            var sendmail = await _emailService.SendEmailAsync(mailContent);
            await _context.AddAsync(createHotel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ChangeDes(int HotelId, string Des, string LanguageId)
        {
            var hotel = _context.Hotels
                .Include(h => h.HotelTranslations)
                .FirstOrDefault(h => h.Id == HotelId);
            if (hotel == null) return false;
            hotel.HotelTranslations.FirstOrDefault(x => x.Language_Id == LanguageId).Description = Des;
            hotel.HotelTranslations.FirstOrDefault(x => x.Language_Id == LanguageId).Description = Des;
            _context.Hotels.Update(hotel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateHotel(int Id, UpdateHotelRequest request)
        {
            var hotel = await _context.Hotels.FindAsync(Id);
            if (hotel == null) return false;
            var updateHotel = await _context.Hotels
                                .Include(h => h.HotelTranslations)
                                .FirstOrDefaultAsync(h => h.Id == Id && h.HotelTranslations.FirstOrDefault().Language_Id == request.LanguageId);
            updateHotel.Hotline  = request.Hotline;
            updateHotel.PriceDefault  = request.Price;
            updateHotel.HotelTranslations.FirstOrDefault().Name = request.Name;
            updateHotel.HotelTranslations.FirstOrDefault().Address = request.Address;
            updateHotel.HotelTranslations.FirstOrDefault().Description = request.Description;
            updateHotel.HotelTranslations.FirstOrDefault().ShortDescription = request.ShortDescription;
            updateHotel.Establish = request.Establish;
            updateHotel.HotelType = await _context.HotelTypes.FindAsync(request.HotelTypeId);
            updateHotel.Location = await _context.Locations.FindAsync(request.LocationId);
            updateHotel.ViewHotel = await _context.ViewHotels.FindAsync(request.ViewId);
            //updateHotel.Latitude = request.Latitude;
            //updateHotel.Longitude = request.Longitude;
            _context.Hotels.Update(updateHotel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RatingMe(RatingRequest request)
        {
            var hotel = await _context.Hotels.FindAsync(request.HotelId);
            if (hotel == null) return false;
            var feedbackCustomer = new FeedbackCustomer
            {
                UserId = Guid.Parse(request.UserId),
                HotelId = request.HotelId,
                StaffScore = request.StaffScore,
                CleanlinessScore = request.CleanlinessScores,
                ComfortScore = request.ComfortScore,
                FacilitiesScore = request.FacilitiesScore,
                LocationScore = request.LocationScore,
                ValueScore = request.ValueScore,
                Score = (request.StaffScore + request.CleanlinessScores + request.ComfortScore + request.FacilitiesScore + request.LocationScore + request.LocationScore) / 6
            };
            await _context.FeedbackCustomers.AddAsync(feedbackCustomer);
            await _context.SaveChangesAsync();

            var feedback = _context.FeedbackCustomers
                .Where(x => x.HotelId == request.HotelId);

            decimal staffScore = feedback.Select(x => x.StaffScore).Average();
            decimal comfortScore = feedback.Select(x => x.ComfortScore).Average();
            decimal facilitiesScore = feedback.Select(x => x.FacilitiesScore).Average();
            decimal cleanlinessScore = feedback.Select(x => x.CleanlinessScore).Average();
            decimal locationScore = feedback.Select(x => x.LocationScore).Average();
            decimal valueScore = feedback.Select(x => x.ValueScore).Average();
            decimal score = feedback.Select(x => x.Score).Average();
            hotel.StaffScore = staffScore;
            hotel.ComfortScore = comfortScore;
            hotel.FacilitiesScore = facilitiesScore;
            hotel.CleanlinessScores = cleanlinessScore;
            hotel.LocationScore = locationScore;
            hotel.ValueScore = valueScore;  
            hotel.Score = score;
            hotel.CountFeedBack = hotel.CountFeedBack + 1;
            _context.Hotels.Update(hotel);  
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
