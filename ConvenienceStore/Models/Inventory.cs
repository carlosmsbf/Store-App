using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models
{
    public class Inventory
    {
        [Key]

        [Display(Name = "Inventory Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, select the Product.")]
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required(ErrorMessage = "Please, fill the Quantity.")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Please, fill the Cost.")]
        [Display(Name = "Cost")]
        public double Cost { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Required(ErrorMessage = "Please, fill the Date.")]
        [Display(Name = "Data de Estoque")]
        public DateTime Date { get; set; }




    }
}
