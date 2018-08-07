using System;
using Abp.Domain.Entities;

namespace MetroStation.Entities
{
    /// <summary>
    /// 司机住宿记录
    /// </summary>
    public class BedUserMapping:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 住宿日期
        /// </summary>
        /// <value>The rec date.</value>
        public DateTime RecDate { get; set; }
        /// <summary>
        /// 公寓
        /// </summary>
        /// <value>The apartment identifier.</value>
        public int ApartmentId { get; set; }
        /// <summary>
        /// 房间
        /// </summary>
        /// <value>The room identifier.</value>
        public int RoomId { get; set; }
        /// <summary>
        /// 床位
        /// </summary>
        /// <value>The bed identifier.</value>
        public int BedId { get; set; }
        /// <summary>
        /// 司机
        /// </summary>
        /// <value>The user identifier.</value>
        public int UserId { get; set; }
        /// <summary>
        /// 早班出勤时间
        /// </summary>
        /// <value>The attend time.</value>
        public DateTime AttendTime { get; set; }
        /// <summary>
        /// 叫班时间
        /// </summary>
        /// <value>The call time.</value>
        public DateTime CallTime { get; set; }
    }
}
