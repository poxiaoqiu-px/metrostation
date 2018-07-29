using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MetroStation.Configuration;
using MetroStation.Web;

namespace MetroStation.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MetroStationDbContextFactory : IDesignTimeDbContextFactory<MetroStationDbContext>
    {
        public MetroStationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MetroStationDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MetroStationDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MetroStationConsts.ConnectionStringName));

            return new MetroStationDbContext(builder.Options);
        }
    }
}
