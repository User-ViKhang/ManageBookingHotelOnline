using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Nation = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Dashboard = table.Column<int>(nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 239, DateTimeKind.Utc).AddTicks(2215)),
                    Status = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Beds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Language = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(255)", nullable: true),
                    Language = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(5)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Language = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViewHotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Language = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewHotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 243, DateTimeKind.Utc).AddTicks(6347)),
                    CheckIn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 243, DateTimeKind.Utc).AddTicks(6606)),
                    CheckOut = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 243, DateTimeKind.Utc).AddTicks(6729)),
                    TotalAmount = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    User_Id = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AppUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Extensions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ExtensionType_Id = table.Column<int>(nullable: false),
                    Language = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Extensions_ExtensionTypes_ExtensionType_Id",
                        column: x => x.ExtensionType_Id,
                        principalTable: "ExtensionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Hotline = table.Column<string>(type: "varchar(11)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Establish = table.Column<DateTime>(type: "date", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal", nullable: false),
                    Thumbnail = table.Column<string>(type: "varchar(255)", nullable: true),
                    HotelType_Id = table.Column<int>(nullable: false),
                    ViewHotel_Id = table.Column<int>(nullable: false),
                    Language = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_HotelTypes_HotelType_Id",
                        column: x => x.HotelType_Id,
                        principalTable: "HotelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotels_ViewHotels_ViewHotel_Id",
                        column: x => x.ViewHotel_Id,
                        principalTable: "ViewHotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 255, DateTimeKind.Utc).AddTicks(4284)),
                    Hotel_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AppUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotel_Services",
                columns: table => new
                {
                    Hotel_Id = table.Column<int>(nullable: false),
                    Service_Id = table.Column<int>(nullable: false),
                    Surcharge = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel_Services", x => new { x.Hotel_Id, x.Service_Id });
                    table.ForeignKey(
                        name: "FK_Hotel_Services_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotel_Services_Services_Service_Id",
                        column: x => x.Service_Id,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ImageSize = table.Column<decimal>(type: "decimal", nullable: false),
                    ImageUrl = table.Column<string>(type: "varchar(255)", nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 266, DateTimeKind.Utc).AddTicks(796)),
                    Hotel_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomCode = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maximum = table.Column<int>(nullable: false, defaultValue: 1),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    PriceByHour = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    PriceOverNight = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    Hotel_Id = table.Column<int>(nullable: false),
                    RoomType_Id = table.Column<int>(nullable: false),
                    Bed_Id = table.Column<int>(nullable: false),
                    Language = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Beds_Bed_Id",
                        column: x => x.Bed_Id,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomType_Id",
                        column: x => x.RoomType_Id,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room_Bookings",
                columns: table => new
                {
                    Room_Id = table.Column<int>(nullable: false),
                    Booking_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room_Bookings", x => new { x.Room_Id, x.Booking_Id });
                    table.ForeignKey(
                        name: "FK_Room_Bookings_Bookings_Booking_Id",
                        column: x => x.Booking_Id,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_Bookings_Rooms_Room_Id",
                        column: x => x.Room_Id,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room_Extensions",
                columns: table => new
                {
                    Room_Id = table.Column<int>(nullable: false),
                    Extension_Id = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room_Extensions", x => new { x.Room_Id, x.Extension_Id });
                    table.ForeignKey(
                        name: "FK_Room_Extensions_Extensions_Extension_Id",
                        column: x => x.Extension_Id,
                        principalTable: "Extensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_Extensions_Rooms_Room_Id",
                        column: x => x.Room_Id,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"), "9f539ce8-4532-4779-9cce-a419e44c3ddc", "Quản trị viên - quản lí tài khoản và kiểm duyệt người dùng", "Administrators", "ADMINISTRATORS" },
                    { new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"), "cd7ec076-cbee-4ff7-929e-f848e5900aa7", "Chủ sở hữu - quản lí tài sản cá nhân, đăng bài và quản lí khách hàng", "Owner", "OWNER" },
                    { new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"), "7fb31be1-fc0c-4980-bebd-a2a0449ce5fa", "Khách hàng đăng nhập - quản lí tài khoản cá nhân và thuê phòng", "Client", "CLIENT" },
                    { new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"), "576d1663-1bd0-4c51-ac17-aefc7fb72622", "Người dùng duyệt web - xem thông tin khách sạn", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"), new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f") },
                    { new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"), new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd") }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarUrl", "Birthday", "ConcurrencyStamp", "Dashboard", "DisplayName", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "Nation", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"), 0, "An Phú, An Hòa, Châu Thành, An Giang", null, new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "4bc6c096-d3d3-4ff7-ba86-811b3ad5ba4f", 352642218, "Hà Vĩ Khang", "hvikhang_21th@student.agu.edu.vn", true, "Vĩ", "Nam", "Khang", false, null, "Việt Nam", "hvikhang_21th@student.agu.edu.vn", "ADMIN", "AQAAAAEAACcQAAAAEMhjQCpXeAquyLtGUARQfLYMaErU0dK9YGktKxsguaQXPt8hPlRG1q7Vbz8X7A/rEA==", "0339141910", false, "", false, "admin" },
                    { new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"), 0, "Châu Phong, Tân Châu, An Giang", null, new DateTime(2002, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "5eba75c2-e407-4cb5-911b-531f961728e1", 354261197, "Hà Thị Mỹ Tiên", "htmtien_21av@student.agu.edu.vn", true, "Mỹ", "Nu", "Tiên", false, null, "Việt Nam", "htmtien_21av@student.agu.edu.vn", "MYTIEN", "AQAAAAEAACcQAAAAEAYQ6v0ta6z1fwfDnlWbY/WB4K/F+QKWFSRqx+Lp+OD6QAz5f93vAYJcrGgcRhxLxQ==", "0357642951", false, "", false, "MyTien" }
                });

            migrationBuilder.InsertData(
                table: "Beds",
                columns: new[] { "Id", "Description", "Language", "Name" },
                values: new object[,]
                {
                    { 12, "One big double bed 2m x 2.2m", "en-US", "Super King size" },
                    { 11, "Một giường đôi lớn 2m x 2.2m", "vi-VN", "Giường siêu lớn" },
                    { 10, "One big double bed 1.8m x 2.1m", "en-US", "Western King Bed" },
                    { 8, "One big double bed 1.8m x 2m", "en-US", "King size Bed" },
                    { 9, "Một giường đôi lớn 1.8m x 2.1m", "vi-VN", "Western King Bed" },
                    { 6, "One big double bed 1.6m x 2m", "en-US", "Queen size Bed" },
                    { 5, "Một giường đôi lớn 1.6m x 2m", "vi-VN", "Giường đôi lớn" },
                    { 4, "One small double bed 1.5m x 2m", "en-US", "Double Bed" },
                    { 3, "Một giường nhỏ 1.5m x 1.2m", "vi-VN", "Giường đôi nhỏ" },
                    { 2, "One bed 1m x 1.2m", "en-US", "Single Bed" },
                    { 7, "Một giường đôi lớn 1.8m x 2m", "vi-VN", "Giường cỡ lớn" },
                    { 1, "Một giường 1m x 1.2m", "vi-VN", "Giường đơn" }
                });

            migrationBuilder.InsertData(
                table: "ExtensionTypes",
                columns: new[] { "Id", "Language", "Name" },
                values: new object[,]
                {
                    { 17, "vi-VN", "An ninh" },
                    { 18, "en-US", "Security" },
                    { 19, "vi-VN", "Chỗ đậu xe" },
                    { 20, "en-US", "Parking" },
                    { 27, "en-US", "Living Room Area" },
                    { 22, "vi-VN", "Đồ ăn & thức uống" },
                    { 24, "vi-VN", "Truyền thông & Công nghệ" },
                    { 25, "en-US", "Media & Technology" },
                    { 26, "vi-VN", "Khu vực phòng khách" },
                    { 16, "en-US", "General" },
                    { 28, "en-US", "Internet" },
                    { 15, "vi-VN", "Tổng quát" },
                    { 23, "en-US", "Food & Beverage" },
                    { 13, "vi-VN", "Lối vào dành cho người khuyết tật" },
                    { 14, "en-US", "Disabled access" },
                    { 1, "vi-VN", "Phòng tắm" },
                    { 2, "en-US", "Bathroom" },
                    { 3, "vi-VN", "Phòng ngủ" },
                    { 4, "en-US", "Bedroom" },
                    { 5, "vi-VN", "Nhà bếp" },
                    { 21, "vi-VN", "Internet" },
                    { 7, "vi-VN", "Tiện ích trong phòng" },
                    { 8, "en-US", "In-room amenities" },
                    { 9, "vi-VN", "Ngoài trời" },
                    { 10, "en-US", "Outdoor" },
                    { 11, "vi-VN", "Chăm sóc sức khỏe" },
                    { 6, "en-US", "Kitchen" },
                    { 12, "en-US", "Healthcare" }
                });

            migrationBuilder.InsertData(
                table: "HotelTypes",
                columns: new[] { "Id", "ImageUrl", "Language", "Name" },
                values: new object[,]
                {
                    { 13, "/images/HotelTypes/cannha.jpg", "vi-VN", "Nhà nguyên căn" },
                    { 12, "/images/HotelTypes/resort.jpg", "en-US", "Resort" },
                    { 11, "/images/HotelTypes/resort.jpg", "vi-VN", "Khu nghỉ dưỡng" },
                    { 9, "/images/HotelTypes/bietthu.jpg", "vi-VN", "Biệt thự" },
                    { 8, "/images/HotelTypes/canho.jpg", "en-US", "Apartment" },
                    { 14, "/images/HotelTypes/cannha.jpg", "en-US", "House" },
                    { 6, "/images/HotelTypes/homestay.jpg", "en-US", "Homestay" },
                    { 7, "/images/HotelTypes/canho.jpg", "vi-VN", "Căn hộ" },
                    { 1, "/images/HotelTypes/khachsan.jpg", "vi-VN", "Khách sạn" },
                    { 2, "/images/HotelTypes/khachsan.jpg", "en-US", "Hotel" },
                    { 10, "/images/HotelTypes/bietthu.jpg", "en-US", "Villa" },
                    { 4, "/images/HotelTypes/nhanghi.jpg", "en-US", "Lodging" },
                    { 5, "/images/HotelTypes/homestay.jpg", "vi-VN", "Homestay" },
                    { 3, "/images/HotelTypes/nhanghi.jpg", "vi-VN", "Nhà nghỉ" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng Việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Language", "Name" },
                values: new object[,]
                {
                    { 12, "en-US", "Executive Suite Room" },
                    { 11, "vi-VN", "Phòng Executive Suite" },
                    { 10, "en-US", "Junior Suite Room" },
                    { 9, "vi-VN", "Phòng Junior Suit" },
                    { 8, "en-US", "Suite Room" },
                    { 7, "vi-VN", "Phòng Suite" },
                    { 5, "vi-VN", "Phòng Deluxe" },
                    { 3, "vi-VN", "Phòng Superior" },
                    { 2, "en-US", "Standard Room" },
                    { 1, "vi-VN", "Phòng Standard" },
                    { 6, "en-US", "Deluxe Room" },
                    { 4, "en-US", "Superior Room" }
                });

            migrationBuilder.InsertData(
                table: "ViewHotels",
                columns: new[] { "Id", "Description", "ImageUrl", "Language", "Name" },
                values: new object[,]
                {
                    { 1, null, "/images/ViewHotels/viewtrungtam.jpg", "vi-VN", "Trung tâm thành phố" },
                    { 2, null, "/images/ViewHotels/viewtrungtam.jpg", "en-US", "City center" }
                });

            migrationBuilder.InsertData(
                table: "Extensions",
                columns: new[] { "Id", "ExtensionType_Id", "Language", "Name" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Giấy vệ sinh" },
                    { 26, 10, "en-US", "BBQ facilities" },
                    { 24, 10, "en-US", "Sun deck" },
                    { 22, 10, "en-US", "Outdoor furniture" },
                    { 25, 9, "vi-VN", "Tiện nghi BBQ" },
                    { 23, 9, "vi-VN", "Sân hiên phơi nắng" },
                    { 21, 9, "vi-VN", "Bàn ghế ngoài trời" },
                    { 20, 8, "en-US", "Power outlet near bed" },
                    { 19, 7, "vi-VN", "Ổ điện gần giường" },
                    { 18, 6, "en-US", "Cooking stove" },
                    { 16, 6, "en-US", "Cleaning products" },
                    { 14, 6, "en-US", "Dining table" },
                    { 17, 5, "vi-VN", "Bếp nấu" },
                    { 15, 5, "vi-VN", "Sản phẩm lau rửa" },
                    { 13, 5, "vi-VN", "Bàn ăn" },
                    { 12, 4, "en-US", "Alarm clock" },
                    { 10, 4, "en-US", "Wardrobe or Closet" },
                    { 8, 4, "en-US", "Bedspread" },
                    { 11, 3, "vi-VN", "Đồng hồ báo thức" },
                    { 9, 3, "vi-VN", "Tủ hoặc phòng để quần áo" },
                    { 7, 3, "vi-VN", "Ra trải giường" },
                    { 6, 2, "en-US", "Bidet" },
                    { 4, 2, "en-US", "Bath towel" },
                    { 2, 2, "en-US", "Toilet paper" },
                    { 5, 1, "vi-VN", "Chậu rửa vệ sinh (bidet)" },
                    { 3, 1, "vi-VN", "Khăn tắm" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Area", "Description", "Establish", "HotelType_Id", "Hotline", "Language", "Latitude", "Longitude", "Name", "Thumbnail", "ViewHotel_Id" },
                values: new object[,]
                {
                    { 1, "12 đường Bà Triệu, Đà Lạt", "Đà Lạt", null, new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "02963678333", "vi-VN", 0m, 0m, "Khách sạn Lê Tuấn Minh", "/images/Thumnails/508886577.jpg", 1 },
                    { 2, "12 Ba Trieu Street, Da Lat", "Da Lat", null, new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "02963678333", "en-US", 0m, 0m, "Le Minh Tuan Hotel", "/images/Thumnails/508886577.jpg", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_User_Id",
                table: "Bookings",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Hotel_Id",
                table: "Comments",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_User_Id",
                table: "Comments",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Extensions_ExtensionType_Id",
                table: "Extensions",
                column: "ExtensionType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Services_Service_Id",
                table: "Hotel_Services",
                column: "Service_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_HotelType_Id",
                table: "Hotels",
                column: "HotelType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_ViewHotel_Id",
                table: "Hotels",
                column: "ViewHotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Hotel_Id",
                table: "Images",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Bookings_Booking_Id",
                table: "Room_Bookings",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Extensions_Extension_Id",
                table: "Room_Extensions",
                column: "Extension_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Bed_Id",
                table: "Rooms",
                column: "Bed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Hotel_Id",
                table: "Rooms",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomType_Id",
                table: "Rooms",
                column: "RoomType_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Hotel_Services");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Room_Bookings");

            migrationBuilder.DropTable(
                name: "Room_Extensions");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Extensions");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "ExtensionTypes");

            migrationBuilder.DropTable(
                name: "Beds");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "HotelTypes");

            migrationBuilder.DropTable(
                name: "ViewHotels");
        }
    }
}
