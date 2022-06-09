using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Helper.Store
{
    public class InventoryBalance
    {

        private int id, productId, quantity;
        private double cost;
        private DateTime date;


        public int Id { get=> id; set=> id = value; }

        public int ProductId { get => productId; set => productId = value; }

        public int Quantity { get => quantity; set =>quantity = value; }

        public double Cost { get => cost; set => cost= value; }

        public DateTime Date { get =>date; set =>date = value; }


    }
}
