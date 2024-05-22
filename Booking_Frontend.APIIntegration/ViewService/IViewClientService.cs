using Booking_Backend.Repository.Paging.ViewModel;
using Booking_Backend.Repository.ViewRepo.Request;
using Booking_Backend.Repository.ViewRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.ViewService
{
    public interface IViewClientService
    {
        Task<PageResult<ViewHotelViewModel>> Get(GetViewHotelRequest request);
    }
}
