using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class BookingCartConfiguration : IEntityTypeConfiguration<BookingCarts>
    {
        public void Configure(EntityTypeBuilder<BookingCarts> builder)
        {
            builder.ToTable("BookingCarts");

            builder.HasKey(x => new { x.Hotel_Id, x.User_Id });
            builder.Property(x => x.Created).HasDefaultValue(DateTime.Now);

            builder.HasOne(x => x.Hotel).WithMany(x => x.BookingCarts).HasForeignKey(x => x.Hotel_Id).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.User).WithMany(x => x.BookingCarts).HasForeignKey(x => x.User_Id).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
