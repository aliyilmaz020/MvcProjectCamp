namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg121 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 20, unicode: false, nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
    }
}
