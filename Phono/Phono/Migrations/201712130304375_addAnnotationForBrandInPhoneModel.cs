namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnnotationForBrandInPhoneModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Phones", "BrandId", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "BrandId" });
            AlterColumn("dbo.Phones", "BrandId", c => c.Int(nullable: false));
            CreateIndex("dbo.Phones", "BrandId");
            AddForeignKey("dbo.Phones", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "BrandId", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "BrandId" });
            AlterColumn("dbo.Phones", "BrandId", c => c.Int());
            CreateIndex("dbo.Phones", "BrandId");
            AddForeignKey("dbo.Phones", "BrandId", "dbo.Brands", "Id");
        }
    }
}
