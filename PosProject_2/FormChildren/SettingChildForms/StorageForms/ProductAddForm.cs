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
using PosProject_2.FormChildren.SettingChildForms.StorageForms;
using PosProject_2.Models;

namespace PosProject_2.FormChildren.SettingChildForms.StorageForms
{
    public partial class ProductAddForm : Form
    {
        DataPoSContext dataContext;
        ProductOption productOption;
        public ProductAddForm()
        {
            InitializeComponent();
            productOption = new ProductOption();
            productOption.cbbTypeProd = this.cbbTypeProd;
            productOption.flowPanel = this.flowLayoutPanel1;
        }
        private void ProductOptionForm_Load(object sender, EventArgs e)
        {
            productOption.LoadData();
        }

        private void txtPriceProd_TextChanged(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;
            productOption.txtPriceProd_TextChanged(text, e);
        }

        private void cbbTypeProd_TextChanged(object sender, EventArgs e)
        {
            ComboBox text = sender as ComboBox;
            productOption.txtUnitProd_TextChanged(text, e);
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<string> info = productOption.NewProductInfo(this.txtNameProd.Text, txtPriceProd.Text, txtUnitProd.Text, cbbTypeProd.Text);
            List<int> tabIndex = new List<int>();
            Dictionary<int, int> idMaterials = productOption.idMaterials;
            tabIndex.Add(-1);
            for (int i = 0; i < info.Count; i++)
            {
                if (info[i].Equals("") || info[i].Length == 0)
                {
                    tabIndex.Add(i);
                }
            }
            if (tabIndex.Count > 1 || idMaterials.Count == 0)
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtPriceProd.ForeColor != Color.Black || this.txtUnitProd.ForeColor != Color.Black)
            {
                MessageBox.Show("Thông tin không phù hợp!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tabIndex.Clear();
            List<SanPham> products = dataContext.SanPhams.ToList();
            foreach (var item in products)
            {
                if (item.ten_sp.Equals(info[0]))
                {
                    tabIndex.Add(0);
                    break;
                }
            }
            if (tabIndex.Count > 0)
            {
                this.txtNameProd.Text = "Thông tin đã tồn tại";
                return;
            }
            var typeId = from type in dataContext.LoaiSPs
                         where type.ten_loai.Equals(info[3])
                         select type.id_loai;
            SQLQuery sqlObject = new SQLQuery();
            string query = $"insert into dbo.SanPham (id_sp, ten_sp, giaBan, id_loai, donVi) values (" +
                $"{products.Count + 1}," +
                $"N'{info[0]}'," +
                $"{Int32.Parse(info[1])}," +
                $"{typeId}," +
                $"N'{info[2]}')";
            sqlObject.OpenCloseConn(query);
            try
            {
                SqlConnection connection = new SqlConnection(sqlObject.ConnectionString);
                connection.Open();
                foreach (var item in idMaterials)
                {
                    query = $"insert into dbo.Lam (id_sanPham, id_nguyenLieu, soLuongNL_1_SP) values({products.Count + 1}, {item.Key}, {item.Value})";
                    SQLQuery.ExecuteQueryNonConn(query, connection);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
