using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 线路与站点对应
    /// </summary>
    public class StationLineMapping:Entity
    {
        /// <summary>
        /// 站点
        /// </summary>
        /// <value>The station identifier.</value>
        public int StationId { get; set; }
        /// <summary>
        /// 逻辑线路
        /// </summary>
        /// <value>The logic line identifier.</value>
        public int LogicLineId { get; set; }
        /// <summary>
        /// 顺序号 
        /// </summary>
        /// <value>The sequence.</value>
        public int Sequence { get; set; }
        /// <summary>
        /// 公里数
        /// </summary>
        /// <value>The mile offset.</value>
        public decimal MileOffset { get; set; }
    }
}
