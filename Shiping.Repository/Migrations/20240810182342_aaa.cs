using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Client",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4424), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4465), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4159), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4197), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4237), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4247), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4273), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4280), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4287), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4300), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4306), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4313), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4326), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4339), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4345), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4359), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4365), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4371), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4378), new DateTime(2024, 8, 10, 21, 23, 41, 420, DateTimeKind.Local).AddTicks(4381) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Client",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

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
    }
}
