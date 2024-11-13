using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class ssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2591), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2631), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2324), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2331), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2338), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2344), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2383), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2421), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2428), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2434), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2447), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2454), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2460), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2467), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2473), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2480), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2493), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2519), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2526), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2539), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2547), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2553), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2556) });
        }
    }
}
