using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 用户线路对应
    /// </summary>
    public class UserLineMapping:Entity
    {
        /// <summary>
        /// 用户
        /// </summary>
        /// <value>The user identifier.</value>
        public int UserId { get; set; }
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
    }
}
