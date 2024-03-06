using Booking_Backend.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Accounts.ViewModels
{
    public class AccountViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string AvatarUrl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public StatusUser Status { get; set; }
    }
}
