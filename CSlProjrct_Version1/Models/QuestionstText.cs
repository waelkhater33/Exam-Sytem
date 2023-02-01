
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuestionstText
    {
        public int question_id { get; set; }
        public string question_des { get; set; }
        public string answer { get; set; }
        public Nullable<int> course_id { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
