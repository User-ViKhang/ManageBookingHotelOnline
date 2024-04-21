using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.SendMail.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Frontend.APIIntegration.EmailService
{
    public interface IEmailServiceClient
    {
        Task<bool> SendEmail(MailData mailData);

    }
}
