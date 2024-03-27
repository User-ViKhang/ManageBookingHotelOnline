using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.HotelType
{
    public interface IHotelTypeClientService
    {
        Task<PageResult<HotelTypeViewModel>> GetHotelType(GetAllHotelTypePagingRequest request);
        Task<bool> UpdateHotelType(int Id, UpdateHotelTypeRequest request);
        Task<bool> CreateHotelType(CreateHotelTypeRequest request);
        Task<bool> DeleteHotelType(int Id);
        Task<List<HotelTypeViewModel>> GetAllHotelType(string languageId);
    }
}