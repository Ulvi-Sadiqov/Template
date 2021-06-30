namespace Template.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonSayAboutUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Text = c.String(nullable: false),
                        Job = c.String(nullable: false),
                        CountOfStars = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Seller = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Year = c.Int(nullable: false),
                        isAuto = c.Boolean(nullable: false),
                        Mi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HorsePower = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Image1 = c.String(nullable: false),
                        Image2 = c.String(nullable: false),
                        Image3 = c.String(nullable: false),
                        Image4 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        ImagePath = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfPlace = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Experts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Job = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 40),
                        Description = c.String(nullable: false),
                        UploadTime = c.DateTime(nullable: false),
                        ImagePath = c.String(nullable: false),
                        Writer = c.String(nullable: false),
                        IsLast = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Description = c.String(nullable: false),
                        ImagePath = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Offers");
            DropTable("dbo.News");
            DropTable("dbo.Experts");
            DropTable("dbo.Contacts");
            DropTable("dbo.Clients");
            DropTable("dbo.Cars");
            DropTable("dbo.PersonSayAboutUs");
        }
    }
}
