using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Hotels.ViewModels;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Repository.Service.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.ServiceHotel
{
    public interface IServiceHotelClientService
    {
        Task<PageResult<ServiceHotelViewModel>> GetServiceHotel(GetServiceHotelRequest request);
        Task<ServiceHotelViewModel> GetServiceHotelById(string languageId, int Id);
        Task<bool> UpdateServiceHotel(int Id, UpdateServiceHotelRequest request);
        Task<bool> CreateServiceHotel(CreateServiceHotelRequest request);
        Task<bool> DeleteServiceHotel(int Id);

        Task<bool> UpdateService_Hotel(HotelInfoViewModel hotelVM);
        Task<List<int>> GetAllServiceHotelByIdHotel(int idHotel);
        Task<List<ServiceHotelViewModel>> GetServiceByHotelId(int idHotelId, string languageId);




    }
}
