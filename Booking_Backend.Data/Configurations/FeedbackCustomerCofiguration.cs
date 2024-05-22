using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class FeedbackCustomerCofiguration : IEntityTypeConfiguration<FeedbackCustomer>
    {
        public void Configure(EntityTypeBuilder<FeedbackCustomer> builder)
        {
            builder.ToTable("FeedbackCustomers");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.StaffScore).HasDefaultValue(0);
            builder.Property(x => x.FacilitiesScore).HasDefaultValue(0);
            builder.Property(x => x.CleanlinessScore).HasDefaultValue(0);
            builder.Property(x => x.ComfortScore).HasDefaultValue(0);
            builder.Property(x => x.LocationScore).HasDefaultValue(0);
            builder.Property(x => x.ValueScore).HasDefaultValue(0);

            builder.HasOne(x => x.User).WithMany(x => x.FeedbackCustomers).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade).IsRequired(false);
            builder.HasOne(x => x.Hotel).WithMany(x => x.FeedbackCustomers).HasForeignKey(x => x.HotelId).OnDelete(DeleteBehavior.Cascade).IsRequired(false);
        }
    }
}
