using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 司机队排班计划
    /// </summary>
    public class UserTeamRecord:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        /// <value>The rec date.</value>
        public DateTime RecDate { get; set; }
        /// <summary>
        /// 司机队
        /// </summary>
        /// <value>The user team identifier.</value>
        public int UserTeamId { get; set; }
        /// <summary>
        /// 顺序号，用于和当日期交路对应
        /// </summary>
        /// <value>The sequence.</value>
        public int Sequence { get; set; }
    }
}
