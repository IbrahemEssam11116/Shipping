using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class FCM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FCMToken",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FCMToken",
                table: "Employee");

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
    }
}
