using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddConstraightBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 918, DateTimeKind.Utc).AddTicks(8043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 44, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 901, DateTimeKind.Utc).AddTicks(4068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 31, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 920, DateTimeKind.Utc).AddTicks(2990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 46, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 878, DateTimeKind.Utc).AddTicks(98),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 9, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 860, DateTimeKind.Utc).AddTicks(3942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 36, 993, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "8daf4429-c26a-402d-a71f-5cddde8396cd");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "aed46a6b-83e7-4a54-acb2-884ef337b7a1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "09e5edfd-ac39-40f7-b2db-6fb06b0b2f36");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "c370db32-1e97-4736-964b-d24bc5efbc51");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d8e971b-f0d3-43c0-9254-d04a1cc9e524", "AQAAAAEAACcQAAAAEA68RZP7SiV5DdI+ApTk5ChlYP2ghZ0kZSpod5VxyMiBQfFOhX323jEwax/51ZRUhA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7906659-2491-4c88-8067-b7017a0ae609", "AQAAAAEAACcQAAAAENjqKyRXG7znfsJp9qHL1HzD+5BGIuBhE4uhLQLYKpC0GV6LlwUif0SkNQ06553rgg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 44, DateTimeKind.Utc).AddTicks(6948),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 918, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 31, DateTimeKind.Utc).AddTicks(1277),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 901, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 46, DateTimeKind.Utc).AddTicks(1654),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 920, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 9, DateTimeKind.Utc).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 878, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6555),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 36, 993, DateTimeKind.Utc).AddTicks(1540),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 860, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "3b5db0a0-cb89-4517-9819-8cc2723934b6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "7b329ed7-4f4c-4653-8927-acc00a3af836");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "38da799f-6180-462b-be8c-d1d89bb619ed");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "c6682c08-da8d-47ef-9c5d-f2c190f23b9f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a9cbaaa-cd82-469d-bd7e-9774a911fa83", "AQAAAAEAACcQAAAAEF7tFDYBW5mdC8rvHJluU5QJpPTU7ZwXTyXsKusgwgDEqifeR7n66n4yNmPt0kDNNQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "05e6907c-621a-470e-a227-04676c5e7f3b", "AQAAAAEAACcQAAAAEElH81uS3QtmINbvHYTZ58GWkoB+poCmGUjaQrEpn86UzQGugRCXAXqkF/BAovidJA==" });
        }
    }
}
