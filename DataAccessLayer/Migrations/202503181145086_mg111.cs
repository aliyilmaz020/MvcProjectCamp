namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg111 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(maxLength: 20, unicode: false));
        }
    }
}
