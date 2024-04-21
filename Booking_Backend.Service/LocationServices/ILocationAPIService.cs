using Booking_Backend.Repository.LocationRepo;
using Booking_Backend.Repository.LocationRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.LocationServices
{
    public interface ILocationAPIService
    {
        Task<List<LocationViewModel>> GetLocations(string Language_Id);
    }
}
