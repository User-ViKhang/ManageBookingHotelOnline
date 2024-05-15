using Booking_Backend.Data.EF;
using Booking_Backend.Repository.ExtensionRoom.Request;
using Booking_Backend.Repository.ExtensionTypeRoom.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Service.Request;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Booking_Backend.Repository.ExtensionRoom.ViewModel;
using Booking_Backend.Utilities.Exceptions;

namespace Booking_Backend.Service.ExtensionRoom
{
    public class ExtensionRoomAPIService : IExtensionRoomAPIService
    {
        private readonly BookingContext _context;

        public ExtensionRoomAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateExtensionRoom(CreateExtensionRoomRequest request)
        {
            var extensionVI = await _context.ExtensionTranslations.FirstOrDefaultAsync(x => x.Name == request.NameVI);
            var extensionEN = await _context.ExtensionTranslations.FirstOrDefaultAsync(x => x.Name == request.NameEN);
            if (extensionVI != null && extensionEN != null) return false;
            var extensionRoom = new Extension()
            {
                ExtensionType_Id = request.ExtensionType_Id,
                ExtensionTranslations = new List<ExtensionTranslation>()
                {
                    new ExtensionTranslation { Name = request.NameVI, Language_Id = "vi-VN"},
                    new ExtensionTranslation { Name = request.NameEN, Language_Id = "en-US"}
                }
            };
            _context.Extensions.Add(extensionRoom);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteExtensionRoom(int Id)
        {
            var extensionRoom = await _context.Extensions.FindAsync(Id);
            if (extensionRoom == null) throw new BookingException("Extension không tồn tại");
            _context.Extensions.Remove(extensionRoom); 
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<PageResult<ExtensionRoomViewModel>> GetExtensionRoom(GetExtensionRoomRequest request)
        {
            var query = from ex in _context.Extensions
                        join ext in _context.ExtensionTranslations on ex.Id equals ext.Extension_Id
                        join exty in _context.ExtensionTypes on ex.ExtensionType_Id equals exty.Id
                        join extyt in _context.ExtensionTypeTranslations on exty.Id equals extyt.ExtensionType_Id
                        where ex.ExtensionType_Id == request.ExtensionTypeId && ext.Language_Id == request.LanguageId && extyt.Language_Id == request.LanguageId
                        select new { ex, ext, extyt };
                        

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.ext.Name.Contains(request.Keyword));
            }
            
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new ExtensionRoomViewModel()
            {
                Id = x.ex.Id,
                Name = x.ext.Name,
                LanguageId = x.ext.Language_Id,
                ExtensionTypeName = x.extyt.Name
            }).ToListAsync();

            var PagedResult = new PageResult<ExtensionRoomViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return PagedResult;
        }

        public async Task<bool> UpdateExtensionRoom(int Id, UpdateExtensionRoomRequest request)
        {
            var extensionRoom = await _context.Extensions.FindAsync(Id);
            if (extensionRoom == null) throw new BookingException("Không thể tìm thể thấy Extension");

            var extensionTranslation = await _context.ExtensionTranslations.FirstOrDefaultAsync(x=>x.Extension_Id == extensionRoom.Id && x.Language_Id == request.Language);

            extensionTranslation.Name = request.Name;

            _context.ExtensionTranslations.Update(extensionTranslation);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
