using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BedTypeRepo.Request
{
    public class GetBedTypeRequest : PagedResultBase
    {
        public string Keyword { get; set; }
        public string LanguageId { get; set; }
    }
}
