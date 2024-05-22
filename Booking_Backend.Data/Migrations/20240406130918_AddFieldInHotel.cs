using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddFieldInHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 748, DateTimeKind.Utc).AddTicks(9015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 501, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Images",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 733, DateTimeKind.Utc).AddTicks(9068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 487, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 750, DateTimeKind.Utc).AddTicks(4895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 503, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.AddColumn<int>(
                name: "Preview",
                table: "Hotels",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Score",
                table: "Hotels",
                nullable: true,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 714, DateTimeKind.Utc).AddTicks(9472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 468, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 696, DateTimeKind.Utc).AddTicks(7777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 449, DateTimeKind.Utc).AddTicks(9050));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preview",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Hotels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 501, DateTimeKind.Utc).AddTicks(6461),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 748, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Images",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 487, DateTimeKind.Utc).AddTicks(6196),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 733, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 503, DateTimeKind.Utc).AddTicks(2081),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 750, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 468, DateTimeKind.Utc).AddTicks(835),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 714, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(2111),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 465, DateTimeKind.Utc).AddTicks(1982),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 712, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 3, 9, 4, 33, 449, DateTimeKind.Utc).AddTicks(9050),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 6, 13, 9, 17, 696, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "5a94f4ed-cbb5-41b3-9651-42e1b9cb219a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "828f5989-fa4b-4fae-9cad-444af7e2afe5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "62c7b2f4-fe37-456a-97e0-8bc5e10c63a5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "a0492f38-c67d-417c-9815-77d0c11623d6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2db00dd9-680b-487d-b9b7-3324840366ee", "AQAAAAEAACcQAAAAEJXi5NMR7BlsRvU6k8p5q0+QXyf5M1awfHM9obl9Fu5FQqxqp2Yt7WpuZltWmm9X+Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d211e7b-9004-4868-98a7-0108a4a0901e", "AQAAAAEAACcQAAAAEPHM2XC57vcw9IYuutXaA/D4jn8Q6H0mRacrvNVac4eZSjVBjmTVqFSkGj3qIPDo1g==" });
        }
    }
}
