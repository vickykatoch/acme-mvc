namespace Acme.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        WorkEmail = c.String(),
                        HomeEmail = c.String(),
                        WorkPhone = c.String(),
                        HomePhone = c.String(),
                        HomeAddress = c.String(),
                        WorkAddress = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        TerminationDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Opportunities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Risks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Risks", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Opportunities", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Risks", new[] { "Customer_Id" });
            DropIndex("dbo.Opportunities", new[] { "Customer_Id" });
            DropTable("dbo.Risks");
            DropTable("dbo.Opportunities");
            DropTable("dbo.Customers");
        }
    }
}
