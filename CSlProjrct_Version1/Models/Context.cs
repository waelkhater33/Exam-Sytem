using CSlProjrct_Version1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlProjrct_Version1
{
    class Context:DbContext
    {
        public Context() : base(@"Data Source =.; Initial Catalog = ExamDataBase; Integrated Security = true")
        {
            
        }
        public virtual DbSet<Exam>Exams{ get; set; }
        public virtual DbSet<ExamQuestionsChoice> ExamQuestionsChoices { get; set; }
        public virtual DbSet<ExamQuestionsText> ExamQuestionsTexts { get; set; }
        public virtual DbSet<ExamQuestionsTF> ExamQuestionsTFs { get; set; }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Intake> Intakes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<AllowanceOption> AllowanceOptions { get; set; }
        public virtual DbSet<StudentAnswer> StudentAnswers { get; set; }

        public virtual DbSet<QuestionstChoice> QuestionstChoices { get; set; }
        public virtual DbSet<QuestionstTF> QuestionstTFs { get; set; }
        public virtual DbSet<QuestionstText> QuestionstTexts { get; set; }
        public virtual DbSet<ExamsLip> ExamsLips { get; set; }
        public virtual DbSet<StudentAnswerSheet> StudentAnswerSheets { get; set; }







        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            //set primary key
            modelBuilder.Entity<Exam>().HasKey(e => e.exam_id);
            //set composite primary key

          modelBuilder.Entity<ExamQuestionsChoice>().HasKey(e => new { e.exam_id, e.question_id });
           modelBuilder.Entity<ExamQuestionsText>().HasKey(e => new { e.exam_id, e.question_id });
          modelBuilder.Entity<ExamQuestionsTF>().HasKey(e => new { e.exam_id, e.question_id });

            modelBuilder.Entity<StudentAnswerSheet>().HasKey(e => new { e.exam_id, e.Student_id,e.question_id });


            modelBuilder.Entity<Branch>().HasKey(e => e.branch_id);
            modelBuilder.Entity<AllowanceOption>()
                .HasKey(e => e.allowanceOption_id);

            modelBuilder.Entity<Track>().HasKey(e => e.track_id);
            modelBuilder.Entity<Intake>().HasKey(e => e.intake_id);
            modelBuilder.Entity<Course>().HasKey(e => e.course_id);
         

            modelBuilder.Entity<ExamsLip>().HasKey(e => e.exam_id);
            modelBuilder.Entity<Instructor>().HasKey(e => e.instructor_id);
            modelBuilder.Entity<QuestionstChoice>().HasKey(e => e.question_id);
            modelBuilder.Entity<QuestionstText>().HasKey(e => e.question_id);
            modelBuilder.Entity<QuestionstTF>().HasKey(e => e.question_id);
            modelBuilder.Entity<Student>().HasKey(e => e.student_id);
            modelBuilder.Entity<StudentAnswer>().HasKey(e => e.studentAnswer_id);


            modelBuilder.Entity<Exam>()
           .HasMany<AllowanceOption>(g => g.AllowanceOptions)
           .WithRequired(s => s.Exam)
           .HasForeignKey<int>(s => s.exam_id);
           //branch exam 1 - m 

           modelBuilder.Entity<Branch>()
           .HasMany<Exam>(g => g.Exams)
           .WithRequired(s => s.Branch)
           .HasForeignKey<int>(s => s.branch_id);









            // modelBuilder.Configurations.Add(new ConfigurationsExam());



        }

    }
}
