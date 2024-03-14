using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddHotelTypeImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 192, DateTimeKind.Utc).AddTicks(9786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 124, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 178, DateTimeKind.Utc).AddTicks(8522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 110, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 166, DateTimeKind.Utc).AddTicks(2134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 89, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(8516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(9224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(9079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 144, DateTimeKind.Utc).AddTicks(2949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 60, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.CreateTable(
                name: "HotelTypeImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ImageSize = table.Column<decimal>(type: "decimal", nullable: false),
                    ImageUrl = table.Column<string>(type: "varchar(255)", nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 195, DateTimeKind.Utc).AddTicks(4962)),
                    isDefault = table.Column<bool>(nullable: false, defaultValue: true),
                    HotelType_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTypeImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelTypeImages_HotelTypes_HotelType_Id",
                        column: x => x.HotelType_Id,
                        principalTable: "HotelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_HotelTypeImages_HotelType_Id",
                table: "HotelTypeImages",
                column: "HotelType_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelTypeImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 124, DateTimeKind.Utc).AddTicks(2280),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 192, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 110, DateTimeKind.Utc).AddTicks(2493),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 178, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 89, DateTimeKind.Utc).AddTicks(2518),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 166, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(719),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(1111),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 67, DateTimeKind.Utc).AddTicks(992),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 150, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 7, 54, 18, 60, DateTimeKind.Utc).AddTicks(6121),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 12, 6, 35, 19, 144, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "e4029608-01dd-4761-9fdc-14e1c6db6790");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "9a9182c5-b94b-494d-8336-4513b8f9a0cf");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "04fd38b2-d513-465c-a1f7-b1cabd50b50a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "ab4e6508-c538-4072-aa4c-abad1bf2729b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f10b3dae-57d4-4367-8682-f99231ba7e69", "AQAAAAEAACcQAAAAEDuPa2mCDM+J1//uSqaV6gy2hWP6e0yePUbihZrRGAi3e5I6BuctWK7huKL9a16TeA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4134b1dd-21f3-4c3f-95a3-5959eb4ef92b", "AQAAAAEAACcQAAAAEODRQYiu5PbMXKMkAMHvaOqeUWkTJmxLARdd9p4uPES3Jm2ILzWvOSkRsW427KXvVg==" });
        }
    }
}
