using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddDeleteBehavior_ExtensionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 195, DateTimeKind.Utc).AddTicks(7498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 19, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 182, DateTimeKind.Utc).AddTicks(6530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 4, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 197, DateTimeKind.Utc).AddTicks(2371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 20, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 156, DateTimeKind.Utc).AddTicks(5854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 981, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 139, DateTimeKind.Utc).AddTicks(8482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 964, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "f39faae6-cb1a-4850-bcdd-419d0323682d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "24346a69-efe1-42df-938e-12670ebdfb28");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "2abb46bc-3078-4ae3-a344-578e9515a276");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "2b4cad08-9fbb-4f05-9256-b48cac974e95");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da350d9c-4a62-45b8-a74b-912379085838", "AQAAAAEAACcQAAAAEIolcZcFBKt/xvDuKOcFeXVcRnRv0FDOUaDZQVT3cks1buUDEaV85Ctlt8FYWVojpQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88d9ee19-0c15-4761-adcf-bb13b674a513", "AQAAAAEAACcQAAAAEPvJcARfxyUB8ANfSmadKKqT4zRBYSJcIVARWFpQfh3nVLfWBeYgx+e1L1TdQg6WGw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 19, DateTimeKind.Utc).AddTicks(2529),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 195, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 4, DateTimeKind.Utc).AddTicks(808),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 182, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 20, DateTimeKind.Utc).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 197, DateTimeKind.Utc).AddTicks(2371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 981, DateTimeKind.Utc).AddTicks(8311),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 156, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7336),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7747),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7608),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 154, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 964, DateTimeKind.Utc).AddTicks(9360),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 4, 43, 11, 139, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "08a6693c-b91d-42f3-8cd2-358d0f8b0298");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "c0992bd3-4a60-4bc9-b9b9-a20e36cf0f36");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "05d24b57-c031-4eb2-b863-de01da447c4d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "f8ca0040-9b32-402c-bd48-31e1c23e6b61");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef74c3fe-42b0-439b-a765-f2c35e68a9ae", "AQAAAAEAACcQAAAAEBN3ebbff7IDBhQm6tvGy4AoM6EXKUC7KOkqFpnf20hSQoR3vYDz06AL8uCeGwQmug==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c55f07a7-7888-4bd3-b7b4-7b8f07891f63", "AQAAAAEAACcQAAAAEDqrMuzK5HpZcSRMArUze8+KD78nv643awWtCjJZ7HDSdnm7OWWxoQnVdZHh9Nmc5Q==" });
        }
    }
}
