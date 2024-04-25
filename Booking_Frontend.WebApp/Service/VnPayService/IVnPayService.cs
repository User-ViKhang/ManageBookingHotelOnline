using Booking_Backend.Repository;
using Booking_Backend.Repository.BookingRepo.Request;
using Microsoft.AspNetCore.Http;

namespace Booking_Frontend.WebApp.Service.VnPayService
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(HttpContext context, VnPaymentRequestModel model);
        VnPaymentResponeModel PaymentExecute(IQueryCollection collections);
    }
}
