using Booking_Backend.Data.EF;
using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Repository.BedRepo.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Booking_Backend.Repository.ExtensionRoom.ViewModel;
using Booking_Backend.Utilities.Exceptions;

namespace Booking_Backend.Service.BedService
{
    public class BedAPIService : IBedAPIService
    {
        private readonly BookingContext _context;

        public BedAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(CreateBedRequest request)
        {
            var bedVI = await _context.BedTranslations.FirstOrDefaultAsync(x => x.Name == request.NameVI && x.Language_Id == "vi-VN");
            var bedEN = await _context.BedTranslations.FirstOrDefaultAsync(x => x.Name == request.NameEN && x.Language_Id == "en-US");
            if( bedVI != null || bedEN != null) return false;
            var bed = new Bed
            {
                BedTranslations = new List<BedTranslation>()
                {
                    new BedTranslation { Name = request.NameVI, Description = request.DescriptionVI, Language_Id = "vi-VN" },
                    new BedTranslation { Name = request.NameEN, Description = request.DescriptionEN, Language_Id = "en-US" }
                }
            };
            await _context.Beds.AddAsync(bed);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int Id)
        {
            var bed = await _context.Beds.FindAsync(Id);
            if(bed == null) return false;
            _context.Beds.Remove(bed);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<PageResult<BedViewModel>> Get(GetBedRequest request)
        {
            var query = from b in _context.Beds
                        join bt in _context.BedTranslations on b.Id equals bt.Bed_Id
                        where bt.Language_Id == request.Language_Id
                        select new { b, bt };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.bt.Name.Contains(request.Keyword));
            }

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new BedViewModel()
            {
                Id = x.b.Id,
                Name = x.bt.Name,
                Language_Id = x.bt.Language_Id,
            }).ToListAsync();

            var PagedResult = new PageResult<BedViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return PagedResult;
        }

        public async Task<BedViewModel> GetById(int Id, string languageId)
        {
            var bed = await _context.Beds.FindAsync(Id);
            if (bed == null) return null;
            var bedTranslation = await _context.BedTranslations.FirstOrDefaultAsync(x=>x.Bed_Id == bed.Id && x.Language_Id == languageId);
            var data = new BedViewModel()
            {
                Id = bed.Id,
                Name = bedTranslation.Name,
                Description = bedTranslation.Description,
                Language_Id = bedTranslation.Language_Id
            };
            return data;
        }

        public async Task<bool> Update(int Id, UpdateBedRequest request)
        {
            var bed = await _context.Beds.FindAsync(Id);
            if (bed == null) return false;
            var bedTranslation = await _context.BedTranslations.FirstOrDefaultAsync(x => x.Bed_Id == bed.Id && x.Language_Id == request.Language_Id);
            bedTranslation.Name = request.Name;
            bedTranslation.Description = request.Description;
            _context.BedTranslations.Update(bedTranslation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
