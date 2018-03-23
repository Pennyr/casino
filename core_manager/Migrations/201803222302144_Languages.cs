namespace core_manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Languages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.languages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Code = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);

            RenameColumn("dbo.currencies", "CurrencyCode", "Code");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.currencies", "Code", "CurrencyCode");
            DropTable("dbo.languages");
        }
    }
}
