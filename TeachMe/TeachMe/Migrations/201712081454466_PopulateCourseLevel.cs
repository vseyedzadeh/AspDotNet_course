namespace TeachMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCourseLevel : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CourseLevels" +
               "( Name, CreditsFinished)" +
               "VALUES('Freshman', 30)"
               );
            Sql("INSERT INTO CourseLevels" +
              "( Name, CreditsFinished)" +
              "VALUES('Sophomore', 60)"
              );
            Sql("INSERT INTO CourseLevels" +
              "( Name, CreditsFinished)" +
              "VALUES('Junior', 90)"
              );
            Sql("INSERT INTO CourseLevels" +
              "( Name, CreditsFinished)" +
              "VALUES('Senior', 120)"
              );
        }
        
        public override void Down()
        {
        }
    }
}
