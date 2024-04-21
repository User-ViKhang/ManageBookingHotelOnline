using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Bills");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x=>x.Created_at).HasDefaultValue(DateTime.UtcNow);

            builder.HasOne(x => x.User).WithMany(x => x.Bills).HasForeignKey(x => x.User_Id).OnDelete(DeleteBehavior.Cascade).IsRequired(false);
            builder.HasOne(x => x.GuestCustomer).WithMany(x => x.Bills).HasForeignKey(x => x.GuestCustomer_Id).OnDelete(DeleteBehavior.Cascade).IsRequired(false);

        }
    }
}
