using Assessment2.Application.Interfaces;
using Assessment2.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Assessment2.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAnalyserService, AnalyserService>();
            return services;
        }
    }
    
}
