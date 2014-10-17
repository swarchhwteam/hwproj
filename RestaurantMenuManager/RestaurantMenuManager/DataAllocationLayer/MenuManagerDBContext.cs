using RestaurantMenuManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RestaurantMenuManager.DataAllocationLayer
{
    public class MenuManagerDBContext : DbContext
    {
        public DbSet<MenuModel> MenuModels { get; set; }
        public DbSet<OrderModel> OrderModels { get; set; }
        public DbSet<ReclamationModel> ReclamationModels { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}