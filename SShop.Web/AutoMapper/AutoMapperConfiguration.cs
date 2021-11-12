using AutoMapper;
using SShop.Web.AutoMapper.Profiles;

namespace SShop.Web.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration ConfigureMappings()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => {
                cfg.AddProfile(new EntityToCommandProfile());
            });
            return mapperConfiguration;
        }
    }
}