namespace Template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarUpdatedAgain : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Name", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Name", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
