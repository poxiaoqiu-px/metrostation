using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MetroStation.Authorization.Roles;
using MetroStation.Authorization.Users;
using MetroStation.MultiTenancy;
using MetroStation.Entities;
using MetroStation.Mapping;

namespace MetroStation.EntityFrameworkCore
{
    public class MetroStationDbContext : AbpZeroDbContext<Tenant, Role, User, MetroStationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Apartment> Apartment { get; set; }
        public DbSet<Bed> Bed { get; set; }
        public DbSet<BedUserMapping> BedUserMapping { get; set; }
        public DbSet<CrossingRoad> CrossingRoad { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ExamRecord> ExamRecord { get; set; }
        public DbSet<ExamRecordDetail> ExamRecordDetail { get; set; }
        public DbSet<ExamType> ExamType { get; set; }
        public DbSet<Line> Line { get; set; }
        public DbSet<LogicLine> LogicLine { get; set; }
        public DbSet<RoleExamTypeMapping> RoleExamTypeMapping { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<StationCode> StationCode { get; set; }
        public DbSet<StationLineMapping> StationLineMapping { get; set; }
        public DbSet<TableInfo> TableInfo { get; set; }
        public DbSet<TableInfoToDate> TableInfoToDate { get; set; }
        public DbSet<TrainDetailInfo> TrainDetailInfo { get; set; }
        public DbSet<TrainSchedule> TrainSchedule { get; set; }
        public DbSet<TurnRule> TurnRule { get; set; }
        public DbSet<TurnRuleDetail> TurnRuleDetail { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }
        public DbSet<UserLineMapping> UserLineMapping { get; set; }
        public DbSet<UserOnDutyRecord> UserOnDutyRecord { get; set; }
        public DbSet<UserOnDutyRecordDetail> UserOnDutyRecordDetail { get; set; }
        public DbSet<UserOnDutyUnit> UserOnDutyUnit { get; set; }
        public DbSet<UserTeam> UserTeam { get; set; }
        public DbSet<UserTeamPlan> UserTeamPlan { get; set; }
        public DbSet<UserTeamRecord> UserTeamRecord { get; set; }
        public DbSet<UserTeamRecordDetail> UserTeamRecordDetail { get; set; }
        public DbSet<UserType> UserType { get; set; }

        public MetroStationDbContext(DbContextOptions<MetroStationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddEntityConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
