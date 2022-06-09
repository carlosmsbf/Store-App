using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models.ModelView
{
    public class InventoryModelView
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public List<Product> ProductList { get; set; }


        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<Brand> BrandList { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Category> CategoryList { get; set; }

        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public List<Inventory> InventoryList { get; set; }

    }
}
