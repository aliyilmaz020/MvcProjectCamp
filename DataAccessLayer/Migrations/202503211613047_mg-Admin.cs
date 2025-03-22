namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        AdminUserName = c.String(nullable: false, maxLength: 20, unicode: false),
                        AdminPassword = c.String(nullable: false, maxLength: 20, unicode: false),
                        AdminRole = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
