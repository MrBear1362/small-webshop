namespace ObligatoriskOpgave2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProductTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        StockStatus = c.Boolean(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        TypeVariation = c.String(),
                        Pic = c.String(),
                        Price = c.Double(nullable: false),
                        Author = c.String(),
                        Publisher = c.String(),
                        Pages = c.Int(),
                        Director = c.String(),
                        ReleaseDate = c.DateTime(),
                        Artist = c.String(),
                        Genre = c.String(),
                        Info = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Customer_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Customer", t => t.Customer_PersonId)
                .Index(t => t.Customer_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Customer_PersonId", "dbo.Customer");
            DropIndex("dbo.Product", new[] { "Customer_PersonId" });
            DropTable("dbo.Product");
            DropTable("dbo.Customer");
        }
    }
}
