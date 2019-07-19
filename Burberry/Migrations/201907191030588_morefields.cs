namespace PrimeBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class morefields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "OtherName", c => c.String());
            AddColumn("dbo.AspNetUsers", "C_Limit", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "Us_Limit", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Us_Limit");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "C_Limit");
            DropColumn("dbo.AspNetUsers", "OtherName");
        }
    }
}
