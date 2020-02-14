namespace finalProjectWindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        BookName = c.String(nullable: false, maxLength: 50),
                        PublisherName = c.String(nullable: false, maxLength: 50),
                        BookGenre = c.String(nullable: false, maxLength: 50),
                        BookPrice = c.Single(nullable: false),
                        Count = c.String(),
                    })
                .PrimaryKey(t => t.BookID);
            
            CreateTable(
                "dbo.Managments",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        BookReturnDate = c.DateTime(nullable: false),
                        returned = c.Boolean(nullable: false),
                        Book_BookID = c.Int(nullable: false),
                        Person_PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Books", t => t.Book_BookID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_PersonID, cascadeDelete: true)
                .Index(t => t.Book_BookID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        PurchaseID = c.Int(nullable: false, identity: true),
                        Money = c.Single(nullable: false),
                        BookReturnededDate = c.DateTime(nullable: false),
                        Managment_OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.Managments", t => t.Managment_OrderID, cascadeDelete: true)
                .Index(t => t.Managment_OrderID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        Fullname = c.String(nullable: false, maxLength: 50),
                        Username = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Managment_OrderID", "dbo.Managments");
            DropForeignKey("dbo.Managments", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.Managments", "Book_BookID", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "Managment_OrderID" });
            DropIndex("dbo.Managments", new[] { "Person_PersonID" });
            DropIndex("dbo.Managments", new[] { "Book_BookID" });
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.People");
            DropTable("dbo.Managments");
            DropTable("dbo.Books");
        }
    }
}
