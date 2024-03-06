using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Paging.ViewModel
{
    public class PagedResultBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRecord { get; set; }
        public int PageCount
        {
            get
            {
                var pageCount = (double)TotalRecord / PageSize;
                return (int)Math.Ceiling(pageCount);
            }
        }
    }
}
