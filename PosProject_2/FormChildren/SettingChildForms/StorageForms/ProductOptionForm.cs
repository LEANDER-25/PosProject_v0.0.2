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

namespace PosProject_2.FormChildren.SettingChildForms.StorageForms
{
    public partial class ProductOptionForm : Form
    {
        public int IdProd;
        DataPoSContext dataContext;
        Dictionary<int, int> idMaterials;
        ProductOption productOption;
        public ProductOptionForm()
        {
            InitializeComponent();
            productOption = new ProductOption();
            productOption.cbbTypeProd = this.cbbTypeProd;
            productOption.flowPanel = this.flowLayoutPanel1;
        }

        private void ProductOptionForm_Load(object sender, EventArgs e)
        {
            productOption.LoadData(IdProd);
            this.txtNameProd.Text = productOption.NameProd;
            this.txtPriceProd.Text = productOption.Price;
            this.txtUnitProd.Text = productOption.UnitProd;
            this.cbbTypeProd.Text = productOption.TypeProd;
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

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            List<string> infos = productOption.NewProductInfo(this.txtNameProd.Text, this.txtPriceProd.Text, this.txtUnitProd.Text, this.cbbTypeProd.Text);
            idMaterials = productOption.idMaterials;
            dataContext = new DataPoSContext();
            var idType = from typ in dataContext.LoaiSPs
                         where typ.ten_loai.Equals(infos[3])
                         select typ.id_loai;
            string query = $"update dbo.SanPham set " +
                $"ten_sp = {infos[0]}, " +
                $"giaBan = {Int32.Parse(infos[1])}, " +
                $"id_loai = {idType}, " +
                $"donVi = {infos[2]} where id_sp = {IdProd}";
            SQLQuery sql = new SQLQuery();
            sql.OpenCloseConn(query);
            MessageBox.Show("Cập nhật thành công!");
            this.Close();
        }

        private void btnDelProd_Click(object sender, EventArgs e)
        {
            string query = $"ALTER TABLE CacBanCoDon nocheck CONSTRAINT fk_sanPham_\n" +
                $"ALTER TABLE Lam nocheck CONSTRAINT fk_sanPham\n" + 
                $"ALTER TABLE ChiTietBanHang nocheck CONSTRAINT fk_spBan_\n" +
                $"delete from dbo.SanPham where id_sp = {IdProd}\n" +
                $"ALTER TABLE CacBanCoDon check CONSTRAINT fk_sanPham_\n" +
                $"ALTER TABLE Lam check CONSTRAINT fk_sanPham\n" +
                $"ALTER TABLE ChiTietBanHang check CONSTRAINT fk_spBan_";
            SQLQuery sql = new SQLQuery();
            sql.OpenCloseConn(query);
            MessageBox.Show("Xóa thành công!");
            this.Close();
        }
    }
}
