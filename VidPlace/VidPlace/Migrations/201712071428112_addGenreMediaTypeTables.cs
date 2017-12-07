namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenreMediaTypeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberIsStock = c.Int(nullable: false),
                        Genre_ID = c.Int(),
                        MediaType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Genres", t => t.Genre_ID)
                .ForeignKey("dbo.MediaTypes", t => t.MediaType_ID)
                .Index(t => t.Genre_ID)
                .Index(t => t.MediaType_ID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MediaTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Media", "MediaType_ID", "dbo.MediaTypes");
            DropForeignKey("dbo.Media", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Media", new[] { "MediaType_ID" });
            DropIndex("dbo.Media", new[] { "Genre_ID" });
            DropTable("dbo.MediaTypes");
            DropTable("dbo.Genres");
            DropTable("dbo.Media");
        }
    }
}
