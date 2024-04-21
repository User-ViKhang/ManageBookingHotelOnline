using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Hotels.ViewModels;
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
            if (serviceVI != null || serviceEN != null) return false;

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
            if (serviceHotel == null) return false;
            _context.ServiceHotels.Remove(serviceHotel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<int>> GetAllServiceHotelByIdHotel(int idHotel)
        {
            var hotel = await _context.Hotels.FindAsync(idHotel);
            if (hotel == null) return null;
            var hotelServiceIds = await _context.Hotel_Services.Where(x => x.Hotel_Id == idHotel).Select(x => x.Service_Id).ToListAsync();
            return hotelServiceIds;
        }

        public async Task<List<ServiceHotelViewModel>> GetServiceByHotelId(int hotelId, string languageId)
        {
            var hotel = await _context.Hotels.FindAsync(hotelId);
            if (hotel == null) return null;
            return _context.Hotel_Services
                                    .Include(hs => hs.Service).ThenInclude(sv=>sv.ServiceHotelTranslations)
                                    .Include(hs => hs.Hotel)
                                    .Where(hs => hs.Hotel_Id == hotelId && hs.Service.ServiceHotelTranslations.FirstOrDefault().Language_Id == languageId)
                                    .Select(x => new ServiceHotelViewModel
                                    {
                                        Id = x.Service_Id,
                                        Name = x.Service.ServiceHotelTranslations.FirstOrDefault().Name,
                                        Description = x.Service.ServiceHotelTranslations.FirstOrDefault().Description
                                    }).ToList();
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
            var serviceHotelTranslation = await _context.ServiceHotelTranslations.FirstOrDefaultAsync(x => x.Language_Id == languageId && x.ServiceHotel_Id == service.Id);
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

        public async Task<bool> UpdateServiceHotel(HotelInfoViewModel hotelVM, int hotelId)
        {
            // Get the hotel
            var hotel = _context.Hotels.FirstOrDefault(h => h.Id == hotelId);

            if (hotel == null)
            {
                // Handle hotel not found
                return false;
            }


            // Get the existing service ids for the hotel
            var existingServiceIds = _context.Hotel_Services.Where(x=>x.Hotel_Id==hotelId).Select(hs => hs.Service_Id).ToList();

            // Find the service ids to add
            var serviceIdsToAdd = hotelVM.IdsService.Where(id => !existingServiceIds.Contains(id)).ToList();

            // Find the service ids to remove
            var serviceIdsToRemove = existingServiceIds.Where(id => !hotelVM.IdsService.Contains(id)).ToList();

            // Add new services
            foreach (var serviceId in serviceIdsToAdd)
            {
                var hotelService = new Hotel_Service
                {
                    Hotel_Id = hotelId,
                    Service_Id = serviceId
                };

                _context.Hotel_Services.Add(hotelService);
            }

            // Remove old services
            foreach (var serviceId in serviceIdsToRemove)
            {
                var hotelService = _context.Hotel_Services.FirstOrDefault(hs => hs.Service_Id == serviceId);

                if (hotelService != null)
                {
                    _context.Hotel_Services.Remove(hotelService);
                }
            }

            // Save changes
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
