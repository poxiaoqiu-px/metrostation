using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 角色与考试类型映射，用于生成特定数量的考题
    /// </summary>
    public class RoleExamTypeMapping:Entity
    {
        /// <summary>
        /// 考试类型
        /// </summary>
        /// <value>The exam type identifier.</value>
        public int ExamTypeId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        /// <value>The role identifier.</value>
        public int RoleId { get; set; }
        /// <summary>
        /// 考题数量
        /// </summary>
        /// <value>The exam count.</value>
        public int ExamCount { get; set; }
    }
}
