using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PosProject_2.Models;

namespace PosProject_2.FormChildren.SettingChildForms.StorageForms
{
    public partial class ImportForm : Form
    {
        DataPoSContext dataContext;
        public ImportForm()
        {
            InitializeComponent();
        }

        ListViewItem CreateItem(ItemImportDetail import)
        {
            ListViewItem item = new ListViewItem();
            item.Name = import.ID.ToString();
            item.Text = import.Name;
            item.SubItems.Add(import.Amount.ToString());
            item.SubItems.Add(import.Price.ToString());
            return item;
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            dataContext = new DataPoSContext();
            List<NguyenLieu> materials = dataContext.NguyenLieus.ToList();

            foreach (var item in materials)
            {
                ImportMaterial import = new ImportMaterial(item.id, item.ten_nguyenLieu);
                import.chckName.CheckStateChanged += ChckName_CheckStateChanged;
                this.flowLayoutPanel1.Controls.Add(import);
            }
        }

        private void ChckName_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            ImportMaterial import = (ImportMaterial)check.Parent;
            if (check.Checked)
            {                
                import.txtAmount.ReadOnly = true;
                import.txtPrice.ReadOnly = true;
                ItemImportDetail importDetail = new ItemImportDetail();
                importDetail.ID = Int32.Parse(check.Name); 
                importDetail.Name = check.Text;
                importDetail.Amount = import.Amount;
                importDetail.Price = import.Price;
                ListViewItem item = CreateItem(importDetail);
                this.listView1.Items.Add(item);
            }
            else
            {
                import.txtAmount.ReadOnly = false;
                import.txtPrice.ReadOnly = false;
                int i = 0;
                foreach (ListViewItem item in this.listView1.Items)
                {
                    if (item.Name.Equals(check.Name))
                    {
                        break;
                    }
                    i++;
                }
                this.listView1.Items.RemoveAt(i);
            }
        }

        private void btnImportInvoice_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<int> invoice = dataContext.HoaDonNhapHangs.Select(h => h.id_hd).ToList();
            int idNext = invoice.Count + 1;
            var selectStaff = from staff in dataContext.NhanViens
                          where staff.isOnline == true
                          select staff.id_nhanVien;
            int idStaff = selectStaff.FirstOrDefault();
            if(this.listView1.Items.Count == 0)
            {
                MessageBox.Show("Không có nguyên liệu được chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (ListViewItem item in this.listView1.Items)
            {
                if(item.SubItems[1].Text == "0")
                {
                    MessageBox.Show("Không thể nhập nguyên liệu với số lượng 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            List<ItemImportDetail> imports = new List<ItemImportDetail>();
            foreach (ListViewItem item in this.listView1.Items)
            {
                ItemImportDetail detail = new ItemImportDetail();
                detail.ID = Int32.Parse(item.Name);
                detail.Amount = Int32.Parse(item.SubItems[1].Text);
                detail.Price = Int32.Parse(item.SubItems[2].Text);
                imports.Add(detail);
            }
            string query = $"insert into dbo.HoaDonNhapHang (id_hd, ngayNhap, id_nv) values ({idNext}, '{DateTime.Now.ToString()}', {idStaff})";
            SQLQuery sql = new SQLQuery();
            sql.OpenCloseConn(query);
            try
            {
                SqlConnection connection = new SqlConnection(sql.ConnectionString);
                connection.Open();
                foreach (var item in imports)
                {
                    query = $"insert into dbo.ChiTietNhapHang (id_hoaDonNhap, id_nguyenLieu, soLuongNhap, giaNhap) values ({idNext}, {item.ID}, {item.Amount}, {item.Price})";
                    SQLQuery.ExecuteQueryNonConn(query, connection);
                }
                connection.Close();
                MessageBox.Show("Xuất thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
