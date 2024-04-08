using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddFiledTotalPeopleinBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 501, DateTimeKind.Utc).AddTicks(6461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 918, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 487, DateTimeKind.Utc).AddTicks(6196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 901, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 503, DateTimeKind.Utc).AddTicks(2081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 920, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 468, DateTimeKind.Utc).AddTicks(835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 878, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(2111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(1982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.AddColumn<int>(
                name: "TotalPeople",
                table: "Bookings",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 449, DateTimeKind.Utc).AddTicks(9050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 860, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "5a94f4ed-cbb5-41b3-9651-42e1b9cb219a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "828f5989-fa4b-4fae-9cad-444af7e2afe5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "62c7b2f4-fe37-456a-97e0-8bc5e10c63a5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "a0492f38-c67d-417c-9815-77d0c11623d6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2db00dd9-680b-487d-b9b7-3324840366ee", "AQAAAAEAACcQAAAAEJXi5NMR7BlsRvU6k8p5q0+QXyf5M1awfHM9obl9Fu5FQqxqp2Yt7WpuZltWmm9X+Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d211e7b-9004-4868-98a7-0108a4a0901e", "AQAAAAEAACcQAAAAEPHM2XC57vcw9IYuutXaA/D4jn8Q6H0mRacrvNVac4eZSjVBjmTVqFSkGj3qIPDo1g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPeople",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 918, DateTimeKind.Utc).AddTicks(8043),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 501, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 901, DateTimeKind.Utc).AddTicks(4068),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 487, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 920, DateTimeKind.Utc).AddTicks(2990),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 503, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 878, DateTimeKind.Utc).AddTicks(98),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 468, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2425),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2825),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 875, DateTimeKind.Utc).AddTicks(2688),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 2, 5, 43, 11, 860, DateTimeKind.Utc).AddTicks(3942),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 449, DateTimeKind.Utc).AddTicks(9050));

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
    }
}
