using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddDeleteBehivior_Bed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 619, DateTimeKind.Utc).AddTicks(9567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 617, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 588, DateTimeKind.Utc).AddTicks(8620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 603, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 623, DateTimeKind.Utc).AddTicks(4305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 618, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 540, DateTimeKind.Utc).AddTicks(2187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 581, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(5822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(6607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(6385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 478, DateTimeKind.Utc).AddTicks(7740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 564, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "4b71b997-b812-4190-bc9f-49b3e26d2743");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "a1e80df5-5036-4f41-ae22-b794a33be5da");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "f05e2845-8e51-4b70-b288-97909a8fac83");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "442fe24b-46fc-43a8-961b-6ebb5bd6fdd6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4909512e-f579-4f5e-b93e-ddca33dc84fc", "AQAAAAEAACcQAAAAEA49xbPAQKXLDXHn5CHRR9UjM641zfrYhnrv4XjQStgqS2mMXaX+HATgW/j3AWSpmQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d32314d8-f96f-4b37-a7e0-900aa572e3b6", "AQAAAAEAACcQAAAAEGAxL6GCIAsMkKFzGiZuh3KlSx54vtTvpFUTJvDHWoT8JdHFdUsP6XmVI5A+v0G7sg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 617, DateTimeKind.Utc).AddTicks(2504),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 619, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 603, DateTimeKind.Utc).AddTicks(9058),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 588, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 618, DateTimeKind.Utc).AddTicks(7800),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 623, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 581, DateTimeKind.Utc).AddTicks(1086),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 540, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(600),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(1033),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 579, DateTimeKind.Utc).AddTicks(858),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 2, 31, 39, 564, DateTimeKind.Utc).AddTicks(6951),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 478, DateTimeKind.Utc).AddTicks(7740));

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
    }
}
