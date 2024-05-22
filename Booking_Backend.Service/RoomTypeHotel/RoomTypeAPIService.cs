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
            var roomTypeVI = await _context.RoomTypeTranslations.FirstOrDefaultAsync(x => x.Name == request.NameVI);
            var roomTypeEN = await _context.RoomTypeTranslations.FirstOrDefaultAsync(x => x.Name == request.NameEN);
            if (roomTypeVI != null || roomTypeEN != null) return false;
            var roomType = new RoomType()
            {
                RoomTypeTranslations = new List<RoomTypeTranslation>()
                {
                    new RoomTypeTranslation() { Name = request.NameVI, Language_Id = "vi-VN"},
                    new RoomTypeTranslation() { Name = request.NameEN, Language_Id = "en-US"}
                }
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
            var query = from r in _context.RoomTypes
                        join rt in _context.RoomTypeTranslations on r.Id equals rt.RoomType_Id
                        where rt.Language_Id == request.LanguageId
                        select new { r, rt };  

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.rt.Name.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new RoomTypeViewModel()
            {
                Id = x.r.Id,
                Name = x.rt.Name,
                Language = x.rt.Language_Id
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
            var roomTypeTranslation = await _context.RoomTypeTranslations.FirstOrDefaultAsync(x => x.RoomType_Id == roomType.Id);

            roomTypeTranslation.Name = request.Name;
            roomTypeTranslation.Language_Id = request.LanguageId;
            _context.RoomTypeTranslations.Update(roomTypeTranslation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
