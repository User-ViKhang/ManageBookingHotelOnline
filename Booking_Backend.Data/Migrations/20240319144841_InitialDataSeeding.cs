using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class InitialDataSeeding : Migration
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
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 815, DateTimeKind.Utc).AddTicks(6387)),
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
                        .Annotation("SqlServer:Identity", "1, 1")
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
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelTypeImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ImageSize = table.Column<decimal>(type: "decimal", nullable: false),
                    ImageUrl = table.Column<string>(type: "varchar(255)", nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 878, DateTimeKind.Utc).AddTicks(5105)),
                    isDefault = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTypeImages", x => x.Id);
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
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceHotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceHotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViewHotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
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
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 831, DateTimeKind.Utc).AddTicks(8501)),
                    CheckIn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 831, DateTimeKind.Utc).AddTicks(9295)),
                    CheckOut = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 831, DateTimeKind.Utc).AddTicks(9496)),
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
                name: "UserImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ImageSize = table.Column<decimal>(type: "decimal", nullable: false),
                    ImageUrl = table.Column<string>(type: "varchar(255)", nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 876, DateTimeKind.Utc).AddTicks(8682)),
                    isDefault = table.Column<bool>(nullable: false, defaultValue: true),
                    User_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserImages_AppUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BedTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language_Id = table.Column<string>(nullable: true),
                    Bed_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BedTranslations_Beds_Bed_Id",
                        column: x => x.Bed_Id,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Extensions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtensionType_Id = table.Column<int>(nullable: false)
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
                name: "ExtensionTypeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Language_Id = table.Column<string>(type: "varchar(5)", nullable: true),
                    ExtensionType_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionTypeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtensionTypeTranslations_ExtensionTypes_ExtensionType_Id",
                        column: x => x.ExtensionType_Id,
                        principalTable: "ExtensionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelTypeImage_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelTypes_HotelTypeImages_HotelTypeImage_Id",
                        column: x => x.HotelTypeImage_Id,
                        principalTable: "HotelTypeImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Language_Id = table.Column<string>(type: "varchar(5)", nullable: true),
                    RoomType_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomTypeTranslations_RoomTypes_RoomType_Id",
                        column: x => x.RoomType_Id,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceHotelTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language_Id = table.Column<string>(type: "varchar(5)", nullable: true),
                    ServiceHotel_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceHotelTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceHotelTranslations_ServiceHotels_ServiceHotel_Id",
                        column: x => x.ServiceHotel_Id,
                        principalTable: "ServiceHotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ViewHotelTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language_Id = table.Column<string>(type: "varchar(5)", nullable: true),
                    ViewHotel_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewHotelTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViewHotelTranslations_ViewHotels_ViewHotel_Id",
                        column: x => x.ViewHotel_Id,
                        principalTable: "ViewHotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Language_Id = table.Column<string>(type: "varchar(5)", nullable: true),
                    Extension_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtensionTranslations_Extensions_Extension_Id",
                        column: x => x.Extension_Id,
                        principalTable: "Extensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hotline = table.Column<string>(type: "varchar(11)", nullable: true),
                    Establish = table.Column<DateTime>(type: "date", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal", nullable: false),
                    HotelType_Id = table.Column<int>(nullable: false),
                    ViewHotel_Id = table.Column<int>(nullable: false)
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
                name: "HotelTypeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Language_Id = table.Column<string>(type: "varchar(5)", nullable: true),
                    HotelType_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTypeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelTypeTranslations_HotelTypes_HotelType_Id",
                        column: x => x.HotelType_Id,
                        principalTable: "HotelTypes",
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
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 835, DateTimeKind.Utc).AddTicks(3266)),
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
                        name: "FK_Hotel_Services_ServiceHotels_Service_Id",
                        column: x => x.Service_Id,
                        principalTable: "ServiceHotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language_Id = table.Column<string>(type: "varchar(5)", nullable: true),
                    Hotel_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelTranslations_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
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
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 860, DateTimeKind.Utc).AddTicks(1786)),
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
                    Maximum = table.Column<int>(nullable: false, defaultValue: 1),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    PriceByHour = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    PriceOverNight = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    Hotel_Id = table.Column<int>(nullable: false),
                    RoomType_Id = table.Column<int>(nullable: false),
                    Bed_Id = table.Column<int>(nullable: false)
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
                    { new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"), "2ebaf1a1-4f0a-408e-b92e-00ea5a93a978", "Quản trị viên - quản lí tài khoản và kiểm duyệt người dùng", "Administrators", "ADMINISTRATORS" },
                    { new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"), "343ea084-f979-4591-be52-f44f26c0ac23", "Chủ sở hữu - quản lí tài sản cá nhân, đăng bài và quản lí khách hàng", "Owner", "OWNER" },
                    { new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"), "7e3fe8fe-ec15-4441-9ef5-a21342b84707", "Khách hàng đăng nhập - quản lí tài khoản cá nhân và thuê phòng", "Client", "CLIENT" },
                    { new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"), "721771c3-bab4-4fbd-8363-a2d9e244d8d9", "Người dùng duyệt web - xem thông tin khách sạn", "User", "USER" }
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
                    { new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"), 0, "An Phú, An Hòa, Châu Thành, An Giang", null, new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ee1af177-b2f5-495f-9a23-b2fe45ddac83", 352642218, "Hà Vĩ Khang", "hvikhang_21th@student.agu.edu.vn", true, "Vĩ", "Nam", "Khang", false, null, "Việt Nam", "hvikhang_21th@student.agu.edu.vn", "ADMIN", "AQAAAAEAACcQAAAAEO3ejeLUC7fGSmj3EzghlFze986NbsxeFRkr34FH/Mg56cHXu4Fe2NOJKO157NIifA==", "0339141910", false, "", false, "admin" },
                    { new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"), 0, "Châu Phong, Tân Châu, An Giang", null, new DateTime(2002, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "8db370d8-7bf0-48a0-87d0-f1ff090ea55d", 354261197, "Hà Thị Mỹ Tiên", "htmtien_21av@student.agu.edu.vn", true, "Mỹ", "Nu", "Tiên", false, null, "Việt Nam", "htmtien_21av@student.agu.edu.vn", "MYTIEN", "AQAAAAEAACcQAAAAEGCn64z7vH3q0s7ApFad7/1iGltDCLkcgk7ff3DKJ6yos0dgvJTy1j7npK+GPXeP8w==", "0357642951", false, "", false, "MyTien" }
                });

            migrationBuilder.InsertData(
                table: "Beds",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "ExtensionTypes",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "HotelTypeImages",
                columns: new[] { "Id", "Caption", "ImageSize", "ImageUrl" },
                values: new object[,]
                {
                    { 2, "caption hoteltype img 2", 222m, "imgrl hoteltype 2" },
                    { 1, "caption hoteltype img 1", 111m, "imgrl hoteltype 1" }
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
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "ServiceHotels",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "ViewHotels",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "BedTranslations",
                columns: new[] { "Id", "Bed_Id", "Description", "Language_Id", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Một giường 1m x 1.2m", "vi-VN", "Giường đơn" },
                    { 2, 1, "One bed 1m x 1.2m", "en-US", "Single Bed" },
                    { 3, 2, "Một giường nhỏ 1.5m x 1.2m", "vi-VN", "Giường đôi nhỏ" },
                    { 4, 2, "One small double bed 1.5m x 2m", "en-US", "Double Bed" }
                });

            migrationBuilder.InsertData(
                table: "ExtensionTypeTranslations",
                columns: new[] { "Id", "ExtensionType_Id", "Language_Id", "Name" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Phòng tắm" },
                    { 2, 1, "en-US", "Bathroom" },
                    { 3, 2, "vi-VN", "Phòng ngủ" },
                    { 4, 2, "en-US", "Bedroom" }
                });

            migrationBuilder.InsertData(
                table: "Extensions",
                columns: new[] { "Id", "ExtensionType_Id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "HotelTypes",
                columns: new[] { "Id", "HotelTypeImage_Id" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "RoomTypeTranslations",
                columns: new[] { "Id", "Language_Id", "Name", "RoomType_Id" },
                values: new object[,]
                {
                    { 1, "vi-VN", "Phòng Standard", 1 },
                    { 2, "en-US", "Standard Room", 1 },
                    { 3, "vi-VN", "Phòng Superior", 2 },
                    { 4, "en-US", "Superior Room", 2 }
                });

            migrationBuilder.InsertData(
                table: "ServiceHotelTranslations",
                columns: new[] { "Id", "Description", "Language_Id", "Name", "ServiceHotel_Id" },
                values: new object[,]
                {
                    { 1, "Có phụ thu lấy quần áo sau 24h", "vi-VN", "Giặt và ủi quần áo", 1 },
                    { 2, "There is an additional charge for picking up clothes after 24 hours", "en-US", "Wash and iron clothes", 1 },
                    { 3, "Không phụ thu, mỗi ngày một thực đơn", "vi-VN", "Cung cấp đồ ăn sáng", 2 },
                    { 4, "No extra charge, one menu every day", "en-US", "Provide breakfast", 2 }
                });

            migrationBuilder.InsertData(
                table: "ViewHotelTranslations",
                columns: new[] { "Id", "Description", "Language_Id", "Name", "ViewHotel_Id" },
                values: new object[,]
                {
                    { 3, null, "vi-VN", "Trung tâm thành phố", 2 },
                    { 1, null, "vi-VN", "Bãi biển", 1 },
                    { 2, null, "en-US", "Beach", 1 },
                    { 4, null, "en-US", "City center", 2 }
                });

            migrationBuilder.InsertData(
                table: "ExtensionTranslations",
                columns: new[] { "Id", "Extension_Id", "Language_Id", "Name" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Giấy vệ sinh" },
                    { 2, 1, "en-US", "Toilet paper" },
                    { 3, 2, "vi-VN", "Ra trải giường" },
                    { 4, 2, "en-US", "Bedspread" }
                });

            migrationBuilder.InsertData(
                table: "HotelTypeTranslations",
                columns: new[] { "Id", "HotelType_Id", "Language_Id", "Name" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Khách sạn" },
                    { 2, 1, "en-US", "Hotel" },
                    { 3, 2, "vi-VN", "Nhà nghỉ" },
                    { 4, 2, "en-US", "Lodging" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Establish", "HotelType_Id", "Hotline", "Latitude", "Longitude", "ViewHotel_Id" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "02963678333", 0m, 0m, 2 },
                    { 2, new DateTime(2002, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "02963678463", 0m, 0m, 1 }
                });

            migrationBuilder.InsertData(
                table: "HotelTranslations",
                columns: new[] { "Id", "Address", "Area", "Description", "Hotel_Id", "Language_Id", "Name" },
                values: new object[,]
                {
                    { 1, "12 đường Bà Triệu, Đà Lạt", "Đà Lạt", "Khách sạn Lê Tuấn Minh", 1, "vi-VN", "Khách sạn Lê Tuấn Minh" },
                    { 2, "12 Ba Trieu Street, Da Lat", "Da Lat", "Le Minh Tuan Hotel", 1, "en-US", "Le Minh Tuan Hotel" },
                    { 3, "Côn Đảo, Vũng Tàu", "Vũng Tàu", "Khách sạn Moon House", 2, "vi-VN", "Khách sạn Moon House" },
                    { 4, "Con Dao, Vung Tau", "Vung Tau", "Moon House Hotel", 2, "en-US", "Moon House Hotel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BedTranslations_Bed_Id",
                table: "BedTranslations",
                column: "Bed_Id");

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
                name: "IX_ExtensionTranslations_Extension_Id",
                table: "ExtensionTranslations",
                column: "Extension_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionTypeTranslations_ExtensionType_Id",
                table: "ExtensionTypeTranslations",
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
                name: "IX_HotelTranslations_Hotel_Id",
                table: "HotelTranslations",
                column: "Hotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HotelTypes_HotelTypeImage_Id",
                table: "HotelTypes",
                column: "HotelTypeImage_Id",
                unique: true,
                filter: "[HotelTypeImage_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HotelTypeTranslations_HotelType_Id",
                table: "HotelTypeTranslations",
                column: "HotelType_Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypeTranslations_RoomType_Id",
                table: "RoomTypeTranslations",
                column: "RoomType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceHotelTranslations_ServiceHotel_Id",
                table: "ServiceHotelTranslations",
                column: "ServiceHotel_Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserImages_User_Id",
                table: "UserImages",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ViewHotelTranslations_ViewHotel_Id",
                table: "ViewHotelTranslations",
                column: "ViewHotel_Id");
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
                name: "BedTranslations");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ExtensionTranslations");

            migrationBuilder.DropTable(
                name: "ExtensionTypeTranslations");

            migrationBuilder.DropTable(
                name: "Hotel_Services");

            migrationBuilder.DropTable(
                name: "HotelTranslations");

            migrationBuilder.DropTable(
                name: "HotelTypeTranslations");

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
                name: "RoomTypeTranslations");

            migrationBuilder.DropTable(
                name: "ServiceHotelTranslations");

            migrationBuilder.DropTable(
                name: "UserImages");

            migrationBuilder.DropTable(
                name: "ViewHotelTranslations");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Extensions");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "ServiceHotels");

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

            migrationBuilder.DropTable(
                name: "HotelTypeImages");
        }
    }
}
