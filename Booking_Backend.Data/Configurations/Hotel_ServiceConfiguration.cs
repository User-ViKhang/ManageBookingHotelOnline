using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class Hotel_ServiceConfiguration : IEntityTypeConfiguration<Hotel_Service>
    {
        public void Configure(EntityTypeBuilder<Hotel_Service> builder)
        {
            builder.ToTable("Hotel_Services");

            builder.HasKey(x => new { x.Hotel_Id, x.Service_Id });
            builder.Property(x => x.Surcharge);

            builder.HasOne(x => x.Hotel).WithMany(x => x.Hotel_Services).HasForeignKey(x => x.Hotel_Id);
            builder.HasOne(x => x.Service).WithMany(x => x.Hotel_Services).HasForeignKey(x => x.Service_Id);
        }
    }
}
