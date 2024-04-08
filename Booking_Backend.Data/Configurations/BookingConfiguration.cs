using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Enums;

namespace Booking_Backend.Data.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Bookings");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Created).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.CheckIn).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.CheckOut).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.TotalAmount).HasDefaultValue(0);
            builder.Property(x => x.Status).HasDefaultValue(StatusBooking.Pedding);
            builder.Property(x => x.TotalPeople).IsRequired(false).HasDefaultValue(1);

            builder.HasOne(x => x.User).WithMany(x => x.Bookings).HasForeignKey(x => x.User_Id).IsRequired(false);
            builder.HasOne(x => x.GuestCustomer).WithMany(x => x.Bookings).HasForeignKey(x => x.GuestCustomer_Id).IsRequired(false);
        }
    }
}
