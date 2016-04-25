namespace SnowCrashBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banking",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        userName = c.String(),
                        Balance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Banking");
        }
    }
}
