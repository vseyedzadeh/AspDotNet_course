namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes" +
                "( SignupFee, DurationInMonth, DiscountRate)" +
                "VALUES(0,0,0)"
                );
            Sql("INSERT INTO MembershipTypes" +
                "( SignupFee, DurationInMonth, DiscountRate)" +
                "VALUES(10,1,10)"
                );
            Sql("INSERT INTO MembershipTypes" +
                "( SignupFee, DurationInMonth, DiscountRate)" +
                "VALUES(30,3,15)"
                );
            Sql("INSERT INTO MembershipTypes" +
                "( SignupFee, DurationInMonth, DiscountRate)" +
                "VALUES(100,12,20)"
                );
        }
        
        public override void Down()
        {
        }
    }
}
