
namespace cas_caproject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
       
        public int exam_id { get; set; }
        public string exam_type { get; set; }
        public Nullable<System.DateTime> startTime { get; set; }
        public Nullable<System.DateTime> endTime { get; set; }
        public Nullable<System.TimeSpan> totalTime { get; set; }
        public int course_id { get; set; }
        public int instructor_id { get; set; }
        public int branch_id { get; set; }
        public int intake_id { get; set; }
        public int track_id { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual Intake Intake { get; set; }
        public virtual Track Track { get; set; }
        public virtual ICollection<ExamQuestionsChoice> ExamQuestionsChoices { get; set; }
        public virtual ICollection<ExamQuestionsText> ExamQuestionsTexts { get; set; }
        public virtual ICollection<ExamQuestionsTF> ExamQuestionsTFs { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
        public virtual ICollection<AllowanceOption> AllowanceOptions { get; set; }



    }
}
