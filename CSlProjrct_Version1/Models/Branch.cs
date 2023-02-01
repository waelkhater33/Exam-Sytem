
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Branch
    {
        public int branch_id { get; set; }
        public string branch_name { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
