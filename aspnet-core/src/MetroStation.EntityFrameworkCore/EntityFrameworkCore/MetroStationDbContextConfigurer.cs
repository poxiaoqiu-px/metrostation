using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MetroStation.EntityFrameworkCore
{
    public static class MetroStationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MetroStationDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MetroStationDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
