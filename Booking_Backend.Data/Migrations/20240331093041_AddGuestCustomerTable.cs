using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddGuestCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 557, DateTimeKind.Utc).AddTicks(1938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 928, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 539, DateTimeKind.Utc).AddTicks(1713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 912, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 559, DateTimeKind.Utc).AddTicks(4157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 929, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 512, DateTimeKind.Utc).AddTicks(6020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 881, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.AddColumn<int>(
                name: "GuestCustomer_Id",
                table: "Bookings",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 488, DateTimeKind.Utc).AddTicks(8480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 858, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.CreateTable(
                name: "GuestCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Nation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestCustomers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "763c7134-476e-44a8-8008-8dfcdece925b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "0b5589b6-2508-4433-965d-633e6bf8651a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "47e3d9af-ed74-4aa4-9208-0aaec35cc44c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "4bda9566-db62-4cd2-8e1d-0dadc7b62b5b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94d98b3f-d0d6-4e14-a17b-042a01ffe4d3", "AQAAAAEAACcQAAAAEH9Q3q8BLJDGRcK8e/7pqDUMu22tLOQnDJMCYxUPbKpwJpDQhVQMH6yy0YdkpgCYaQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53d9618e-fa9c-460f-8de6-e4eeecf5484b", "AQAAAAEAACcQAAAAELxeeSd84MfzUPyD9ZMqf4xmSIe8PQgBphqerplAVxmGjqmTEzIa8u2wRO6kEdEpsQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_GuestCustomer_Id",
                table: "Bookings",
                column: "GuestCustomer_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_GuestCustomers_GuestCustomer_Id",
                table: "Bookings",
                column: "GuestCustomer_Id",
                principalTable: "GuestCustomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_GuestCustomers_GuestCustomer_Id",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "GuestCustomers");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_GuestCustomer_Id",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "GuestCustomer_Id",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 928, DateTimeKind.Utc).AddTicks(4060),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 557, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 912, DateTimeKind.Utc).AddTicks(2152),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 539, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 929, DateTimeKind.Utc).AddTicks(9548),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 559, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 881, DateTimeKind.Utc).AddTicks(1061),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 512, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(41),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(613),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 878, DateTimeKind.Utc).AddTicks(413),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 28, 16, 49, 53, 858, DateTimeKind.Utc).AddTicks(1715),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 488, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "8401a181-1b82-47dc-af6c-1339e33b0760");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "3ed40fa6-a73e-489a-abc9-8087543e1cb9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "b6b12a8c-4590-415d-965d-46e88f454465");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "d9342ddb-06aa-4043-b229-162fefb05394");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c6d62ea-bac4-4952-8950-061a748bc53b", "AQAAAAEAACcQAAAAEB4+w6NdUKQ3vGw2+BQqA1DkPO2PwsInmPiHu7UGcq8w0g0Mpw/wzOZO5x8r8u5l0A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12214cbf-56c1-4391-a990-aadf5016c632", "AQAAAAEAACcQAAAAENuAt72LfbpiC5UBoEl45f8hvU8DEBJdGrh7UObDWI8P8zo64nEAB8p9cTg2UrzOKA==" });
        }
    }
}
