using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 列车运行计划
    /// </summary>
    public class TrainSchedule:Entity<long>
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
        /// 起始站
        /// </summary>
        /// <value>The start station identifier.</value>
        public int StartStationId { get; set; }
        /// <summary>
        /// 终点站
        /// </summary>
        /// <value>The end station identifier.</value>
        public int EndStationId { get; set; }
        /// <summary>
        /// 当前站
        /// </summary>
        /// <value>The station identifier.</value>
        public int StationId { get; set; }
        /// <summary>
        /// 顺序号
        /// </summary>
        /// <value>The sequence.</value>
        public int Sequence { get; set; }
        /// <summary>
        /// 到站时间
        /// </summary>
        /// <value>The arrive.</value>
        public int Arrive { get; set; }
        /// <summary>
        /// 离站时间
        /// </summary>
        /// <value>The depart.</value>
        public int Depart { get; set; }
        /// <summary>
        /// 上下行
        /// </summary>
        /// <value>The direction.</value>
        public int Direction { get; set; }
        /// <summary>
        /// 车次号
        /// </summary>
        /// <value>The train identifier.</value>
        public string TrainId { get; set; }
        /// <summary>
        /// 车体号
        /// </summary>
        /// <value>The middle identifier.</value>
        public string MidId { get; set; }
        /// <summary>
        /// 趟次号
        /// </summary>
        /// <value>The last identifier.</value>
        public string LastId { get; set; }
        /// <summary>
        /// 下趟车次号
        /// </summary>
        /// <value>The arc ne.</value>
        public string Arc_Ne { get; set; }
        /// <summary>
        /// 停站时间
        /// </summary>
        /// <value>The stop.</value>
        public int Stop { get; set; }
        /// <summary>
        /// 本站运行时间，即从上一站到本站的时间
        /// </summary>
        /// <value>The RTT IME.</value>
        public int RTTime { get; set; }
    }
}
