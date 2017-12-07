namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropForeignKeyInCustomerTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "membershipType_Id", "dbo.MembershipTypes");
            DropColumn("dbo.Customers", "membershipType_Id");
        }
        
        public override void Down()
        {
            AddForeignKey("dbo.Customers", "membershipType_Id", "dbo.MembershipTypes", "Id");
            AddColumn("dbo.Customers", "membershipType_Id", c => c.Int());
        }
    }
}
