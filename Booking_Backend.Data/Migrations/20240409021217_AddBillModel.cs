using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddBillModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 371, DateTimeKind.Utc).AddTicks(76),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 748, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.AddColumn<int>(
                name: "BillId",
                table: "Room_Bookings",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 355, DateTimeKind.Utc).AddTicks(5110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 733, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 372, DateTimeKind.Utc).AddTicks(4906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 750, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 333, DateTimeKind.Utc).AddTicks(5944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 714, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(2688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(3262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(3070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 314, DateTimeKind.Utc).AddTicks(1753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 696, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<Guid>(nullable: false),
                    GuestCustomer_Id = table.Column<int>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 375, DateTimeKind.Utc).AddTicks(8492))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_GuestCustomers_GuestCustomer_Id",
                        column: x => x.GuestCustomer_Id,
                        principalTable: "GuestCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_AppUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "ac8097cf-a40c-4618-bbcf-216fc22f40e9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "6378028f-1dbd-4fa6-a8b0-bb099d45c8db");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "1a001095-5225-45de-9b44-22bc1f62ff2f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "d4cd5435-3578-47ff-9416-f90888122626");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "577d7a3b-f069-47bd-85f0-7ae9742252fa", "AQAAAAEAACcQAAAAEHkxD1zvylbq8jCwNOrHZ2Pa1FXPw0D2cXbNQv1meBei+xM+LqSHhndRkFHZ2civ1Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac5a88c1-c564-4988-ae8c-4cc9af337a16", "AQAAAAEAACcQAAAAEJXAySUTEUJx2isEUgP55yc4mUrsq4HeQFmn8P9lRSvnao0yXrGeVm1iEeg6Ps6Ciw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Room_Bookings_BillId",
                table: "Room_Bookings",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_GuestCustomer_Id",
                table: "Bills",
                column: "GuestCustomer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_User_Id",
                table: "Bills",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Bookings_Bills_BillId",
                table: "Room_Bookings",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Bookings_Bills_BillId",
                table: "Room_Bookings");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Room_Bookings_BillId",
                table: "Room_Bookings");

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "Room_Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 748, DateTimeKind.Utc).AddTicks(9015),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 371, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 733, DateTimeKind.Utc).AddTicks(9068),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 355, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 750, DateTimeKind.Utc).AddTicks(4895),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 372, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 714, DateTimeKind.Utc).AddTicks(9472),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 333, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1046),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1450),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1316),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 329, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 696, DateTimeKind.Utc).AddTicks(7777),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 2, 12, 16, 314, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "f3dab3f4-646a-4941-bc44-a954b21eab09");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "a45d8d10-17dd-4835-b2ab-86df33fb8e48");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "aaa7358f-c2c1-4c75-bd08-3c19c5e49224");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "7cfa7005-d754-4725-84d2-dc06f71ad98b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "784293ca-f28f-4aaf-b987-5163d0df2960", "AQAAAAEAACcQAAAAEJu6PRURQvMzUIr5g1iLv7vkE1AbKeZ4jKM5IPJCCHDMv9OJdGBN4UzPogrQtH7nTQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bb17a9f-b284-45ce-8b35-057f6b4b3130", "AQAAAAEAACcQAAAAEGd1UOCntEd4Ao0LPeMRr8Y/P3dZsxAlJIbkb/3K0qtO/jx0gjjwgHQMVaSHykSmVw==" });
        }
    }
}
