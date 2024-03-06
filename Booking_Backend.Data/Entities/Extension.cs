using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Entities
{
    public class Extension
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ExtensionType ExtensionType { get; set; }
        public int ExtensionType_Id { get; set; }
        public string Language { get; set; }
        public List<Room_Extension> Room_Extensions { get; set; }
    }
}
