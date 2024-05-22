using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdateFKBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AppUsers_User_Id",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 222, DateTimeKind.Utc).AddTicks(1526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 557, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 205, DateTimeKind.Utc).AddTicks(3676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 539, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 224, DateTimeKind.Utc).AddTicks(4208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 559, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 179, DateTimeKind.Utc).AddTicks(2567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 512, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.AlterColumn<Guid>(
                name: "User_Id",
                table: "Bookings",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 154, DateTimeKind.Utc).AddTicks(8708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 488, DateTimeKind.Utc).AddTicks(8480));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AppUsers_User_Id",
                table: "Bookings",
                column: "User_Id",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AppUsers_User_Id",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 557, DateTimeKind.Utc).AddTicks(1938),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 222, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 539, DateTimeKind.Utc).AddTicks(1713),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 205, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 559, DateTimeKind.Utc).AddTicks(4157),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 224, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 512, DateTimeKind.Utc).AddTicks(6020),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 179, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.AlterColumn<Guid>(
                name: "User_Id",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3031),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 509, DateTimeKind.Utc).AddTicks(3324),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 176, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 31, 9, 30, 40, 488, DateTimeKind.Utc).AddTicks(8480),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 31, 9, 38, 40, 154, DateTimeKind.Utc).AddTicks(8708));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AppUsers_User_Id",
                table: "Bookings",
                column: "User_Id",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
