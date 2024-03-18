using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class ChangeServicetoServiceHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 302, DateTimeKind.Utc).AddTicks(6578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 192, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 290, DateTimeKind.Utc).AddTicks(7758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 178, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 304, DateTimeKind.Utc).AddTicks(4278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 195, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 260, DateTimeKind.Utc).AddTicks(5128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 166, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 248, DateTimeKind.Utc).AddTicks(6560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 248, DateTimeKind.Utc).AddTicks(6994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 248, DateTimeKind.Utc).AddTicks(6854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 244, DateTimeKind.Utc).AddTicks(2016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 144, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "e0d0be7a-f6a6-4f34-9b53-43bd26aefbd5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "2a1c35c2-82ee-41cd-93ab-780e5a738093");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "7c988bbc-16b4-4540-ab5e-6558af1ac373");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "9469b7d0-76dd-486a-9e7d-e6327bed4c45");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "273505bf-6867-4727-82b9-d85d9b489f13", "AQAAAAEAACcQAAAAEFQaK5tHMzr65pGMnAvzHpjQlcJOVyee7mTVja5lGdVbd3w+6CUlbrdnd1UIZROKVQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d701eb5-3bed-4813-a990-228f97474537", "AQAAAAEAACcQAAAAELHF2XfOl2qlfUg2KJGCw4tr7Xx+ByjOdpMbBZ0TfyxA12Er4Ra+NeUj9v2u1HFHwA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 192, DateTimeKind.Utc).AddTicks(9786),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 302, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 178, DateTimeKind.Utc).AddTicks(8522),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 290, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 195, DateTimeKind.Utc).AddTicks(4962),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 304, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 166, DateTimeKind.Utc).AddTicks(2134),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 260, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(8516),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 248, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(9224),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 248, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(9079),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 248, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 144, DateTimeKind.Utc).AddTicks(2949),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 6, 7, 51, 244, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "97295214-2297-4329-a75c-60c4ad968d4e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "0af7ea41-d6a1-4c1d-a32a-809a96057ad6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "eec8ea3d-541a-44c7-ac65-35fc6c50294f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "8acc8419-0303-4a80-bf78-b6f2a21c3742");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7071fa2-112a-4602-b0c8-4eae024b575f", "AQAAAAEAACcQAAAAEA0rColeUuE6oeZM1IAY0U+gnaylQX/2GU20gB48ONDq7hk+ECsAY3ZBLgVXYPbBGg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe37396e-ab1e-4ad0-941e-9b112a9abddf", "AQAAAAEAACcQAAAAEAjsH4xjsOP2ty+vwrD/rOnhSyxDIxOYDITz9Gmn8uYB/CAbvNJfhUw0lIfiM/GP8A==" });
        }
    }
}
