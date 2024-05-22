using Booking_Backend.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_Backend.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Languages
            modelBuilder.Entity<Language>().HasData(
                new Language() {Id="vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() {Id="en-US", Name = "English", IsDefault = false }
                );

            // Hotel - Chỉnh sửa hoàn tất
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 1,
                    Hotline = "02963678333",
                    Establish = new DateTime(2002, 11, 11),
                    Latitude = 0,
                    Longitude = 0,
                    HotelType_Id = 1,
                    ViewHotel_Id = 2
                },
                new Hotel()
                {
                    Id = 2,
                    Hotline = "02963678463",
                    Establish = new DateTime(2002, 02, 11),
                    Latitude = 0,
                    Longitude = 0,
                    HotelType_Id = 1,
                    ViewHotel_Id = 1
                }
            );

            // HotelTranslation - Chỉnh sửa hoàn tất
            modelBuilder.Entity<HotelTranslation>().HasData(
                new HotelTranslation()
                {
                    Id = 1,
                    Hotel_Id = 1,
                    Name = "Khách sạn Lê Tuấn Minh",
                    Address = "12 đường Bà Triệu, Đà Lạt",
                    Language_Id = "vi-VN",
                    Area = "Đà Lạt",
                    Description = "Khách sạn Lê Tuấn Minh",
                },
                new HotelTranslation()
                {
                    Id = 2,
                    Hotel_Id = 1,
                    Name = "Le Minh Tuan Hotel",
                    Address = "12 Ba Trieu Street, Da Lat",
                    Language_Id = "en-US",
                    Area = "Da Lat",
                    Description = "Le Minh Tuan Hotel",
                },

                new HotelTranslation()
                {
                    Id = 3,
                    Hotel_Id = 2,
                    Name = "Khách sạn Moon House",
                    Address = "Côn Đảo, Vũng Tàu",
                    Language_Id = "vi-VN",
                    Area = "Vũng Tàu",
                    Description = "Khách sạn Moon House",
                },
                new HotelTranslation()
                {
                    Id = 4,
                    Hotel_Id = 2,
                    Name = "Moon House Hotel",
                    Address = "Con Dao, Vung Tau",
                    Language_Id = "en-US",
                    Area = "Vung Tau",
                    Description = "Moon House Hotel",
                }
            );

            // HotelTypeTranslation - Chỉnh sửa hoàn tất
            modelBuilder.Entity<HotelTypeTranslation>().HasData(
                new HotelTypeTranslation() { Id = 1, HotelType_Id = 1, Name = "Khách sạn", Language_Id = "vi-VN" },
                new HotelTypeTranslation() { Id = 2, HotelType_Id = 1, Name = "Hotel", Language_Id = "en-US" },

                new HotelTypeTranslation() { Id = 3, HotelType_Id = 2, Name = "Nhà nghỉ", Language_Id = "vi-VN" },
                new HotelTypeTranslation() { Id = 4, HotelType_Id = 2, Name = "Lodging", Language_Id = "en-US" }
            );

            // HotelTypes - Chỉnh sửa hoàn tất
            modelBuilder.Entity<HotelType>().HasData(
                new HotelType() { Id = 1, HotelTypeImage_Id = 1 },
                new HotelType() { Id = 2, HotelTypeImage_Id = 2 }
            );

            // HotelTypeImages - Chỉnh sửa hoàn tất
            modelBuilder.Entity<HotelTypeImage>().HasData(
                new HotelTypeImage() { Id = 1, Caption = "caption hoteltype img 1", ImageSize = 111, ImageUrl = "imgrl hoteltype 1" },
                new HotelTypeImage() { Id = 2, Caption = "caption hoteltype img 2", ImageSize = 222, ImageUrl = "imgrl hoteltype 2" }
            );
            
            // ViewHotelTranslations - Chỉnh sửa hoàn tất
            modelBuilder.Entity<ViewHotelTranslation>().HasData(
                new ViewHotelTranslation() { Id = 1, ViewHotel_Id = 1, Name = "Bãi biển", Language_Id = "vi-VN" },
                new ViewHotelTranslation() { Id = 2, ViewHotel_Id = 1, Name = "Beach", Language_Id = "en-US" },

                new ViewHotelTranslation() { Id = 3, ViewHotel_Id = 2, Name = "Trung tâm thành phố", Language_Id = "vi-VN" },
                new ViewHotelTranslation() { Id = 4, ViewHotel_Id = 2, Name = "City center", Language_Id = "en-US" }
            );

            // ViewHotels - Chỉnh sửa hoàn tất
            modelBuilder.Entity<ViewHotel>().HasData(
                new ViewHotel() { Id = 1 },
                new ViewHotel() { Id = 2 }
            );

            // RoomTypeTranslations - Chỉnh sửa hoàn tất
            modelBuilder.Entity<RoomTypeTranslation>().HasData(
                new RoomTypeTranslation() { Id = 1, RoomType_Id = 1, Name = "Phòng Standard", Language_Id = "vi-VN" },
                new RoomTypeTranslation() { Id = 2, RoomType_Id = 1, Name = "Standard Room", Language_Id = "en-US" },

                new RoomTypeTranslation() { Id = 3, RoomType_Id = 2, Name = "Phòng Superior", Language_Id = "vi-VN" },
                new RoomTypeTranslation() { Id = 4, RoomType_Id = 2, Name = "Superior Room", Language_Id = "en-US" }
            );

            // RoomTypes - Chỉnh sửa hoàn tất
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType() { Id = 1 },
                new RoomType() { Id = 2 }
            );

            // ServiceHotelTranslations - Chỉnh sửa hoàn tất
            modelBuilder.Entity<ServiceHotelTranslation>().HasData(
                new ServiceHotelTranslation() { Id = 1, ServiceHotel_Id = 1, Name = "Giặt và ủi quần áo", Description = "Có phụ thu lấy quần áo sau 24h", Language_Id = "vi-VN" },
                new ServiceHotelTranslation() { Id = 2, ServiceHotel_Id = 1, Name = "Wash and iron clothes", Description = "There is an additional charge for picking up clothes after 24 hours", Language_Id = "en-US"},
                
                new ServiceHotelTranslation() { Id = 3, ServiceHotel_Id = 2, Name = "Cung cấp đồ ăn sáng", Description = "Không phụ thu, mỗi ngày một thực đơn", Language_Id = "vi-VN" },
                new ServiceHotelTranslation() { Id = 4, ServiceHotel_Id = 2, Name = "Provide breakfast", Description = "No extra charge, one menu every day", Language_Id = "en-US"}
            );

            // ServiceHotels - Chỉnh sửa hoàn tất
            modelBuilder.Entity<ServiceHotel>().HasData(
                new ServiceHotel() { Id = 1 },
                new ServiceHotel() { Id = 2 }
            );

            // BedTranslation - Chỉnh sửa hoàn tất
            modelBuilder.Entity<BedTranslation>().HasData(
                new BedTranslation() { Id = 1, Bed_Id = 1, Name = "Giường đơn", Description = "Một giường 1m x 1.2m", Language_Id = "vi-VN" },
                new BedTranslation() { Id = 2, Bed_Id = 1, Name = "Single Bed", Description="One bed 1m x 1.2m", Language_Id = "en-US" },
                
                new BedTranslation() { Id = 3, Bed_Id = 2, Name = "Giường đôi nhỏ", Description = "Một giường nhỏ 1.5m x 1.2m", Language_Id = "vi-VN" },
                new BedTranslation() { Id = 4, Bed_Id = 2, Name = "Double Bed", Description="One small double bed 1.5m x 2m", Language_Id = "en-US" }
            );

            // Beds - Chỉnh sửa hoàn tất
            modelBuilder.Entity<Bed>().HasData(
                new Bed() { Id = 1 },
                new Bed() { Id = 2 }
            );

            // ExtensionTypeTranslations - Chỉnh sửa hoàn tất
            modelBuilder.Entity<ExtensionTypeTranslation>().HasData(
                new ExtensionTypeTranslation() { Id = 1, ExtensionType_Id = 1, Name = "Phòng tắm", Language_Id = "vi-VN" },
                new ExtensionTypeTranslation() { Id = 2, ExtensionType_Id = 1, Name = "Bathroom", Language_Id = "en-US" },

                new ExtensionTypeTranslation() { Id = 3, ExtensionType_Id = 2, Name = "Phòng ngủ", Language_Id = "vi-VN" },
                new ExtensionTypeTranslation() { Id = 4, ExtensionType_Id = 2, Name = "Bedroom", Language_Id = "en-US" }
            );

            // ExtensionTypes - Chỉnh sửa hoàn tất
            modelBuilder.Entity<ExtensionType>().HasData(
                new ExtensionType() { Id = 1 },
                new ExtensionType() { Id = 2 }
             );

            // ExtensionTranslations - Chỉnh sửa hoàn tất
            modelBuilder.Entity<ExtensionTranslation>().HasData(
                new ExtensionTranslation() { Id = 1, Extension_Id = 1, Name = "Giấy vệ sinh", Language_Id = "vi-VN" },
                new ExtensionTranslation() { Id = 2, Extension_Id = 1, Name = "Toilet paper", Language_Id = "en-US" },
                
                new ExtensionTranslation() { Id = 3, Extension_Id = 2, Name = "Ra trải giường",  Language_Id = "vi-VN" },
                new ExtensionTranslation() { Id = 4, Extension_Id = 2, Name = "Bedspread", Language_Id = "en-US" }
            );

            // Extensions - Chỉnh sửa hoàn tất
            modelBuilder.Entity<Extension>().HasData(
                new Extension() { Id = 1, ExtensionType_Id = 1},
                new Extension() { Id = 2, ExtensionType_Id = 2}
            );

            // Roles
            var Administrators = new Guid("265E11DA-BC22-4FE7-B286-493D6A09D46F"); //Quản trị viên
            var Owner = new Guid("F0404419-A456-4CD6-A8BC-E19C246904C5"); //Chủ sở hữu
            var Client = new Guid("1F10D63E-C240-4BE5-A95B-B868C41501DD"); //Khách hàng
            var User = new Guid("AD9C3BFC-FD01-4696-B8C8-0CE10E6A3632"); //Người dùng duyệt web

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = Administrators,
                    Name = "Administrators",
                    NormalizedName = "ADMINISTRATORS",
                    Description = "Quản trị viên - quản lí tài khoản và kiểm duyệt người dùng"
                }, 
                new AppRole
                {
                    Id = Owner,
                    Name = "Owner",
                    NormalizedName = "OWNER",
                    Description = "Chủ sở hữu - quản lí tài sản cá nhân, đăng bài và quản lí khách hàng"
                }, 
                new AppRole
                {
                    Id = Client,
                    Name = "Client",
                    NormalizedName = "CLIENT",
                    Description = "Khách hàng đăng nhập - quản lí tài khoản cá nhân và thuê phòng"
                }, 
                new AppRole
                {
                    Id = User,
                    Name = "User",
                    NormalizedName = "USER",
                    Description = "Người dùng duyệt web - xem thông tin khách sạn"
                });

            // Users
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = new Guid("B5E9EBBD-FD85-4AD0-B820-0AA8105EBDD2"),
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "hvikhang_21th@student.agu.edu.vn",
                    NormalizedEmail = "hvikhang_21th@student.agu.edu.vn",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Vikhang11112002@"),
                    SecurityStamp = string.Empty,
                    FirstName = "Vĩ",
                    LastName = "Khang",
                    DisplayName = "Hà Vĩ Khang",
                    Birthday = new DateTime(2002, 11, 11),
                    Nation = "Việt Nam",
                    Gender = "Nam",
                    PhoneNumber = "0339141910",
                    Dashboard = 352642218,
                    Address = "An Phú, An Hòa, Châu Thành, An Giang"
                },
                new AppUser
                {
                    Id = new Guid("31FF741E-5A2A-4AFD-8448-7DC59C03A5B6"),
                    UserName = "MyTien",
                    NormalizedUserName = "MYTIEN",
                    Email = "htmtien_21av@student.agu.edu.vn",
                    NormalizedEmail = "htmtien_21av@student.agu.edu.vn",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Hatien22122002@"),
                    SecurityStamp = string.Empty,
                    FirstName = "Mỹ",
                    LastName = "Tiên",
                    DisplayName = "Hà Thị Mỹ Tiên",
                    Birthday = new DateTime(2002, 12, 22),
                    Nation = "Việt Nam",
                    Gender = "Nu",
                    PhoneNumber = "0357642951",
                    Dashboard = 354261197,
                    Address = "Châu Phong, Tân Châu, An Giang"
                });

            // Asign Role User
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                RoleId = Administrators,
                UserId = new Guid("B5E9EBBD-FD85-4AD0-B820-0AA8105EBDD2"),
            },
            new IdentityUserRole<Guid>
            {
                RoleId = Client,
                UserId = new Guid("31FF741E-5A2A-4AFD-8448-7DC59C03A5B6"),
            }
        );
        }
    }
}
