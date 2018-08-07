using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 逻辑线路
    /// </summary>
    public class LogicLine:Entity
    {
        /// <summary>
        /// 逻辑线路名称
        /// </summary>
        /// <value>The name of the logic line.</value>
        public string LogicLineName { get; set; }
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
    }
}
