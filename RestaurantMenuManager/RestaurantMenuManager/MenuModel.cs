//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class MenuModel
    {
        public MenuModel()
        {
            this.Drinks = new HashSet<Drink>();
            this.Foods = new HashSet<Food>();
        }
    
        public int ID { get; set; }
        public string MenuName { get; set; }
        public string DrinkName { get; set; }
        public string FoodName { get; set; }
        public Nullable<int> OrderModel_ID { get; set; }
    
        public virtual ICollection<Drink> Drinks { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public virtual OrderModel OrderModel { get; set; }
    }
}
