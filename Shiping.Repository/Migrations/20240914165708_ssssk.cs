using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class ssssk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "OrderHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(1286), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3486), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2065), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2101), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2146), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2169), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2194), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2535), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2558), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2580), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2625), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2671), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2869), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2965), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2986), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3011), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3034), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3057), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3083), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3105), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3130), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3151), new DateTime(2024, 9, 14, 19, 57, 7, 317, DateTimeKind.Local).AddTicks(3162) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "OrderHistories");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6511), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7366), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7415), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6940), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6955), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6964), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6974), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7043), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7093), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7113), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7134), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7163), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7172), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7202), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7222), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7232), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7242), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7251), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7261), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7272), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7300), new DateTime(2024, 9, 14, 17, 58, 49, 707, DateTimeKind.Local).AddTicks(7304) });
        }
    }
}
