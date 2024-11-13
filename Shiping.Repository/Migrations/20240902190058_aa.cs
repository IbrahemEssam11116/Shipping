using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "SideFees",
                table: "Cities",
                type: "real",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SideFees",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(1783), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2371), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2065), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2074), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2080), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2087), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2093), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2132), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2166), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2173), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2180), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2186), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2192), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2212), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2218), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2225), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2231), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2244), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2251), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2257), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2264), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2276), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2283), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2290), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2296), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2303), new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2306) });
        }
    }
}
