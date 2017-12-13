namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeIdInModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Phones", "BrandId", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "BrandId" });
            DropPrimaryKey("dbo.Brands");
            DropPrimaryKey("dbo.Phones");
            AddColumn("dbo.Phones", "Brand_Id", c => c.Int());
            AlterColumn("dbo.Brands", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Phones", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Brands", "Id");
            AddPrimaryKey("dbo.Phones", "Id");
            CreateIndex("dbo.Phones", "Brand_Id");
            AddForeignKey("dbo.Phones", "Brand_Id", "dbo.Brands", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Brand_Id", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "Brand_Id" });
            DropPrimaryKey("dbo.Phones");
            DropPrimaryKey("dbo.Brands");
            AlterColumn("dbo.Phones", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Brands", "Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Phones", "Brand_Id");
            AddPrimaryKey("dbo.Phones", "Id");
            AddPrimaryKey("dbo.Brands", "Id");
            CreateIndex("dbo.Phones", "BrandId");
            AddForeignKey("dbo.Phones", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
        }
    }
}
