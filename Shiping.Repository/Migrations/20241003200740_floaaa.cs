using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class floaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderCount",
                table: "statuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(4966), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5198), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5210), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5250), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5325), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5331), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5337), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5352), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5357), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5363), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5368), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5374), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5379), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5385), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5390), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5395), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5400), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5406), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5411), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5426), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5431), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5436), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5441), new DateTime(2024, 10, 3, 23, 7, 39, 171, DateTimeKind.Local).AddTicks(5444) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCount",
                table: "statuses");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4277), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4609), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4441), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4444), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4447), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4449), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4488), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4491), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4493), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4496), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4498), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4501), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4503), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4506), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4511), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4513), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4515), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4520), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4523), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4525), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4528), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4530), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4533), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4535), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4538), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4540), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4543), new DateTime(2024, 10, 3, 16, 59, 37, 830, DateTimeKind.Local).AddTicks(4544) });
        }
    }
}
