using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SShop.Web.Data;

namespace SShop.Web.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(
            this IServiceCollection services,
            IConfiguration configuration)
            => services
                .AddDbContext<CatalogContext>(options => options
                    .UseSqlServer(configuration.GetDefaultConnectionString()));



        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
            => services;

        public static IServiceCollection AddSwagger(this IServiceCollection services)
            => services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(
                    "v1",
                    new OpenApiInfo
                    {
                        Title = "SShop.Web",
                        Version = "v1"
                    });
                c.EnableAnnotations();
            });

        public static void AddApiControllers(this IServiceCollection services)
            => services
                .AddControllers();
    }
}
