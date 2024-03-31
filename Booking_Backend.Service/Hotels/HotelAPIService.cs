using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Hotels.Request;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Service.Files;
using Booking_Backend.Service.Images;
using Booking_Backend.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        public HotelAPIService(BookingContext context, IImageService image, IStorageService storage)
        {
            _context = context;
            _image = image;
            _storage = storage;
        }

        public async Task<HotelDetailViewModel> GetHotelById(int Id, string LanguageId)
        {
            /*var hotel = await _context.Hotels
                .Include(h => h.HotelTranslations)
                .Include(h => h.Images)
                .Include(h => h.HotelType)
                .Include(h => h.HotelType.HotelTypeTranslations)
                .Include(h => h.ViewHotel)
                .Include(h => h.ViewHotel.ViewHotelTranslations)
                .Include(h => h.Rooms)
                .FirstOrDefaultAsync(h => h.Id == Id);*/
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
                .Include(h=>h.Rooms)
                    .ThenInclude(r => r.Bed)
                        .ThenInclude(b => b.BedTranslations)
                .FirstOrDefaultAsync(h => h.Id == Id);

            /*if (hotel == null)
            {
                throw new BookingException("Hotel not found");
            }

            var data = new Hotel
            {
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
                HotelTranslations = hotel.HotelTranslations.Where(ht=>ht.Language_Id==LanguageId).Select(ht => new HotelTranslation
                {
                    Id = ht.Id,
                    Address = ht.Address,
                    Area = ht.Area,
                    Description = ht.Description,
                    Name = ht.Name,
                }).ToList(),
                Rooms = hotel.Rooms.Select(ht => new Room
                {
                    Id = ht.Id,
                    RoomCode = ht.RoomCode,
                    Maximum = ht.Maximum,
                    Status = ht.Status,
                    PriceOverNight = ht.PriceOverNight,
                    RoomType = new RoomType
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
                }
            };*/

            if (hotel == null)
            {
                throw new BookingException("Hotel not found");
            }

            var data = new HotelDetailViewModel
            {
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
                }).ToList(),
                Rooms = hotel.Rooms.Select(ht => new Room
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
                        select new { hotel,  hotelTranslation, hotelTypeTranslation, viewHotelTranslation };
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new HotelViewModel()
            {
                Id = x.hotel.Id,
                Name = x.hotelTranslation.Name,
                Address = x.hotelTranslation.Address,
                HotelTypeName = x.hotelTypeTranslation.Name,
                ShortDescription = x.hotelTranslation.ShortDescription,
                Thumbnail = x.hotel.Thumbnail
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


    }
}
