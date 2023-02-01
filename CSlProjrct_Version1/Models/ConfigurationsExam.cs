using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlProjrct_Version1
{
    class ConfigurationsExam:EntityTypeConfiguration<Exam>
    {
        public ConfigurationsExam()
        {
            this.HasKey(e => e.exam_id);
         //   this.HasMany(e=>e.allowanceOption_id);
        }
    }
}
