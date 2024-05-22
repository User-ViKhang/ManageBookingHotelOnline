using Booking_Backend.Repository.Hotels.ViewModels;
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
        Task<bool> UpdateServiceHotel(HotelInfoViewModel hotelVM, int hotelId);


        Task<PageResult<ServiceHotelViewModel>> GetServiceHotel(GetServiceHotelRequest request);
        Task<ServiceHotelViewModel> GetServiceHotelById(int Id, string languageId);
        Task<List<int>> GetAllServiceHotelByIdHotel(int idHotel);
        Task<List<ServiceHotelViewModel>> GetServiceByHotelId(int idHotelId, string languageId);
    }
}
