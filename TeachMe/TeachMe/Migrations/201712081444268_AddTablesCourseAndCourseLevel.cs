namespace TeachMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesCourseAndCourseLevel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Code = c.String(nullable: false, maxLength: 10),
                        NumberOfCredits = c.Int(nullable: false),
                        MaximumNumberOfStudents = c.Int(nullable: false),
                        ProvideBy = c.String(),
                        CourseLevelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CourseLevels", t => t.CourseLevelId, cascadeDelete: true)
                .Index(t => t.CourseLevelId);
            
            CreateTable(
                "dbo.CourseLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        CreditsFinished = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CourseLevelId", "dbo.CourseLevels");
            DropIndex("dbo.Courses", new[] { "CourseLevelId" });
            DropTable("dbo.CourseLevels");
            DropTable("dbo.Courses");
        }
    }
}
