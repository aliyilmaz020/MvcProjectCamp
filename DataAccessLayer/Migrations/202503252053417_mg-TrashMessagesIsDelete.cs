namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgTrashMessagesIsDelete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageIsDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "MessageIsDelete");
        }
    }
}
