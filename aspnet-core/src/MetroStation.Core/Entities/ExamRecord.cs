using System;
using Abp.Authorization.Users;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 考试记录
    /// </summary>
    public class ExamRecord:Entity
    {
        /// <summary>
        /// 用户
        /// </summary>
        /// <value>The user identifier.</value>
        public int UserId { get; set; }
        /// <summary>
        /// 考试类型
        /// </summary>
        /// <value>The exam type identifier.</value>
        public int ExamTypeId { get; set; }
        /// <summary>
        /// 考题数量
        /// </summary>
        /// <value>The exam count.</value>
        public int ExamCount { get; set; }
        /// <summary>
        /// 错误数量
        /// </summary>
        /// <value>The error count.</value>
        public int ErrorCount { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        /// <value>The exam date.</value>
        public DateTime ExamDate { get; set; }
    }
}
