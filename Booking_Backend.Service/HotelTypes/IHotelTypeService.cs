using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.HotelTypes.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.HotelTypes
{
    public interface IHotelTypeService
    {
        Task<APIResult<int>> CreateHotelType(CreateHotelTypeRequest request);
        Task<List<GetHotelTypeViewModel>> GetAllHotelType();
    }
}
