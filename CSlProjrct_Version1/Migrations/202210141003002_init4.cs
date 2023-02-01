namespace CSlProjrct_Version1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuestionstChoices", "answer", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.QuestionstChoices", "answer");
        }
    }
}
