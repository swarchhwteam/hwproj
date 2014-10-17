namespace RestaurantMenuManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drink",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DrinkName = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Quantity = c.Single(nullable: false),
                        MenuModel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuModel", t => t.MenuModel_ID)
                .Index(t => t.MenuModel_ID);
            
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        ReqDurationInMinutes = c.Int(nullable: false),
                        Quantity = c.Single(nullable: false),
                        Cathegory = c.String(nullable: false),
                        MenuModel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuModel", t => t.MenuModel_ID)
                .Index(t => t.MenuModel_ID);
            
            CreateTable(
                "dbo.MenuModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuName = c.String(),
                        DrinkName = c.String(),
                        FoodName = c.String(),
                        OrderModel_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.OrderModel", t => t.OrderModel_ID)
                .Index(t => t.OrderModel_ID);
            
            CreateTable(
                "dbo.OrderModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WhenOrdered = c.DateTime(nullable: false),
                        ClientName = c.String(),
                        MenuName = c.String(),
                        Bill = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ReclamationModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        WhenOrdered = c.DateTime(nullable: false),
                        When = c.DateTime(nullable: false),
                        Subject = c.String(nullable: false),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuModel", "OrderModel_ID", "dbo.OrderModel");
            DropForeignKey("dbo.Food", "MenuModel_ID", "dbo.MenuModel");
            DropForeignKey("dbo.Drink", "MenuModel_ID", "dbo.MenuModel");
            DropIndex("dbo.MenuModel", new[] { "OrderModel_ID" });
            DropIndex("dbo.Food", new[] { "MenuModel_ID" });
            DropIndex("dbo.Drink", new[] { "MenuModel_ID" });
            DropTable("dbo.ReclamationModel");
            DropTable("dbo.OrderModel");
            DropTable("dbo.MenuModel");
            DropTable("dbo.Food");
            DropTable("dbo.Drink");
        }
    }
}
