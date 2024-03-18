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
            var isResult = await _context.Services.FirstOrDefaultAsync(x=>x.Name == request.Name);
            if (isResult != null) return false;
            var service = new ServiceHotel()
            {
                Name = request.Name,
                Description = request.Description,
                Language = request.Language
            };
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteServiceHotel(int Id)
        {
            var serviceHotel = await _context.Services.FindAsync(Id);
            if(serviceHotel == null) return false;
            _context.Services.Remove(serviceHotel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<PageResult<ServiceHotelViewModel>> GetServiceHotel(GetServiceHotelRequest request)
        {
            var query = from service in _context.Services
                        where service.Language == request.LanguageId
                        select service;

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.Name == request.Keyword);
            }
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
            .Select(x => new ServiceHotelViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Language = x.Language,
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

        public async Task<ServiceHotelViewModel> GetServiceHotelById(int Id)
        {
            var service = await _context.Services.FindAsync(Id);
            if (service == null) return null;
            var serviceHotelViewModel = new ServiceHotelViewModel()
            {
                Id = service.Id,
                Name = service.Name,
                Description = service.Description,
                Language = service.Language
            };
            return serviceHotelViewModel;
        }

        public async Task<bool> UpdateServiceHotel(int Id, UpdateServiceHotelRequest request)
        {
            var serviceHotel = await _context.Services.FindAsync(Id);
            if (serviceHotel == null) return false;
            serviceHotel.Name = request.Name;
            serviceHotel.Description = request.Description;
            serviceHotel.Language = request.Language;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
