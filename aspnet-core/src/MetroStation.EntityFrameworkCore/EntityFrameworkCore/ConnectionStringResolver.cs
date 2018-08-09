using System;
using Abp.Configuration.Startup;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.MultiTenancy;
using Abp.Zero.EntityFrameworkCore;
using MetroStation.Configuration;
using MetroStation.Web;
using Microsoft.Extensions.Configuration;

namespace MetroStation.EntityFrameworkCore
{
    public class ConnectionStringResolver : DefaultConnectionStringResolver
    {
        public ConnectionStringResolver(IAbpStartupConfiguration configuration)
            : base(configuration)
        {
        }

        public override string GetNameOrConnectionString(ConnectionStringResolveArgs args)
        {
            if (args["DbContextConcreteType"] as Type == typeof(AuditLogDbContext))
            {
                var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());
                return configuration.GetConnectionString(MetroStationConsts.AuditLogConnectionStringName);
            }

            return base.GetNameOrConnectionString(args);
        }
    }
}
