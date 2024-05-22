using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddShortDescriptionInHotelTranslation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 253, DateTimeKind.Utc).AddTicks(4590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 919, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 233, DateTimeKind.Utc).AddTicks(9194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 905, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 255, DateTimeKind.Utc).AddTicks(7663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 920, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "HotelTranslations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 214, DateTimeKind.Utc).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 887, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(6998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(7456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(7316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 196, DateTimeKind.Utc).AddTicks(1653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 870, DateTimeKind.Utc).AddTicks(6666));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "HotelTranslations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 919, DateTimeKind.Utc).AddTicks(2400),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 253, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 905, DateTimeKind.Utc).AddTicks(7727),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 233, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 920, DateTimeKind.Utc).AddTicks(7139),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 255, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 887, DateTimeKind.Utc).AddTicks(4509),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 214, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4071),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4468),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4331),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 211, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 870, DateTimeKind.Utc).AddTicks(6666),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 28, 5, 30, 41, 196, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "86d8ace0-738d-468f-bb19-17d0509ae2e8");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "25e2fba4-7519-4360-9af5-ec7655946a21");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "28fb370c-574f-4ec6-a9be-d1d2716994e6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "80002b79-b1d0-40dd-a95d-a13162e6d5b9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0de2488f-bc60-461b-bcec-1afc8c09b99e", "AQAAAAEAACcQAAAAEEIxO62ez39H/HNDY8Z0XK+aW+ohurfSCEWrPvYPLuymGEVA5VSmZ1GvN3DU42LA4g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86ad4a3b-3e28-445f-996c-00e58ef1babd", "AQAAAAEAACcQAAAAEBNYSdH3L+nMn+sy+x+CZTVXr6Qm7o2Us19/tHcyRHTQ4CrhTl3HjfevrNy2VypaKw==" });
        }
    }
}
