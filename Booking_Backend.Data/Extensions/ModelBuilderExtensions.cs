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

            //Hotels
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel() { 
                    Id = 1, 
                    Name = "Khách sạn Lê Tuấn Minh", 
                    Area= "Đà Lạt", 
                    Address="12 đường Bà Triệu, Đà Lạt", 
                    Hotline="02963678333", 
                    Establish= new DateTime(2002, 11, 11), 
                    HotelType_Id=1, 
                    ViewHotel_Id=1,
                    Thumbnail= "/images/Thumnails/508886577.jpg", 
                    Language="vi-VN"
                    },
                new Hotel() { 
                    Id = 2, 
                    Name = "Le Minh Tuan Hotel", 
                    Area= "Da Lat", 
                    Address="12 Ba Trieu Street, Da Lat", 
                    Hotline="02963678333", 
                    Establish= new DateTime(2002, 11, 11), 
                    HotelType_Id=2, 
                    ViewHotel_Id=2,
                    Thumbnail= "/images/Thumnails/508886577.jpg", 
                    Language="en-US"
                    }
                );

            // ViewHotels
            modelBuilder.Entity<ViewHotel>().HasData(
                new ViewHotel() { Id = 1, Name = "Trung tâm thành phố", ImageUrl = "/images/ViewHotels/viewtrungtam.jpg", Language = "vi-VN" },
                new ViewHotel() { Id = 2, Name = "City center", ImageUrl = "/images/ViewHotels/viewtrungtam.jpg", Language = "en-US" }

            );

            // HotelTypes
            modelBuilder.Entity<HotelType>().HasData(
                new HotelType() { Id = 1, Name = "Khách sạn", ImageUrl="/images/HotelTypes/khachsan.jpg", Language = "vi-VN" },
                new HotelType() { Id = 2, Name = "Hotel", ImageUrl = "/images/HotelTypes/khachsan.jpg", Language= "en-US" },

                new HotelType() { Id = 3, Name = "Nhà nghỉ", ImageUrl = "/images/HotelTypes/nhanghi.jpg", Language = "vi-VN" },
                new HotelType() { Id = 4, Name = "Lodging", ImageUrl = "/images/HotelTypes/nhanghi.jpg", Language= "en-US" },

                new HotelType() { Id = 5, Name = "Homestay", ImageUrl = "/images/HotelTypes/homestay.jpg", Language = "vi-VN" },
                new HotelType() { Id = 6, Name = "Homestay", ImageUrl = "/images/HotelTypes/homestay.jpg", Language= "en-US" },

                new HotelType() { Id = 7, Name = "Căn hộ", ImageUrl = "/images/HotelTypes/canho.jpg", Language = "vi-VN" },
                new HotelType() { Id = 8, Name = "Apartment", ImageUrl = "/images/HotelTypes/canho.jpg", Language= "en-US" },

                new HotelType() { Id = 9, Name = "Biệt thự", ImageUrl = "/images/HotelTypes/bietthu.jpg", Language = "vi-VN" },
                new HotelType() { Id = 10, Name = "Villa", ImageUrl = "/images/HotelTypes/bietthu.jpg", Language= "en-US" },

                new HotelType() { Id = 11, Name = "Khu nghỉ dưỡng", ImageUrl = "/images/HotelTypes/resort.jpg", Language = "vi-VN" },
                new HotelType() { Id = 12, Name = "Resort", ImageUrl = "/images/HotelTypes/resort.jpg", Language= "en-US" },

                new HotelType() { Id = 13, Name = "Nhà nguyên căn", ImageUrl = "/images/HotelTypes/cannha.jpg", Language = "vi-VN" },
                new HotelType() { Id = 14, Name = "House", ImageUrl = "/images/HotelTypes/cannha.jpg", Language= "en-US" }
                );


            // RoomTypes
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType() { Id = 1, Name = "Phòng Standard", Language = "vi-VN" },
                new RoomType() { Id = 2, Name = "Standard Room", Language= "en-US" },

                new RoomType() { Id = 3, Name = "Phòng Superior", Language = "vi-VN" },
                new RoomType() { Id = 4, Name = "Superior Room", Language = "en-US" },

                new RoomType() { Id = 5, Name = "Phòng Deluxe", Language = "vi-VN" },
                new RoomType() { Id = 6, Name = "Deluxe Room", Language = "en-US" },
                
                new RoomType() { Id = 7, Name = "Phòng Suite", Language = "vi-VN" },    
                new RoomType() { Id = 8, Name = "Suite Room", Language = "en-US" },
                
                new RoomType() { Id = 9, Name = "Phòng Junior Suit", Language = "vi-VN" },
                new RoomType() { Id = 10, Name = "Junior Suite Room", Language = "en-US" },
                
                new RoomType() { Id = 11, Name = "Phòng Executive Suite", Language = "vi-VN" },
                new RoomType() { Id = 12, Name = "Executive Suite Room", Language = "en-US" }
            );
            
            // Beds
            modelBuilder.Entity<Bed>().HasData(
                new Bed() { Id = 1, Name = "Giường đơn", Description = "Một giường 1m x 1.2m", Language = "vi-VN" },
                new Bed() { Id = 2, Name = "Single Bed", Description="One bed 1m x 1.2m", Language = "en-US" },
                
                new Bed() { Id = 3, Name = "Giường đôi nhỏ", Description = "Một giường nhỏ 1.5m x 1.2m", Language = "vi-VN" },
                new Bed() { Id = 4, Name = "Double Bed", Description="One small double bed 1.5m x 2m", Language = "en-US" },
                
                new Bed() { Id = 5, Name = "Giường đôi lớn", Description = "Một giường đôi lớn 1.6m x 2m", Language = "vi-VN" },
                new Bed() { Id = 6, Name = "Queen size Bed", Description="One big double bed 1.6m x 2m", Language = "en-US" },

                new Bed() { Id = 7, Name = "Giường cỡ lớn", Description = "Một giường đôi lớn 1.8m x 2m", Language = "vi-VN" },
                new Bed() { Id = 8, Name = "King size Bed", Description="One big double bed 1.8m x 2m", Language = "en-US" },

                new Bed() { Id = 9, Name = "Western King Bed", Description = "Một giường đôi lớn 1.8m x 2.1m", Language = "vi-VN" },
                new Bed() { Id = 10, Name = "Western King Bed", Description="One big double bed 1.8m x 2.1m", Language = "en-US" },

                new Bed() { Id = 11, Name = "Giường siêu lớn", Description = "Một giường đôi lớn 2m x 2.2m", Language = "vi-VN" },
                new Bed() { Id = 12, Name = "Super King size", Description="One big double bed 2m x 2.2m", Language = "en-US" }
            );
            
            // ExtensionTypes
            modelBuilder.Entity<ExtensionType>().HasData(
                new ExtensionType() { Id = 1, Name = "Phòng tắm", Language = "vi-VN" },
                new ExtensionType() { Id = 2, Name = "Bathroom", Language = "en-US" },

                new ExtensionType() { Id = 3, Name = "Phòng ngủ", Language = "vi-VN" },
                new ExtensionType() { Id = 4, Name = "Bedroom", Language = "en-US" },

                new ExtensionType() { Id = 5, Name = "Nhà bếp", Language = "vi-VN" },
                new ExtensionType() { Id = 6, Name = "Kitchen", Language = "en-US" },

                new ExtensionType() { Id = 7, Name = "Tiện ích trong phòng", Language = "vi-VN" },
                new ExtensionType() { Id = 8, Name = "In-room amenities", Language = "en-US" },

                new ExtensionType() { Id = 9, Name = "Ngoài trời", Language = "vi-VN" },
                new ExtensionType() { Id = 10, Name = "Outdoor", Language = "en-US" },

                new ExtensionType() { Id = 11, Name = "Chăm sóc sức khỏe", Language = "vi-VN" },
                new ExtensionType() { Id = 12, Name = "Healthcare", Language = "en-US" },

                new ExtensionType() { Id = 13, Name = "Lối vào dành cho người khuyết tật", Language = "vi-VN" },
                new ExtensionType() { Id = 14, Name = "Disabled access", Language = "en-US" },

                new ExtensionType() { Id = 15, Name = "Tổng quát", Language = "vi-VN" },
                new ExtensionType() { Id = 16, Name = "General", Language = "en-US" },

                new ExtensionType() { Id = 17, Name = "An ninh", Language = "vi-VN" },
                new ExtensionType() { Id = 18, Name = "Security", Language = "en-US" },

                new ExtensionType() { Id = 19, Name = "Chỗ đậu xe", Language = "vi-VN" },
                new ExtensionType() { Id = 20, Name = "Parking", Language = "en-US" },

                new ExtensionType() { Id = 21, Name = "Internet", Language = "vi-VN" },
                new ExtensionType() { Id = 28, Name = "Internet", Language = "en-US" },

                new ExtensionType() { Id = 22, Name = "Đồ ăn & thức uống", Language = "vi-VN" },
                new ExtensionType() { Id = 23, Name = "Food & Beverage", Language = "en-US" },

                new ExtensionType() { Id = 24, Name = "Truyền thông & Công nghệ", Language = "vi-VN" },
                new ExtensionType() { Id = 25, Name = "Media & Technology", Language = "en-US" },

                new ExtensionType() { Id = 26, Name = "Khu vực phòng khách", Language = "vi-VN" },
                new ExtensionType() { Id = 27, Name = "Living Room Area", Language = "en-US" }
            );

            // Extensions
            modelBuilder.Entity<Extension>().HasData(
                new Extension() { Id = 1, Name = "Giấy vệ sinh", ExtensionType_Id = 1, Language = "vi-VN" },
                new Extension() { Id = 2, Name = "Toilet paper", ExtensionType_Id = 2, Language = "en-US" },
                new Extension() { Id = 3, Name = "Khăn tắm", ExtensionType_Id = 1, Language = "vi-VN" },
                new Extension() { Id = 4, Name = "Bath towel", ExtensionType_Id = 2, Language = "en-US" },
                new Extension() { Id = 5, Name = "Chậu rửa vệ sinh (bidet)", ExtensionType_Id = 1, Language = "vi-VN" },
                new Extension() { Id = 6, Name = "Bidet", ExtensionType_Id = 2, Language = "en-US" },

                new Extension() { Id = 7, Name = "Ra trải giường", ExtensionType_Id = 3, Language = "vi-VN" },
                new Extension() { Id = 8, Name = "Bedspread", ExtensionType_Id = 4, Language = "en-US" },
                new Extension() { Id = 9, Name = "Tủ hoặc phòng để quần áo", ExtensionType_Id = 3, Language = "vi-VN" },
                new Extension() { Id = 10, Name = "Wardrobe or Closet", ExtensionType_Id = 4, Language = "en-US" },
                new Extension() { Id = 11, Name = "Đồng hồ báo thức", ExtensionType_Id = 3, Language = "vi-VN" },
                new Extension() { Id = 12, Name = "Alarm clock", ExtensionType_Id = 4, Language = "en-US" },

                new Extension() { Id = 13, Name = "Bàn ăn", ExtensionType_Id = 5, Language = "vi-VN" },
                new Extension() { Id = 14, Name = "Dining table", ExtensionType_Id = 6, Language = "en-US" },
                new Extension() { Id = 15, Name = "Sản phẩm lau rửa", ExtensionType_Id = 5, Language = "vi-VN" },
                new Extension() { Id = 16, Name = "Cleaning products", ExtensionType_Id = 6, Language = "en-US" },
                new Extension() { Id = 17, Name = "Bếp nấu", ExtensionType_Id = 5, Language = "vi-VN" },
                new Extension() { Id = 18, Name = "Cooking stove", ExtensionType_Id = 6, Language = "en-US" },

                new Extension() { Id = 19, Name = "Ổ điện gần giường", ExtensionType_Id = 7, Language = "vi-VN" },
                new Extension() { Id = 20, Name = "Power outlet near bed", ExtensionType_Id = 8, Language = "en-US" },

                new Extension() { Id = 21, Name = "Bàn ghế ngoài trời", ExtensionType_Id = 9, Language = "vi-VN" },
                new Extension() { Id = 22, Name = "Outdoor furniture", ExtensionType_Id = 10, Language = "en-US" },
                new Extension() { Id = 23, Name = "Sân hiên phơi nắng", ExtensionType_Id = 9, Language = "vi-VN" },
                new Extension() { Id = 24, Name = "Sun deck", ExtensionType_Id = 10, Language = "en-US" },
                new Extension() { Id = 25, Name = "Tiện nghi BBQ", ExtensionType_Id = 9, Language = "vi-VN" },
                new Extension() { Id = 26, Name = "BBQ facilities", ExtensionType_Id = 10, Language = "en-US" }
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
