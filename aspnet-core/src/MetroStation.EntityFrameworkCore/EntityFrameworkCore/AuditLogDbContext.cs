using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MetroStation.Authorization.Roles;
using MetroStation.Authorization.Users;
using MetroStation.MultiTenancy;
using MetroStation.Entities;
using MetroStation.Mapping;

namespace MetroStation.EntityFrameworkCore
{
    public class AuditLogDbContext : DbContext
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<AuditLogs> AuditLog { get; set; }

        public AuditLogDbContext(DbContextOptions<AuditLogDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
