﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantMenuManager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestaurantMenuManagerEntities : DbContext
    {
        public RestaurantMenuManagerEntities()
            : base("name=RestaurantMenuManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<MenuModel> MenuModels { get; set; }
        public DbSet<OrderModel> OrderModels { get; set; }
        public DbSet<ReclamationModel> ReclamationModels { get; set; }
    }
}