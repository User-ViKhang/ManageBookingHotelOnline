using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotels");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Hotline).HasColumnType("varchar(11)");
            builder.Property(x => x.Establish).HasColumnType("date");
            builder.Property(x => x.Latitude).HasColumnType("decimal");
            builder.Property(x => x.Longitude).HasColumnType("decimal");
            builder.Property(x => x.Thumbnail);

            builder.HasOne(x => x.HotelType).WithMany(x => x.Hotels).HasForeignKey(x => x.HotelType_Id);
            builder.HasOne(x => x.ViewHotel).WithMany(x => x.Hotels).HasForeignKey(x => x.ViewHotel_Id);
            builder.HasOne(x => x.Location).WithMany(x => x.Hotels).HasForeignKey(x => x.Location_Id);
            builder.HasOne(x => x.User).WithMany(x => x.Hotels).HasForeignKey(x => x.User_Id);
        }
    }
}
