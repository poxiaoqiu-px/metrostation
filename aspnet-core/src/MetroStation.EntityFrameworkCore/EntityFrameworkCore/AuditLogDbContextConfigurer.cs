using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace MetroStation.EntityFrameworkCore
{
    public static class AuditLogDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AuditLogDbContext> builder, string connectionString)
        {
            //builder.UseMySql(connectionString);
            builder.UseMySql(connectionString, x =>
            {
                x.ServerVersion(new Version("10.3.8"), ServerType.MariaDb);
            });
        }

        public static void Configure(DbContextOptionsBuilder<AuditLogDbContext> builder, DbConnection connection)
        {
            //builder.UseMySql(connection);
            builder.UseMySql(connection, x =>
             {
                 x.ServerVersion(new Version("10.3.8"), ServerType.MariaDb);
             });
        }
    }
}
