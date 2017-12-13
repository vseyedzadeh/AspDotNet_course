namespace SurveyOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTopics : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics" +
               "(Name)" + " VALUES('Science')");

            Sql("INSERT INTO Topics" +
               "(Name)" + " VALUES('Politics')");

            Sql("INSERT INTO Topics" +
               "(Name)" + " VALUES('Music')");

            Sql("INSERT INTO Topics" +
               "(Name)" + " VALUES('Economics')");

            Sql("INSERT INTO Topics" +
               "(Name)" + " VALUES('Other')");
        }
        
        public override void Down()
        {
        }
    }
}
