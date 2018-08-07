using System;
using Abp.Domain.Entities;
namespace MetroStation.Entities
{
    /// <summary>
    /// 题库
    /// </summary>
    public class Exam:Entity
    {
        /// <summary>
        /// 线路
        /// </summary>
        /// <value>The line identifier.</value>
        public int LineId { get; set; }
        /// <summary>
        /// 考试类型
        /// </summary>
        /// <value>The exam type identifier.</value>
        public int ExamTypeId { get; set; }
        /// <summary>
        /// 题目等级
        /// </summary>
        /// <value>The exam level.</value>
        public int ExamLevel { get; set; }
        /// <summary>
        /// 题干
        /// </summary>
        /// <value>The exam text.</value>
        public string ExamText { get; set; }
        /// <summary>
        /// 正确答案
        /// </summary>
        /// <value>The answer.</value>
        public string Answer { get; set; }
        /// <summary>
        /// 选项
        /// </summary>
        /// <value>The option a.</value>
        public string OptionA { get; set; }
        /// <summary>
        /// 选项
        /// </summary>
        /// <value>The option b.</value>
        public string OptionB { get; set; }
        /// <summary>
        /// 选项
        /// </summary>
        /// <value>The option c.</value>
        public string OptionC { get; set; }
        /// <summary>
        /// 选项
        /// </summary>
        /// <value>The option d.</value>
        public string OptionD { get; set; }
        /// <summary>
        /// 选项
        /// </summary>
        /// <value>The option e.</value>
        public string OptionE { get; set; }
        /// <summary>
        /// 选项
        /// </summary>
        /// <value>The option f.</value>
        public string OptionF { get; set; }
    }
}
