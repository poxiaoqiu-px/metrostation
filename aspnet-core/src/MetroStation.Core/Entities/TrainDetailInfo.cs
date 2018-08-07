using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 列车运营记录
    /// </summary>
    public class TrainDetailInfo:Entity
    {
        /// <summary>
        /// 时刻表
        /// </summary>
        /// <value>The table info identifier.</value>
        public int TableInfoId { get; set; }
        /// <summary>
        /// 列车号
        /// </summary>
        /// <value>The train identifier.</value>
        public string TrainId { get; set; }
        /// <summary>
        /// 发车时间
        /// </summary>
        /// <value>The start.</value>
        public int Start { get; set; }
        /// <summary>
        /// 回库时间
        /// </summary>
        /// <value>The end.</value>
        public int End { get; set; }
        /// <summary>
        /// 运行时长
        /// </summary>
        /// <value>The interval.</value>
        public int Interval { get; set; }
    }
}
