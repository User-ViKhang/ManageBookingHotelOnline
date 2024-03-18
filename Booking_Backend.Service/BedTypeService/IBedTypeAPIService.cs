using Booking_Backend.Repository.BedTypeRepo.Request;
using Booking_Backend.Repository.BedTypeRepo.ViewModel;
using Booking_Backend.Repository.HotelTypes.Requests;
using Booking_Backend.Repository.Paging.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.BedTypeService
{
    public interface IBedTypeAPIService
    {
        Task<PageResult<BedTypeViewModel>> GetBedType(GetBedTypeRequest request);
        Task<BedTypeViewModel> GetBedTypeById(int Id);
        Task<bool> UpdateBedType(int Id, UpdateBedTypeRequest request);
        Task<bool> CreateBedType(CreateBedTypeRequest request);
        Task<bool> DeleteBedType(int Id);

    }
}
