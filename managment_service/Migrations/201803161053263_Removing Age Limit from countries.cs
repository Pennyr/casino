namespace managment_service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingAgeLimitfromcountries : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.countries", "AgeLimit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.countries", "AgeLimit", c => c.Int(nullable: false));
        }
    }
}
