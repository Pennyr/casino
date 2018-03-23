namespace core_manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CurrenyTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.currencies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        CurrencyCode = c.String(unicode: false),
                        ExchangeRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.currencies");
        }
    }
}
