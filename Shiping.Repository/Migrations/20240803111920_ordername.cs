using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class ordername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recipient",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8474), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8199), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8212), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8245), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8276), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8301), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8316), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8323), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8330), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8344), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8351), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8357), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8364), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8371), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8398), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8426), new DateTime(2024, 8, 3, 14, 19, 19, 269, DateTimeKind.Local).AddTicks(8429) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Recipient",
                table: "Orders");

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
        }
    }
}
