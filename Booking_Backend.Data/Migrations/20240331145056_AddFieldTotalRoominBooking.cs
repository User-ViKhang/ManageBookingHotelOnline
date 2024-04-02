using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddFieldTotalRoominBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 844, DateTimeKind.Utc).AddTicks(6049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 131, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 829, DateTimeKind.Utc).AddTicks(9891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 116, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 846, DateTimeKind.Utc).AddTicks(6551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 132, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 808, DateTimeKind.Utc).AddTicks(6537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 97, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.AddColumn<int>(
                name: "TotalRoom",
                table: "Bookings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 790, DateTimeKind.Utc).AddTicks(4773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 79, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "bc0b2bce-8817-4362-8825-f8e21c384067");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "94a30262-07c1-4e1f-93a7-4baee50776aa");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "314f4a9b-d5a3-4a2e-8320-97bf27eeaf31");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "eeb1c95b-2afe-4f74-a8c7-f408e9415f17");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a4608fa-08bb-4d40-baae-9249a291a10e", "AQAAAAEAACcQAAAAEMA+BJmEFGAYZ6vrPs+97+5Q/YDT16NOmyofAOl0PsEm0CcUghzSIWYSO7zfHKRjTw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e08c308-b68e-450e-b49e-4bf85a526c6f", "AQAAAAEAACcQAAAAEGH1qdbWJ+N5dv3w+n83fCePIAGJ3I00dTWBEOsORkhD9qgzkzTFaZYjswGe7yUgpg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalRoom",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 131, DateTimeKind.Utc).AddTicks(2883),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 844, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 116, DateTimeKind.Utc).AddTicks(8282),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 829, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 132, DateTimeKind.Utc).AddTicks(9264),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 846, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 97, DateTimeKind.Utc).AddTicks(2215),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 808, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8478),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8883),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8748),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 79, DateTimeKind.Utc).AddTicks(7595),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 790, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "be31da09-0760-427c-8b53-765802fa0e16");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "5f2661df-e7b9-4cd3-b492-d2b0f0104ffc");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "4b1c424b-5f62-4dea-85e6-0a3e0d11ebca");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "e5060090-4c67-41fc-8cbb-002e2452b2e5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9382155e-2c29-49bb-a2b1-29320e3db257", "AQAAAAEAACcQAAAAEJcvdJog/xc840asD1AvtD/t+59/yRvnegEjNg/uez0j18LOnPo4XZQEP/cwDuCUgQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "803edc39-94ff-4098-b3dc-b95c9fb599c3", "AQAAAAEAACcQAAAAEGnM5SpCJBY9sDTUn/nP1gSRGD/uyg3Bsr1IYr+Ix5BYdk7qgUzFEr7g8p6y6tYbzA==" });
        }
    }
}
