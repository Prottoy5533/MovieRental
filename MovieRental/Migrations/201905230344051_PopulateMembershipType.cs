namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) values (1,'Pay As You Go',0,0,0)");
            Sql("insert into MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) values (2,'Monthly',30,1,10)");
            Sql("insert into MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) values (3,'Quaterly',90,3,15)");
            Sql("insert into MembershipTypes(Id,Name,SignUpFee,DurationInMonths,DiscountRate) values (4,'Annualy',300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
