using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class Room_BookingConfiguration : IEntityTypeConfiguration<Room_Booking>
    {
        public void Configure(EntityTypeBuilder<Room_Booking> builder)
        {
            builder.ToTable("Room_Bookings");

            builder.HasKey(x => new { x.Room_Id, x.Booking_Id });

            builder.HasOne(x => x.Room).WithMany(x => x.Room_Bookings).HasForeignKey(x => x.Room_Id);
            builder.HasOne(x => x.Booking).WithMany(x => x.Room_Bookings).HasForeignKey(x => x.Booking_Id);
        }
    }
}
