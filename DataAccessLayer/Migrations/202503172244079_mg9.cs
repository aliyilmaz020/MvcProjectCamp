namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mg9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(maxLength: 20, unicode: false, nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
    }
}
