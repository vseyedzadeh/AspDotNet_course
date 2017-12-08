namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Populate_Phone_Types : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PhoneTypes" +
               "( ID, Type, OS)" +
               "VALUES(1, 'Smart', 'Android')"
               );
            Sql("INSERT INTO PhoneTypes" +
               "( ID, Type, OS)" +
               "VALUES(2, 'Smart', 'iOS')"
               );
            Sql("INSERT INTO PhoneTypes" +
               "( ID, Type, OS)" +
               "VALUES(3, 'Bar', 'NA')"
               );
            Sql("INSERT INTO PhoneTypes" +
               "( ID, Type, OS)" +
               "VALUES(4, 'Flip', 'NA')"
               );

        }

        public override void Down()
        {
        }
    }
}
