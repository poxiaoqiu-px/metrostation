using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 时刻表
    /// </summary>
    public class TableInfo:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 时刻表名称
        /// </summary>
        /// <value>The name of the table.</value>
        public string TableName { get; set; }
        /// <summary>
        /// 导入时间
        /// </summary>
        /// <value>The insert time.</value>
        public DateTime InsertTime { get; set; }
    }
}
