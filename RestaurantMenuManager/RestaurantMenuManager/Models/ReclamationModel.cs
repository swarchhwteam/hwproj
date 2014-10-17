using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMenuManager.Models
{
    public class ReclamationModel
    {
        public string ClientName { get; set; } // Model table foreignkey

        public int ID { get; set; }

        public DateTime WhenOrdered { get; set; }
        [DataType(DataType.DateTime)]
        //       [DisplayFormat(NullDisplayText = "NotSpecified", DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime When { get; set; }

        [Required]
        public string Subject { get; set; }
        [Required]
        public string Content { get; set; }

      //  public virtual OrderModel OrderModel { get; set; }

    }
}