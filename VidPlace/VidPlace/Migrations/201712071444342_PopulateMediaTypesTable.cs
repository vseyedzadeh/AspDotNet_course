namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMediaTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql(
                "INSERT INTO MediaTypes (TypeName) VALUES ('Movie')"
               );

            Sql(
                "INSERT INTO MediaTypes (TypeName) VALUES ('TV Show')"
               );

            Sql(
                "INSERT INTO MediaTypes (TypeName) VALUES ('Toturial')"
               );
        }
        
        public override void Down()
        {
        }
    }
}
