using Microsoft.EntityFrameworkCore;
using Shiping.Repository.Models;

namespace PrimeDealsRealestat.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ClientPayment> ClientPayment { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeePermission> EmployeePermission { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<Permissrion> Permissrion { get; set; }
        public DbSet<ClientOrderPayment> ClientOrderPayments { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<CompanyInfo> CompanyInfo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
            new City { Id = 1, Name = "Cairo", NameAr = "cairo" }
        );
            modelBuilder.Entity<EmployeeType>().HasData(
           new EmployeeType { Id = 1, Name = "Admin", NameAr = "Admin", IsAllowDelete = false },
           new EmployeeType { Id = 2, Name = "Driver", NameAr = "سواق", IsAllowDelete = false },
           new EmployeeType { Id = 3, Name = "Support", NameAr = "دعم", IsAllowDelete = false },
           new EmployeeType { Id = 4, Name = "CallCenter", NameAr = "خدمة عملاء", IsAllowDelete = false },
           new EmployeeType { Id = 5, Name = "Accountant", NameAr = "محاسب", IsAllowDelete = false },
           new EmployeeType { Id = 6, Name = "Warehouse", NameAr = "عامل مستودع", IsAllowDelete = false }
           
       );
            modelBuilder.Entity<Permissrion>().HasData(
          new Permissrion { Id = 1, Name = "Admin", NameAr = "Admin", EmployeeTypeId = 1 }
      );
            modelBuilder.Entity<Status>().HasData(
        new Status { Id = 1, Name = "new", NameAr = "جديد" },
        new Status { Id = 2, Name = "preparing", NameAr = "قيد التحضير" },
        new Status { Id = 3, Name = "picked up", NameAr = "تم الاستلام" },
        new Status { Id = 4, Name = "shipped", NameAr = "تم الشحن" },
        new Status { Id = 5, Name = "delivered", NameAr = "تم التوصيل" },
        new Status { Id = 6, Name = "failed", NameAr = "فشل" },
        new Status { Id = 7, Name = "failed fees collected", NameAr = "فشل - تم جمع الرسوم" },
        new Status { Id = 8, Name = "could not reach client", NameAr = "تعذر الوصول إلى العميل" },
        new Status { Id = 9, Name = "client reschedule", NameAr = "العميل أعاد الجدولة" },
        new Status { Id = 10, Name = "cancelled", NameAr = "ملغى" },
        new Status { Id = 11, Name = "returned to shipper", NameAr = "تمت إعادة الشحنة إلى المرسل" },
        new Status { Id = 12, Name = "not received", NameAr = "لم يتم الاستلام" },
        new Status { Id = 13, Name = "COD received", NameAr = "تم استلام الدفع عند الاستلام" },
        new Status { Id = 14, Name = "missing info", NameAr = "معلومات مفقودة" },
        new Status { Id = 15, Name = "on hold", NameAr = "في الانتظار" },
        new Status { Id = 16, Name = "customer cancelled", NameAr = "ألغى العميل" },
        new Status { Id = 17, Name = "not ready", NameAr = "غير جاهز" },
        new Status { Id = 18, Name = "received at warehouse", NameAr = "تم الاستلام في المستودع" },
        new Status { Id = 19, Name = "resend", NameAr = "إعادة إرسال" },
        new Status { Id = 20, Name = "ready", NameAr = "جاهز" },
        new Status { Id = 21, Name = "duplicated", NameAr = "مكرر" },
        new Status { Id = 22, Name = "missing piece", NameAr = "قطعة مفقودة" },
        new Status { Id = 23, Name = "Paid", NameAr = "تم الدفع" }
    );
            modelBuilder.Entity<Employee>().HasData(
           new Employee
           {
               Id = 1,
               UserName = "Admin",
               Password = "P@ssw0rd",
               PhoneNumber = "1234567890",
               EmployeeTypeId = 1,
               CityId = 1,
               DistrictId = null,

               IsDeleted = false,
               title = "MR"
           }
       );
            modelBuilder.Entity<EmployeePermission>().HasData(
      new EmployeePermission { Id = 1, EmployeeId = 1, permissrionId = 1 }
  );

            modelBuilder.Entity<CompanyInfo>().HasData(
      new CompanyInfo { Id = 1, PhoneMumber = "0112012811", AboutUs = "About  Ussss" , AboutUsAR="3n 2lsherka"}
  );
        }

    }
}
