
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ExamQuestionsChoice
    {
        public int question_id { get; set; }
        public string question_des { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        [MaxLength(1)]
        public  string answerChoice { get; set; }
        [MaxLength(1)]
        public string StudentanswerChoice { get; set; }
        public Nullable<int> degree { get; set; }
        public int exam_id { get; set; }
        public virtual Exam Exam { get; set; }
    }
}
