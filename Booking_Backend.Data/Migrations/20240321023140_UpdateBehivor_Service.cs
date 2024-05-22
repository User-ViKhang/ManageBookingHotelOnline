using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdateBehivor_Service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 617, DateTimeKind.Utc).AddTicks(2504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 181, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 603, DateTimeKind.Utc).AddTicks(9058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 118, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 618, DateTimeKind.Utc).AddTicks(7800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 186, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 581, DateTimeKind.Utc).AddTicks(1086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 73, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(1033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 564, DateTimeKind.Utc).AddTicks(6951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 18, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "809637bb-1ede-47ed-8c42-8662ad1ec284");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "c818c6ad-879c-4976-997d-00ada12ce672");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "1035e49e-e1f1-4a5b-87b5-219f8090d9df");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "2b69b609-10fd-4953-9f8f-759afb5af958");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bed35c92-68bf-42d6-ae31-7ba8005df124", "AQAAAAEAACcQAAAAEFAKHVHUrmZuPcGBgnh0VSr07z8E6OjV6BH9qxejaBfT00SzO9PbMTbCxmFx+0Uceg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c524b21-5026-4b94-82b0-ab57920d6a18", "AQAAAAEAACcQAAAAED6GruAqBJ9wKlFtAVj6V2r/4h5iBMjH0jWJDiTYttjlb1EBdE8Yct+T2apng2J78w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 181, DateTimeKind.Utc).AddTicks(8869),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 617, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 118, DateTimeKind.Utc).AddTicks(544),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 603, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 186, DateTimeKind.Utc).AddTicks(6885),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 618, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 73, DateTimeKind.Utc).AddTicks(9962),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 581, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(2644),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(3193),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 71, DateTimeKind.Utc).AddTicks(3022),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 6, 8, 39, 18, DateTimeKind.Utc).AddTicks(6691),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 564, DateTimeKind.Utc).AddTicks(6951));

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
    }
}
