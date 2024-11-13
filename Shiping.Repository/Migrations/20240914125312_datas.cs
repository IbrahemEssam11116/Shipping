using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class datas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutUsAR",
                table: "CompanyInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 9, 14, 15, 53, 11, 395, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "CompanyInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "AboutUsAR",
                value: "3n 2lsherka");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutUsAR",
                table: "CompanyInfo");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3387), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(4001), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3717), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3726), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3733), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3740), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3747), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3786), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3826), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3832), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3839), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3846), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3853), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3859), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3866), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3873), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3887), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3893), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3914), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3921), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3947), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3961), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3964) });
        }
    }
}
