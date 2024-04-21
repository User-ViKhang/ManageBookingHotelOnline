using Booking_Backend.Repository.BookingRepo.Request;
using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.SendMail.Request;
using Booking_Frontend.APIIntegration.BookingService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.EmailService
{
    public class EmailServiceClient : BaseClientService, IEmailServiceClient
    {
        public EmailServiceClient(
            IHttpClientFactory httpClientfactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration config)
            : base(httpClientfactory, httpContextAccessor, config) { }

        public async Task<bool> SendEmail(MailData mailData)
        {
            return await PostAsyncNotFile<MailData>("/api/email/SendMail", mailData);
        }
    }
}
