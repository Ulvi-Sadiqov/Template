namespace Template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BugFixed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "Title", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "Title", c => c.String(nullable: false, maxLength: 40));
        }
    }
}
