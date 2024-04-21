using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.BillService
{
    public interface IBillAPIService
    {
        Task<bool> CreateBill(int bookingId);

    }
}
