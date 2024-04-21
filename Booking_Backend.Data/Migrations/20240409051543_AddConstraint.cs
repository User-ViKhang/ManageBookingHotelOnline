using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 655, DateTimeKind.Utc).AddTicks(9468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 371, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 639, DateTimeKind.Utc).AddTicks(7848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 355, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 657, DateTimeKind.Utc).AddTicks(7019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 372, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 606, DateTimeKind.Utc).AddTicks(7888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 333, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.AlterColumn<Guid>(
                name: "User_Id",
                table: "Bills",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "GuestCustomer_Id",
                table: "Bills",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 661, DateTimeKind.Utc).AddTicks(3559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 375, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 588, DateTimeKind.Utc).AddTicks(980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 314, DateTimeKind.Utc).AddTicks(1753));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 371, DateTimeKind.Utc).AddTicks(76),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 655, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 355, DateTimeKind.Utc).AddTicks(5110),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 639, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 372, DateTimeKind.Utc).AddTicks(4906),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 657, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 333, DateTimeKind.Utc).AddTicks(5944),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 606, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(2688),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(3262),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(3070),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 603, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.AlterColumn<Guid>(
                name: "User_Id",
                table: "Bills",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GuestCustomer_Id",
                table: "Bills",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 375, DateTimeKind.Utc).AddTicks(8492),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 661, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 314, DateTimeKind.Utc).AddTicks(1753),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 15, 42, 588, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "ac8097cf-a40c-4618-bbcf-216fc22f40e9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "6378028f-1dbd-4fa6-a8b0-bb099d45c8db");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "1a001095-5225-45de-9b44-22bc1f62ff2f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "d4cd5435-3578-47ff-9416-f90888122626");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "577d7a3b-f069-47bd-85f0-7ae9742252fa", "AQAAAAEAACcQAAAAEHkxD1zvylbq8jCwNOrHZ2Pa1FXPw0D2cXbNQv1meBei+xM+LqSHhndRkFHZ2civ1Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac5a88c1-c564-4988-ae8c-4cc9af337a16", "AQAAAAEAACcQAAAAEJXAySUTEUJx2isEUgP55yc4mUrsq4HeQFmn8P9lRSvnao0yXrGeVm1iEeg6Ps6Ciw==" });
        }
    }
}
