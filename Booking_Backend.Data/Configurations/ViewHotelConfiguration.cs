using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class ViewHotelConfiguration : IEntityTypeConfiguration<ViewHotel>
    {
        public void Configure(EntityTypeBuilder<ViewHotel> builder)
        {
            builder.ToTable("ViewHotels");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
