using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models
{
    public class Sale
    {
        [Key]

        [Display(Name = "Sale Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, select the an Item Id from the Store.")]
        [Display(Name = "Item Id")]
        public int StoreId { get; set; }
        public Store Store { get; set; }
        [Required(ErrorMessage = "Please, fill the Quantity.")]
        [Display(Name = "Sale Quantity")]
        public int Quantity { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Required(ErrorMessage = "Please, fill the Date.")]
        [Display(Name = "Sale Date")]
        public DateTime Date { get; set; }


    }
}
