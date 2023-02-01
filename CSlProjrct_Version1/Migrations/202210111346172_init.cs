namespace CSlProjrct_Version1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllowanceOptions",
                c => new
                    {
                        allowanceOption_id = c.Int(nullable: false, identity: true),
                        allowanceOption_name = c.String(),
                        option1 = c.Boolean(),
                        option2 = c.Boolean(),
                        exam_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.allowanceOption_id)
                .ForeignKey("dbo.Exams", t => t.exam_id, cascadeDelete: true)
                .Index(t => t.exam_id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        exam_id = c.Int(nullable: false, identity: true),
                        exam_type = c.String(),
                        startTime = c.DateTime(),
                        endTime = c.DateTime(),
                        totalTime = c.Time(precision: 7),
                        course_id = c.Int(nullable: false),
                        instructor_id = c.Int(nullable: false),
                        branch_id = c.Int(nullable: false),
                        intake_id = c.Int(nullable: false),
                        track_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.exam_id)
                .ForeignKey("dbo.Branches", t => t.branch_id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.course_id, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.instructor_id, cascadeDelete: true)
                .ForeignKey("dbo.Intakes", t => t.intake_id, cascadeDelete: true)
                .ForeignKey("dbo.Tracks", t => t.track_id, cascadeDelete: true)
                .Index(t => t.course_id)
                .Index(t => t.instructor_id)
                .Index(t => t.branch_id)
                .Index(t => t.intake_id)
                .Index(t => t.track_id);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        branch_id = c.Int(nullable: false, identity: true),
                        branch_name = c.String(),
                    })
                .PrimaryKey(t => t.branch_id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        student_id = c.Int(nullable: false, identity: true),
                        student_fn = c.String(),
                        student_ln = c.String(),
                        adress = c.String(),
                        phone = c.String(),
                        userName = c.String(),
                        Password = c.String(),
                        branch_id = c.Int(),
                        intake_id = c.Int(),
                        track_id = c.Int(),
                        exam_id = c.Int(),
                        course_id = c.Int(),
                    })
                .PrimaryKey(t => t.student_id)
                .ForeignKey("dbo.Branches", t => t.branch_id)
                .ForeignKey("dbo.Courses", t => t.course_id)
                .ForeignKey("dbo.Exams", t => t.exam_id)
                .ForeignKey("dbo.Intakes", t => t.intake_id)
                .ForeignKey("dbo.Tracks", t => t.track_id)
                .Index(t => t.branch_id)
                .Index(t => t.intake_id)
                .Index(t => t.track_id)
                .Index(t => t.exam_id)
                .Index(t => t.course_id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        course_id = c.Int(nullable: false, identity: true),
                        course_name = c.String(),
                        min_deg = c.Int(),
                        max_deg = c.Int(),
                        instructor_id = c.Int(),
                    })
                .PrimaryKey(t => t.course_id)
                .ForeignKey("dbo.Instructors", t => t.instructor_id)
                .Index(t => t.instructor_id);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        instructor_id = c.Int(nullable: false, identity: true),
                        instructor_f_n = c.String(),
                        instructor_l_n = c.String(),
                        email = c.String(),
                        adress = c.String(),
                        phone = c.String(),
                        userName = c.String(),
                        Password = c.String(),
                        manager_ID = c.Int(),
                    })
                .PrimaryKey(t => t.instructor_id);
            
            CreateTable(
                "dbo.QuestionstChoices",
                c => new
                    {
                        question_id = c.Int(nullable: false, identity: true),
                        question_des = c.String(),
                        option1 = c.String(),
                        option2 = c.String(),
                        option3 = c.String(),
                        option4 = c.String(),
                        course_id = c.Int(),
                    })
                .PrimaryKey(t => t.question_id)
                .ForeignKey("dbo.Courses", t => t.course_id)
                .Index(t => t.course_id);
            
            CreateTable(
                "dbo.QuestionstTexts",
                c => new
                    {
                        question_id = c.Int(nullable: false, identity: true),
                        question_des = c.String(),
                        answer = c.String(),
                        course_id = c.Int(),
                    })
                .PrimaryKey(t => t.question_id)
                .ForeignKey("dbo.Courses", t => t.course_id)
                .Index(t => t.course_id);
            
            CreateTable(
                "dbo.QuestionstTFs",
                c => new
                    {
                        question_id = c.Int(nullable: false, identity: true),
                        question_des = c.String(),
                        answer = c.Boolean(),
                        course_id = c.Int(),
                    })
                .PrimaryKey(t => t.question_id)
                .ForeignKey("dbo.Courses", t => t.course_id)
                .Index(t => t.course_id);
            
            CreateTable(
                "dbo.StudentAnswers",
                c => new
                    {
                        studentAnswer_id = c.Int(nullable: false, identity: true),
                        student_id = c.Int(),
                        exam_id = c.Int(),
                        course_id = c.Int(),
                        result = c.Int(),
                        resultC = c.Int(),
                        resultTF = c.Int(),
                        resultText = c.Int(),
                        exam_degree = c.Int(),
                    })
                .PrimaryKey(t => t.studentAnswer_id)
                .ForeignKey("dbo.Courses", t => t.course_id)
                .ForeignKey("dbo.Exams", t => t.exam_id)
                .ForeignKey("dbo.Students", t => t.student_id)
                .Index(t => t.student_id)
                .Index(t => t.exam_id)
                .Index(t => t.course_id);
            
            CreateTable(
                "dbo.Intakes",
                c => new
                    {
                        intake_id = c.Int(nullable: false, identity: true),
                        intake_number = c.Int(),
                    })
                .PrimaryKey(t => t.intake_id);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        track_id = c.Int(nullable: false, identity: true),
                        track_name = c.String(),
                    })
                .PrimaryKey(t => t.track_id);
            
            CreateTable(
                "dbo.ExamQuestionsChoices",
                c => new
                    {
                        exam_id = c.Int(nullable: false),
                        question_id = c.Int(nullable: false),
                        question_des = c.String(),
                        option1 = c.String(),
                        option2 = c.String(),
                        option3 = c.String(),
                        option4 = c.String(),
                        degree = c.Int(),
                    })
                .PrimaryKey(t => new { t.exam_id, t.question_id })
                .ForeignKey("dbo.Exams", t => t.exam_id, cascadeDelete: true)
                .Index(t => t.exam_id);
            
            CreateTable(
                "dbo.ExamQuestionsTexts",
                c => new
                    {
                        exam_id = c.Int(nullable: false),
                        question_id = c.Int(nullable: false),
                        question_des = c.String(),
                        answerText = c.String(),
                        degree = c.Int(),
                        StudentanswerText = c.String(),
                    })
                .PrimaryKey(t => new { t.exam_id, t.question_id })
                .ForeignKey("dbo.Exams", t => t.exam_id, cascadeDelete: true)
                .Index(t => t.exam_id);
            
            CreateTable(
                "dbo.ExamQuestionsTFs",
                c => new
                    {
                        exam_id = c.Int(nullable: false),
                        question_id = c.Int(nullable: false),
                        question_des = c.String(),
                        answerTF = c.Boolean(nullable: false),
                        degree = c.Int(),
                        StudentanswerTf = c.String(),
                    })
                .PrimaryKey(t => new { t.exam_id, t.question_id })
                .ForeignKey("dbo.Exams", t => t.exam_id, cascadeDelete: true)
                .Index(t => t.exam_id);
            
            CreateTable(
                "dbo.ExamsLips",
                c => new
                    {
                        exam_id = c.Int(nullable: false, identity: true),
                        course_name = c.String(),
                        instructor_name = c.String(),
                        exams_year = c.String(),
                    })
                .PrimaryKey(t => t.exam_id);
            
            CreateTable(
                "dbo.StudentAnswerSheets",
                c => new
                    {
                        exam_id = c.Int(nullable: false),
                        Student_id = c.Int(nullable: false),
                        question_id = c.Int(nullable: false),
                        degree = c.Int(nullable: false),
                        question = c.String(),
                        Answers = c.String(),
                    })
                .PrimaryKey(t => new { t.exam_id, t.Student_id })
                .ForeignKey("dbo.Exams", t => t.exam_id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_id, cascadeDelete: true)
                .Index(t => t.exam_id)
                .Index(t => t.Student_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAnswerSheets", "Student_id", "dbo.Students");
            DropForeignKey("dbo.StudentAnswerSheets", "exam_id", "dbo.Exams");
            DropForeignKey("dbo.ExamQuestionsTFs", "exam_id", "dbo.Exams");
            DropForeignKey("dbo.ExamQuestionsTexts", "exam_id", "dbo.Exams");
            DropForeignKey("dbo.ExamQuestionsChoices", "exam_id", "dbo.Exams");
            DropForeignKey("dbo.Students", "track_id", "dbo.Tracks");
            DropForeignKey("dbo.Exams", "track_id", "dbo.Tracks");
            DropForeignKey("dbo.Students", "intake_id", "dbo.Intakes");
            DropForeignKey("dbo.Exams", "intake_id", "dbo.Intakes");
            DropForeignKey("dbo.Students", "exam_id", "dbo.Exams");
            DropForeignKey("dbo.Students", "course_id", "dbo.Courses");
            DropForeignKey("dbo.StudentAnswers", "student_id", "dbo.Students");
            DropForeignKey("dbo.StudentAnswers", "exam_id", "dbo.Exams");
            DropForeignKey("dbo.StudentAnswers", "course_id", "dbo.Courses");
            DropForeignKey("dbo.QuestionstTFs", "course_id", "dbo.Courses");
            DropForeignKey("dbo.QuestionstTexts", "course_id", "dbo.Courses");
            DropForeignKey("dbo.QuestionstChoices", "course_id", "dbo.Courses");
            DropForeignKey("dbo.Exams", "instructor_id", "dbo.Instructors");
            DropForeignKey("dbo.Courses", "instructor_id", "dbo.Instructors");
            DropForeignKey("dbo.Exams", "course_id", "dbo.Courses");
            DropForeignKey("dbo.Students", "branch_id", "dbo.Branches");
            DropForeignKey("dbo.Exams", "branch_id", "dbo.Branches");
            DropForeignKey("dbo.AllowanceOptions", "exam_id", "dbo.Exams");
            DropIndex("dbo.StudentAnswerSheets", new[] { "Student_id" });
            DropIndex("dbo.StudentAnswerSheets", new[] { "exam_id" });
            DropIndex("dbo.ExamQuestionsTFs", new[] { "exam_id" });
            DropIndex("dbo.ExamQuestionsTexts", new[] { "exam_id" });
            DropIndex("dbo.ExamQuestionsChoices", new[] { "exam_id" });
            DropIndex("dbo.StudentAnswers", new[] { "course_id" });
            DropIndex("dbo.StudentAnswers", new[] { "exam_id" });
            DropIndex("dbo.StudentAnswers", new[] { "student_id" });
            DropIndex("dbo.QuestionstTFs", new[] { "course_id" });
            DropIndex("dbo.QuestionstTexts", new[] { "course_id" });
            DropIndex("dbo.QuestionstChoices", new[] { "course_id" });
            DropIndex("dbo.Courses", new[] { "instructor_id" });
            DropIndex("dbo.Students", new[] { "course_id" });
            DropIndex("dbo.Students", new[] { "exam_id" });
            DropIndex("dbo.Students", new[] { "track_id" });
            DropIndex("dbo.Students", new[] { "intake_id" });
            DropIndex("dbo.Students", new[] { "branch_id" });
            DropIndex("dbo.Exams", new[] { "track_id" });
            DropIndex("dbo.Exams", new[] { "intake_id" });
            DropIndex("dbo.Exams", new[] { "branch_id" });
            DropIndex("dbo.Exams", new[] { "instructor_id" });
            DropIndex("dbo.Exams", new[] { "course_id" });
            DropIndex("dbo.AllowanceOptions", new[] { "exam_id" });
            DropTable("dbo.StudentAnswerSheets");
            DropTable("dbo.ExamsLips");
            DropTable("dbo.ExamQuestionsTFs");
            DropTable("dbo.ExamQuestionsTexts");
            DropTable("dbo.ExamQuestionsChoices");
            DropTable("dbo.Tracks");
            DropTable("dbo.Intakes");
            DropTable("dbo.StudentAnswers");
            DropTable("dbo.QuestionstTFs");
            DropTable("dbo.QuestionstTexts");
            DropTable("dbo.QuestionstChoices");
            DropTable("dbo.Instructors");
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
            DropTable("dbo.Branches");
            DropTable("dbo.Exams");
            DropTable("dbo.AllowanceOptions");
        }
    }
}
