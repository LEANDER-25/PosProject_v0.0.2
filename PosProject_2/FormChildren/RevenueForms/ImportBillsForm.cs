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
    public partial class ImportBillsForm : Form
    {
        DataPoSContext dataContext;
        List<HoaDonNhapHang> exportBills;
        List<ChiTietNhapHang> exportDetails;
        List<ItemImportDetail> importDetails;
        List<ItemBill> itemBills;
        public ImportBillsForm()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            this.listView2.Items.Clear();
            ListView listView = sender as ListView;
            if (listView.SelectedItems.Count > 0)
            {
                int idBill = Int32.Parse(listView.SelectedItems[0].Name);
                foreach (var item in importDetails)
                {
                    if (item.IDBill == idBill)
                    {
                        ListViewItem viewItem = CreateDetailItem(item);
                        this.listView2.Items.Add(viewItem);
                    }
                }
            }
        }

        void GetSaleDetail()
        {
            exportDetails = dataContext.ChiTietNhapHangs.ToList();
            importDetails = new List<ItemImportDetail>();
            List<NguyenLieu> materials = dataContext.NguyenLieus.ToList();
            foreach (var item in exportDetails)
            {
                var result = from prod in materials where prod.id == item.id_nguyenLieu select prod;
                int price = item.giaNhap.Value;
                string name = result.First().ten_nguyenLieu;
                ItemImportDetail itemSale = new ItemImportDetail(item.id_hoaDonNhap, item.id_nguyenLieu, name, price, item.soLuongNhap.Value);
                importDetails.Add(itemSale);
            }
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            exportBills = dataContext.HoaDonNhapHangs.ToList();
            GetSaleDetail();
            itemBills = new List<ItemBill>();
            foreach (var item in exportBills)
            {
                List<ItemImportDetail> details = new List<ItemImportDetail>();
                foreach (ItemImportDetail item2 in importDetails)
                {
                    if (item2.IDBill == item.id_hd)
                    {
                        details.Add(item2);
                    }
                }
                ItemBill bill = new ItemBill(item.id_hd, item.id_nv.Value, item.ngayNhap, details);
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
        ListViewItem CreateDetailItem(ItemImportDetail detail)
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
