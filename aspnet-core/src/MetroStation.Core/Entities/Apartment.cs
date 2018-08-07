using System;
using Abp.Domain.Entities;

namespace MetroStation.Entities
{
    /// <summary>
    /// 公寓
    /// </summary>
    public class Apartment:Entity
    {
        /// <summary>
        /// 公寓名称
        /// </summary>
        /// <value>The name of the apartment.</value>
        public string ApartmentName { get; set; }
        /// <summary>
        /// 所属线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 对应的退勤站点
        /// </summary>
        /// <value>The station identifier.</value>
        public int StationId { get; set; }
    }
}
