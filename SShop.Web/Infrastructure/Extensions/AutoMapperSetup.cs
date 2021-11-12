using SShop.Web.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SShop.Web.Infrastructure.Extensions
{
    public static class AutoMapperSetup
    {
        public static IServiceCollection AddAutoMapperSetup(this IServiceCollection services)
        {
            var mapper = AutoMapperConfiguration.ConfigureMappings();
            services.AddAutoMapper(x => mapper.CreateMapper(), Assembly.Load("SShop.Web"));
            return services;
        }
    }
}
