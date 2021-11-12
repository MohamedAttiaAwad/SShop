using Microsoft.Extensions.Configuration;

namespace SShop.Web.Infrastructure.Extensions
{
    public static class ConfigurationExtensions
    {
        public static string GetDefaultConnectionString(this IConfiguration configuration)
       => configuration.GetConnectionString("DefaultConnection");
    }
}
