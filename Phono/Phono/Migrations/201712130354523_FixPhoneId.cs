namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixPhoneId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Phones");
            AlterColumn("dbo.Phones", "Id", c => c.Int(identity: true, nullable: false));
            AddPrimaryKey("dbo.Phones", "Id");
        }
        
        public override void Down()
        {
        }
    }
}
