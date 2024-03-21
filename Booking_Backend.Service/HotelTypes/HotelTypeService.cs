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
using System.Text.RegularExpressions;   

namespace Booking_Backend.Service.HotelTypes
{
    public class HotelTypeService : IHotelTypeService
    {
        private readonly BookingContext _context;
        private readonly IImageService _image;
        private readonly IStorageService _storage;

        public HotelTypeService(BookingContext context, IImageService hotelTypeImage, IStorageService storage)
        {
            _context = context;
            _image = hotelTypeImage;
            _storage = storage;
        }

        public async Task<bool> CreateHotelType(CreateHotelTypeRequest request)
        {
            var hotelTypeVI = await _context.HotelTypeTranslations.FirstOrDefaultAsync(x => x.Name == request.NameVI && x.Language_Id == "vi-VN");
            var hotelTypeEN = await _context.HotelTypeTranslations.FirstOrDefaultAsync(x => x.Name == request.NameEN && x.Language_Id == "en-US");
            if (hotelTypeVI != null && hotelTypeEN != null) return false;
            var result = new HotelType
            {
                HotelTypeTranslations = new List<HotelTypeTranslation>()
                {
                    new HotelTypeTranslation { Name = request.NameVI, Language_Id = "vi-VN"},
                    new HotelTypeTranslation { Name = request.NameEN, Language_Id = "en-US"}
                }
            };
            if (request.Image != null)
            {
                result.HotelTypeImage = new HotelTypeImage()
                {
                    Caption = $"Initial image hotel type at " + DateTime.UtcNow.ToString(),
                    ImageSize = request.Image.Length,
                    ImageUrl = await _image.SaveFile(request.Image),
                    Created = DateTime.Now,
                    isDefault = true
                };
            }
            _context.HotelTypes.Add(result);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteHotelType(int Id)
        {
            var hotelType = await _context.HotelTypes.FindAsync(Id);
            if (hotelType == null) return false;
            // Tìm record img
            var hotelTypeImage = await _context.HotelTypeImages.FirstOrDefaultAsync(x=>x.Id == hotelType.HotelTypeImage_Id);
            // Xóa record hoteltype
            var removeHotelType = _context.HotelTypes.Remove(hotelType);
            // Xóa file server
            await _storage.DeleteFileAsync(hotelTypeImage.ImageUrl);
            // Xóa record hoteltypeimage
            var removeHotelTypeImage = _context.HotelTypeImages.Remove(hotelTypeImage);
            await _context.SaveChangesAsync();
            return true;
        }

        // Lấy tất cả chỗ nghỉ dưỡng theo ngôn ngữ
        public async Task<PageResult<HotelTypeViewModel>> GetHotelType(GetAllHotelTypePagingRequest request)
        {
            var query = from h in _context.HotelTypes
                        join ht in _context.HotelTypeTranslations on h.Id equals ht.HotelType_Id into htGroup
                        from ht in htGroup.DefaultIfEmpty()
                        join ih in _context.HotelTypeImages on h.HotelTypeImage_Id equals ih.Id into ihGroup
                        from ih in ihGroup.DefaultIfEmpty()
                        where ht.Language_Id == request.LanguageId
                        select new
                        {
                            h.Id,
                            ht.Name,
                            ImageUrl = ih != null ? ih.ImageUrl : null,
                            ht.Language_Id
                        };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.Name.Contains(request.Keyword));
            }

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new HotelTypeViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Language_Id = x.Language_Id
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

        
        public async Task<HotelTypeViewModel> GetHotelTypeById(string Language_Id, int Id)
        {
            var hotelType = await _context.HotelTypes.FindAsync(Id);
            if (hotelType == null) return null; 
            var hotelTypeTranslation = await _context.HotelTypeTranslations.FirstOrDefaultAsync(x=>x.HotelType_Id == hotelType.Id && x.Language_Id == Language_Id);
            var hotelImage = await _context.HotelTypeImages.FirstOrDefaultAsync(x => x.Id == hotelType.HotelTypeImage_Id);
            var hotelTypeVM = new HotelTypeViewModel()
            {
                Id = hotelType.Id,
                Name = hotelTypeTranslation.Name,
                ImageUrl = hotelImage.ImageUrl,
                Language_Id = hotelTypeTranslation.Language_Id,
            };
            return hotelTypeVM;
        }
/*
        /*public async Task<HotelTypeImageViewModel> GetImageByHotelTypeId(int hotelTypeId)
        {
            var hotelTypeImage = await _context.HotelTypeImages.FirstOrDefaultAsync(x => x.HotelType_Id == hotelTypeId);
            if (hotelTypeImage == null) return null;
            var result = new HotelTypeImageViewModel()
            {
                Id = hotelTypeImage.Id,
                Caption = hotelTypeImage.Caption,
                ImageSize = hotelTypeImage.ImageSize,
                ImageUrl = hotelTypeImage.ImageUrl,
                Created = hotelTypeImage.Created,
                isDefault = hotelTypeImage.isDefault
            };
            return result;
        }*/

        public async Task<bool> UpdateHotelType(int Id, UpdateHotelTypeRequest request)
        {
            var hotelType = await _context.HotelTypes.FindAsync(Id);
            if (hotelType == null) return false;
            var hotelTypeTranslation = await _context.HotelTypeTranslations.FirstOrDefaultAsync(x => x.HotelType_Id == hotelType.Id && x.Language_Id == request.Language_Id);
            var hotelTypeImage = await _context.HotelTypeImages.FirstOrDefaultAsync(x => x.Id == hotelType.HotelTypeImage_Id);

            hotelType.Id = Id;
            hotelTypeTranslation.Name = request.Name;

            if (request.Image != null)
            {

                await _storage.DeleteFileAsync(hotelTypeImage.ImageUrl);

                hotelTypeImage.Caption = "Hotel type image has been at " + DateTime.UtcNow.ToString();
                hotelTypeImage.ImageUrl = await _image.SaveFile(request.Image);
                hotelTypeImage.ImageSize = request.Image.Length;
                hotelTypeImage.isDefault = true;
            }

            _context.HotelTypes.Update(hotelType);
            _context.HotelTypeImages.Update(hotelTypeImage);
            _context.HotelTypeTranslations.Update(hotelTypeTranslation);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}