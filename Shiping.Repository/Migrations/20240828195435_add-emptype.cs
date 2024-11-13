using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class addemptype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "CreatedAt", "IsAllowDelete", "IsDeleted", "ModifiedAt", "Name", "NameAr", "PermissrionId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2080), false, false, new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2083), "Support", "دعم", null },
                    { 4, new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2087), false, false, new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2090), "CallCenter", "خدمة عملاء", null },
                    { 5, new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2093), false, false, new DateTime(2024, 8, 28, 22, 54, 33, 402, DateTimeKind.Local).AddTicks(2096), "Accountant", "محاسب", null }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4424), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4465), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4159), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4197), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4237), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4247), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4273), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4280), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4287), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4300), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4306), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4313), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4326), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4339), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4345), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4359), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4365), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4371), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4378), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4381) });
        }
    }
}
