using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddDeleteBehavior_Extension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 181, DateTimeKind.Utc).AddTicks(8869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 195, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 118, DateTimeKind.Utc).AddTicks(544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 182, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 186, DateTimeKind.Utc).AddTicks(6885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 197, DateTimeKind.Utc).AddTicks(2371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 73, DateTimeKind.Utc).AddTicks(9962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 156, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(2644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(3193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(3022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 18, DateTimeKind.Utc).AddTicks(6691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 139, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "b209706c-ad06-4a69-b666-fa586a5968a9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "e16ccc1e-89e6-4e59-91e6-64c69591879b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "9b69aca2-e9ca-4f3f-9fc8-e5ff186d8cf9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "60751fb2-83bb-479e-a297-56b0dd4068fb");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0b1bfee-dfa3-4ffc-9603-35208750a8d7", "AQAAAAEAACcQAAAAEN9RtHxFTYGQDt1typx/Ch3tV6/s7lPibJgoTEW0deNYNqM81GDoUh1PmdHYE8RVLA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "355914a1-7174-4328-9113-b079d74980d5", "AQAAAAEAACcQAAAAEKdQoYM9m0jWRH9C4AfASHx+CPPV//BLpxVgU6tpZyfu9bEahvUytiv443pcS6ic6A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 195, DateTimeKind.Utc).AddTicks(7498),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 181, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 182, DateTimeKind.Utc).AddTicks(6530),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 118, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 197, DateTimeKind.Utc).AddTicks(2371),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 186, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 156, DateTimeKind.Utc).AddTicks(5854),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 73, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5157),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5561),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5425),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 139, DateTimeKind.Utc).AddTicks(8482),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 18, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "f39faae6-cb1a-4850-bcdd-419d0323682d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "24346a69-efe1-42df-938e-12670ebdfb28");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "2abb46bc-3078-4ae3-a344-578e9515a276");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "2b4cad08-9fbb-4f05-9256-b48cac974e95");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da350d9c-4a62-45b8-a74b-912379085838", "AQAAAAEAACcQAAAAEIolcZcFBKt/xvDuKOcFeXVcRnRv0FDOUaDZQVT3cks1buUDEaV85Ctlt8FYWVojpQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88d9ee19-0c15-4761-adcf-bb13b674a513", "AQAAAAEAACcQAAAAEPvJcARfxyUB8ANfSmadKKqT4zRBYSJcIVARWFpQfh3nVLfWBeYgx+e1L1TdQg6WGw==" });
        }
    }
}
