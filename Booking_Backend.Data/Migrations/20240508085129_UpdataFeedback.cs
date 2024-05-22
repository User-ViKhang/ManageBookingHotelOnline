using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdataFeedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 377, DateTimeKind.Utc).AddTicks(9248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 81, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 364, DateTimeKind.Utc).AddTicks(2538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 62, DateTimeKind.Utc).AddTicks(1818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 379, DateTimeKind.Utc).AddTicks(4863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 83, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.AddColumn<int>(
                name: "CleanlinessScores",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComfortScore",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacilitiesScore",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationScore",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StaffScore",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValueScore",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 344, DateTimeKind.Utc).AddTicks(7746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 32, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(6908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(7313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(7173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 15, 51, 28, 385, DateTimeKind.Local).AddTicks(221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 15, 47, 40, 90, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 382, DateTimeKind.Utc).AddTicks(9316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 87, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 331, DateTimeKind.Utc).AddTicks(2026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 15, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "ddc5a65d-7fdd-43a6-b6f8-587ab22b2c91");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "14d6ca25-7b3a-473f-887a-e7b79bdd8c6e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "2da2d008-8818-4780-a89b-f4d804d3a23a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "c581b2d8-e6b9-470a-a261-41bce9d27c38");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2db2e6a7-7d16-4c6d-a929-c4b21953def3", "AQAAAAEAACcQAAAAEFS09UumCo33uIVBRE9qRe+gvKnYBVuLHRhgMp2NRD8D8TpGjiovvDLeia5/Hmlm5A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84933310-95c1-42df-95cd-7a69289773ea", "AQAAAAEAACcQAAAAEBxUvaXdHU9L0LOIjpSYFBJc0rFVL64JRx0SwR2gcHgDdKezsztmxGQZjtWTX2NTrw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CleanlinessScores",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "ComfortScore",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "FacilitiesScore",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "LocationScore",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "StaffScore",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "ValueScore",
                table: "Hotels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 81, DateTimeKind.Utc).AddTicks(4201),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 377, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 62, DateTimeKind.Utc).AddTicks(1818),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 364, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 83, DateTimeKind.Utc).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 379, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 32, DateTimeKind.Utc).AddTicks(8368),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 344, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7353),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7793),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 28, DateTimeKind.Utc).AddTicks(7633),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 341, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 15, 47, 40, 90, DateTimeKind.Local).AddTicks(2150),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 15, 51, 28, 385, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 87, DateTimeKind.Utc).AddTicks(5669),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 382, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 8, 8, 47, 40, 15, DateTimeKind.Utc).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 8, 8, 51, 28, 331, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "a9a29792-ccb9-4960-a4f7-06d545d44a92");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "efe4f406-4e0a-44f3-92fa-90a4e0701e7e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "9381eb16-e14b-4790-8704-2fbd996e7f42");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "07498440-a657-482d-b965-0f379dc93626");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "316c7993-0ac1-460c-98cf-d1e6292bcf4a", "AQAAAAEAACcQAAAAEAfmAtviH0AvjgINmqc8anIlZbno89KY61aB9ycVaeYnyh0BAVDZxf6OZfxwdIxI3g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d6ce466-bb54-4be5-8356-b3305faaa86f", "AQAAAAEAACcQAAAAEMrIRCbLcyxazF/r2Mkk3O0BvW7fygNiWa4dPF1sbL8RE/XBRGCCktUz8eD1ki0e1w==" });
        }
    }
}
