using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.ViewRepo.Request;
using Booking_Backend.Repository.ViewRepo.ViewModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.ViewHotelService
{
    public interface IViewHotelAPIService
    {
        Task<PageResult<ViewHotelViewModel>> Get(GetViewHotelRequest request);
    }
}
