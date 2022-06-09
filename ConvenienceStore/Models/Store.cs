using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models
{
    public class Store
    {

        [Key]
        [Display(Name = "Store Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please, select the Item Id from the Inventory.")]
        [Display(Name = "Inventory Id")]
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        [Required(ErrorMessage = "Please, fill the Quantity.")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Please, fill the Price.")]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Required(ErrorMessage = "Please, fill the Date.")]
        [Display(Name = "Store Date Registered")]
        public DateTime Date { get; set; }


    }
}
