using Booking_Backend.Data.EF;
using Booking_Backend.Repository.BedTypeRepo.Request;
using Booking_Backend.Repository.BedTypeRepo.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Booking_Backend.Service.BedTypeService
{
    public class BedTypeAPIService : IBedTypeAPIService
    {
        private readonly BookingContext _context;

        public BedTypeAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateBedType(CreateBedTypeRequest request)
        {
            var bed = await _context.Beds.FirstOrDefaultAsync(x=>x.Name == request.Name);
            if (bed != null) return false;
            var bedVM = new Bed()
            {
                Name = request.Name,
                Description = request.Description,
                Language = request.Language,
            };
            await _context.Beds.AddAsync(bedVM);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteBedType(int Id)
        {
            var bedVM = await _context.Beds.FindAsync(Id);
            if (bedVM == null) return false;
             _context.Beds.Remove(bedVM);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<PageResult<BedTypeViewModel>> GetBedType(GetBedTypeRequest request)
        {
            //var query = _context.Beds.Where(x=>x.Language==request.LanguageId).ToList();
            var query = from bed in _context.Beds
                        where bed.Language == request.LanguageId
                        select bed;

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.Name == request.Keyword);
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new BedTypeViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Language = x.Language,
            }).ToListAsync();
            var PagedResult = new PageResult<BedTypeViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return PagedResult;
        }

        public async Task<BedTypeViewModel> GetBedTypeById(int Id)
        {
            var bed = await _context.Beds.FindAsync(Id);
            if (bed == null) return null;
            var bedModel = new BedTypeViewModel()
            {
                Id = bed.Id,
                Name = bed.Name,
                Description = bed.Description,
                Language = bed.Language
            };
            return bedModel;
        }

        public async Task<bool> UpdateBedType(int Id, UpdateBedTypeRequest request)
        {
            var bedType = await _context.Beds.FindAsync(Id);
            if (bedType == null) return false;
            bedType.Name = request.Name;
            bedType.Description = request.Description;
            bedType.Language = request.Language;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
