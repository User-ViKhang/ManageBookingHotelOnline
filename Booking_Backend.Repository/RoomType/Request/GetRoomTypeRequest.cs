using Booking_Backend.Repository.Paging.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.RoomType.Request
{
    public class GetRoomTypeRequest : PagedResultBase
    {
        public string Keyword { get; set; }
        public string LanguageId { get; set; }
    }
}
