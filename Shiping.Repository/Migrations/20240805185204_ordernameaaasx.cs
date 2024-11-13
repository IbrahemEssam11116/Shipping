using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class ordernameaaasx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultFees",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(5480), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6362), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6054), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6066), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6103), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6139), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6147), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6154), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6161), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6167), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6174), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6181), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6194), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6201), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6207), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6214), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6234), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6247), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6267), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 8, 5, 21, 52, 3, 540, DateTimeKind.Local).AddTicks(6283) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultFees",
                table: "Employee");

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
    }
}
