using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

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
            //builder.UseMySql(connection);
            builder.UseMySql(connection, x =>
             {
                 x.ServerVersion(new Version("10.3.8"), ServerType.MariaDb);
             });
        }
    }
}
