using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosProject_2.Models;

namespace PosProject_2.FormChildren
{
    public partial class PayAction : Form
    {
        public string NameTable { get; set; }
        DataPoSContext dataContext;
        public List<ItemPayDetail> OrderedItems;
        public int TotalCash { get; set; } 
        public PayAction()
        {
            InitializeComponent();
        }
        public PayAction(string nameTable, List<CacBanCoDon> billTemps)
        {
            //dataContext = new DataPoSContext();
            this.NameTable = nameTable;
            SetOrderedItems(billTemps);
            InitializeComponent();
            LoadDataIToForm();
        }
        void LoadDataIToForm()
        {
            int indentity = 0;
            this.TotalCash = 0;
            //List<NhanVien> staffs = dataContext.NhanViens.Where(s => s.isOnline == true).ToList();
            //this.lbStaffName.Text = staffs.Count != 0 ? staffs[0].ten_nhanVien : "";
            this.lbTableName.Text = this.NameTable;
            foreach (var item in OrderedItems)
            {
                int amount = item.Amount;
                int price = item.Price;
                indentity++;
                ListViewItem itemView = new ListViewItem();
                itemView.Name = item.ID_Product.ToString();
                itemView.Font = new Font("Segor UI", 9);
                itemView.Text = indentity.ToString(); 
                itemView.SubItems.Add(item.Name);
                itemView.SubItems.Add(amount.ToString());
                itemView.SubItems.Add(item.ToCash.ToString());
                this.listOrderdItems.Items.Add(itemView);
                this.TotalCash += item.ToCash;
            }
            this.lbTotalCash.Text = TotalCash.ToString();
        }
        void SetOrderedItems(List<CacBanCoDon> billTemp)
        {
            this.OrderedItems = new List<ItemPayDetail>();
            int idtentity = 0;
            foreach (var item in billTemp)
            {
                idtentity++;
                ItemPayDetail itemPay = new ItemPayDetail(
                    idtentity,
                    item.id_sp,
                    item.ten_sp,
                    item.soLuongYeuCau.Value,
                    item.giaBan.Value
                );
                this.OrderedItems.Add(itemPay);
            }
        }
    }
}
