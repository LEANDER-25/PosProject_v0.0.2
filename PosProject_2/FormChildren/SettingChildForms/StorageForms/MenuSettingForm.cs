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
using System.Text.RegularExpressions;
using PosProject_2.Models;

namespace PosProject_2.FormChildren.SettingChildForms.StorageForms
{
    public partial class MenuSettingForm : Form
    {
        DataPoSContext dataContext;
        public MenuSettingForm()
        {
            InitializeComponent();
        }
        ListViewItem CreateItem(SanPham sp)
        {
            ListViewItem item = new ListViewItem();
            item.Name = sp.id_sp.ToString();
            item.Text = sp.id_sp.ToString();
            item.SubItems.Add(sp.ten_sp);
            item.SubItems.Add(sp.giaBan.ToString());
            item.SubItems.Add(sp.donVi);
            var type = from tp in dataContext.LoaiSPs
                       where tp.id_loai == sp.id_loai
                       select tp.ten_loai;
            item.SubItems.Add(type.First());
            return item;
        }

        void LoadData()
        {
            this.listProduct.Items.Clear();
            dataContext = new DataPoSContext();
            List<SanPham> products = dataContext.SanPhams.ToList();
            foreach (var item in products)
            {
                ListViewItem listItem = CreateItem(item);
                this.listProduct.Items.Add(listItem);
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MenuSettingForm_Activated(this, new EventArgs());
        }

        private void listProduct_DoubleClick(object sender, EventArgs e)
        {
            ListView item = sender as ListView;
            if(item.SelectedItems.Count > 0)
            {
                ProductOptionForm productOption = new ProductOptionForm();
                productOption.IdProd = Int32.Parse(item.SelectedItems[0].Name);
                productOption.ShowDialog();
            }            
        }

        private void MenuSettingForm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void rdioNameFilter_CheckedChanged(object sender, EventArgs e)
        {
            this.txtFilter.AutoCompleteCustomSource.AddRange(dataContext.SanPhams.Select(s => s.ten_sp).ToArray());
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (rdioNameFilter.Checked)
            {
                List<SanPham> sp = dataContext.SanPhams.ToList();
                this.listProduct.Items.Clear();
                foreach (var item in sp)
                {
                    if (item.ten_sp.Contains(this.txtFilter.Text))
                    {
                        ListViewItem lItem = CreateItem(item);
                        listProduct.Items.Add(lItem);
                    }
                }
            }
        }

        private void btnOpenAddForm_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new ProductAddForm();
            productAddForm.ShowDialog();
        }
    }
}
