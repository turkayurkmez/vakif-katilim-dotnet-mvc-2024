using eshop.Application;
using eshop.Infrastructure;
using eshop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Common.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, string connectionString)
        {
          //Application
            services.AddScoped<IProductService, CustomProductService>();
            services.AddScoped<ICategoryService, CustomCategoryService>();
            services.AddScoped<IUserService, UserService>();
          //Infrastructure
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepostiory>();        
            services.AddDbContext<VakifEshopDbContext>(option => option.UseSqlServer(connectionString));

            return services;
        }
    }
}
