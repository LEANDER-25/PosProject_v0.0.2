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
    public partial class OrderedForm : Form
    {
        DataPoSContext dataContext;
        Form searchResultForm;
        private List<ItemOrdered> Ordereds;
        public int IDThisTable { get; set; }
        public OrderedForm()
        {
            InitializeComponent();
        }
        public OrderedForm(int idThisTable)
        {
            this.IDThisTable = idThisTable;
            dataContext = new DataPoSContext();
            Ordereds = new List<ItemOrdered>();
            InitializeComponent();
        }
        public List<ItemOrdered> GetOrdereds()
        {
            foreach (SelectedItemButton item in this.flowSelectProduct.Controls)
            {
                ItemOrdered itemOrdered = new ItemOrdered();
                itemOrdered.IDTable = this.IDThisTable;
                itemOrdered.ID = item.IDItem;
                itemOrdered.Name = item.Name;
                itemOrdered.Price = item.Price;
                itemOrdered.Amount = item.Amount;
                Ordereds.Add(itemOrdered);
            }
            return Ordereds;
        }
        void LoadDataToForm()
        {
            List<LoaiSP> typePdts = dataContext.LoaiSPs.ToList();
            List<SanPham> products = dataContext.SanPhams.ToList();
            txtSearch.AutoCompleteCustomSource.AddRange(products.Select(p => p.ten_sp).ToArray());
            this.tabProductList.Font = new Font("Segor UI", 10);
            this.tabProductList.TabPages.Add(TabItem(products, "Tất cả", -1));
            foreach (var typeItem in typePdts)
            {
                this.tabProductList.TabPages.Add(TabItem(products, typeItem.ten_loai, typeItem.id_loai));
            }
            FlowLoadData();
        }
        TabPage TabItem(List<SanPham> products, string text, int idType)
        {
            TabPage tabPage = new TabPage();
            tabPage.Font = new Font("Segor UI", 10);
            tabPage.Text = text;
            if (idType > -1)
                products = products.Where(p => p.id_loai == idType).ToList();
            ListView listView = new ListView();
            listView.Size = this.tabProductList.Size;
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            Dictionary<int, string> titles = new Dictionary<int, string>();
            titles.Add(50, "ID");
            titles.Add(350, "Tên sản phẩm");
            titles.Add(listView.Size.Width - 400, "Giá bán");
            foreach (var item in titles)
            {
                ColumnHeader header = new ColumnHeader();
                header.Text = item.Value;
                header.Width = item.Key;
                header.TextAlign = HorizontalAlignment.Left;
                listView.Columns.Add(header);
            }
            int colorFill = 0;
            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem();
                item.Name = product.id_sp.ToString();
                item.Font = new Font("Segor UI", 9);
                item.Text = product.id_sp.ToString();
                item.SubItems.Add(product.ten_sp);
                item.SubItems.Add(product.giaBan.ToString());
                colorFill++;
                if((colorFill + 1) % 2 == 0)
                {
                    item.BackColor = Color.Bisque;
                }
                listView.Items.Add(item);
            }
            listView.DoubleClick += ListSResult_DoubleClick;
            tabPage.Controls.Add(listView);
            return tabPage;
        }

        void OpenForm(Form result)
        {
            if(searchResultForm != null)
            {
                searchResultForm.Close();
            }
            searchResultForm = result;
            result.Dock = DockStyle.Fill;
            result.TopLevel = false;
            result.Parent = this;
            this.panelItems.Controls.Add(result);
            this.ActivateMdiChild(result);
            result.BringToFront();
            result.Show();
        }
        void FlowLoadData()
        {
            List<CacBanCoDon> orderedTables = dataContext.CacBanCoDons.Where(t => t.id_ban == this.IDThisTable).ToList();
            if(orderedTables.Count != 0)
            {
                foreach (var item in orderedTables)
                {
                    SelectedItemButton selectedItem = new SelectedItemButton(item.id_sp, item.soLuongYeuCau.Value);
                    selectedItem.btnRemoveThis.Click += BtnRemoveThis_Click;
                    this.flowSelectProduct.Controls.Add(selectedItem);
                }
            }
        }

        private void BtnRemoveThis_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.flowSelectProduct.Controls.Remove(btn.Parent);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Equals(""))
            {
                this.txtSearch.Text = "Vui lòng thêm từ khóa!";
                return;
            }
            SearchResultForm searchForm = new SearchResultForm(txtSearch.Text);
            searchForm.listSResult.DoubleClick += ListSResult_DoubleClick;
            OpenForm(searchForm);
        }

        private void ListSResult_DoubleClick(object sender, EventArgs e)
        {
            ListView list = sender as ListView;
            if (list.SelectedItems.Count > 0)
            {
                int idProduct = Int32.Parse(list.SelectedItems[0].Name);
                SelectedItemButton selectedItem = new SelectedItemButton(idProduct, 1);
                selectedItem.btnRemoveThis.Click += BtnRemoveThis_Click;
                if (IsItemExistInFlowPanel(selectedItem))
                    return;
                else
                {
                    this.flowSelectProduct.Controls.Add(selectedItem);
                }
            }
        }
        bool IsItemExistInFlowPanel(SelectedItemButton item)
        {
            bool flag = false;
            foreach (SelectedItemButton flowItem in this.flowSelectProduct.Controls)
            {
                if(item.IDItem == flowItem.IDItem)
                {
                    flag = true;
                    flowItem.Amount++;
                    break;
                }
            }
            return flag;
        }

        private void OrderedForm_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }
    }
}
