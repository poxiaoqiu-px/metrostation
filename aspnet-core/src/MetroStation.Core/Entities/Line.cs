using System;
using Abp.Domain.Entities;

namespace MetroStation.Entities
{
    /// <summary>
    /// 线路
    /// </summary>
    public class Line:Entity
    {
        /// <summary>
        /// 线路名称
        /// </summary>
        /// <value>The name of the line.</value>
        public string LineName { get; set; }

    }
}
