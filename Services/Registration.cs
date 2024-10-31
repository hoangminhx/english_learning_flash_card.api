using Microsoft.Extensions.DependencyInjection;
using Services.Implementation;
using Services.Interfaces;

namespace Services
{
    public static class Registration
    {
        public static IServiceCollection RegisterENServices(this IServiceCollection services)
        {
            services.AddTransient<ICardService, CardService> ();
            return services;
        }
    }
}
