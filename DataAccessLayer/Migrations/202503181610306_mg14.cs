namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mg14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 30, unicode: false, nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterTitle");
        }
    }
}
