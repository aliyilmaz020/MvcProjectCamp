namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgMessage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        SenderMail = c.String(maxLength: 50, unicode: false),
                        ReceiverMail = c.String(maxLength: 50, unicode: false),
                        Subject = c.String(maxLength: 50, unicode: false),
                        MessageContent = c.String(maxLength: 8000, unicode: false),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MessageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
