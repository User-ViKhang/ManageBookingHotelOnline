using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.GuestCustomerRepo.Request;
using Booking_Backend.Repository.GuestCustomerRepo.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.GuestCustomerService
{
    public interface IGuestCustomerAPIService
    {
        Task<APIResult<GuestCustomer>> CreateGuestCustomer(CreateGuestCustomerRequest request);
    }
}
