using Booking_Backend.Repository.Common.Languages;
using System.Collections.Generic;

namespace Booking_Frontend.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageViewModel> Languages { get; set; }
        public string CurrentLanguageId { get; set; }
    }
}