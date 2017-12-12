namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRentals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.MediaRentals",
                c => new
                    {
                        Media_ID = c.Int(nullable: false),
                        Rental_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Media_ID, t.Rental_Id })
                .ForeignKey("dbo.Media", t => t.Media_ID, cascadeDelete: true)
                .ForeignKey("dbo.Rentals", t => t.Rental_Id, cascadeDelete: true)
                .Index(t => t.Media_ID)
                .Index(t => t.Rental_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MediaRentals", "Rental_Id", "dbo.Rentals");
            DropForeignKey("dbo.MediaRentals", "Media_ID", "dbo.Media");
            DropForeignKey("dbo.Rentals", "CustomerId", "dbo.Customers");
            DropIndex("dbo.MediaRentals", new[] { "Rental_Id" });
            DropIndex("dbo.MediaRentals", new[] { "Media_ID" });
            DropIndex("dbo.Rentals", new[] { "CustomerId" });
            DropTable("dbo.MediaRentals");
            DropTable("dbo.Rentals");
        }
    }
}
