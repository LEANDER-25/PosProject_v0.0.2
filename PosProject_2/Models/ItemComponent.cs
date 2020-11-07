using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject_2.Models
{
    public class ItemComponent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ItemComponent()
        {

        }
        public ItemComponent(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
    public class ItemStaff : ItemComponent
    {
        public string Position { get; set; }
        public string AccName { get; set; }
        public string Password { get; set; }
        public bool IsOnline { get; set; }
        public ItemStaff()
        {

        }
        public ItemStaff(int id, string name, string position, string accName, string pwd) : base(id, name)
        {
            this.AccName = accName;
            this.Password = pwd;
            this.Position = position;
            this.IsOnline = false;
        }
    }
    public class ItemProduct : ItemComponent
    {
        public int IDType { get; set; }
        public int Price { get; set; }
        public ItemProduct()
        {

        }
        public ItemProduct(int id, string name, int idType, int price) : base(id, name)
        {
            this.IDType = idType;
            this.Price = price;
        }
    }
    public class ItemBill : ItemComponent
    {
        public int IDStaff { get; set; }
        public DateTime SaleDate { get; set; }
        public int TotalCash { get; set; }
        public ItemBill()
        {

        }
        public ItemBill(int id, int idStaff, DateTime saleDate, int totalCash)
        {
            this.ID = id;
            this.IDStaff = idStaff;
            this.SaleDate = saleDate;
            this.TotalCash = totalCash;
        }

    }
    public class ItemSaleDetail : ItemProduct
    {
        public int IDBill { get; set; }
        public int Amount { get; set; }
        public int ToCash { get; set; }
        public ItemSaleDetail()
        {

        }
        public ItemSaleDetail(int idBill, int idProduct, string nameProduct, int amount, int idType, int price, int toCash) : base(idProduct, nameProduct, idType, price)
        {
            this.IDBill = idBill;
            this.Amount = amount;
            this.ToCash = toCash;
        }

    }
}
