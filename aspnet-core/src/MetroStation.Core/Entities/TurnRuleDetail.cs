using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 轮班规则明细
    /// </summary>
    public class TurnRuleDetail:Entity
    {
        /// <summary>
        /// 轮班规则
        /// </summary>
        /// <value>The turn rule identifier.</value>
        public int TurnRuleId { get; set; }
        /// <summary>
        /// 轮班规则明细
        /// </summary>
        /// <value>The name of the turn rule detail.</value>
        public string TurnRuleDetailName { get; set; }
        /// <summary>
        /// 是否当班
        /// </summary>
        /// <value><c>true</c> if on duty; otherwise, <c>false</c>.</value>
        public bool OnDuty { get; set; }
        /// <summary>
        /// 顺序号
        /// </summary>
        /// <value>The sequence.</value>
        public int Sequence { get; set; }
    }
}
