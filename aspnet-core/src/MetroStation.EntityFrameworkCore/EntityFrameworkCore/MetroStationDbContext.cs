using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MetroStation.Authorization.Roles;
using MetroStation.Authorization.Users;
using MetroStation.MultiTenancy;

namespace MetroStation.EntityFrameworkCore
{
    public class MetroStationDbContext : AbpZeroDbContext<Tenant, Role, User, MetroStationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MetroStationDbContext(DbContextOptions<MetroStationDbContext> options)
            : base(options)
        {
        }
    }
}
