namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "CompanyTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.Companies", "AboutShort", c => c.String(maxLength: 100));
            AddColumn("dbo.Companies", "Mail", c => c.String(maxLength: 50));
            AddColumn("dbo.Companies", "Password", c => c.String(maxLength: 50));
            AddColumn("dbo.Companies", "PhoneNumber", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "PhoneNumber");
            DropColumn("dbo.Companies", "Password");
            DropColumn("dbo.Companies", "Mail");
            DropColumn("dbo.Companies", "AboutShort");
            DropColumn("dbo.Companies", "CompanyTitle");
        }
    }
}
