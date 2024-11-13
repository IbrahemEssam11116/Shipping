using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class aboutus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9914), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9593), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9618), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9661), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9699), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9706), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9713), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9727), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9734), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9741), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9755), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9762), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9769), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9778), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9792), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9806), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9813), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9821), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9828), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9836), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9843), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9846) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7284), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7888), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7933), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7597), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7606), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7620), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7627), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7671), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7704), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7712), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7718), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7724), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7738), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7744), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7751), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7757), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7764), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7771), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7777), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7784), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7798), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7804), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7810), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7817), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7824), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7830), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7837), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7843), new DateTime(2024, 9, 2, 22, 0, 57, 114, DateTimeKind.Local).AddTicks(7846) });
        }
    }
}
