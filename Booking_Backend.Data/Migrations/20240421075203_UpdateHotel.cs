using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdateHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 293, DateTimeKind.Utc).AddTicks(5760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 847, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 277, DateTimeKind.Utc).AddTicks(5248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 833, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 295, DateTimeKind.Utc).AddTicks(4796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 848, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Hotels",
                type: "decimal(11,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Hotels",
                type: "decimal(11,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 251, DateTimeKind.Utc).AddTicks(4581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 814, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(1778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(2586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(2284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 14, 52, 2, 301, DateTimeKind.Local).AddTicks(7643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 13, 10, 14, 854, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 299, DateTimeKind.Utc).AddTicks(5977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 852, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 226, DateTimeKind.Utc).AddTicks(2855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 796, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "d3ca5463-2e6e-48fd-8a6b-39f62aa29f96");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "a86c9b13-0811-4c3f-884a-51d7ee45131a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "d69471cd-e150-4cad-bde3-1cbb1e87e4c8");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "729883a8-bb29-4787-b3a0-d7e264aa38a5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8a77d43-ce85-4a61-b750-a023de932f22", "AQAAAAEAACcQAAAAENaoaJ4yqUA7/YJibOx2e4PcPWVUAff61v8bIDTMg+RRJW7t2hUne7qH5SOhMbdBJA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b82901ff-7471-4886-bf69-7e5570275b90", "AQAAAAEAACcQAAAAEKLO/eoHJ88CzWtd0eqYrq0gGlbCamolD6LtNG4NI505jwJzr46uUUVUXWbOL5aCnQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 847, DateTimeKind.Utc).AddTicks(1212),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 293, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 833, DateTimeKind.Utc).AddTicks(6594),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 277, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 848, DateTimeKind.Utc).AddTicks(9697),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 295, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Hotels",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,8)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Hotels",
                type: "decimal",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,8)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 814, DateTimeKind.Utc).AddTicks(377),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 251, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(8873),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(9312),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 810, DateTimeKind.Utc).AddTicks(9171),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 13, 10, 14, 854, DateTimeKind.Local).AddTicks(3158),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 14, 52, 2, 301, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 852, DateTimeKind.Utc).AddTicks(4880),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 299, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 20, 6, 10, 14, 796, DateTimeKind.Utc).AddTicks(1073),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 226, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "594b0664-94a2-47fd-a624-69d7d1ef92b3");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "f430caaf-64b9-47e5-a5cb-e355cb217b33");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "d1bb6a30-17b9-4463-8cf6-3e1ea55c3d9d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "45ffbe83-e7ad-43dc-ad1f-68b9fe076186");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a3820a1-bd61-4868-b548-a919d7ebe6b3", "AQAAAAEAACcQAAAAEE7uEGhvYE+jwTyndE8bur4dLAfn1aekjXsXtViXeeBikUNP/ngmHP2JR274Xc9oXw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3cc6689-4aa0-4826-aa01-bdad2293c8d5", "AQAAAAEAACcQAAAAEBG2uDa82HAJp2ceJ7gNo4kv1VK63b+iefy37Yfe6GYLGAjt1LrkpQskD82C9LYDyQ==" });
        }
    }
}
