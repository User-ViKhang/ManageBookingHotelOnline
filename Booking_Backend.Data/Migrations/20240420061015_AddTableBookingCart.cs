using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddTableBookingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 847, DateTimeKind.Utc).AddTicks(1212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 655, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 833, DateTimeKind.Utc).AddTicks(6594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 639, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 848, DateTimeKind.Utc).AddTicks(9697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 657, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 814, DateTimeKind.Utc).AddTicks(377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 606, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(8873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(9312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(9171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 852, DateTimeKind.Utc).AddTicks(4880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 661, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 796, DateTimeKind.Utc).AddTicks(1073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 588, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.CreateTable(
                name: "BookingCarts",
                columns: table => new
                {
                    Hotel_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 4, 20, 13, 10, 14, 854, DateTimeKind.Local).AddTicks(3158))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingCarts", x => new { x.Hotel_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_BookingCarts_Hotels_Hotel_Id",
                        column: x => x.Hotel_Id,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingCarts_AppUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "594b0664-94a2-47fd-a624-69d7d1ef92b3");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "f430caaf-64b9-47e5-a5cb-e355cb217b33");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "d1bb6a30-17b9-4463-8cf6-3e1ea55c3d9d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "45ffbe83-e7ad-43dc-ad1f-68b9fe076186");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a3820a1-bd61-4868-b548-a919d7ebe6b3", "AQAAAAEAACcQAAAAEE7uEGhvYE+jwTyndE8bur4dLAfn1aekjXsXtViXeeBikUNP/ngmHP2JR274Xc9oXw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3cc6689-4aa0-4826-aa01-bdad2293c8d5", "AQAAAAEAACcQAAAAEBG2uDa82HAJp2ceJ7gNo4kv1VK63b+iefy37Yfe6GYLGAjt1LrkpQskD82C9LYDyQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_BookingCarts_User_Id",
                table: "BookingCarts",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingCarts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 655, DateTimeKind.Utc).AddTicks(9468),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 847, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 639, DateTimeKind.Utc).AddTicks(7848),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 833, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 657, DateTimeKind.Utc).AddTicks(7019),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 848, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 606, DateTimeKind.Utc).AddTicks(7888),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 814, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4277),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4678),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4541),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 661, DateTimeKind.Utc).AddTicks(3559),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 852, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 588, DateTimeKind.Utc).AddTicks(980),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 796, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "73d360f9-d26e-4a43-9e0c-9cf256884082");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "57a590ba-ee1e-4e53-a9de-bbbdc278ca81");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "179b1ccd-7c44-4043-9773-d52eb2cd7e57");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "e3bd853e-0975-4a54-b568-deb50da45fb0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f0d8de8-8206-48f4-a525-c72c5929515c", "AQAAAAEAACcQAAAAEDqrCemFEqacAuijxcoLLCGgEXLJtUJlF8ndZ1EnqtCpls8HgN6E1Eb1lkWsLuuWbg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "042e1654-cc0c-4f2c-9a46-3a317cf20833", "AQAAAAEAACcQAAAAECsfMmGO7kgv5v7m22R5xASS0qw8fH4d4X5QAJl22V9R6+DWSshw8DAShh1GmDu05w==" });
        }
    }
}
