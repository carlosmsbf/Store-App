using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models
{
    public class ProductControl
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int QuantityInventory { get; set; }
        public int QuantityStore { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }

        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

        public string ControlType { get; set; }
    }
}
