using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 用户单元出勤记录明细
    /// </summary>
    public class UserOnDutyRecordDetail:Entity
    {
        /// <summary>
        /// 用户出勤记录
        /// </summary>
        /// <value>The user on duty record identifier.</value>
        public int UserOnDutyRecordId { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        /// <value>The rec date.</value>
        public DateTime RecDate { get; set; }
        /// <summary>
        /// 用户类型
        /// </summary>
        /// <value>The user type identifier.</value>
        public int UserTypeId { get; set; }
        /// <summary>
        /// 计划司机
        /// </summary>
        /// <value>The plan user identifier.</value>
        public int PlanUserId { get; set; }
        /// <summary>
        /// 实际司机
        /// </summary>
        /// <value>The user identifier.</value>
        public int UserId { get; set; }
    }
}
