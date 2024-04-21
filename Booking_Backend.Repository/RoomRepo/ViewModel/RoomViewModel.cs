using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Booking_Backend.Repository.ExtensionRoom.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Repository.RoomRepo.ViewModel
{
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string RoomCode { get; set; }
        public int Maximum { get; set; }
        public StatusRoom Status { get; set; }
        public decimal PriceOverNight { get; set; }
        public Booking_Backend.Data.Entities.RoomType RoomType { get; set; }
        public Bed Bed { get; set; }
        public int BedId { get; set; }
        public int RoomTypeId { get; set; }
        public List<ExtensionRoomViewModel> ExtensionViewModels { get; set; }
    }
}
