using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Booking_Backend.Repository.Accounts.ViewModels
{
    public class ForgetPasswordViewModel
    {
        [Required(ErrorMessage = "Email không được để trống!")]
        [EmailAddress(ErrorMessage = "Sai định dạng của email!")]
        public string Email { get; set; }
    }
}
