using System.Collections.Generic;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection 
            AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PanasDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultDbConnection"));
                options.UseLazyLoadingProxies();
            });

            services.AddScoped<IPanasDbContext, PanasDbContext>();
            return services;
        }

        public static void MigrateContext(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<PanasDbContext>();
            context?.Database.Migrate();
        }
    }
}