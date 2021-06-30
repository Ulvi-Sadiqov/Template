namespace Template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "forMonth", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "forMonth");
        }
    }
}
