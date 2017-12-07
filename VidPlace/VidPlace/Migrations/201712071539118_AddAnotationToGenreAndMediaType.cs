namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnotationToGenreAndMediaType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.MediaTypes", "TypeName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MediaTypes", "TypeName", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
        }
    }
}
