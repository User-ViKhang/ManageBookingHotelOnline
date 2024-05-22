using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class UpdateHotelLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 919, DateTimeKind.Utc).AddTicks(2400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 120, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 905, DateTimeKind.Utc).AddTicks(7727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 103, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 920, DateTimeKind.Utc).AddTicks(7139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 123, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.AddColumn<int>(
                name: "Location_Id",
                table: "Hotels",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 887, DateTimeKind.Utc).AddTicks(4509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 76, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 72, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 73, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 73, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 870, DateTimeKind.Utc).AddTicks(6666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 54, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "86d8ace0-738d-468f-bb19-17d0509ae2e8");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "25e2fba4-7519-4360-9af5-ec7655946a21");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "28fb370c-574f-4ec6-a9be-d1d2716994e6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "80002b79-b1d0-40dd-a95d-a13162e6d5b9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0de2488f-bc60-461b-bcec-1afc8c09b99e", "AQAAAAEAACcQAAAAEEIxO62ez39H/HNDY8Z0XK+aW+ohurfSCEWrPvYPLuymGEVA5VSmZ1GvN3DU42LA4g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86ad4a3b-3e28-445f-996c-00e58ef1babd", "AQAAAAEAACcQAAAAEBNYSdH3L+nMn+sy+x+CZTVXr6Qm7o2Us19/tHcyRHTQ4CrhTl3HjfevrNy2VypaKw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_Location_Id",
                table: "Hotels",
                column: "Location_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Locations_Location_Id",
                table: "Hotels",
                column: "Location_Id",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Locations_Location_Id",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_Location_Id",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Location_Id",
                table: "Hotels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 120, DateTimeKind.Utc).AddTicks(6657),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 919, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 103, DateTimeKind.Utc).AddTicks(2609),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 905, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 123, DateTimeKind.Utc).AddTicks(2139),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 920, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 76, DateTimeKind.Utc).AddTicks(665),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 887, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 72, DateTimeKind.Utc).AddTicks(9900),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 73, DateTimeKind.Utc).AddTicks(592),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 73, DateTimeKind.Utc).AddTicks(369),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 885, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 5, 38, 18, 54, DateTimeKind.Utc).AddTicks(6453),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 27, 7, 10, 25, 870, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "31434fe7-2866-4ad6-9676-39e6abb79c72");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "6be9ac3d-19ab-4a8b-bcd4-af7223f2e0ba");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "56529639-77c6-43e7-9e0f-34af3194d8df");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "5a04807a-e60f-4103-bbf3-b5075e4c0f2b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "702941a1-e530-4991-b45e-b955d609016a", "AQAAAAEAACcQAAAAEB41FFWzKByFhH/uTGwTYvgWi1tE0GMZ+f2EMlqO7IhEGXlYjo+7HzGiILPXKjg2pw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbf16731-9a42-4675-8b9b-81915fa65f20", "AQAAAAEAACcQAAAAELdD/+VdXc6BqrSqAloZ6MnUQNhzY0lHgb6jZrbiGcKWEjnhdjdlJPTrNOvP4SHkMg==" });
        }
    }
}
