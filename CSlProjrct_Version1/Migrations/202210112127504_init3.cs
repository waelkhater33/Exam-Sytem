namespace CSlProjrct_Version1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.StudentAnswerSheets");
            AddPrimaryKey("dbo.StudentAnswerSheets", new[] { "exam_id", "Student_id", "question_id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.StudentAnswerSheets");
            AddPrimaryKey("dbo.StudentAnswerSheets", new[] { "exam_id", "Student_id" });
        }
    }
}
