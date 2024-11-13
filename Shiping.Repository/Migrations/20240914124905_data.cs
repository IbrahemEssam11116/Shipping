using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutUs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneMumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfo", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3387), new DateTime(2024, 9, 14, 15, 49, 3, 863, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.InsertData(
                table: "CompanyInfo",
                columns: new[] { "Id", "AboutUs", "PhoneMumber" },
                values: new object[] { 1, "About  Ussss", "0112012811" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyInfo");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9882), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9914), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9593), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9618), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9661), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9699), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9706), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9713), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9720), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9727), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9734), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9741), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9755), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9762), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9769), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9778), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9792), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9806), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9813), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9821), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9828), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9836), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9843), new DateTime(2024, 9, 14, 15, 44, 4, 461, DateTimeKind.Local).AddTicks(9846) });
        }
    }
}
