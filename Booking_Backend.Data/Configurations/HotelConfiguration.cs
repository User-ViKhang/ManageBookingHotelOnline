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
            builder.Property(x => x.Latitude).HasColumnType("decimal(9,6)");
            builder.Property(x => x.Longitude).HasColumnType("decimal(9,6)");
            builder.Property(x => x.Thumbnail);
            builder.Property(x => x.Preview).HasDefaultValue(0).IsRequired(false);
            builder.Property(x => x.PriceDefault).HasDefaultValue(0m).IsRequired(false);
            builder.Property(x => x.Score).HasDefaultValue(0m).HasColumnType("decimal(3,1)");
            builder.Property(x => x.CountFeedBack).HasDefaultValue(0).HasColumnType("int");

            builder.Property(x => x.StaffScore).HasDefaultValue(0m).HasColumnType("decimal(3,1)");
            builder.Property(x => x.CleanlinessScores).HasDefaultValue(0m).HasColumnType("decimal(3,1)");
            builder.Property(x => x.ComfortScore).HasDefaultValue(0m).HasColumnType("decimal(3,1)");
            builder.Property(x => x.FacilitiesScore).HasDefaultValue(0m).HasColumnType("decimal(3,1)");
            builder.Property(x => x.LocationScore).HasDefaultValue(0m).HasColumnType("decimal(3,1)");
            builder.Property(x => x.ValueScore).HasDefaultValue(0m).HasColumnType("decimal(3,1)");


            builder.HasOne(x => x.HotelType).WithMany(x => x.Hotels).HasForeignKey(x => x.HotelType_Id);
            builder.HasOne(x => x.ViewHotel).WithMany(x => x.Hotels).HasForeignKey(x => x.ViewHotel_Id);
            builder.HasOne(x => x.Location).WithMany(x => x.Hotels).HasForeignKey(x => x.Location_Id);
            builder.HasOne(x => x.User).WithMany(x => x.Hotels).HasForeignKey(x => x.User_Id);
        }
    }
}
