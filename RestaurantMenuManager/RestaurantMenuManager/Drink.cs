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
    
    public partial class Drink
    {
        public int ID { get; set; }
        public string DrinkName { get; set; }
        public int Price { get; set; }
        public float Quantity { get; set; }
        public Nullable<int> MenuModel_ID { get; set; }
    
        public virtual MenuModel MenuModel { get; set; }
    }
}