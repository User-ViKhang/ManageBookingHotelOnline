using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Repository.BedRepo.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.BedService
{
    public interface IBedAPIService
    {
        Task<PageResult<BedViewModel>> Get(GetBedRequest request);
        Task<BedViewModel> GetById(int Id, string languageId);
        Task<bool> Create(CreateBedRequest request);
        Task<bool> Update(int Id, UpdateBedRequest request);
        Task<bool> Delete(int Id);
    }
}
