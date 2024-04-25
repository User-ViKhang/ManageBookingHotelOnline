using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 341, DateTimeKind.Utc).AddTicks(6750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 260, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 324, DateTimeKind.Utc).AddTicks(1344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 247, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 343, DateTimeKind.Utc).AddTicks(4575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 261, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 294, DateTimeKind.Utc).AddTicks(5813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 226, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(2619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(3057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(2913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.AddColumn<int>(
                name: "Payment",
                table: "Bookings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 12, 35, 30, 352, DateTimeKind.Local).AddTicks(378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 21, 36, 47, 267, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 348, DateTimeKind.Utc).AddTicks(5177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 265, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 271, DateTimeKind.Utc).AddTicks(807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 208, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "fdda247d-f96d-4273-a562-f271ba504508");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "9c512c04-98b6-47fd-96d9-60ddae2834bf");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "27b7261c-204e-4b4b-89a6-6ecaccca1213");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "f7c58c02-75e6-4116-af1a-9c0d91f2f0ac");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c60a4f72-7dee-4cfe-a4e1-aee566d2d57b", "AQAAAAEAACcQAAAAECUUv6zzohnKxYNbGmUm0pfdzXc3n5RfZaQvcjDpBF9+Yde2M2+QMJvryxnR4jAG4A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d8ea170-dd21-416b-9ab4-fb4a8bc2ff85", "AQAAAAEAACcQAAAAEAn8Fi7NXGbyTSQiVlGHEX9JdfVzVL3eD9pEtvkcIB/y7G7otl7HOlmxHqONswbSrA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Payment",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 260, DateTimeKind.Utc).AddTicks(2907),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 341, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 247, DateTimeKind.Utc).AddTicks(6040),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 324, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 261, DateTimeKind.Utc).AddTicks(8353),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 343, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 226, DateTimeKind.Utc).AddTicks(9160),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 294, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(473),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(886),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(753),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 21, 36, 47, 267, DateTimeKind.Local).AddTicks(484),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 12, 35, 30, 352, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 265, DateTimeKind.Utc).AddTicks(3506),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 348, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 208, DateTimeKind.Utc).AddTicks(5657),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 271, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "f8336941-f150-470f-947e-e815932c5737");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "c9b2572f-d8c4-47e9-abbb-9e36793346e6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "7d9ed6b1-0363-433f-9709-080573e5ad21");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "90509a2f-1549-4732-a344-d513453dd5be");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce8a662b-353a-4564-9956-7845ab88ec1e", "AQAAAAEAACcQAAAAEDc1ayX15QTthOhbJzL56xXGZ2VsiqYtvinEmJyNtZEBctYxIwcF4vUE5EWnacWwow==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36495644-ff49-470a-a96f-84ab340d75f0", "AQAAAAEAACcQAAAAEKdRdlsLDOSXJMJZJdJLs4X7BfNbj/9lOWMr1ySY9AsDHwL1waGs1oCKYFOeElEUCg==" });
        }
    }
}
