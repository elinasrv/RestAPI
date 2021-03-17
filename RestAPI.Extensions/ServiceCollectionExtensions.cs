using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestAPI.Data.DBContext;
using RestAPI.Repositories;
using RestAPI.Repositories.Interfaces;
using RestAPI.Services;
using RestAPI.Services.Interfaces;
using Microsoft.Extensions.Hosting;

namespace RestAPI.Extensions
{
    /// <summary>
    /// Extension class for registering the serivces for DI
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the services to the DI container
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddRestServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddTransient<AppDbContext>();
            services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("RestAPI-in-memory"),ServiceLifetime.Transient);

            //services.AddScoped<IBaseRepository,BaseRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();

           
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetSection("ConnectionString").Value));

            return services;
        }
    }
}
