using Microsoft.EntityFrameworkCore;
using ProvaPub.Repository;
using ProvaPub.Services;

namespace ProvaPub.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<DbContext, TestDbContext>();

            // Services
            services.AddScoped<ProductService>();
            services.AddScoped<CustomerService>();
            services.AddScoped<GenericService>();
            services.AddScoped<PayOrderService>();

            return services;
        }
    }
}
