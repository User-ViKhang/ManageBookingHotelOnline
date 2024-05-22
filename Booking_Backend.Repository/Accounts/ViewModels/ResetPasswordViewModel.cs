using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Accounts.ViewModels
{
    public class ResetPasswordViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }
    }
}
