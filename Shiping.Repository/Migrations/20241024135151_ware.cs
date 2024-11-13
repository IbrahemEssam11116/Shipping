using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class ware : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7784), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "CompanyInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8067), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8044), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8058), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7931), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7934), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7936), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7939), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "CreatedAt", "IsAllowDelete", "IsDeleted", "ModifiedAt", "Name", "NameAr", "PermissrionId" },
                values: new object[] { 6, new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7941), false, false, new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7942), "Warehouse", "عامل مستودع", null });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7956), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7974), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7977), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7982), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7984), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7986), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7988), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7991), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7993), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7995), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7997), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(7999), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8002), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8004), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8006), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8008), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8010), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8012), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8014), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8017), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8019), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8021), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8023), new DateTime(2024, 10, 25, 2, 51, 51, 99, DateTimeKind.Local).AddTicks(8024) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 6);

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
    }
}
