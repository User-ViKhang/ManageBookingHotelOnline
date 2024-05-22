using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdateHotelLatute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 541, DateTimeKind.Utc).AddTicks(978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 293, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 525, DateTimeKind.Utc).AddTicks(3713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 277, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 544, DateTimeKind.Utc).AddTicks(2941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 295, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Hotels",
                type: "decimal(9,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,8)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Hotels",
                type: "decimal(9,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11,8)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 502, DateTimeKind.Utc).AddTicks(8259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 251, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 15, 21, 5, 549, DateTimeKind.Local).AddTicks(8569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 14, 52, 2, 301, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 548, DateTimeKind.Utc).AddTicks(586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 299, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 482, DateTimeKind.Utc).AddTicks(4749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 226, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "e50c2909-1c69-486a-b511-0a02ce90c396");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "9cc5ef17-8fc7-4bc9-8a6f-4554e8169dea");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "f227e192-2e7c-4dcb-90ce-ef7aa432ec03");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "42580ca0-9c9a-4a63-bd4f-4c8913226d33");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18542e3c-68af-4531-b1f4-581cf64c58ef", "AQAAAAEAACcQAAAAEHlJCFuOYbcr4mWaYDN4cGdyWG4JnAbZAHOG1+M63FdP6vMD/O0DcoL8b70lmQ2eQQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d4c0599-dd4f-40c1-988f-d47573842102", "AQAAAAEAACcQAAAAEFDDTcN8t2fSbuApBg7lr9zIiDGtvwQAoSUhGhmTclnzlgB7jiLX9ReHEHPh3XuheA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 293, DateTimeKind.Utc).AddTicks(5760),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 541, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 277, DateTimeKind.Utc).AddTicks(5248),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 525, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 295, DateTimeKind.Utc).AddTicks(4796),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 544, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Hotels",
                type: "decimal(11,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Hotels",
                type: "decimal(11,8)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 251, DateTimeKind.Utc).AddTicks(4581),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 502, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(1778),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(2586),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 246, DateTimeKind.Utc).AddTicks(2284),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 14, 52, 2, 301, DateTimeKind.Local).AddTicks(7643),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 15, 21, 5, 549, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 299, DateTimeKind.Utc).AddTicks(5977),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 548, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 7, 52, 2, 226, DateTimeKind.Utc).AddTicks(2855),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 482, DateTimeKind.Utc).AddTicks(4749));

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
    }
}
