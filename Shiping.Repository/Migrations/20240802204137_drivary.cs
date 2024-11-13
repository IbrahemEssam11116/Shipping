using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class drivary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employee_DriveryId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "DriveryId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(446), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(1002), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(705), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(715), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(749), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(780), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(788), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(795), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(809), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(828), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(835), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(841), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(848), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(861), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(881), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(888), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(901), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(908), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(914), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(921), new DateTime(2024, 8, 2, 23, 41, 36, 98, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employee_DriveryId",
                table: "Orders",
                column: "DriveryId",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employee_DriveryId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "DriveryId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(7706), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(7968), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(7979), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8010), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8041), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8049), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8056), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8063), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8069), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8076), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8083), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8089), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8096), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8102), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8116), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8122), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8129), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8135), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8142), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8149), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8155), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8169), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8175), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8182), new DateTime(2024, 8, 2, 23, 32, 52, 514, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employee_DriveryId",
                table: "Orders",
                column: "DriveryId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
