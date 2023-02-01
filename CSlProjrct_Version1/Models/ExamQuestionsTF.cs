using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlProjrct_Version1
{
   public partial class ExamQuestionsTF
    {
        public int question_id { get; set; }
        public string question_des { get; set; }
        public bool answerTF { get; set; }
        public Nullable<int> degree { get; set; }
        public int exam_id { get; set; }
        public String StudentanswerTf { get; set; }

        public virtual Exam Exam { get; set; }
    }
}
