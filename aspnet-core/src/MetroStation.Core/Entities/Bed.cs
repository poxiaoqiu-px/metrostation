using System;
using Abp.Domain.Entities;

namespace MetroStation.Entities
{
    /// <summary>
    /// 床位
    /// </summary>
    public class Bed:Entity
    {
        /// <summary>
        /// 所属房间
        /// </summary>
        /// <value>The room identifier.</value>
        public int RoomId { get; set; }
        /// <summary>
        /// 床位号
        /// </summary>
        /// <value>The bed number.</value>
        public string BedNum { get; set; }
    }
}
