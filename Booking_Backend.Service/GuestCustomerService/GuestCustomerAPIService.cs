using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.GuestCustomerRepo.Request;
using Booking_Backend.Repository.GuestCustomerRepo.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.GuestCustomerService
{
    public class GuestCustomerAPIService : IGuestCustomerAPIService
    {
        private readonly BookingContext _context;

        public GuestCustomerAPIService(BookingContext context)
        {
            _context = context;
        }

        public async Task<APIResult<GuestCustomer>> CreateGuestCustomer(CreateGuestCustomerRequest request)
        {
            var guestCus = await _context.GuestCustomers.FirstOrDefaultAsync(x=>x.Email ==  request.Email);
            if (guestCus != null) return new APIResult_Error<GuestCustomer>("Email người dùng đã tồn tại");
            var guestCusNew = new GuestCustomer()
            {
                Email = request.Email,
                FullName = request.FullName,
                Nation = request.Nation,
                PhoneNumber = request.PhoneNumber
            };
            await _context.GuestCustomers.AddAsync(guestCusNew);
            await _context.SaveChangesAsync();
            var guestCusVM = await _context.GuestCustomers.FirstOrDefaultAsync(x=>x.Email == request.Email);
            return new APIResult_Success<GuestCustomer>(new GuestCustomer()
            {
                Id = guestCusVM.Id,
                Email = guestCusVM.Email,
                FullName = guestCusVM.FullName,
                Nation = guestCusVM.Nation,
                PhoneNumber = guestCusVM.PhoneNumber
            });
        }
    }
}
