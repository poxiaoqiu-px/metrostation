using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 站点码，即目的地码
    /// </summary>
    public class StationCode:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 站点
        /// </summary>
        /// <value>The station identifier.</value>
        public int StationId { get; set; }
        /// <summary>
        /// 站点码
        /// </summary>
        /// <value>The name of the station code.</value>
        public string StationCodeName { get; set; }
    }
}
