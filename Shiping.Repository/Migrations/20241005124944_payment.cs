using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AllowShowInPayment",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowShowInPayment",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3642), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4259), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4290), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3962), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3970), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3977), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3983), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4065), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4072), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4079), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4084), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4089), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4093), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4098), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4103), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4108), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4121), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4126), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4135), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4145), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4155), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4160), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4165), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 10, 4, 23, 51, 7, 571, DateTimeKind.Local).AddTicks(4176) });
        }
    }
}
