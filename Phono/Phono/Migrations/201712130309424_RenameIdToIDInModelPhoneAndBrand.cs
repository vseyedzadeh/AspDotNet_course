namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameIdToIDInModelPhoneAndBrand : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Phones", "Id", c => c.Int(identity: true));
        }
        
        public override void Down()
        {
        }
    }
}
