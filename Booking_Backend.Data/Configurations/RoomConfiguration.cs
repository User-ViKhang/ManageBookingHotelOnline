using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Enums;

namespace Booking_Backend.Data.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.RoomCode).HasColumnType("nvarchar(255)");
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Maximum).HasDefaultValue(1);
            builder.Property(x => x.PriceByHour).HasDefaultValue(0);
            builder.Property(x => x.PriceOverNight).HasDefaultValue(0);
            builder.Property(x => x.Status).HasDefaultValue(StatusRoom.Empty);
            builder.Property(x => x.Language).HasColumnType("varchar(5)");

            builder.HasOne(x => x.Hotel).WithMany(x => x.Rooms).HasForeignKey(x => x.Hotel_Id);
            builder.HasOne(x => x.RoomType).WithMany(x => x.Rooms).HasForeignKey(x => x.RoomType_Id);
            builder.HasOne(x => x.Bed).WithMany(x => x.Rooms).HasForeignKey(x => x.Bed_Id);
        }
    }
}
