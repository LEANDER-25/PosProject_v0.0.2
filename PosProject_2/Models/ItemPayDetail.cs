using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject_2.Models
{
    public class ItemPayDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ID_Product { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public int ToCash
        {
            get; set;
        }
        DataPoSContext dataContext;
        public ItemPayDetail()
        {

        }
        public ItemPayDetail(int id, int id_product, int amount)
        {
            dataContext = new DataPoSContext();
            List<SanPham> product = dataContext.SanPhams.Where(p => p.id_sp == id_product).ToList();
            this.ID_Product = id_product;
            this.Name = product[0].ten_sp;
            this.Amount = amount;
            this.Price = product[0].giaBan.Value;
            this.ToCash = this.Amount * this.Price;
        }
    }
}
