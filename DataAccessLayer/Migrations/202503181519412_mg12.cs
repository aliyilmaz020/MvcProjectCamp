namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterName", c => c.String(maxLength: 20, unicode: false, nullable: false));
            AlterColumn("dbo.Writers", "WriterSurname", c => c.String(maxLength: 20, unicode: false, nullable: false));
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 300, unicode: false, nullable: false));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 100, unicode: false, nullable: false));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(nullable: false, maxLength: 300, unicode: false));
            AlterColumn("dbo.Writers", "WriterSurname", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Writers", "WriterName", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
    }
}
