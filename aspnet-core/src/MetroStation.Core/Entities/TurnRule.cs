using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 轮班规则
    /// </summary>
    public class TurnRule:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 轮班规则名称
        /// </summary>
        /// <value>The name of the turn rule.</value>
        public string TurnRuleName { get; set; }
        /// <summary>
        /// 是否包含周末
        /// </summary>
        /// <value><c>true</c> if include weekend; otherwise, <c>false</c>.</value>
        public bool IncludeWeekend { get; set; }
    }
}
