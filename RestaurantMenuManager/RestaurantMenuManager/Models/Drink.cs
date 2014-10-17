using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMenuManager.Models
{
    public class Drink
    {
         [Required]
        public string DrinkName { get; set; }

        public int ID { get; set; }
         [Required]
        public int Price { get; set; }
         [Required]
        public float Quantity { get; set; }
    }
}