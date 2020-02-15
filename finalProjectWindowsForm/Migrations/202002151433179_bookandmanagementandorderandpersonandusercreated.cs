namespace finalProjectWindowsForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookandmanagementandorderandpersonandusercreated : DbMigration
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
                    })
                .PrimaryKey(t => t.BookID);
            
            CreateTable(
                "dbo.Managements",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        BookReturnDate = c.DateTime(nullable: false),
                        returned = c.Boolean(nullable: false),
                        Book_BookID = c.Int(nullable: false),
                        Person_PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Books", t => t.Book_BookID, cascadeDelete: false)
                .ForeignKey("dbo.People", t => t.Person_PersonID, cascadeDelete: false)
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
                        OrderID = c.Int(nullable: false, identity: true),
                        Money = c.Single(nullable: false),
                        BookReturnededDate = c.DateTime(nullable: false),
                        Management_OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Managements", t => t.Management_OrderID, cascadeDelete: false)
                .Index(t => t.Management_OrderID);
            
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
            DropForeignKey("dbo.Orders", "Management_OrderID", "dbo.Managements");
            DropForeignKey("dbo.Managements", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.Managements", "Book_BookID", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "Management_OrderID" });
            DropIndex("dbo.Managements", new[] { "Person_PersonID" });
            DropIndex("dbo.Managements", new[] { "Book_BookID" });
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.People");
            DropTable("dbo.Managements");
            DropTable("dbo.Books");
        }
    }
}
