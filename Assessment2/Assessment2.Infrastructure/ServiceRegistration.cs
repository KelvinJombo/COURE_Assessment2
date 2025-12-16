using Assessment2.Application.Interfaces;
using Assessment2.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Assessment2.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IInMemoryDatabase, InMemoryDatabase>();
            return services;
        }
    }

}
