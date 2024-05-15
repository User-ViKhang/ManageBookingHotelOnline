using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddTablefeedbackCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 256, DateTimeKind.Utc).AddTicks(3218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 341, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 239, DateTimeKind.Utc).AddTicks(5075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 324, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 258, DateTimeKind.Utc).AddTicks(4606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 343, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 220, DateTimeKind.Utc).AddTicks(2394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 294, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 23, 30, 0, 266, DateTimeKind.Local).AddTicks(4451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 12, 35, 30, 352, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 262, DateTimeKind.Utc).AddTicks(7763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 348, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 205, DateTimeKind.Utc).AddTicks(2300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 271, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.CreateTable(
                name: "FeedbackCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    HotelId = table.Column<int>(nullable: false),
                    StaffScore = table.Column<int>(nullable: false, defaultValue: 0),
                    ComfortScore = table.Column<int>(nullable: false, defaultValue: 0),
                    FacilitiesScore = table.Column<int>(nullable: false, defaultValue: 0),
                    CleanlinessScore = table.Column<int>(nullable: false, defaultValue: 0),
                    LocationScore = table.Column<int>(nullable: false, defaultValue: 0),
                    ValueScore = table.Column<int>(nullable: false, defaultValue: 0),
                    Score = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedbackCustomers_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedbackCustomers_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "d91797a7-08cf-4180-ae99-adee0dcd1f51");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "dcc8562b-e2de-45ea-ab1c-bb3330685831");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "0b7f8414-4d9e-4a04-9050-c3cba4ca061e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "dff7d88a-05df-4778-bbd7-9c5f17355717");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "950a1a9d-2b3e-4deb-9f77-442459f7b074", "AQAAAAEAACcQAAAAEOlCL/kvQregzL1924t5U4Yecpep7jbJmBetlKJJv4t6cha4033UVLOFyIh4cpx3VQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "333ada93-51d0-4107-a2b0-8c352a98057e", "AQAAAAEAACcQAAAAEKIcCjdG80eMkAKNzArEmujIV20psHzzO+jap/5IzK7QSZEuwOhSLSfrPKBEP6bQtg==" });

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackCustomers_HotelId",
                table: "FeedbackCustomers",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackCustomers_UserId",
                table: "FeedbackCustomers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedbackCustomers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 341, DateTimeKind.Utc).AddTicks(6750),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 256, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 324, DateTimeKind.Utc).AddTicks(1344),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 239, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 343, DateTimeKind.Utc).AddTicks(4575),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 258, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 294, DateTimeKind.Utc).AddTicks(5813),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 220, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(2619),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(3057),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 290, DateTimeKind.Utc).AddTicks(2913),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 217, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 12, 35, 30, 352, DateTimeKind.Local).AddTicks(378),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 23, 30, 0, 266, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 348, DateTimeKind.Utc).AddTicks(5177),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 262, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 5, 35, 30, 271, DateTimeKind.Utc).AddTicks(807),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 5, 16, 30, 0, 205, DateTimeKind.Utc).AddTicks(2300));

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
    }
}
