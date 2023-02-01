using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlProjrct_Version1.Models
{
    internal class StudentAnswerSheet
    {
       
        public  int Student_id { get; set; }
        public int exam_id { get; set; }
        public int question_id { get; set; }

        public int degree { get; set; }
        public String question { get; set; }
        public String Answers { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual Student Student { get; set; } 
        




    }
}
