using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 120, DateTimeKind.Utc).AddTicks(6657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 619, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 103, DateTimeKind.Utc).AddTicks(2609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 588, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 123, DateTimeKind.Utc).AddTicks(2139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 623, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 76, DateTimeKind.Utc).AddTicks(665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 540, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 72, DateTimeKind.Utc).AddTicks(9900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 73, DateTimeKind.Utc).AddTicks(592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 73, DateTimeKind.Utc).AddTicks(369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 54, DateTimeKind.Utc).AddTicks(6453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 478, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Properties = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationTranslation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Language_Id = table.Column<string>(nullable: false),
                    Location_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationTranslation_Locations_Location_Id",
                        column: x => x.Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "31434fe7-2866-4ad6-9676-39e6abb79c72");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "6be9ac3d-19ab-4a8b-bcd4-af7223f2e0ba");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "56529639-77c6-43e7-9e0f-34af3194d8df");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "5a04807a-e60f-4103-bbf3-b5075e4c0f2b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "702941a1-e530-4991-b45e-b955d609016a", "AQAAAAEAACcQAAAAEB41FFWzKByFhH/uTGwTYvgWi1tE0GMZ+f2EMlqO7IhEGXlYjo+7HzGiILPXKjg2pw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbf16731-9a42-4675-8b9b-81915fa65f20", "AQAAAAEAACcQAAAAELdD/+VdXc6BqrSqAloZ6MnUQNhzY0lHgb6jZrbiGcKWEjnhdjdlJPTrNOvP4SHkMg==" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationTranslation_Location_Id",
                table: "LocationTranslation",
                column: "Location_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationTranslation");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 619, DateTimeKind.Utc).AddTicks(9567),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 120, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 588, DateTimeKind.Utc).AddTicks(8620),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 103, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 623, DateTimeKind.Utc).AddTicks(4305),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 123, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 540, DateTimeKind.Utc).AddTicks(2187),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 76, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(5822),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 72, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(6607),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 73, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 526, DateTimeKind.Utc).AddTicks(6385),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 73, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 7, 9, 35, 478, DateTimeKind.Utc).AddTicks(7740),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 54, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "4b71b997-b812-4190-bc9f-49b3e26d2743");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "a1e80df5-5036-4f41-ae22-b794a33be5da");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "f05e2845-8e51-4b70-b288-97909a8fac83");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "442fe24b-46fc-43a8-961b-6ebb5bd6fdd6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4909512e-f579-4f5e-b93e-ddca33dc84fc", "AQAAAAEAACcQAAAAEA49xbPAQKXLDXHn5CHRR9UjM641zfrYhnrv4XjQStgqS2mMXaX+HATgW/j3AWSpmQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d32314d8-f96f-4b37-a7e0-900aa572e3b6", "AQAAAAEAACcQAAAAEGAxL6GCIAsMkKFzGiZuh3KlSx54vtTvpFUTJvDHWoT8JdHFdUsP6XmVI5A+v0G7sg==" });
        }
    }
}
