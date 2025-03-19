namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg31 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "AboutImage2", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Abouts", "AboutImage1", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Abouts", "AboutDetails2", c => c.String(nullable: false, maxLength: 1000, unicode: false));
            AlterColumn("dbo.Abouts", "AboutDetails1", c => c.String(nullable: false, maxLength: 1000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "AboutImage2", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Abouts", "AboutImage1", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Abouts", "AboutDetails2", c => c.String(nullable: false, maxLength: 1000, unicode: false));
            AlterColumn("dbo.Abouts", "AboutDetails1", c => c.String(nullable: false, maxLength: 1000, unicode: false));
        }
    }
}
