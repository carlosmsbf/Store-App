using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models
{
    public class Report
    {
        [Key]

        [Display(Name = "Report Id")]
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string Category { get; set; }

        [Display(Name = "Brand")]
        public string Brand { get; set; }

        [Display(Name = "Product")]
        public string Product { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Cost")]
        public double Cost { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Profit")]
        public double Profit { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Registered Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Operation Type")]
        public string TypeOfTransaction { get; set; }

        [Display(Name = "Product Operation Id")]
        public int OperationId { get; set; }



    }
}
