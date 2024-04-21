using Booking_Backend.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Booking_Backend.Utilities.Exceptions;
using Booking_Backend.Repository.LocationRepo;
using Booking_Backend.Repository.LocationRepo.ViewModel;

namespace Booking_Backend.Service.LocationServices
{
    public class LocationAPIService : ILocationAPIService
    {
        private readonly BookingContext _context;

        public LocationAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<int> GetTotalPropertyByLocation(string nameLocation)
        {
            var locationId = await _context.LocationTranslations.Where(x=>x.Name == nameLocation).Select(x=>x.Location_Id).FirstOrDefaultAsync();
            var totalProperties = await _context.Locations.Where(x=>x.Id==locationId).Select(x=>x.Properties).FirstOrDefaultAsync();
            return totalProperties;
        }

        public async Task<List<LocationViewModel>> GetLocations(string Language_Id)
        {
            var locations = await _context.Locations.Include(l => l.LocationTranslations)
                .Select(x => new LocationViewModel
                {
                    Id = x.Id,
                    Name = x.LocationTranslations.FirstOrDefault(x =>x.Language_Id == Language_Id).Name,
                    Language_Id = Language_Id
                }).ToListAsync();
            return locations;
        }
    }
}
