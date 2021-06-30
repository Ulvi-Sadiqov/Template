namespace Template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEverything : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "MaxSpeed", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "MaxSpeed");
        }
    }
}
