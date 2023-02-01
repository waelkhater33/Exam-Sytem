
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class QuestionstChoice
    {
        public int question_id { get; set; }
        public string question_des { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        [MaxLength(1)]
        public String answer { get; set; }
        public Nullable<int> course_id { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
