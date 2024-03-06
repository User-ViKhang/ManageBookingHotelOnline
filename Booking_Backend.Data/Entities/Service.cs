﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Hotel_Service> Hotel_Services { get; set; }
        public string Language { get; set; }
    }
}
