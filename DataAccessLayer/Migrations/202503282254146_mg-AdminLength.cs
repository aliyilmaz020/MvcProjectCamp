namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgAdminLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "AdminUserName", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Admins", "AdminPassword", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "AdminPassword", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.Admins", "AdminUserName", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
    }
}
