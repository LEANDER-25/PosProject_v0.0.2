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
    public partial class SearchResultForm : Form
    {
        DataPoSContext dataContext;
        string searchString;
        public SearchResultForm()
        {
            InitializeComponent();
        }
        public SearchResultForm(string searchString)
        {
            this.searchString = searchString;
            dataContext = new DataPoSContext();
            InitializeComponent();
        }
        void LoadResult()
        {
            List<SanPham> items = dataContext.SanPhams.Where(i => i.ten_sp.Contains(this.searchString)).ToList();
            foreach (var item in items)
            {
                ListViewItem viewItem = new ListViewItem();
                viewItem.Name = item.id_sp.ToString();
                viewItem.Text = item.id_sp.ToString();
                viewItem.SubItems.Add(item.ten_sp);
                viewItem.SubItems.Add(item.giaBan.ToString());
                listSResult.Items.Add(viewItem);
            }
        }

        private void SearchResultForm_Activated(object sender, EventArgs e)
        {
            LoadResult();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
