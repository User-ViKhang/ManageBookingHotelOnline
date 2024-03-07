using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking_Backend.Data.Migrations
{
    public partial class AddUserImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 501, DateTimeKind.Utc).AddTicks(7017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 266, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 491, DateTimeKind.Utc).AddTicks(4402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 255, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(3643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 243, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(4159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 243, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(3977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 243, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 473, DateTimeKind.Utc).AddTicks(6955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 239, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.CreateTable(
                name: "UserImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ImageSize = table.Column<decimal>(type: "decimal", nullable: false),
                    ImageUrl = table.Column<string>(type: "varchar(255)", nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 515, DateTimeKind.Utc).AddTicks(2143)),
                    User_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserImages_AppUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "ddb4ef42-36d7-4bf3-8ea4-4a1650b6a31c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "8cf3de67-c4a8-4e91-b74f-04827b2cb53c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "7ac23bad-b982-4b2d-8892-b71570317857");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "3fcb11f1-26ec-4db2-93bb-5cd059695d3a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8754c0ea-3f77-4a2e-970d-cafc3f43de28", "AQAAAAEAACcQAAAAEJ1Ob+v7UyxYo3W+hAvIdP6tsy7EkivKTgXGu3oRFwPv3cfcTea9RlfgR2BmWIcXqw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "151c853f-ced8-43bd-b801-ee4572e49172", "AQAAAAEAACcQAAAAEF5E/K9eUE5U+ONIMShFCx/omvIPSYUb1a11FNwPgEjizxANYYCZDK6JGsVt7e8mbQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserImages_User_Id",
                table: "UserImages",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 266, DateTimeKind.Utc).AddTicks(796),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 501, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 255, DateTimeKind.Utc).AddTicks(4284),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 491, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 243, DateTimeKind.Utc).AddTicks(6347),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckOut",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 243, DateTimeKind.Utc).AddTicks(6729),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 243, DateTimeKind.Utc).AddTicks(6606),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 479, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 15, 28, 22, 239, DateTimeKind.Utc).AddTicks(2215),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 6, 6, 44, 30, 473, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f10d63e-c240-4be5-a95b-b868c41501dd"),
                column: "ConcurrencyStamp",
                value: "7fb31be1-fc0c-4980-bebd-a2a0449ce5fa");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("265e11da-bc22-4fe7-b286-493d6a09d46f"),
                column: "ConcurrencyStamp",
                value: "9f539ce8-4532-4779-9cce-a419e44c3ddc");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad9c3bfc-fd01-4696-b8c8-0ce10e6a3632"),
                column: "ConcurrencyStamp",
                value: "576d1663-1bd0-4c51-ac17-aefc7fb72622");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0404419-a456-4cd6-a8bc-e19c246904c5"),
                column: "ConcurrencyStamp",
                value: "cd7ec076-cbee-4ff7-929e-f848e5900aa7");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("31ff741e-5a2a-4afd-8448-7dc59c03a5b6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5eba75c2-e407-4cb5-911b-531f961728e1", "AQAAAAEAACcQAAAAEAYQ6v0ta6z1fwfDnlWbY/WB4K/F+QKWFSRqx+Lp+OD6QAz5f93vAYJcrGgcRhxLxQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5e9ebbd-fd85-4ad0-b820-0aa8105ebdd2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bc6c096-d3d3-4ff7-ba86-811b3ad5ba4f", "AQAAAAEAACcQAAAAEMhjQCpXeAquyLtGUARQfLYMaErU0dK9YGktKxsguaQXPt8hPlRG1q7Vbz8X7A/rEA==" });
        }
    }
}
