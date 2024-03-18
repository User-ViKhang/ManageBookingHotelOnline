using Booking_Backend.Repository.BedTypeRepo.Request;
using Booking_Backend.Repository.BedTypeRepo.ViewModel;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.Request;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.BedType
{
    public interface IBedTypeClientService
    {
        Task<PageResult<BedTypeViewModel>> GetBedType(GetBedTypeRequest request);
        Task<BedTypeViewModel> GetBedTypeById(int Id);
        Task<bool> UpdateBedType(int Id, UpdateBedTypeRequest request);
        Task<bool> DeleteBedType(int Id);
        Task<bool> CreateBedType(CreateBedTypeRequest request);


    }
}
