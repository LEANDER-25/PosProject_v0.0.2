using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject_2.Models
{
    public class ItemPayDetail : ItemComponent
    {
        public int ID_Product { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public int ToCash
        {
            get; set;
        }
        public ItemPayDetail()
        {

        }
        public ItemPayDetail(int id, int id_product, string name, int amount, int price) : base(id, name)
        {
            this.ID_Product = id_product;
            this.Amount = amount;
            this.Price = price;
            this.ToCash = this.Amount * this.Price;
        }
    }
}
