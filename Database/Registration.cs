using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Database
{
    public static class Registration
    {
        public static IServiceCollection RegisterDatabaseServices(this IServiceCollection services, ConfigurationManager configurationManager)
        {
            string cns = configurationManager.GetConnectionString("DefaultDb") ?? "";

            return services.AddDbContext<ENContext>(options =>
                {
                    options
                        .UseLazyLoadingProxies()
                        .UseSqlServer(cns);
                });
        }
    }
}
