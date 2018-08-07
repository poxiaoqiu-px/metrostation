using System;
using Abp.Domain.Entities;

namespace MetroStation.Entities
{
    /// <summary>
    /// 站点
    /// </summary>
    public class Station:Entity
    {
        /// <summary>
        /// 站点名称
        /// </summary>
        /// <value>The name of the station.</value>
        public string StationName { get; set; }
        /// <summary>
        /// 简拼
        /// </summary>
        /// <value>The station abbr.</value>
        public string StationAbbr { get; set; }
    }
}
