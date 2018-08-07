using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 时刻表分配记录
    /// </summary>
    public class TableInfoToDate:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 时刻表
        /// </summary>
        /// <value>The table info identifier.</value>
        public int TableInfoId { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        /// <value>The rec date.</value>
        public DateTime RecDate { get; set; }
    }
}
