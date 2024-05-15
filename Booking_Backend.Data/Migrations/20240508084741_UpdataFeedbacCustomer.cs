using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdataFeedbacCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 81, DateTimeKind.Utc).AddTicks(4201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 256, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 62, DateTimeKind.Utc).AddTicks(1818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 239, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 83, DateTimeKind.Utc).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 258, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 32, DateTimeKind.Utc).AddTicks(8368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 220, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 15, 47, 40, 90, DateTimeKind.Local).AddTicks(2150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 23, 30, 0, 266, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 87, DateTimeKind.Utc).AddTicks(5669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 262, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 15, DateTimeKind.Utc).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 205, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "a9a29792-ccb9-4960-a4f7-06d545d44a92");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "efe4f406-4e0a-44f3-92fa-90a4e0701e7e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "9381eb16-e14b-4790-8704-2fbd996e7f42");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "07498440-a657-482d-b965-0f379dc93626");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "316c7993-0ac1-460c-98cf-d1e6292bcf4a", "AQAAAAEAACcQAAAAEAfmAtviH0AvjgINmqc8anIlZbno89KY61aB9ycVaeYnyh0BAVDZxf6OZfxwdIxI3g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d6ce466-bb54-4be5-8356-b3305faaa86f", "AQAAAAEAACcQAAAAEMrIRCbLcyxazF/r2Mkk3O0BvW7fygNiWa4dPF1sbL8RE/XBRGCCktUz8eD1ki0e1w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 256, DateTimeKind.Utc).AddTicks(3218),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 81, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 239, DateTimeKind.Utc).AddTicks(5075),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 62, DateTimeKind.Utc).AddTicks(1818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 258, DateTimeKind.Utc).AddTicks(4606),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 83, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 220, DateTimeKind.Utc).AddTicks(2394),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 32, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2801),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2676),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 23, 30, 0, 266, DateTimeKind.Local).AddTicks(4451),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 15, 47, 40, 90, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 262, DateTimeKind.Utc).AddTicks(7763),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 87, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 205, DateTimeKind.Utc).AddTicks(2300),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 15, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "d91797a7-08cf-4180-ae99-adee0dcd1f51");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "dcc8562b-e2de-45ea-ab1c-bb3330685831");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "0b7f8414-4d9e-4a04-9050-c3cba4ca061e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "dff7d88a-05df-4778-bbd7-9c5f17355717");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "950a1a9d-2b3e-4deb-9f77-442459f7b074", "AQAAAAEAACcQAAAAEOlCL/kvQregzL1924t5U4Yecpep7jbJmBetlKJJv4t6cha4033UVLOFyIh4cpx3VQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "333ada93-51d0-4107-a2b0-8c352a98057e", "AQAAAAEAACcQAAAAEKIcCjdG80eMkAKNzArEmujIV20psHzzO+jap/5IzK7QSZEuwOhSLSfrPKBEP6bQtg==" });
        }
    }
}
