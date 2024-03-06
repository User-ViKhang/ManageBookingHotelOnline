using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotels");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Area).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Address).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Hotline).HasColumnType("varchar(11)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Establish).HasColumnType("date");
            builder.Property(x => x.Latitude).HasColumnType("decimal");
            builder.Property(x => x.Longitude).HasColumnType("decimal");
            builder.Property(x => x.Thumbnail).HasColumnType("varchar(255)");
            builder.Property(x => x.Language).HasColumnType("varchar(5)");

            builder.HasOne(x => x.HotelType).WithMany(x => x.Hotels).HasForeignKey(x => x.HotelType_Id);
            builder.HasOne(x => x.ViewHotel).WithMany(x => x.Hotels).HasForeignKey(x => x.ViewHotel_Id);
        }
    }
}
