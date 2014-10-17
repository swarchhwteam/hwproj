using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMenuManager.Models
{
    public class Food
    {
         [Required]
        public string FoodName { get; set; }

         public int ID { get; set; }

        [Required]
         public int Price { get; set; }
        [Required]
         public int ReqDurationInMinutes { get; set; }
        [Required]
         public float Quantity { get; set; }
        [Required]
         public string Cathegory { get; set; }  //Appetizer MainDish Dessert
    }
}