using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models
{
    public class Brand
    {
        [Key]


        [Display(Name = "Brand Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please, fill the Brand Name.")]
        [Display(Name = "Brand Name")]
        public string Name { get; set; }


    }
}
