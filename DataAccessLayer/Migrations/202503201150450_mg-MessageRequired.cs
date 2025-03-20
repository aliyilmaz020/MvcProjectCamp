namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgMessageRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "SenderMail", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Messages", "ReceiverMail", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Messages", "Subject", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Messages", "MessageContent", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "MessageContent", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Messages", "Subject", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Messages", "ReceiverMail", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Messages", "SenderMail", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
