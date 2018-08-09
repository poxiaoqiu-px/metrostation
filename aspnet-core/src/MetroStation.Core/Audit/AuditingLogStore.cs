using System;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Castle.Core.Logging;
using MetroStation.Entities;

namespace MetroStation.Audit
{
    public class AuditingLogStore: IAuditingStore, ITransientDependency
    {
        private readonly IRepository<AuditLogs, long> _auditlogRepository;

        public AuditingLogStore(IRepository<AuditLogs, long> auditlogRepository)
        {
            _auditlogRepository = auditlogRepository;
        }

        public ILogger Logger { get; set; }
        public async Task SaveAsync(AuditInfo auditInfo)
        {
            var entity = AuditLog.CreateFromAuditInfo(auditInfo).MapTo<AuditLogs>();
            await _auditlogRepository.InsertAsync(entity);
        }
    }
}
