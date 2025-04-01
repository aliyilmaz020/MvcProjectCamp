namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgMessageIsSentDelete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageIsDeleteSent", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "MessageIsDeleteSent");
        }
    }
}
