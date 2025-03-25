namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgMessageIsRead : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageIsRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "MessageIsRead");
        }
    }
}
