﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.BedTypeRepo.Request
{
    public class CreateBedTypeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
    }
}