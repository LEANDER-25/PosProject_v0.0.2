using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_2.FormChildren.SettingChildForms.StorageForms
{
    public partial class MaterialSettingForm : Form
    {
        DataPoSContext dataContext;
        public MaterialSettingForm()
        {
            InitializeComponent();
        }
        ListViewItem CreateItem(NguyenLieu nl)
        {
            ListViewItem item = new ListViewItem();
            item.Name = nl.id.ToString();
            item.Text = nl.id.ToString();
            item.SubItems.Add(nl.ten_nguyenLieu);
            item.SubItems.Add(nl.soLuongConLai.ToString());
            item.SubItems.Add(nl.soLuongLe_1_dvt.ToString());
            item.SubItems.Add(nl.donViTinhLe);
            return item;
        }
        void LoadDate()
        {
            this.listView.Items.Clear();
            dataContext = new DataPoSContext();
            List<NguyenLieu> nls = dataContext.NguyenLieus.ToList();
            foreach (var item in nls)
            {
                ListViewItem card = CreateItem(item);
                this.listView.Items.Add(card);
            }
        }

        private void MaterialSettingForm_Load(object sender, EventArgs e)
        {
            LoadDate();
        }
    }
}
