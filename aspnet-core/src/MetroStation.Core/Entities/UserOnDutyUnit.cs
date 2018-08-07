using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 出勤单元
    /// </summary>
    public class UserOnDutyUnit:Entity
    {
        /// <summary>
        /// 所属车队
        /// </summary>
        /// <value>The user team identifier.</value>
        public int UserTeamId { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        /// <value>The user identifier.</value>
        public int UserId { get; set; }
        /// <summary>
        /// 用户类型，操控司机、学员司机、派班员等
        /// </summary>
        /// <value>The user type identifier.</value>
        public int UserTypeId { get; set; }
        /// <summary>
        /// 顺序号
        /// </summary>
        /// <value>The sequence.</value>
        public int Sequence { get; set; }
    }
}
