namespace SnowCrashBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class login : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAccount",
                c => new
                    {
                        UserAccountID = c.Int(nullable: false),
                        Title = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserAccountID);
            
            CreateTable(
                "dbo.Join",
                c => new
                    {
                        JoinId = c.Int(nullable: false, identity: true),
                        UserAccountID = c.Int(nullable: false),
                        ProfileID = c.Int(nullable: false),
                        Type = c.Int(),
                        Types = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JoinId)
                .ForeignKey("dbo.Profile", t => t.ProfileID, cascadeDelete: true)
                .ForeignKey("dbo.UserAccount", t => t.UserAccountID, cascadeDelete: true)
                .Index(t => t.UserAccountID)
                .Index(t => t.ProfileID);
            
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstMidName = c.String(),
                        userName = c.String(),
                        JoinDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Join", "UserAccountID", "dbo.UserAccount");
            DropForeignKey("dbo.Join", "ProfileID", "dbo.Profile");
            DropIndex("dbo.Join", new[] { "ProfileID" });
            DropIndex("dbo.Join", new[] { "UserAccountID" });
            DropTable("dbo.Profile");
            DropTable("dbo.Join");
            DropTable("dbo.UserAccount");
        }
    }
}
