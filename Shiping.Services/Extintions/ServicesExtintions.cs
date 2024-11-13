using Microsoft.Extensions.DependencyInjection;
using Shiping.Services.Services;

namespace Shiping.Services.Extintions
{
    public class ServicesExtintions
    {
        public static void ConfigureServises(IServiceCollection services)
        {

            services.AddTransient<ClientSevice>();
            services.AddTransient<EmployeeService>();
            services.AddTransient<OrderService>();
            services.AddScoped<AuthService>();
            services.AddTransient<LookupsService>();
            services.AddTransient<FirebaseHttpClientService>();
        }
    }
}
