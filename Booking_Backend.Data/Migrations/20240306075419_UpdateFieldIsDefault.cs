using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdateFieldIsDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "UserImages",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 124, DateTimeKind.Utc).AddTicks(2280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 515, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.AddColumn<bool>(
                name: "isDefault",
                table: "UserImages",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 110, DateTimeKind.Utc).AddTicks(2493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 501, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 89, DateTimeKind.Utc).AddTicks(2518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 491, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(1111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 60, DateTimeKind.Utc).AddTicks(6121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 473, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "e4029608-01dd-4761-9fdc-14e1c6db6790");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "9a9182c5-b94b-494d-8336-4513b8f9a0cf");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "04fd38b2-d513-465c-a1f7-b1cabd50b50a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "ab4e6508-c538-4072-aa4c-abad1bf2729b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f10b3dae-57d4-4367-8682-f99231ba7e69", "AQAAAAEAACcQAAAAEDuPa2mCDM+J1//uSqaV6gy2hWP6e0yePUbihZrRGAi3e5I6BuctWK7huKL9a16TeA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4134b1dd-21f3-4c3f-95a3-5959eb4ef92b", "AQAAAAEAACcQAAAAEODRQYiu5PbMXKMkAMHvaOqeUWkTJmxLARdd9p4uPES3Jm2ILzWvOSkRsW427KXvVg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDefault",
                table: "UserImages");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "UserImages",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 515, DateTimeKind.Utc).AddTicks(2143),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 124, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 501, DateTimeKind.Utc).AddTicks(7017),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 110, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 491, DateTimeKind.Utc).AddTicks(4402),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 89, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(3643),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(4159),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(3977),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 473, DateTimeKind.Utc).AddTicks(6955),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 60, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "ddb4ef42-36d7-4bf3-8ea4-4a1650b6a31c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "8cf3de67-c4a8-4e91-b74f-04827b2cb53c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "7ac23bad-b982-4b2d-8892-b71570317857");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "3fcb11f1-26ec-4db2-93bb-5cd059695d3a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8754c0ea-3f77-4a2e-970d-cafc3f43de28", "AQAAAAEAACcQAAAAEJ1Ob+v7UyxYo3W+hAvIdP6tsy7EkivKTgXGu3oRFwPv3cfcTea9RlfgR2BmWIcXqw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "151c853f-ced8-43bd-b801-ee4572e49172", "AQAAAAEAACcQAAAAEF5E/K9eUE5U+ONIMShFCx/omvIPSYUb1a11FNwPgEjizxANYYCZDK6JGsVt7e8mbQ==" });
        }
    }
}
