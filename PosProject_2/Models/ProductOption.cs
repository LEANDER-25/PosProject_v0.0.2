using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PosProject_2.Models
{
    class ProductOption
    {
        public DataPoSContext dataContext;
        public Dictionary<int, int> idMaterials;
        public FlowLayoutPanel flowPanel;
        public ComboBox cbbTypeProd;
        public string NameProd, Price, UnitProd, TypeProd;

        public ProductOption()
        {

        }

        public void LoadData()
        {
            dataContext = new DataPoSContext();
            List<NguyenLieu> materials = dataContext.NguyenLieus.ToList();
            idMaterials = new Dictionary<int, int>();
            foreach (var item in materials)
            {
                MaterialCard card = new MaterialCard(item.id, item.ten_nguyenLieu);
                card.checkMateName.CheckStateChanged += CheckMateName_CheckStateChanged;
                this.flowPanel.Controls.Add(card);
            }
            string[] nameTypeProds = dataContext.LoaiSPs.Select(l => l.ten_loai).ToArray();
            this.cbbTypeProd.Items.AddRange(nameTypeProds);
            this.cbbTypeProd.AutoCompleteCustomSource.AddRange(nameTypeProds);
        }
        public void LoadData(int idProd)
        {
            dataContext = new DataPoSContext();
            List<NguyenLieu> materials = dataContext.NguyenLieus.ToList();
            List<Lam> makes = dataContext.Lams.Where(m => m.id_sanPham == idProd).ToList();
            idMaterials = new Dictionary<int, int>();
            foreach (var item in materials)
            {
                MaterialCard card = new MaterialCard(item.id, item.ten_nguyenLieu);
                foreach (var item2 in makes)
                {
                    if(item.id == item2.id_nguyenLieu)
                    {
                        card.SetNumber(item2.soLuongNL_1_SP.Value);
                        card.checkMateName.Checked = true;
                        card.txtNumberMate.ReadOnly = true;
                    }
                }
                card.checkMateName.CheckStateChanged += CheckMateName_CheckStateChanged;
                this.flowPanel.Controls.Add(card);
            }
            string[] nameTypeProds = dataContext.LoaiSPs.Select(l => l.ten_loai).ToArray();
            this.cbbTypeProd.Items.AddRange(nameTypeProds);
            this.cbbTypeProd.AutoCompleteCustomSource.AddRange(nameTypeProds);
            var prod = from pro in dataContext.SanPhams
                       where pro.id_sp == idProd
                       select pro;
            this.NameProd = prod.First().ten_sp;
            this.Price = prod.First().giaBan.ToString();
            this.UnitProd = prod.First().donVi;
            this.TypeProd = nameTypeProds[prod.First().id_loai.Value - 1];
        }

        public void CheckMateName_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            MaterialCard item = (MaterialCard)checkBox.Parent;
            if (checkBox.Checked)
            {
                item.txtNumberMate.ReadOnly = true;
                idMaterials.Add(Int32.Parse(checkBox.Name), item.NumberPerProd);
            }
            else
            {
                item.txtNumberMate.ReadOnly = false;
                idMaterials.Remove(Int32.Parse(checkBox.Name));
            }
        }
        public string TrimAll(string text)
        {
            text = text.TrimStart();
            text = text.TrimEnd();
            return text;
        }

        public List<string> NewProductInfo(string name, string price, string unit, string type)
        {
            List<string> info = new List<string>();
            string text = name;
            info.Add(TrimAll(text));
            text = price;
            info.Add(TrimAll(text));
            text = unit;
            info.Add(TrimAll(text));
            text = type;
            info.Add(TrimAll(text));
            return info;
        }
        public void txtPriceProd_TextChanged(object sender, EventArgs e)
        {
            TextBox txtPriceProd = sender as TextBox;
            if (!Regex.IsMatch(txtPriceProd.Text, @"^[\d]{4,}$"))
            {
                txtPriceProd.ForeColor = Color.Red;
            }
            else
            {
                txtPriceProd.ForeColor = Color.Black;
            }
        }

        public void txtUnitProd_TextChanged(object sender, EventArgs e)
        {
            ComboBox txtUnitProd = sender as ComboBox;
            if (!Regex.IsMatch(txtUnitProd.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                txtUnitProd.ForeColor = Color.Red;
            }
            else
            {
                txtUnitProd.ForeColor = Color.Black;
            }
        }
    }
}
