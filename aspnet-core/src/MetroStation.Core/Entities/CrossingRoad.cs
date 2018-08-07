using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 交路
    /// </summary>
    public class CrossingRoad:Entity
    {
        /// <summary>
        /// 时刻表
        /// </summary>
        /// <value>The table info identifier.</value>
        public int TableInfoId { get; set; }
        /// <summary>
        /// 轮班规则明细，原系统中的zby
        /// </summary>
        /// <value>The turn rule detail identifier.</value>
        public int TurnRuleDetailId { get; set; }
        /// <summary>
        /// 用户组
        /// </summary>
        /// <value>The user group identifier.</value>
        public int UserGroupId { get; set; }
        /// <summary>
        /// 交路名称，早1、早2等
        /// </summary>
        /// <value>The name of the crossing road.</value>
        public string CrossingRoadName { get; set; }
        /// <summary>
        /// 出勤站
        /// </summary>
        /// <value>The atten station.</value>
        public string AttenStation { get; set; }
        /// <summary>
        /// 出勤时间
        /// </summary>
        /// <value>The atten time.</value>
        public DateTime AttenTime { get; set; }
        /// <summary>
        /// 出勤车次
        /// </summary>
        /// <value>The atten train.</value>
        public string AttenTrain { get; set; }
        /// <summary>
        /// 发车时间
        /// </summary>
        /// <value>The train time.</value>
        public DateTime TrainTime { get; set; }
        /// <summary>
        /// 开行交路
        /// </summary>
        /// <value>The run train.</value>
        public string RunTrain { get; set; }
        /// <summary>
        /// 退勤车次
        /// </summary>
        /// <value>The off train.</value>
        public string OffTrain { get; set; }
        /// <summary>
        /// 退勤时间
        /// </summary>
        /// <value>The off time.</value>
        public DateTime OffTime { get; set; }
        /// <summary>
        /// 退勤站
        /// </summary>
        /// <value>The off station.</value>
        public string OffStation { get; set; }
        /// <summary>
        /// 公里数
        /// </summary>
        /// <value>The miles.</value>
        public decimal Miles { get; set; }
        /// <summary>
        /// 工时
        /// </summary>
        /// <value>The hours.</value>
        public decimal Hours { get; set; }
    }
}
