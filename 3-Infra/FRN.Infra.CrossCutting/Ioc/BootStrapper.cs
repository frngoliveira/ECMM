using FRN.Infra._3._1_Context;
using Microsoft.Extensions.DependencyInjection;

namespace FRN.Infra.CrossCutting.Ioc
{
    public static class BootStrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services) 
        {
            services.AddScoped<FRNContext>();

            return services;
        }
    }
}
