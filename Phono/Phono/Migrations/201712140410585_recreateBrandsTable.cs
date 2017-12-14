namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recreateBrandsTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Phones");
            DropTable("dbo.Brands");
            CreateTable(
               "dbo.Brands",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   BrandName = c.String(nullable: false, maxLength: 255),
                   CountryOfOrigin = c.String(nullable: true),
               })
               .PrimaryKey(t => t.Id);

            CreateTable(
           "dbo.Phones",
           c => new
           {
               ID = c.Int(identity: true, nullable: false),
               PhoneName = c.String(nullable: false, maxLength: 255),
               BrandId = c.Int(nullable: false),
               DateReleased = c.DateTime(nullable: true),
               ScreenSize = c.String(nullable: true),
               PhoneTypeId = c.Byte(nullable: false),
           })
           .PrimaryKey(t => t.ID)
           .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
           .ForeignKey("dbo.PhoneTypes", t => t.PhoneTypeId, cascadeDelete: true)
           .Index(t => t.BrandId)
           .Index(t => t.PhoneTypeId);
        }
        
        public override void Down()
        {
        }
    }
}
