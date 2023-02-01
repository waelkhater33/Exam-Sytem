
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instructor
    {
        
    
        public int instructor_id { get; set; }
        public string instructor_f_n { get; set; }
        public string instructor_l_n { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public Nullable<int> manager_ID { get; set; }
    
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
