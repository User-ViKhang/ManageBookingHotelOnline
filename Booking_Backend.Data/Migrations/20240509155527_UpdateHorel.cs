using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdateHorel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 764, DateTimeKind.Utc).AddTicks(7172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 266, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 752, DateTimeKind.Utc).AddTicks(1807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 250, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 766, DateTimeKind.Utc).AddTicks(1863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 268, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                table: "Hotels",
                type: "decimal(3,1)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true,
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 732, DateTimeKind.Utc).AddTicks(2056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 220, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(1805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(2205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(2068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 22, 55, 26, 771, DateTimeKind.Local).AddTicks(4494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 8, 44, 21, 274, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 769, DateTimeKind.Utc).AddTicks(6898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 272, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 718, DateTimeKind.Utc).AddTicks(8474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 199, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "ea820c7d-f73f-4efe-a5da-644b2f796d4e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "14b65a0e-94b6-4214-96b8-34046fd8802a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "7f880eb1-7730-484b-9d01-cb26c4bec09f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "3f32baa3-3144-48cc-860c-c0c37ea3f694");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1bcd1f3a-74c5-44b4-9e43-13eb0a8396ff", "AQAAAAEAACcQAAAAEGVSz525v6tEJSYvf7iMV++gnD0LZsYDsiUB2P5XFXqZ3OAMQqwm33ZnZyvsotxHfA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbbefcef-e105-4c9d-9975-f4b5fe969fc1", "AQAAAAEAACcQAAAAEAg01ou8sldtxxdx1gfgcy1iwucuxSGUnhKsaMyx7rF/FH42KDZY2xIzoZColJxPsQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 266, DateTimeKind.Utc).AddTicks(3095),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 764, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 250, DateTimeKind.Utc).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 752, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 268, DateTimeKind.Utc).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 766, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                table: "Hotels",
                type: "decimal(18,2)",
                nullable: true,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 220, DateTimeKind.Utc).AddTicks(2010),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 732, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(3993),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(1805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(4470),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 213, DateTimeKind.Utc).AddTicks(4265),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 8, 44, 21, 274, DateTimeKind.Local).AddTicks(621),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 22, 55, 26, 771, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 272, DateTimeKind.Utc).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 769, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 1, 44, 21, 199, DateTimeKind.Utc).AddTicks(7377),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 718, DateTimeKind.Utc).AddTicks(8474));

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
    }
}
