using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MetroStation.Configuration;

namespace MetroStation.Web.Host.Startup
{
    [DependsOn(
       typeof(MetroStationWebCoreModule))]
    public class MetroStationWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MetroStationWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MetroStationWebHostModule).GetAssembly());
        }
    }
}
