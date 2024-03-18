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
            var checkExtension = await _context.Extensions.FirstOrDefaultAsync(x => x.Name == request.Name);
            if (checkExtension != null) throw new BookingException("Tiện ích phòng đã tồn tại");
            var extensionRoom = new Extension()
            {
                Name = request.Name,
                Language = request.Language,
                ExtensionType_Id = request.ExtensionType_Id
            };
            _context.Extensions.Add(extensionRoom);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteExtensionRoom(int Id)
        {
            var extensionRoom = await _context.Extensions.FindAsync(Id);
            if (extensionRoom == null) throw new BookingException("Extension không tồn tại");
            _context.Extensions.Remove(extensionRoom); await _context.SaveChangesAsync();
            return true;
        }

        public async Task<PageResult<ExtensionRoomViewModel>> GetExtensionRoom(GetExtensionRoomRequest request)
        {
            var query = from ex in _context.Extensions
                        join ext in _context.ExtensionTypes on ex.ExtensionType_Id equals ext.Id
                        where ex.Language == request.LanguageId
                        select new { ex, ExtensionTypeName = ext.Name };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.ex.Name.Contains(request.Keyword));
            }
            
            if (request.ExtensionTypeId != null && request.ExtensionTypeId != 0)
            {
                query = query.Where(x => x.ex.ExtensionType_Id == request.ExtensionTypeId);
            }

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new ExtensionRoomViewModel()
            {
                Id = x.ex.Id,
                Name = x.ex.Name,
                LanguageId = x.ex.Language,
                ExtensionTypeName = x.ExtensionTypeName,
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

            extensionRoom.Name = request.Name;

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
