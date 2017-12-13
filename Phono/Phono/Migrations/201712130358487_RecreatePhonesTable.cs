namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RecreatePhonesTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Phones");
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
