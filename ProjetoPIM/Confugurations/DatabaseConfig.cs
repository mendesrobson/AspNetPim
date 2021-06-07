using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoPIM.Context;
using System;
using Microsoft.Extensions.Configuration;

namespace ProjetoPIM.Confugurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //services.AddDbContext<SqlContext>(options =>
            //   options.UseSqlServer(Environment.GetEnvironmentVariable("Default")));

            services.AddDbContext<SqlContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("Default")));

            //Environment.GetEnvironmentVariable("PIM") 

            //configuration.GetConnectionString("Default")


        }
    }
}
