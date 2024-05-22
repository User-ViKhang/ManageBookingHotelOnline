using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddFiledCountFeedBackHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 859, DateTimeKind.Utc).AddTicks(6387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 764, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 846, DateTimeKind.Utc).AddTicks(6326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 752, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 861, DateTimeKind.Utc).AddTicks(1501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 766, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.AddColumn<int>(
                name: "CountFeedBack",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 826, DateTimeKind.Utc).AddTicks(3033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 732, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(2619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(1805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(3065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(2935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 13, 31, 16, 866, DateTimeKind.Local).AddTicks(8512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 22, 55, 26, 771, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 865, DateTimeKind.Utc).AddTicks(523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 769, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 812, DateTimeKind.Utc).AddTicks(4969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 718, DateTimeKind.Utc).AddTicks(8474));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountFeedBack",
                table: "Hotels");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 764, DateTimeKind.Utc).AddTicks(7172),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 859, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 752, DateTimeKind.Utc).AddTicks(1807),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 846, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 766, DateTimeKind.Utc).AddTicks(1863),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 861, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 732, DateTimeKind.Utc).AddTicks(2056),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 826, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(1805),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(2205),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 729, DateTimeKind.Utc).AddTicks(2068),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 823, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BookingCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 22, 55, 26, 771, DateTimeKind.Local).AddTicks(4494),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 13, 31, 16, 866, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created_at",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 769, DateTimeKind.Utc).AddTicks(6898),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 865, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 9, 15, 55, 26, 718, DateTimeKind.Utc).AddTicks(8474),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 5, 11, 6, 31, 16, 812, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "ea820c7d-f73f-4efe-a5da-644b2f796d4e");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "14b65a0e-94b6-4214-96b8-34046fd8802a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "7f880eb1-7730-484b-9d01-cb26c4bec09f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "3f32baa3-3144-48cc-860c-c0c37ea3f694");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1bcd1f3a-74c5-44b4-9e43-13eb0a8396ff", "AQAAAAEAACcQAAAAEGVSz525v6tEJSYvf7iMV++gnD0LZsYDsiUB2P5XFXqZ3OAMQqwm33ZnZyvsotxHfA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbbefcef-e105-4c9d-9975-f4b5fe969fc1", "AQAAAAEAACcQAAAAEAg01ou8sldtxxdx1gfgcy1iwucuxSGUnhKsaMyx7rF/FH42KDZY2xIzoZColJxPsQ==" });
        }
    }
}
