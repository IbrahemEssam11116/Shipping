using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class aaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "CompanyInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CompanyInfo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "CompanyInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 712, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 10, 13, 23, 40, 24, 712, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "CompanyInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(329), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(350), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(134), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(140), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(143), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(147), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(176), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(198), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(201), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(205), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(209), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(214), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(217), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(221), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(225), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(228), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(236), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(239), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(247), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(250), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(254), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(266), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(273), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(277), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(280), new DateTime(2024, 10, 13, 23, 40, 24, 713, DateTimeKind.Local).AddTicks(281) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CompanyInfo");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CompanyInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "CompanyInfo");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4157), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4405), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4412), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4417), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4422), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4460), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4491), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4498), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4503), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4513), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4523), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4529), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4534), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4539), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4544), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4549), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4559), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4564), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4569), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4579), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4589), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4603), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4605) });
        }
    }
}
