using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Auditing;
using Abp.AutoMapper;

namespace MetroStation.Entities
{
    [Table("Auditlog")]
    [AutoMapFrom(typeof(AuditLog))]
    public class AuditLogs:AuditLog
    {
    }
}
