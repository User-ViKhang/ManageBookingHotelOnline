using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.HotelTypes
{
    public class HotelTypeService : IHotelTypeService
    {
        private readonly BookingContext _context;

        public HotelTypeService(BookingContext context)
        {
            _context = context;
        }

        public async Task<APIResult<int>> CreateHotelType(CreateHotelTypeRequest request)
        {
            var hotelType = new HotelType
            {
                Name = request.Name,
                ImageUrl = request.ImageUrl
            };
            _context.HotelTypes.Add(hotelType);
            await _context.SaveChangesAsync();
            return new APIResult_Success<int>(hotelType.Id);
        }

        public async Task<List<GetHotelTypeViewModel>> GetAllHotelType(string languageId)
        {
            return await _context.HotelTypes.Where(x => x.Language == languageId)
                .Select(x => new GetHotelTypeViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageUrl = x.ImageUrl,
                    Language = x.Language
                }).ToListAsync();
        }
    }
}