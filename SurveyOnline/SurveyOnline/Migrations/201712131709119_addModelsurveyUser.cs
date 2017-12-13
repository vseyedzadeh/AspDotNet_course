namespace SurveyOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModelsurveyUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SurveyUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        AnnualIncome = c.Decimal(precision: 18, scale: 2),
                        SurveyID = c.Int(nullable: false),
                        SurveyAnswer = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Surveys", t => t.SurveyID, cascadeDelete: true)
                .Index(t => t.SurveyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SurveyUsers", "SurveyID", "dbo.Surveys");
            DropIndex("dbo.SurveyUsers", new[] { "SurveyID" });
            DropTable("dbo.SurveyUsers");
        }
    }
}
