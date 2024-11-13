using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class ordernameaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(751), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1314), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1021), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1031), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1063), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1117), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1124), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1131), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1138), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1145), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1151), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1158), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1165), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1172), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1179), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1192), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1199), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1206), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1213), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1227), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1233), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1240), new DateTime(2024, 8, 5, 19, 16, 52, 826, DateTimeKind.Local).AddTicks(1243) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employee");

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
    }
}
