using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Booking_Backend.Data.Entities;

namespace Booking_Backend.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Content).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Created).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.CountComment).HasDefaultValue(0);

            builder.HasOne(x => x.Hotel).WithMany(x => x.Comments).HasForeignKey(x => x.Hotel_Id);
            builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.User_Id);
        }
    }
}
