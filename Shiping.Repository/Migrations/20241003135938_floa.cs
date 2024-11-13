using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class floa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "DefaultFees",
                table: "Employee",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DefaultFees",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7510), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7518), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7562), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7567), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7570), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7574), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7578), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7582), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7585), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7589), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7593), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7597), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7601), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7604), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7608), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7612), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7616), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7619), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7623), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7627), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7630), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7638), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7642), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7645), new DateTime(2024, 9, 29, 22, 42, 18, 199, DateTimeKind.Local).AddTicks(7647) });
        }
    }
}
