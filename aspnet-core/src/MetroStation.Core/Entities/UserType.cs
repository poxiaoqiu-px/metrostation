using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 用户类型，操控司机、学员司机、派班员等
    /// </summary>
    public class UserType:Entity
    {
        /// <summary>
        /// 用户类型
        /// </summary>
        /// <value>The name of the user type.</value>
        public string UserTypeName { get; set; }
    }
}
