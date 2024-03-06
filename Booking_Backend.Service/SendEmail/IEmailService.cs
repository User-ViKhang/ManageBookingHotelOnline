using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Backend.Service.SendEmail
{
    public interface IEmailService
    {
        Task<bool> SendEmail(string _to, string _subject, string _body);
    }
}
