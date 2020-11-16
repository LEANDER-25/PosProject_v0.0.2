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

namespace PosProject_2.FormChildren.RevenueForms
{
    public partial class ExportForm : Form
    {
        DataPoSContext dataContext;
        List<HoaDonBanHang> exportBills;
        List<ChiTietBanHang> exportDetails;
        List<ItemSaleDetail> saleDetails;
        List<ItemBill> itemBills;
        public ExportForm()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            this.listView2.Items.Clear();
            ListView listView = sender as ListView;
            if(listView.SelectedItems.Count > 0)
            {
                int idBill = Int32.Parse(listView.SelectedItems[0].Name);
                foreach (var item in saleDetails)
                {
                    if(item.IDBill == idBill)
                    {
                        ListViewItem viewItem = CreateDetailItem(item);
                        this.listView2.Items.Add(viewItem);
                    }
                }
            }
        }

        void GetSaleDetail()
        {
            exportDetails = dataContext.ChiTietBanHangs.ToList();
            saleDetails = new List<ItemSaleDetail>();
            List<SanPham> products = dataContext.SanPhams.ToList();
            foreach (var item in exportDetails)
            {
                var result = from prod in products where prod.id_sp == item.id_sp select prod;
                int price = result.First().giaBan.Value;
                string name = result.First().ten_sp;
                ItemSaleDetail itemSale = new ItemSaleDetail(item.id_hdBan, item.id_sp, name, price, item.soLuong.Value);
                saleDetails.Add(itemSale);
            }
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            exportBills = dataContext.HoaDonBanHangs.ToList();
            GetSaleDetail();
            itemBills = new List<ItemBill>();
            foreach (var item in exportBills)
            {
                List<ItemSaleDetail> details = new List<ItemSaleDetail>();
                foreach (ItemSaleDetail item2 in saleDetails)
                {
                    if(item2.IDBill == item.id_hd)
                    {
                        details.Add(item2);
                    }
                }
                ItemBill bill = new ItemBill(item.id_hd, item.id_nv.Value, item.ngayBan, details);
                itemBills.Add(bill);
            }
            foreach (var item in itemBills)
            {
                ListViewItem viewItem = CreateBillItem(item);
                this.listView1.Items.Add(viewItem);
            }
        }
        ListViewItem CreateBillItem(ItemBill bill)
        {
            ListViewItem item = new ListViewItem();
            item.Name = bill.ID.ToString();
            item.Text = bill.ID.ToString();
            item.SubItems.Add(bill.SaleDate.ToString());
            item.SubItems.Add(bill.IDStaff.ToString());
            item.SubItems.Add(bill.TotalCash.ToString());
            return item;
        }
        ListViewItem CreateDetailItem(ItemSaleDetail detail)
        {
            ListViewItem item = new ListViewItem();
            item.Name = detail.ID.ToString();
            item.Text = detail.Name;
            item.SubItems.Add(detail.Price.ToString());
            item.SubItems.Add(detail.Amount.ToString());
            item.SubItems.Add(detail.ToCash.ToString());
            return item;
        }
    }
}
