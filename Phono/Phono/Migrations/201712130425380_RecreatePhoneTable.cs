namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecreatePhoneTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Phones", "ScreenSize", c => c.Single());
        }
        
        public override void Down()
        {
        }
    }
}
