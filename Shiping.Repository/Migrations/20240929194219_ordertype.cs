using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class ordertype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderTypeId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderType", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderType_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderType_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrderType");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTypeId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7769), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8132), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8150), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7983), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7987), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7990), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7992), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8010), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8055), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8058), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8061), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8064), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8066), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8068), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8071), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8073), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8076), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8081), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8083), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8085), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8088), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8090), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8095), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8097), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8102), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8104), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8110) });
        }
    }
}
