using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 考试类型
    /// </summary>
    public class ExamType:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 考试类型名称
        /// </summary>
        /// <value>The name of the exam type.</value>
        public string ExamTypeName { get; set; }
    }
}
