using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddFieldNoteinBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 131, DateTimeKind.Utc).AddTicks(2883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 222, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 116, DateTimeKind.Utc).AddTicks(8282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 205, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 132, DateTimeKind.Utc).AddTicks(9264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 224, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 97, DateTimeKind.Utc).AddTicks(2215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 179, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Bookings",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 79, DateTimeKind.Utc).AddTicks(7595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 154, DateTimeKind.Utc).AddTicks(8708));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 222, DateTimeKind.Utc).AddTicks(1526),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 131, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 205, DateTimeKind.Utc).AddTicks(3676),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 116, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 224, DateTimeKind.Utc).AddTicks(4208),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 132, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 179, DateTimeKind.Utc).AddTicks(2567),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 97, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4476),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4888),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4750),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 94, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 154, DateTimeKind.Utc).AddTicks(8708),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 28, 27, 79, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "f8db4b58-7613-4fc5-96c6-073d93703d03");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "017ada73-44f8-4ea6-97d0-8ad2417b66aa");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "163035ce-5527-4e34-a8a4-0389566f5a46");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "c8d51615-1a89-4cde-9a03-a2f37c8b9c76");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ee740cc-347c-44e3-b4d8-53edc7e171b1", "AQAAAAEAACcQAAAAEEd2Hp7o/Zbs2he9rUTg2TqnQyWzb8Cm09pf3wRPzvImeqiLmLFh4H3LbLrJ+EuV+w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44cca40b-f771-456a-a1e9-1651a7ac71fc", "AQAAAAEAACcQAAAAEBmWlhII62e6Lma5tWcb5NgGrW9N2fhndgiMK5aUSQpg9NYrXnJPeKKNmdIifYxWjQ==" });
        }
    }
}
