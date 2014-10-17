using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantMenuManager.Models
{
    public class MenuModel
    {
        public virtual ICollection<Drink> Drink { get; set; }
        public virtual ICollection<Food> Food { get; set; }

        public int ID { get; set; }
        public string MenuName { get; set; }
        public virtual OrderModel OrderModel { get; set; }

        public string DrinkName { get; set; }
        public string FoodName { get; set; }

    }
 
    
}
 