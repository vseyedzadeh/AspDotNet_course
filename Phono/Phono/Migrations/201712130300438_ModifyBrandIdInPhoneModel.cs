namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyBrandIdInPhoneModel : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Phones", new[] { "Brand_Id" });
            DropColumn("dbo.Phones", "BrandId");
            RenameColumn(table: "dbo.Phones", name: "Brand_Id", newName: "BrandId");
            AlterColumn("dbo.Phones", "BrandId", c => c.Int());
            CreateIndex("dbo.Phones", "BrandId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Phones", new[] { "BrandId" });
            AlterColumn("dbo.Phones", "BrandId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Phones", name: "BrandId", newName: "Brand_Id");
            AddColumn("dbo.Phones", "BrandId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Phones", "Brand_Id");
        }
    }
}
