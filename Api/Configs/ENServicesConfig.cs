using Database;
using Services;

namespace Api.Configs
{
    public static class ENServicesConfig
    {
        public static IServiceCollection AddServices_EN(this IServiceCollection services, ConfigurationManager configurationManager)
        { 
            return services.RegisterDatabaseServices(configurationManager)
                            .RegisterENServices();
        }
    }
}
