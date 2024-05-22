using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddTableCommentUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 685, DateTimeKind.Utc).AddTicks(5025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 859, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 669, DateTimeKind.Utc).AddTicks(1444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 846, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 687, DateTimeKind.Utc).AddTicks(2769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 861, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 641, DateTimeKind.Utc).AddTicks(5291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 826, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.AddColumn<int>(
                name: "CountComment",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 637, DateTimeKind.Utc).AddTicks(6982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 637, DateTimeKind.Utc).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 637, DateTimeKind.Utc).AddTicks(7281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 11, 12, 59, 693, DateTimeKind.Local).AddTicks(9767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 31, 16, 866, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 691, DateTimeKind.Utc).AddTicks(7523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 865, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 625, DateTimeKind.Utc).AddTicks(3341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 812, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.CreateTable(
                name: "Comment_Users",
                columns: table => new
                {
                    Comment_Id = table.Column<int>(nullable: false),
                    User_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment_Users", x => new { x.Comment_Id, x.User_Id });
                    table.ForeignKey(
                        name: "FK_Comment_Users_Comments_Comment_Id",
                        column: x => x.Comment_Id,
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_Users_AppUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "4bf0d0ab-a296-4602-a78d-2d79e732b18c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "2da31cde-9f50-477a-b58f-28edf6e68a4e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "c4779b59-914b-4e9d-9e55-4b163dfd1e0b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "61a4717b-c50b-4419-9a40-bb7f30e8742a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e006bed-dd0f-48d7-b141-313f94a06918", "AQAAAAEAACcQAAAAEFDHHL3k3cSFWiq01R8QXaBGLYCEGw7WPY1TsiWUS+fW3odKv/uSP2PpKgZ/zYvU/Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "236bce04-f6af-463d-af4c-7089ded574f4", "AQAAAAEAACcQAAAAEJf+YqO4H+6aiSPXygW1iGf+Yglns5906PayhdF/UMAGBFEI3IFpeXE950V8y0Ch3g==" });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_Users_User_Id",
                table: "Comment_Users",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment_Users");

            migrationBuilder.DropColumn(
                name: "CountComment",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 859, DateTimeKind.Utc).AddTicks(6387),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 685, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 846, DateTimeKind.Utc).AddTicks(6326),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 669, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 861, DateTimeKind.Utc).AddTicks(1501),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 687, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 826, DateTimeKind.Utc).AddTicks(3033),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 641, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(2619),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 637, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(3065),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 637, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(2935),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 637, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 31, 16, 866, DateTimeKind.Local).AddTicks(8512),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 11, 12, 59, 693, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 865, DateTimeKind.Utc).AddTicks(523),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 691, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 812, DateTimeKind.Utc).AddTicks(4969),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 12, 4, 12, 59, 625, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "a9c5c261-b3a1-4325-a63e-faab2b1910cb");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "478fa20c-589a-4488-9047-8cac27fe79c0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "f31bae63-e01a-4999-bb68-269d4e1b03c0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "a63e595f-1d66-463d-9d8f-535108052b9f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbbfb4b9-eb97-4820-b768-66122e455b8b", "AQAAAAEAACcQAAAAEOGRXeCcOL2WGBhPzUmqB7a27gYp/+wf8jtljxkusHOCr4Jjif7sm1EGdVg/mCUaNg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6491fe4a-d657-4a77-ab5c-33d81f1ad07f", "AQAAAAEAACcQAAAAEAcQWzN6OdFzCGJihvX22UV+D86ddx2/f3T1cEl2GlzcidrtFM1DOfy39niNvNbryg==" });
        }
    }
}
