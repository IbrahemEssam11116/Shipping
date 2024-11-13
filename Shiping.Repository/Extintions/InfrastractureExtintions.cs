using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PrimeDealsRealestat.Repository.Data;
using PrimeDealsRealestat.Repository.Interfaces;

namespace PrimeDealsRealestat.Repository.Extintions
{
    public class InfrastractureExtintions
    {
        public static void ConfigureDataBase(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DataContext>(b => b.UseSqlServer(connectionString));

        }
        public static void ConfigureServises(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        }

    }
}
