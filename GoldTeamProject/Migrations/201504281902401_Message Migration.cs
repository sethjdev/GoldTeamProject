namespace GoldTeamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateSent = c.DateTime(nullable: false),
                        Messages = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
