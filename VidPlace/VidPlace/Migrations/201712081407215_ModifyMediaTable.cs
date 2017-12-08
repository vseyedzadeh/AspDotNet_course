namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMediaTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Media", name: "Genre_ID", newName: "GenreID");
            RenameColumn(table: "dbo.Media", name: "MediaType_ID", newName: "MediaTypeID");
            RenameIndex(table: "dbo.Media", name: "IX_MediaType_ID", newName: "IX_MediaTypeID");
            RenameIndex(table: "dbo.Media", name: "IX_Genre_ID", newName: "IX_GenreID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Media", name: "IX_GenreID", newName: "IX_Genre_ID");
            RenameIndex(table: "dbo.Media", name: "IX_MediaTypeID", newName: "IX_MediaType_ID");
            RenameColumn(table: "dbo.Media", name: "MediaTypeID", newName: "MediaType_ID");
            RenameColumn(table: "dbo.Media", name: "GenreID", newName: "Genre_ID");
        }
    }
}
