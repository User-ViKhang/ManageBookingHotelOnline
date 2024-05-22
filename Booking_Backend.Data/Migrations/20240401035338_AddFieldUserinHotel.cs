using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddFieldUserinHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 44, DateTimeKind.Utc).AddTicks(6948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 844, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 31, DateTimeKind.Utc).AddTicks(1277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 829, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 46, DateTimeKind.Utc).AddTicks(1654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 846, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.AddColumn<Guid>(
                name: "User_Id",
                table: "Hotels",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 9, DateTimeKind.Utc).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 808, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 1, 3, 53, 36, 993, DateTimeKind.Utc).AddTicks(1540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 790, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "3b5db0a0-cb89-4517-9819-8cc2723934b6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "7b329ed7-4f4c-4653-8927-acc00a3af836");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "38da799f-6180-462b-be8c-d1d89bb619ed");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "c6682c08-da8d-47ef-9c5d-f2c190f23b9f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a9cbaaa-cd82-469d-bd7e-9774a911fa83", "AQAAAAEAACcQAAAAEF7tFDYBW5mdC8rvHJluU5QJpPTU7ZwXTyXsKusgwgDEqifeR7n66n4yNmPt0kDNNQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "05e6907c-621a-470e-a227-04676c5e7f3b", "AQAAAAEAACcQAAAAEElH81uS3QtmINbvHYTZ58GWkoB+poCmGUjaQrEpn86UzQGugRCXAXqkF/BAovidJA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_User_Id",
                table: "Hotels",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_AppUsers_User_Id",
                table: "Hotels",
                column: "User_Id",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_AppUsers_User_Id",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_User_Id",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "Hotels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 844, DateTimeKind.Utc).AddTicks(6049),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 44, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 829, DateTimeKind.Utc).AddTicks(9891),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 31, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 846, DateTimeKind.Utc).AddTicks(6551),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 46, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 808, DateTimeKind.Utc).AddTicks(6537),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 9, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(130),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(554),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 806, DateTimeKind.Utc).AddTicks(421),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 37, 7, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 14, 50, 55, 790, DateTimeKind.Utc).AddTicks(4773),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 1, 3, 53, 36, 993, DateTimeKind.Utc).AddTicks(1540));

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
    }
}
