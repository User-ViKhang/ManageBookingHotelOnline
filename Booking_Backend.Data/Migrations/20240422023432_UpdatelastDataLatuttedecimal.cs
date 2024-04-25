using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdatelastDataLatuttedecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 317, DateTimeKind.Utc).AddTicks(4737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 541, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 304, DateTimeKind.Utc).AddTicks(2236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 525, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 319, DateTimeKind.Utc).AddTicks(314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 544, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 284, DateTimeKind.Utc).AddTicks(9109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 502, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 9, 34, 31, 324, DateTimeKind.Local).AddTicks(2066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 15, 21, 5, 549, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 322, DateTimeKind.Utc).AddTicks(4128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 548, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 267, DateTimeKind.Utc).AddTicks(2090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 482, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "2a91fc50-8922-4588-afde-922b447105d0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "e28d7f9d-c25c-4b0b-b04d-9f2bf619d4d0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "7b636698-65b2-4ec9-8a1b-c047f8d0292a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "202c8206-c7fe-439d-b04b-a017f860a69b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d29edc3-041d-43e8-89b4-37c26c78d21e", "AQAAAAEAACcQAAAAEAEQTN/OugHDDmDDgeGu24p6ZBpYjdkBhxkl7Chej36vvmH3rUf5KtAgREQPvLhOaQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9110126-445c-4fad-85c3-f63b9849a890", "AQAAAAEAACcQAAAAEExeLIpKf+rVDg13ehkwztlqRrmMhr61oj2EVtQS8oP0W7S0/2PGKK9kuAN8M1YI5A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 541, DateTimeKind.Utc).AddTicks(978),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 317, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 525, DateTimeKind.Utc).AddTicks(3713),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 304, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 544, DateTimeKind.Utc).AddTicks(2941),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 319, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 502, DateTimeKind.Utc).AddTicks(8259),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 284, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9167),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9583),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 499, DateTimeKind.Utc).AddTicks(9450),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 282, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 15, 21, 5, 549, DateTimeKind.Local).AddTicks(8569),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 9, 34, 31, 324, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 548, DateTimeKind.Utc).AddTicks(586),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 322, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 21, 8, 21, 5, 482, DateTimeKind.Utc).AddTicks(4749),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 22, 2, 34, 31, 267, DateTimeKind.Utc).AddTicks(2090));

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
    }
}
