using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Repository.Service.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.ServicesHotel
{
    public class ServiceAPIService : IServiceAPIService
    {
        private readonly BookingContext _context;

        public ServiceAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateServiceHotel(CreateServiceHotelRequest request)
        {
            var serviceVI = await _context.ServiceHotelTranslations.FirstOrDefaultAsync(x => x.Name == request.NameVI);
            var serviceEN = await _context.ServiceHotelTranslations.FirstOrDefaultAsync(x => x.Name == request.NameEN);
            if(serviceVI != null || serviceEN != null) return false;

            var service = new ServiceHotel()
            {
                ServiceHotelTranslations = new List<ServiceHotelTranslation>()
                {
                    new ServiceHotelTranslation() { Name = request.NameVI, Description = request.DescriptionVI, Language_Id = "vi-VN" },
                    new ServiceHotelTranslation() { Name = request.NameEN, Description = request.DescriptionEN, Language_Id = "en-US" }
                }
            };
            await _context.ServiceHotels.AddAsync(service);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteServiceHotel(int Id)
        {
            var serviceHotel = await _context.ServiceHotels.FindAsync(Id);
            if(serviceHotel == null) return false;
            _context.ServiceHotels.Remove(serviceHotel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<PageResult<ServiceHotelViewModel>> GetServiceHotel(GetServiceHotelRequest request)
        {
            var query = from sv in _context.ServiceHotels
                        join svt in _context.ServiceHotelTranslations on sv.Id equals svt.ServiceHotel_Id
                        where svt.Language_Id == request.LanguageId
                        select new { sv, svt };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.svt.Name == request.Keyword);
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new ServiceHotelViewModel()
            {
                Id = x.sv.Id,
                Name = x.svt.Name,
                Description = x.svt.Description,
                Language = x.svt.Language_Id,
            }).ToListAsync();
            var PagedResult = new PageResult<ServiceHotelViewModel>()
            {
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                TotalRecord = totalRow
            };
            return PagedResult;
        }

        public async Task<ServiceHotelViewModel> GetServiceHotelById(int Id, string languageId)
        {
            var service = await _context.ServiceHotels.FindAsync(Id);
            if (service == null) return null;
            var serviceHotelTranslation = await _context.ServiceHotelTranslations.FirstOrDefaultAsync(x=>x.Language_Id == languageId && x.ServiceHotel_Id == service.Id);
            var serviceHotelViewModel = new ServiceHotelViewModel()
            {
                Id = service.Id,
                Name = serviceHotelTranslation.Name,
                Description = serviceHotelTranslation.Description,
                Language = serviceHotelTranslation.Language_Id
            };
            return serviceHotelViewModel;
        }

        public async Task<bool> UpdateServiceHotel(int Id, UpdateServiceHotelRequest request)
        {
            var serviceHotel = await _context.ServiceHotels.FindAsync(Id);
            if (serviceHotel == null) return false;
            var serviceHotelTranslation = await _context.ServiceHotelTranslations.FirstOrDefaultAsync(x => x.ServiceHotel_Id == serviceHotel.Id && x.Language_Id == request.Language);

            serviceHotelTranslation.Name = request.Name;
            serviceHotelTranslation.Description = request.Description;
            _context.ServiceHotelTranslations.Update(serviceHotelTranslation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
