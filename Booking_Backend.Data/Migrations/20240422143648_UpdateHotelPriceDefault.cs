using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdateHotelPriceDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 260, DateTimeKind.Utc).AddTicks(2907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 317, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 247, DateTimeKind.Utc).AddTicks(6040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 304, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 261, DateTimeKind.Utc).AddTicks(8353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 319, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.AddColumn<decimal>(
                name: "PriceDefault",
                table: "Hotels",
                nullable: true,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 226, DateTimeKind.Utc).AddTicks(9160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 284, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 21, 36, 47, 267, DateTimeKind.Local).AddTicks(484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 9, 34, 31, 324, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 265, DateTimeKind.Utc).AddTicks(3506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 322, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 208, DateTimeKind.Utc).AddTicks(5657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 267, DateTimeKind.Utc).AddTicks(2090));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceDefault",
                table: "Hotels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 317, DateTimeKind.Utc).AddTicks(4737),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 260, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 304, DateTimeKind.Utc).AddTicks(2236),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 247, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 319, DateTimeKind.Utc).AddTicks(314),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 261, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 284, DateTimeKind.Utc).AddTicks(9109),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 226, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(504),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(919),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(780),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 224, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 9, 34, 31, 324, DateTimeKind.Local).AddTicks(2066),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 21, 36, 47, 267, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 322, DateTimeKind.Utc).AddTicks(4128),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 265, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 267, DateTimeKind.Utc).AddTicks(2090),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 14, 36, 47, 208, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "2a91fc50-8922-4588-afde-922b447105d0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "e28d7f9d-c25c-4b0b-b04d-9f2bf619d4d0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "7b636698-65b2-4ec9-8a1b-c047f8d0292a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "202c8206-c7fe-439d-b04b-a017f860a69b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d29edc3-041d-43e8-89b4-37c26c78d21e", "AQAAAAEAACcQAAAAEAEQTN/OugHDDmDDgeGu24p6ZBpYjdkBhxkl7Chej36vvmH3rUf5KtAgREQPvLhOaQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9110126-445c-4fad-85c3-f63b9849a890", "AQAAAAEAACcQAAAAEExeLIpKf+rVDg13ehkwztlqRrmMhr61oj2EVtQS8oP0W7S0/2PGKK9kuAN8M1YI5A==" });
        }
    }
}
