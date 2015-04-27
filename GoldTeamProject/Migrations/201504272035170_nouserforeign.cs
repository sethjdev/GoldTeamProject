namespace GoldTeamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nouserforeign : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "UserID", "dbo.Users");
            DropIndex("dbo.Products", new[] { "UserID" });
            DropColumn("dbo.Products", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "UserID");
            AddForeignKey("dbo.Products", "UserID", "dbo.Users", "ID", cascadeDelete: true);
        }
    }
}
