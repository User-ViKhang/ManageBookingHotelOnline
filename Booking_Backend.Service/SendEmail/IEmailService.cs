using Booking_Backend.Repository.Common;
using Booking_Backend.Repository.SendMail.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.SendEmail
{
    public interface IEmailService
    {
        Task<APIResult<string>> SendEmailAsync(MailData mailData);
        Task<bool> SendEmail(MailData mailData);

    }
}
