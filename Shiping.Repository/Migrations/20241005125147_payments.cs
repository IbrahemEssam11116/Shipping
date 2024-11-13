using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class payments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AllowShowInPayment",
                table: "Orders",
                newName: "DisAllowShowInPayment");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4157), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4405), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4412), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4417), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4422), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4460), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4491), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4498), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4503), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4513), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4523), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4529), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4534), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4539), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4544), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4549), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4559), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4564), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4569), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4579), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4589), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4603), new DateTime(2024, 10, 5, 15, 51, 45, 157, DateTimeKind.Local).AddTicks(4605) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisAllowShowInPayment",
                table: "Orders",
                newName: "AllowShowInPayment");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(2797), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3683), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3086), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3094), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3109), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3184), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3191), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3198), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3205), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3211), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3218), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3224), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3232), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3238), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3245), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3252), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3563), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3570), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3577), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3583), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3596), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3618), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3625), new DateTime(2024, 10, 5, 15, 49, 43, 865, DateTimeKind.Local).AddTicks(3628) });
        }
    }
}
