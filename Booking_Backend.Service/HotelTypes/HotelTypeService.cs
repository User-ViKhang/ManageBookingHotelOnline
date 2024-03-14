using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.HotelTypes.ViewModels;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.UserImage.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Booking_Backend.Repository.Users.ViewModel;
using Booking_Backend.Service.Files;
using Booking_Backend.Service.Images;
using Booking_Backend.Utilities.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Booking_Backend.Service.HotelTypes
{
    public class HotelTypeService : IHotelTypeService
    {
        private readonly BookingContext _context;
        private readonly IImageService _image;
        private readonly IStorageService _storage;

        public HotelTypeService(BookingContext context, IImageService image, IStorageService storage)
        {
            _context = context;
            _image = image;
            _storage = storage;
        }

        public async Task<bool> CreateHotelType(string languageId, CreateHotelTypeRequest request)
        {
            var hotelType = await _context.HotelTypes.FirstOrDefaultAsync(x => x.Name == request.Name);
            if (hotelType != null) return false;
            var result = new HotelType
            {
                Name = request.Name,
                Language = languageId,
            };
            if (request.Thumbnail != null)
            {
                result.HotelTypeImages = new List<HotelTypeImage>()
                {
                    new HotelTypeImage()
                    {
                        Caption = $"thumbnail-hoteltype-{request.Name}",
                        ImageSize = request.Thumbnail.Length,
                        ImageUrl = await _image.SaveFile(request.Thumbnail),
                        Created = DateTime.Now,
                        isDefault = true
                    }
                };
                result.ImageUrl = await _image.SaveFile(request.Thumbnail);
            }
            _context.HotelTypes.Add(result);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteHotelType(int Id)
        {
            var hotelType = await _context.HotelTypes.FindAsync(Id);
            if (hotelType == null) return false;
            var isResult = _context.HotelTypes.Remove(hotelType);
            await _storage.DeleteFileAsync(hotelType.ImageUrl);
            await _context.SaveChangesAsync();
            return true;
        }

        // Lấy tất cả chỗ nghỉ dưỡng theo ngôn ngữ
        public async Task<PageResult<HotelTypeViewModel>> GetHotelType(GetAllHotelTypePagingRequest request)
        {
            var query = from ht in _context.HotelTypes
                        where ht.Language == request.LanguageId
                        join hti in _context.HotelTypeImages on ht.Id equals hti.HotelType_Id into gj
                        from subHotelTypeImage in gj.DefaultIfEmpty()
                        select new
                        {
                            ht,
                            ImageUrl = subHotelTypeImage != null ? subHotelTypeImage.ImageUrl : null
                        };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.ht.Name.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new HotelTypeViewModel()
            {
                Id = x.ht.Id,
                Name = x.ht.Name,
                Language = x.ht.Language,
                ImageUrl = x.ImageUrl
            }).ToListAsync();
            var PagedResult = new PageResult<HotelTypeViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return PagedResult;
        }

        public async Task<HotelTypeViewModel> GetHotelTypeById(string languageId, int hotelTypeId)
        {
            var hotelType = await _context.HotelTypes.FindAsync(hotelTypeId);
            if (hotelType == null) return null;
            var result = new HotelTypeViewModel()
            {
                Id = hotelType.Id,
                Name = hotelType.Name,
                Language = languageId,
                ImageUrl = hotelType.ImageUrl,
                Thumbnail = await this.GetImageByHotelTypeId(hotelTypeId)
            };
            return result;
        }

        public async Task<HotelTypeImageViewModel> GetImageByHotelTypeId(int hotelTypeId)
        {
            var image = await _context.HotelTypeImages.FirstOrDefaultAsync(x => x.HotelType_Id == hotelTypeId);
            if (image == null) return null;
            var result = new HotelTypeImageViewModel()
            {
                Id = image.Id,
                Caption = image.Caption,
                ImageSize = image.ImageSize,
                ImageUrl = image.ImageUrl,
                Created = image.Created,
                isDefault = image.isDefault
            };
            return result;
        }

        public async Task<bool> UpdateHotelType(int Id, UpdateHotelTypeRequest request)
        {
            var hotelType = await _context.HotelTypes.FindAsync(Id);

            if (hotelType == null) return false;

            hotelType.Id = Id;
            hotelType.Name = request.Name;
            hotelType.Language = request.LanguageId;

            if (request.Thumbnail != null)
            {
                var thumbnail = await _context.HotelTypeImages.FirstOrDefaultAsync(x => x.HotelType_Id == Id);

                if (thumbnail != null) // Cập nhật img
                {
                    thumbnail.Caption = "hoteltypeimg-updated-" + request.Name;
                    thumbnail.ImageSize = request.Thumbnail.Length;
                    thumbnail.ImageUrl = await _image.SaveFile(request.Thumbnail);
                    thumbnail.isDefault = true;
                    hotelType.ImageUrl = thumbnail.ImageUrl;
                    _context.HotelTypeImages.Update(thumbnail);
                }
                else // Tạo img
                {
                    hotelType.HotelTypeImages = new List<HotelTypeImage>()
                    {
                        new HotelTypeImage()
                        {
                            Caption = "hoteltypeimg-" + request.Name,
                            ImageSize = request.Thumbnail.Length,
                            ImageUrl = await _image.SaveFile(request.Thumbnail),
                            isDefault = true
                        }
                    };
                    hotelType.ImageUrl = hotelType.HotelTypeImages[0].ImageUrl;
                }
                hotelType.HotelTypeImages = new List<HotelTypeImage>()
                {
                    new HotelTypeImage()
                    {
                        Caption = thumbnail.Caption,
                        ImageSize = thumbnail.ImageSize,
                        ImageUrl = thumbnail.ImageUrl,
                        isDefault = true,
                        Created = DateTime.Now
                    }
                };
            }
            await _context.SaveChangesAsync();
            return true;
        }
    }
}