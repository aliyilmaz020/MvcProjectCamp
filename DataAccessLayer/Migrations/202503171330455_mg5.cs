namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryStatus", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryStatus", c => c.Boolean(nullable: false));
        }
    }
}
