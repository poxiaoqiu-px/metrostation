using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MetroStation.Authorization;

namespace MetroStation
{
    [DependsOn(
        typeof(MetroStationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MetroStationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MetroStationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MetroStationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
