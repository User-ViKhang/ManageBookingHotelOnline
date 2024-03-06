using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class ExtensionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public List<Extension> Extensions { get; set; }
    }
}
