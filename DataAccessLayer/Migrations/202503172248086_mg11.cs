namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.String(maxLength: 500, unicode: false, nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.String(nullable: false, maxLength: 500, unicode: false));
        }
    }
}
