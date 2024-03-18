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
            var isResult = await _context.ExtensionTypes.FirstOrDefaultAsync(x => x.Name == request.Name);
            if (isResult != null) return false;
            var extensionType = new ExtensionType()
            {
                Name = request.Name,
                Language = request.LanguageId
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

        public async Task<List<ExtensionTypeRoomViewModel>> GetAll(string languageId)
        {
            var query = from ex in _context.ExtensionTypes
                        where ex.Language == languageId
                        select ex;
            var data = await query.Select(x => new ExtensionTypeRoomViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                LanguageId = x.Language,
            }).ToListAsync();
            return data;
        }

        public async Task<PageResult<ExtensionTypeRoomViewModel>> GetExtensionTypeRoom(GetExtensionTypeRoomRequest request)
        {
            var query = from ext in _context.ExtensionTypes
                        where ext.Language == request.LanguageId
                        select ext;

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.Name == request.Keyword);
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new ExtensionTypeRoomViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                LanguageId = x.Language,
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
            extensionType.Name = request.Name;
            extensionType.Language = request.LanguageId;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
