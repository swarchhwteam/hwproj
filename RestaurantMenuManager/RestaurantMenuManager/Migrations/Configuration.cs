namespace RestaurantMenuManager.Migrations
{
    using RestaurantMenuManager.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantMenuManager.DataAllocationLayer.MenuManagerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RestaurantMenuManager.DataAllocationLayer.MenuManagerDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

/*
            var food = new List<Food>
            {
                new Food { FoodName="Túrós csusza" ,Price=750, Quantity=1, ReqDurationInMinutes=30 , Cathegory="maindish" },
 
               
            };
            food.ForEach(s => context.Foods.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();






            var drink = new List<Drink>
            {
                new Drink {    DrinkName="narancslé", Quantity=5, Price=80 },
 
               
            };
            drink.ForEach(s => context.Drinks.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();






            var menu = new List<MenuModel>
            {
                new MenuModel {  FoodName="Túrós csusza",  DrinkName="narancslé", MenuName="xxx"},
 
               
            };
            menu.ForEach(s => context.MenuModels.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();




            var order = new List<OrderModel>
            {
                new OrderModel {   MenuName="xxx", WhenOrdered=DateTime.Parse("2012-09-01-11:00"), ClientName="Ami", Bill=1000},
 
               
            };
            order.ForEach(s => context.OrderModels.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();



            var rec = new List<ReclamationModel>
            {
                new ReclamationModel {  Subject="csusza", Content="sóóóóóssss", WhenOrdered=DateTime.Parse("2012-09-01-11:00"), ClientName="Ami"},
 
               
            };
            rec.ForEach(s => context.ReclamationModels.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();*/
        }
    }
}
