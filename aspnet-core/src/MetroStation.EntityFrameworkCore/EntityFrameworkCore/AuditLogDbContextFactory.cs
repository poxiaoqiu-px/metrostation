using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MetroStation.Configuration;
using MetroStation.Web;

namespace MetroStation.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AuditLogDbContextFactory : IDesignTimeDbContextFactory<AuditLogDbContext>
    {

        public AuditLogDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AuditLogDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AuditLogDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MetroStationConsts.AuditLogConnectionStringName));

            return new AuditLogDbContext(builder.Options);
        }
    }
}
