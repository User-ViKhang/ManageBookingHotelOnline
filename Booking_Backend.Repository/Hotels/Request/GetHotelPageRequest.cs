using Booking_Backend.Repository.Paging.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.Request
{
    public class GetHotelByLocationRequest : PagingRequestBase
    {
        public string LanguageId { get; set; }
        public string LocationName { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }
        public int TotalPeople { get; set; }
        public bool IsHightFeedBack { get; set; }
        public bool isLowPrice { get; set; }
    }
}
