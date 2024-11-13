using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class fees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Fees",
                table: "District",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fees",
                table: "Cities",
                type: "real",
                nullable: false,
                defaultValue: 0f);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fees",
                table: "District");

            migrationBuilder.DropColumn(
                name: "Fees",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(8736), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 702, DateTimeKind.Local).AddTicks(8), new DateTime(2024, 7, 30, 22, 43, 9, 702, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 702, DateTimeKind.Local).AddTicks(95), new DateTime(2024, 7, 30, 22, 43, 9, 702, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9534), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9544), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9588), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9599), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9623), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9634), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9644), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9655), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9667), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9678), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9711), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9732), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9751), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9776), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9825), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9848), new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9859) });
        }
    }
}
