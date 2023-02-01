
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamQuestionsText
    {
        public int question_id { get; set; }
        public string question_des { get; set; }
        public string answerText { get; set; }
        public Nullable<int> degree { get; set; }
        public int exam_id { get; set; }
        public String StudentanswerText { get; set; }

        public virtual Exam Exam { get; set; }
    }
}
