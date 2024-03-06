using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public decimal ImageSize { get; set; }
        public decimal ImageUrl { get; set; }
        public DateTime Created { get; set; }
        public Hotel Hotel { get; set; }
        public int Hotel_Id { get; set; }
    }
}
