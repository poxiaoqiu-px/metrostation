using System.Collections.Generic;
using System.Reflection;
using Abp.Dapper;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using MetroStation.EntityFrameworkCore.Seed;

namespace MetroStation.EntityFrameworkCore
{
    [DependsOn(
        typeof(MetroStationCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule),
        typeof(AbpDapperModule))]
    public class MetroStationEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<MetroStationDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        MetroStationDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        MetroStationDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });

                Configuration.Modules.AbpEfCore().AddDbContext<AuditLogDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AuditLogDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AuditLogDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MetroStationEntityFrameworkModule).GetAssembly());
            //这里会自动去扫描程序集中配置好的映射关系
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(MetroStationEntityFrameworkModule).GetAssembly() });
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
