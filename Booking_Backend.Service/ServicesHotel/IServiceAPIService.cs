using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.Service.Request;
using Booking_Backend.Repository.Service.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.ServicesHotel
{
    public interface IServiceAPIService
    {
        Task<bool> CreateServiceHotel(CreateServiceHotelRequest request);
        Task<bool> UpdateServiceHotel(int Id, UpdateServiceHotelRequest request);
        Task<bool> DeleteServiceHotel(int Id);


        Task<PageResult<ServiceHotelViewModel>> GetServiceHotel(GetServiceHotelRequest request);
        Task<ServiceHotelViewModel> GetServiceHotelById(int Id);
    }
}
