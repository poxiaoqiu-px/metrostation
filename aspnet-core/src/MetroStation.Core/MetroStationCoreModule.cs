﻿using Abp.Auditing;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using MetroStation.Authorization;
using MetroStation.Authorization.Roles;
using MetroStation.Authorization.Users;
using MetroStation.Configuration;
using MetroStation.Localization;
using MetroStation.MultiTenancy;
using MetroStation.Timing;
using MetroStation.Audit;

namespace MetroStation
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class MetroStationCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = false;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            MetroStationLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = MetroStationConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();

            //authorizationprovider会自动注册到依赖注入系统中
            //Configuration.Authorization.Providers.Add<MetroStationAuthorizationProvider>();

            IocManager.Register<IAuditingStore, AuditingLogStore>(DependencyLifeStyle.Transient);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MetroStationCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
