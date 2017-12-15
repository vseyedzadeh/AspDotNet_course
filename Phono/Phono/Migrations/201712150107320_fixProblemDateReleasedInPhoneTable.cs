namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixProblemDateReleasedInPhoneTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Phones", "DateReleased", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Phones", "DateReleased", c => c.DateTime());
        }
    }
}
