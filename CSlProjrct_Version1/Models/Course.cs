
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
       
        public int course_id { get; set; }
        public string course_name { get; set; }
        public Nullable<int> min_deg { get; set; }
        public Nullable<int> max_deg { get; set; }
        public Nullable<int> instructor_id { get; set; }
    
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<QuestionstChoice> QuestionstChoices { get; set; }
        public virtual ICollection<QuestionstText> QuestionstTexts { get; set; }
        public virtual ICollection<QuestionstTF> QuestionstTFs { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
    }
}
