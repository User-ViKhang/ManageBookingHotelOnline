using Booking_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Configurations
{
    public class Comment_AppUserConfiguration : IEntityTypeConfiguration<Comment_User>
    {
        public void Configure(EntityTypeBuilder<Comment_User> builder)
        {
            builder.ToTable("Comment_Users");

            builder.HasKey(x => new { x.Comment_Id, x.User_Id });

            builder.HasOne(x => x.Comment).WithMany(x => x.Comment_Users).HasForeignKey(x => x.Comment_Id).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.User).WithMany(x => x.Comment_Users).HasForeignKey(x => x.User_Id).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
