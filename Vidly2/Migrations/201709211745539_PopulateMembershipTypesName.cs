namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesName : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DUrationInMonths, DiscountRate, Name) VALUES (5,0,0,0,'Pay as You Go')");
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DUrationInMonths, DiscountRate, Name) VALUES (6,30,1,10,'Monthly')");
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DUrationInMonths, DiscountRate, Name) VALUES (7,90,3,15,'Every 3 Months')");
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DUrationInMonths, DiscountRate, Name) VALUES (8,300,12,20,'Annual')");
        }
        
        public override void Down()
        {
        }
    }
}
