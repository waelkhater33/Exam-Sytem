
namespace CSlProjrct_Version1
{
    using System;
    using System.Collections.Generic;
    
    public partial class AllowanceOption
    {
   
        public int allowanceOption_id { get; set; }
        public string allowanceOption_name { get; set; }
        public Nullable<bool> option1 { get; set; }
        public Nullable<bool> option2 { get; set; }

        public int exam_id { get; set; }
        public virtual Exam Exam { get; set; }

    }
}
