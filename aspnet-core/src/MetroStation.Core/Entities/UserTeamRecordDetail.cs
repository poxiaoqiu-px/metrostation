using System;
using Abp.Domain.Entities;

namespace MetroStation.Entities
{
    /// <summary>
    /// 司机队排班计划明细
    /// </summary>
    public class UserTeamRecordDetail:Entity
    {
        /// <summary>
        /// 司机队排班计划
        /// </summary>
        /// <value>The user team record identifier.</value>
        public int UserTeamRecordId { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        /// <value>The user identifier.</value>
        public int UserId { get; set; }
        /// <summary>
        /// 用户类型
        /// </summary>
        /// <value>The user type identifier.</value>
        public int UserTypeId { get; set; }
    }
}
