namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mg15 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Headings", "HeadingName", c => c.String(maxLength: 50, unicode: false, nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Headings", "HeadingName", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
    }
}
