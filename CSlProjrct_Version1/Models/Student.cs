
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
       
        public int student_id { get; set; }
        public string student_fn { get; set; }
        public string student_ln { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }

        public Nullable<int> branch_id { get; set; }
        public Nullable<int> intake_id { get; set; }
        public Nullable<int> track_id { get; set; }
        public Nullable<int> exam_id { get; set; }
        public Nullable<int> course_id { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Course Course { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Intake Intake { get; set; }
        public virtual Track Track { get; set; }
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
    }
}
