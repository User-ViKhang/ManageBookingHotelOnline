﻿using Booking_Backend.Data.Configurations;
using Booking_Backend.Data.Entities;
using Booking_Backend.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;

namespace Booking_Backend.Data.EF
{
    public class BookingContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public BookingContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new BedConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new ExtensionConfiguration());
            modelBuilder.ApplyConfiguration(new ExtensionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            modelBuilder.ApplyConfiguration(new Hotel_ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new HotelTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new Room_BookingConfiguration());
            modelBuilder.ApplyConfiguration(new Room_ExtensionConfiguration());
            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new ViewHotelConfiguration());
            modelBuilder.ApplyConfiguration(new UserImageConfiguration());
            modelBuilder.ApplyConfiguration(new HotelTypeImageConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            modelBuilder.Seed();

            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Bed> Beds { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Extension> Extensions { get; set; }
        public DbSet<ExtensionType> ExtensionTypes { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Hotel_Service> Hotel_Services { get; set; }
        public DbSet<HotelType> HotelTypes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Room_Booking> Room_Bookings { get; set; }
        public DbSet<Room_Extension> Room_Extensions { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ViewHotel> ViewHotels { get; set; }
        public DbSet<UserImage> UserImages { get; set; }
        public DbSet<HotelTypeImage> HotelTypeImages { get; set; }
    }
}