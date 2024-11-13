using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class EMPLOYEEaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(3011), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(3044), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2745), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2756), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2791), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2825), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2839), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2846), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2853), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2859), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2866), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2879), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2899), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2906), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2926), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2933), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2939), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2946), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2953), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2959), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 8, 5, 22, 25, 32, 424, DateTimeKind.Local).AddTicks(2969) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employee");

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
    }
}
