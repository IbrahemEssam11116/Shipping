using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class matrials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderMaterial_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "statuses",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name", "NameAr" },
                values: new object[] { 23, new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8109), false, new DateTime(2024, 9, 29, 0, 31, 24, 492, DateTimeKind.Local).AddTicks(8110), "Paid", "تم الدفع" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderMaterial_MaterialId",
                table: "OrderMaterial",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMaterial_OrderId",
                table: "OrderMaterial",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderMaterial");

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(3022), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2882), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2889), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2895), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2947), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2950), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2953), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2955), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2961), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2967), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2970), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2973), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2978), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2981), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2990), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2993), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2996), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 9, 28, 16, 15, 52, 351, DateTimeKind.Local).AddTicks(3000) });
        }
    }
}
