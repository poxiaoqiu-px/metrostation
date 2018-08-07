using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 考试记录明细
    /// </summary>
    public class ExamRecordDetail:Entity
    {
        /// <summary>
        /// 考试记录
        /// </summary>
        /// <value>The exam record identifier.</value>
        public int ExamRecordId { get; set; }
        /// <summary>
        /// 考题编号
        /// </summary>
        /// <value>The examid.</value>
        public int ExamId { get; set; }
        /// <summary>
        /// 用户实际答案
        /// </summary>
        /// <value>The answer.</value>
        public string Answer { get; set; }
        /// <summary>
        /// 是否正确
        /// </summary>
        /// <value><c>true</c> if is correct; otherwise, <c>false</c>.</value>
        public bool IsCorrect { get; set; }
    }
}
