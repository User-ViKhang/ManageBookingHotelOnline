using Booking_Backend.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.Hotels.Request
{
    public class CreateHotelRequest
    {
        public string Name { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Hotline { get; set; }
        public string Description { get; set; }
        public DateTime Establish { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Thumbnail { get; set; }
        public List<Hotel_Service> Hotel_Services { get; set; }
        public List<Image> Images { get; set; }
        public List<Room> Rooms { get; set; }
        public HotelType HotelType { get; set; }
        public int HotelType_Id { get; set; }
        public ViewHotel ViewHotel { get; set; }
        public int ViewHotel_Id { get; set; }
        public string Language { get; set; }
    }
}
