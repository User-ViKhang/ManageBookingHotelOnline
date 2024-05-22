using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class ServiceHotelConfiguration : IEntityTypeConfiguration<ServiceHotel>
    {
        public void Configure(EntityTypeBuilder<ServiceHotel> builder)
        {
            builder.ToTable("ServiceHotels");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

        }
    }
}
