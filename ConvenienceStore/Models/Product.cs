using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Product Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please, fill the Category.")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required(ErrorMessage = "Please, fill the Product.")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please, select the Brand.")]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        [Required(ErrorMessage = "Please, fill the Description.")]
        [Display(Name = "Product Description")]
        public string Description { get; set; }

        

    }
}
