using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 用户组
    /// </summary>
    public class UserGroup:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 用户组
        /// </summary>
        /// <value>The name of the user group.</value>
        public string UserGroupName { get; set; }
    }
}
