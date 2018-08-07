using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 车队
    /// </summary>
    public class UserTeam:Entity
    {
        /// <summary>
        /// 车队名称
        /// </summary>
        /// <value>The name of the user team.</value>
        public string UserTeamName { get; set; }
        /// <summary>
        /// 所属用户组
        /// </summary>
        /// <value>The user group identifier.</value>
        public int UserGroupId { get; set; }
    }
}
