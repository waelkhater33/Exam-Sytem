
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentAnswer
    {
        public int studentAnswer_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> exam_id { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<int> result { get; set; }
        public Nullable<int> resultC { get; set; }
        public Nullable<int> resultTF { get; set; }
        public Nullable<int> resultText { get; set; }
        public Nullable<int> exam_degree { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Student Student { get; set; }

       // public virtual ICollection<AnswersChoose> AnswersChoose { get; set; }
     


    }
}
