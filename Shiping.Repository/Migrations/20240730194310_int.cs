using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shiping.Repository.Migrations
{
    public partial class @int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_District_DistrictId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UserTypeId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "Employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name", "NameAr" },
                values: new object[] { 1, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(8736), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(8816), "Cairo", "cairo" });

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "CreatedAt", "IsAllowDelete", "IsDeleted", "ModifiedAt", "Name", "NameAr", "PermissrionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9200), false, false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9218), "Admin", "Admin", null },
                    { 2, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9236), false, false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9251), "Driver", "سواق", null }
                });

            migrationBuilder.InsertData(
                table: "statuses",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name", "NameAr" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9516), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9527), "new", "جديد" },
                    { 2, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9534), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9538), "preparing", "قيد التحضير" },
                    { 3, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9544), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9548), "picked up", "تم الاستلام" },
                    { 4, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9559), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9573), "shipped", "تم الشحن" },
                    { 5, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9579), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9583), "delivered", "تم التوصيل" },
                    { 6, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9588), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9592), "failed", "فشل" },
                    { 7, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9599), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9603), "failed fees collected", "فشل - تم جمع الرسوم" },
                    { 8, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9611), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9616), "could not reach client", "تعذر الوصول إلى العميل" },
                    { 9, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9623), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9627), "client reschedule", "العميل أعاد الجدولة" },
                    { 10, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9634), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9638), "cancelled", "ملغى" },
                    { 11, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9644), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9649), "returned to shipper", "تمت إعادة الشحنة إلى المرسل" },
                    { 12, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9655), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9660), "not received", "لم يتم الاستلام" },
                    { 13, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9667), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9672), "COD received", "تم استلام الدفع عند الاستلام" },
                    { 14, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9678), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9682), "missing info", "معلومات مفقودة" },
                    { 15, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9690), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9701), "on hold", "في الانتظار" },
                    { 16, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9711), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9725), "customer cancelled", "ألغى العميل" },
                    { 17, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9732), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9742), "not ready", "غير جاهز" },
                    { 18, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9751), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9763), "received at warehouse", "تم الاستلام في المستودع" },
                    { 19, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9776), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9787), "resend", "إعادة إرسال" },
                    { 20, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9799), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9811), "ready", "جاهز" },
                    { 21, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9825), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9837), "duplicated", "مكرر" },
                    { 22, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9848), false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9859), "missing piece", "قطعة مفقودة" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "CityId", "CreatedAt", "DistrictId", "EmployeeTypeId", "IsDeleted", "ModifiedAt", "Password", "PhoneNumber", "UserName", "title" },
                values: new object[] { 1, 1, new DateTime(2024, 7, 30, 22, 43, 9, 702, DateTimeKind.Local).AddTicks(8), null, 1, false, new DateTime(2024, 7, 30, 22, 43, 9, 702, DateTimeKind.Local).AddTicks(23), "P@ssw0rd", "1234567890", "Admin", "MR" });

            migrationBuilder.InsertData(
                table: "Permissrion",
                columns: new[] { "Id", "CreatedAt", "EmployeeTypeId", "IsDeleted", "ModifiedAt", "Name", "NameAr" },
                values: new object[] { 1, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9337), 1, false, new DateTime(2024, 7, 30, 22, 43, 9, 701, DateTimeKind.Local).AddTicks(9350), "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "EmployeePermission",
                columns: new[] { "Id", "CreatedAt", "EmployeeId", "IsDeleted", "ModifiedAt", "permissrionId" },
                values: new object[] { 1, new DateTime(2024, 7, 30, 22, 43, 9, 702, DateTimeKind.Local).AddTicks(95), 1, false, new DateTime(2024, 7, 30, 22, 43, 9, 702, DateTimeKind.Local).AddTicks(100), 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_District_DistrictId",
                table: "Employee",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_District_DistrictId",
                table: "Employee");

            migrationBuilder.DeleteData(
                table: "EmployeePermission",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "statuses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissrion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserTypeId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_District_DistrictId",
                table: "Employee",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
