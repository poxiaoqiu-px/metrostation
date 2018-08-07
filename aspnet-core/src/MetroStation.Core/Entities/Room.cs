using System;
using Abp.Domain.Entities;

namespace MetroStation.Entities
{
    /// <summary>
    /// 房间
    /// </summary>
    public class Room:Entity
    {
        /// <summary>
        /// 房间号
        /// </summary>
        /// <value>The name of the room.</value>
        public string RoomName { get; set; }
        /// <summary>
        /// 所属公寓
        /// </summary>
        /// <value>The apartment identifier.</value>
        public int ApartmentId { get; set; }
    }
}
