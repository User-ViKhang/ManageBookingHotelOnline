using Booking_Backend.Data.EF;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.RoomType.ViewModel;
using Booking_Backend.Repository.ViewRepo.Request;
using Booking_Backend.Repository.ViewRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Booking_Backend.Service.ViewHotelService
{
    public class ViewHotelAPIService : IViewHotelAPIService
    {
        private readonly BookingContext _context;

        public ViewHotelAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<PageResult<ViewHotelViewModel>> Get(GetViewHotelRequest  request)
        {
            var query = from v in _context.ViewHotels
                        join vt in _context.ViewHotelTranslations on v.Id equals vt.ViewHotel_Id
                        where vt.Language_Id == request.LanguageId
                        select new { v, vt };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.vt.Name.Contains(request.Keyword));
            }

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new ViewHotelViewModel()
            {
                Id = x.v.Id,
                Name = x.vt.Name,
                Description = x.vt.Description,
                LanguageId = x.vt.Language_Id
            }).ToListAsync();
            var PagedResult = new PageResult<ViewHotelViewModel>()
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
