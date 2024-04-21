using Booking_Backend.Repository.LocationRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.LocationService
{
    public interface ILocationClientService
    {
        Task<List<LocationViewModel>> GetLocations(string Language_Id);
    }
}
