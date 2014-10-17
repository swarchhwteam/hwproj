using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMenuManager.Models
{
    public class OrderModel
    {
        public int ID { get; set; }

        [DataType(DataType.DateTime)]
        //       [DisplayFormat(NullDisplayText = "NotSpecified", DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime WhenOrdered { get; set; }

        public string ClientName { get; set; }
        public string MenuName { get; set; }
        public int Bill { get; set; }

    //    public virtual ReclamationModel ReclamationModel { get; set; }
        public virtual ICollection<MenuModel> MenuModel { get; set; }

    }
}