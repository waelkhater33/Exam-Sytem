namespace CSlProjrct_Version1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExamQuestionsChoices", "answerChoice", c => c.String(maxLength: 1));
            AddColumn("dbo.ExamQuestionsChoices", "StudentanswerChoice", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExamQuestionsChoices", "StudentanswerChoice");
            DropColumn("dbo.ExamQuestionsChoices", "answerChoice");
        }
    }
}
