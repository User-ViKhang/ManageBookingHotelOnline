using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class Room_ExtensionConfiguration : IEntityTypeConfiguration<Room_Extension>
    {
        public void Configure(EntityTypeBuilder<Room_Extension> builder)
        {
            builder.ToTable("Room_Extensions");

            builder.HasKey(x => new { x.Room_Id, x.Extension_Id });

            builder.Property(x=>x.Quantity).HasDefaultValue(0);

            builder.HasOne(x => x.Room).WithMany(x => x.Room_Extensions).HasForeignKey(x => x.Room_Id);
            builder.HasOne(x => x.Extension).WithMany(x => x.Room_Extensions).HasForeignKey(x => x.Extension_Id);

        }
    }
}
