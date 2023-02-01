
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Intake
    {
       
        public int intake_id { get; set; }
        public Nullable<int> intake_number { get; set; }
    
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
