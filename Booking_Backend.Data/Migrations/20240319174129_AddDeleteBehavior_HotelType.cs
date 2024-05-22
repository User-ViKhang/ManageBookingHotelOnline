using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddDeleteBehavior_HotelType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelTypes_HotelTypeImages_HotelTypeImage_Id",
                table: "HotelTypes");

            migrationBuilder.DropIndex(
                name: "IX_HotelTypes_HotelTypeImage_Id",
                table: "HotelTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 19, DateTimeKind.Utc).AddTicks(2529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 876, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 4, DateTimeKind.Utc).AddTicks(808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 860, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.AlterColumn<int>(
                name: "HotelTypeImage_Id",
                table: "HotelTypes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 20, DateTimeKind.Utc).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 878, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 981, DateTimeKind.Utc).AddTicks(8311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 835, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 831, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 831, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 831, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 964, DateTimeKind.Utc).AddTicks(9360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 815, DateTimeKind.Utc).AddTicks(6387));

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

            migrationBuilder.CreateIndex(
                name: "IX_HotelTypes_HotelTypeImage_Id",
                table: "HotelTypes",
                column: "HotelTypeImage_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelTypes_HotelTypeImages_HotelTypeImage_Id",
                table: "HotelTypes",
                column: "HotelTypeImage_Id",
                principalTable: "HotelTypeImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelTypes_HotelTypeImages_HotelTypeImage_Id",
                table: "HotelTypes");

            migrationBuilder.DropIndex(
                name: "IX_HotelTypes_HotelTypeImage_Id",
                table: "HotelTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "UserImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 876, DateTimeKind.Utc).AddTicks(8682),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 19, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 860, DateTimeKind.Utc).AddTicks(1786),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 4, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.AlterColumn<int>(
                name: "HotelTypeImage_Id",
                table: "HotelTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "HotelTypeImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 878, DateTimeKind.Utc).AddTicks(5105),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 28, 20, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 835, DateTimeKind.Utc).AddTicks(3266),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 981, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 831, DateTimeKind.Utc).AddTicks(8501),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 831, DateTimeKind.Utc).AddTicks(9496),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 831, DateTimeKind.Utc).AddTicks(9295),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 979, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 19, 14, 48, 40, 815, DateTimeKind.Utc).AddTicks(6387),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 19, 17, 41, 27, 964, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "7e3fe8fe-ec15-4441-9ef5-a21342b84707");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "2ebaf1a1-4f0a-408e-b92e-00ea5a93a978");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "721771c3-bab4-4fbd-8363-a2d9e244d8d9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "343ea084-f979-4591-be52-f44f26c0ac23");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8db370d8-7bf0-48a0-87d0-f1ff090ea55d", "AQAAAAEAACcQAAAAEGCn64z7vH3q0s7ApFad7/1iGltDCLkcgk7ff3DKJ6yos0dgvJTy1j7npK+GPXeP8w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee1af177-b2f5-495f-9a23-b2fe45ddac83", "AQAAAAEAACcQAAAAEO3ejeLUC7fGSmj3EzghlFze986NbsxeFRkr34FH/Mg56cHXu4Fe2NOJKO157NIifA==" });

            migrationBuilder.CreateIndex(
                name: "IX_HotelTypes_HotelTypeImage_Id",
                table: "HotelTypes",
                column: "HotelTypeImage_Id",
                unique: true,
                filter: "[HotelTypeImage_Id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelTypes_HotelTypeImages_HotelTypeImage_Id",
                table: "HotelTypes",
                column: "HotelTypeImage_Id",
                principalTable: "HotelTypeImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
