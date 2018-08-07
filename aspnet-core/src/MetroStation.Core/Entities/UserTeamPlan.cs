using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 司机队排班
    /// </summary>
    public class UserTeamPlan:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 司机队
        /// </summary>
        /// <value>The user team identifier.</value>
        public int UserTeamId { get; set; }
        /// <summary>
        /// 轮班规则明细，即早、白、夜、休
        /// </summary>
        /// <value>The turn rule detail identifier.</value>
        public int TurnRuleDetailId { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        /// <value>The rec date.</value>
        public DateTime RecDate { get; set; }
    }
}
