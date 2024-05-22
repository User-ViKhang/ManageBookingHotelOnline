using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddFieldThumbnailInHotelEF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 928, DateTimeKind.Utc).AddTicks(4060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 253, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 912, DateTimeKind.Utc).AddTicks(2152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 233, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 929, DateTimeKind.Utc).AddTicks(9548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 255, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Hotels",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 881, DateTimeKind.Utc).AddTicks(1061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 214, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(41),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 858, DateTimeKind.Utc).AddTicks(1715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 196, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "8401a181-1b82-47dc-af6c-1339e33b0760");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "3ed40fa6-a73e-489a-abc9-8087543e1cb9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "b6b12a8c-4590-415d-965d-46e88f454465");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "d9342ddb-06aa-4043-b229-162fefb05394");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c6d62ea-bac4-4952-8950-061a748bc53b", "AQAAAAEAACcQAAAAEB4+w6NdUKQ3vGw2+BQqA1DkPO2PwsInmPiHu7UGcq8w0g0Mpw/wzOZO5x8r8u5l0A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12214cbf-56c1-4391-a990-aadf5016c632", "AQAAAAEAACcQAAAAENuAt72LfbpiC5UBoEl45f8hvU8DEBJdGrh7UObDWI8P8zo64nEAB8p9cTg2UrzOKA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Hotels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 253, DateTimeKind.Utc).AddTicks(4590),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 928, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 233, DateTimeKind.Utc).AddTicks(9194),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 912, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 255, DateTimeKind.Utc).AddTicks(7663),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 929, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 214, DateTimeKind.Utc).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 881, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(6998),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(7456),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(7316),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 196, DateTimeKind.Utc).AddTicks(1653),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 858, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "4b8d6f3c-79e2-4bba-a1f4-61671e69c4e2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "01586ab1-23c8-4e7f-9059-654bd191721e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "3a696d9f-e6b7-43c4-b0db-7f2c2cbbc0e2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "014cbe25-0a2c-48f7-8b4f-258183c42870");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a483380d-14ff-4ba9-8199-75ea4b3803a0", "AQAAAAEAACcQAAAAEESFcCA5BXDbO4gRFQfgF1HuiHArmWSxLOWVqHEiUAIGzrIZCdmyHWGP3fcn0n89eg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b0ea94b-7c1c-41fd-9d92-58b52026fa0e", "AQAAAAEAACcQAAAAEJ+8wqqGf1GD5ytXw8aDILJCnUI6pNoYebVgHO+T+YIle74tsLLWKujQKA3KFdOsRQ==" });
        }
    }
}
