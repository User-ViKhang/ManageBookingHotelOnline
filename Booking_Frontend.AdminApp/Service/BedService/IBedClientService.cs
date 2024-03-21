using Booking_Backend.Repository.BedRepo.Request;
using Booking_Backend.Repository.BedRepo.ViewModel;
using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Users.Request;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp.Service.BedService
{
    public interface IBedClientService
    {
        Task<PageResult<BedViewModel>> Get(GetBedRequest request);
        Task<BedViewModel> GetById(int Id, string languageId);
        Task<bool> Update(int Id, UpdateBedRequest request);
    }
}
