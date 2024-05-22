using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.ExtensionTypeRoom.Request;
using Booking_Backend.Repository.ExtensionTypeRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Microsoft.EntityFrameworkCore;
using Booking_Backend.Repository.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Booking_Backend.Service.ExtensionTypeRoom
{
    public class ExtensionTypeRoomAPIService : IExtensionTypeRoomAPIService
    {
        private readonly BookingContext _context;

        public ExtensionTypeRoomAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateExtensionTypeRoom(CreateExtensionTypeRoomRequest request)
        {
            var extensionTypeTranslationVI = await _context.ExtensionTranslations.FirstOrDefaultAsync(x => x.Name == request.NameVI && x.Language_Id == "vi-VN");
            var extensionTypeTranslationEN = await _context.ExtensionTranslations.FirstOrDefaultAsync(x => x.Name == request.NameEN && x.Language_Id == "en-US");
            if (extensionTypeTranslationVI != null && extensionTypeTranslationEN != null) return false;

            var extensionType = new ExtensionType()
            {
                ExtensionTypeTranslations = new List<ExtensionTypeTranslation>()
                {
                    new ExtensionTypeTranslation() { Name = request.NameVI, Language_Id = "vi-VN" },
                    new ExtensionTypeTranslation() { Name = request.NameEN, Language_Id = "en-US" }
                }
            };
            await _context.ExtensionTypes.AddAsync(extensionType);
            await _context.SaveChangesAsync();
            return true;
        }
        
        public async Task<bool> DeleteExtensionTypeRoom(int Id)
        {
            var extension = await _context.ExtensionTypes.FindAsync(Id);
            if (extension == null) return false;
            var isResult = _context.ExtensionTypes.Remove(extension);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<ExtensionTypeRoomViewModel>> GetAll(string Language_Id)
        {
            var query = from ex in _context.ExtensionTypes
                        join ext in _context.ExtensionTypeTranslations on ex.Id equals ext.ExtensionType_Id
                        where ext.Language_Id == Language_Id
                        select new { ex, ext };
            var data = await query.Select(x => new ExtensionTypeRoomViewModel()
            {
                Id = x.ex.Id,
                Name = x.ext.Name,
                Language_Id = x.ext.Language_Id
            }).ToListAsync();
            return data;
        }

        public async Task<List<ExtensionType>> GetExtensionGroup(string languageId)
        {
            return await _context.ExtensionTypes
           .Include(etype => etype.ExtensionTypeTranslations)
           .Include(etype => etype.Extensions).ThenInclude(e => e.ExtensionTranslations)
           .Where(etype => etype.ExtensionTypeTranslations.Any(x => x.Language_Id == languageId))
           .Select(etype => new ExtensionType
           {
               Id = etype.Id,
               ExtensionTypeTranslations = etype.ExtensionTypeTranslations
                   .Where(x => x.Language_Id == languageId)
                   .Select(x => new ExtensionTypeTranslation
                   {
                       Id = x.Id,
                       Name = x.Name,
                       Language_Id = x.Language_Id
                   }).ToList(),
               Extensions = etype.Extensions
                   .Where(e => e.ExtensionTranslations.Any(x => x.Language_Id == languageId))
                   .Select(e => new Extension
                   {
                       Id = e.Id,
                       ExtensionType = e.ExtensionType,
                       ExtensionType_Id = e.ExtensionType_Id,
                       Room_Extensions = e.Room_Extensions,
                       ExtensionTranslations = e.ExtensionTranslations
                           .Where(x => x.Language_Id == languageId)
                           .Select(x => new ExtensionTranslation
                           {
                               Id = x.Id,
                               Name = x.Name,
                               Language_Id = x.Language_Id
                           }).ToList()
                   }).ToList()
           }).ToListAsync();
        }

        public async Task<PageResult<ExtensionTypeRoomViewModel>> GetExtensionTypeRoom(GetExtensionTypeRoomRequest request)
        {
            var query = from ex in _context.ExtensionTypes
                        join ext in _context.ExtensionTypeTranslations on ex.Id equals ext.ExtensionType_Id
                        where ext.Language_Id == request.Language_Id
                        select new { ex, ext };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.ext.Name == request.Keyword);
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new ExtensionTypeRoomViewModel()
            {
                Id = x.ex.Id,
                Name = x.ext.Name,
                Language_Id = x.ext.Language_Id
            }).ToListAsync();
            var PagedResult = new PageResult<ExtensionTypeRoomViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return PagedResult;
        }
        
        public async Task<bool> UpdateExtensionTypeRoom(int Id, UpdateExtensionTypeRoomRequest request)
        {
            var extensionType = await _context.ExtensionTypes.FindAsync(Id);
            if (extensionType == null) return false;

            var extensionTypeTranslation = await _context.ExtensionTypeTranslations.FirstOrDefaultAsync(x => x.ExtensionType_Id == Id);

            extensionTypeTranslation.Name = request.Name;
            extensionTypeTranslation.Language_Id = request.Language_Id;
            _context.ExtensionTypeTranslations.Update(extensionTypeTranslation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
