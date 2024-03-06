using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Paging.ViewModel
{
    public class PageResult<T> : PagedResultBase
    {
        public List<T> Items { get; set; }
    }
}
