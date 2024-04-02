using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.SendMail.Request
{
    public class MailData
    {
        public string ReceiverName { get; set; }
        public string ReceiverEmail { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
