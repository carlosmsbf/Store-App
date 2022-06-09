using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models
{
    public class Category
    {
        
        [Key]


        [Display(Name = "Category Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please, fill the Category Name.")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please, fill the Category Description.")]
        [Display(Name = "Category Description")]
        public string Description { get; set; }

    }
}
