using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomType.Request;
using Booking_Backend.Repository.RoomType.ViewModel;
using Booking_Backend.Repository.Service.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.RoomTypeHotel
{
    public class RoomTypeAPIService : IRoomTypeAPIService
    {
        private readonly BookingContext _context;

        public RoomTypeAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateRoomType(CreateRoomTypeRequest request)
        {
            var isResult = await _context.RoomTypes.FirstOrDefaultAsync(x => x.Name == request.Name);
            if (isResult != null) return false;
            var roomType = new RoomType()
            {
                Name = request.Name,
                Language = request.LanguageId
            };
            await _context.RoomTypes.AddAsync(roomType);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteRoomType(int Id)
        {
            var roomType = await _context.RoomTypes.FindAsync(Id);
            if(roomType == null) return false;
            _context.RoomTypes.Remove(roomType);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<PageResult<RoomTypeViewModel>> GetRoomTypes(GetRoomTypeRequest request)
        {
            var romtype = _context.RoomTypes.Select(x => x.Language == request.LanguageId);

            var query = from rt in _context.RoomTypes
                        where rt.Language == request.LanguageId
                        select rt;

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.Name.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new RoomTypeViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Language = x.Language
            }).ToListAsync();
            var PagedResult = new PageResult<RoomTypeViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return PagedResult;
        }

        public async Task<bool> UpdateRoomTypes(int Id, UpdateRoomTypeRrequest request)
        {
            var roomType = await _context.RoomTypes.FindAsync(Id);
            if (roomType == null) return false;
            roomType.Name = request.Name;
            roomType.Language = request.LanguageId;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
