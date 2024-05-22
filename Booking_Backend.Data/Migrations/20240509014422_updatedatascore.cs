using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class updatedatascore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 266, DateTimeKind.Utc).AddTicks(3095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 377, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 250, DateTimeKind.Utc).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 364, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 268, DateTimeKind.Utc).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 379, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.AlterColumn<decimal>(
                name: "ValueScore",
                table: "Hotels",
                type: "decimal(3,1)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "StaffScore",
                table: "Hotels",
                type: "decimal(3,1)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "LocationScore",
                table: "Hotels",
                type: "decimal(3,1)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "FacilitiesScore",
                table: "Hotels",
                type: "decimal(3,1)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "ComfortScore",
                table: "Hotels",
                type: "decimal(3,1)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "CleanlinessScores",
                table: "Hotels",
                type: "decimal(3,1)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValueScore",
                table: "FeedbackCustomers",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "StaffScore",
                table: "FeedbackCustomers",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "LocationScore",
                table: "FeedbackCustomers",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "FacilitiesScore",
                table: "FeedbackCustomers",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "ComfortScore",
                table: "FeedbackCustomers",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "CleanlinessScore",
                table: "FeedbackCustomers",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 220, DateTimeKind.Utc).AddTicks(2010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 344, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(3993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(4470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(4265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 8, 44, 21, 274, DateTimeKind.Local).AddTicks(621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 15, 51, 28, 385, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 272, DateTimeKind.Utc).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 382, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 199, DateTimeKind.Utc).AddTicks(7377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 331, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "a7e23286-caea-4087-a52c-b8a16bc8f36d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "03d6e863-f128-41b7-962c-9b6df0f1a831");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "d007767b-8967-4fe0-958b-01db264ae2cc");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "43632f6a-e5bf-4c03-8431-0864b274814e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "262b446c-0cdb-4e5c-9bca-81b0fdc42283", "AQAAAAEAACcQAAAAEIwLbfeW2gbUKdl9VrHUF/8XKu5GkHgbIRKC+Q6WXMYpWLsdA3hTwSNWUHZxltENoA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2120ae9f-ac00-4965-9aea-1a0ccead782f", "AQAAAAEAACcQAAAAEFzZsBAvoxi2NW5+XMae1L6mECI91WmLG2apy1VgNo4/PhXnL22BmP6vfZlqXjRCVg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 377, DateTimeKind.Utc).AddTicks(9248),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 266, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 364, DateTimeKind.Utc).AddTicks(2538),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 250, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 379, DateTimeKind.Utc).AddTicks(4863),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 268, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.AlterColumn<int>(
                name: "ValueScore",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "StaffScore",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "LocationScore",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "FacilitiesScore",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "ComfortScore",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "CleanlinessScores",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "ValueScore",
                table: "FeedbackCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "StaffScore",
                table: "FeedbackCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "LocationScore",
                table: "FeedbackCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "FacilitiesScore",
                table: "FeedbackCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "ComfortScore",
                table: "FeedbackCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "CleanlinessScore",
                table: "FeedbackCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 344, DateTimeKind.Utc).AddTicks(7746),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 220, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(6908),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(7313),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(7173),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 15, 51, 28, 385, DateTimeKind.Local).AddTicks(221),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 8, 44, 21, 274, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 382, DateTimeKind.Utc).AddTicks(9316),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 272, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 331, DateTimeKind.Utc).AddTicks(2026),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 199, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "ddc5a65d-7fdd-43a6-b6f8-587ab22b2c91");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "14d6ca25-7b3a-473f-887a-e7b79bdd8c6e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "2da2d008-8818-4780-a89b-f4d804d3a23a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "c581b2d8-e6b9-470a-a261-41bce9d27c38");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2db2e6a7-7d16-4c6d-a929-c4b21953def3", "AQAAAAEAACcQAAAAEFS09UumCo33uIVBRE9qRe+gvKnYBVuLHRhgMp2NRD8D8TpGjiovvDLeia5/Hmlm5A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84933310-95c1-42df-95cd-7a69289773ea", "AQAAAAEAACcQAAAAEBxUvaXdHU9L0LOIjpSYFBJc0rFVL64JRx0SwR2gcHgDdKezsztmxGQZjtWTX2NTrw==" });
        }
    }
}
