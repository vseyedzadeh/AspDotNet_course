namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnnotationToModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "CountryOfOrigin", c => c.String());
            AlterColumn("dbo.Phones", "ScreenSize", c => c.Single());
            AlterColumn("dbo.PhoneTypes", "Type", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.PhoneTypes", "OS", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhoneTypes", "OS", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.PhoneTypes", "Type", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Phones", "ScreenSize", c => c.Byte());
            AlterColumn("dbo.Brands", "CountryOfOrigin", c => c.String(nullable: false));
        }
    }
}
