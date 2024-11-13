using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class feesaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHistories_Employee_EmployeeId",
                table: "OrderHistories");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "OrderHistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_OrderHistories_Employee_EmployeeId",
                table: "OrderHistories",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHistories_Employee_EmployeeId",
                table: "OrderHistories");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "OrderHistories",
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
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(5049), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4802), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4884), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4891), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4898), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4918), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4931), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4938), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4972), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4979), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4985), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4992), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(5006), new DateTime(2024, 8, 2, 23, 20, 42, 290, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHistories_Employee_EmployeeId",
                table: "OrderHistories",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
