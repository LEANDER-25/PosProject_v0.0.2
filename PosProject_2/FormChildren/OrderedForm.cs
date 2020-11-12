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
using System.Data.SqlClient;

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
        //public List<ItemOrdered> GetOrdereds()
        //{
        //    Ordereds = new List<ItemOrdered>();
        //    foreach (SelectedItemButton item in this.flowSelectProduct.Controls)
        //    {
        //        ItemOrdered itemOrdered = new ItemOrdered();
        //        itemOrdered.IDTable = this.IDThisTable;
        //        itemOrdered.ID = item.IDItem;
        //        itemOrdered.Name = item.Name;
        //        itemOrdered.Price = item.Price;
        //        itemOrdered.Amount = item.Amount;
        //        Ordereds.Add(itemOrdered);
        //    }
        //    return Ordereds;
        //}
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEmptyFlow())
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 sản phẩm", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var tableExist = from table in dataContext.BanAns
                             where table.id == this.IDThisTable
                             select table.isOrder;
            string connString = @"Data Source=LAPTOP-VGNL1UAA;Initial Catalog=Project_1_Pos_FakeData;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                List<ItemOrdered> ordereds = new List<ItemOrdered>();
                CloneOrderedItems(ref ordereds);
                Dictionary<int, int> usedMaterials = new Dictionary<int, int>();
                connection.Open();
                if (Boolean.Parse(tableExist.First().Value.ToString()))
                {
                    int flag = 0;
                    Dictionary<int, int> existAmountItems = new Dictionary<int, int>();
                    List<CacBanCoDon> savedItems = dataContext.CacBanCoDons.Where(s => s.id_ban == this.IDThisTable).ToList();
                    if (ordereds.Count == savedItems.Count)
                    {
                        for (int i = 0; i < savedItems.Count; i++)
                        {
                            if (ordereds[i].ID == savedItems[i].id_sp)
                            {
                                if (ordereds[i].Amount > savedItems[i].soLuongYeuCau)
                                {
                                    flag = 2;
                                    existAmountItems.Add(ordereds[i].ID, ordereds[i].Amount - savedItems[i].soLuongYeuCau.Value);
                                }
                                else if (ordereds[i].Amount < savedItems[i].soLuongYeuCau)
                                {
                                    flag = 1;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else if (ordereds[i].ID != savedItems[i].id_sp)
                            {
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 1)
                        {
                            MessageBox.Show("Chúng tôi nhận thấy rằng bạn vừa đổi ít nhất một sản phẩm hoặc giảm số lượng của sản phẩm đã lưu!" +
                                "Rất tiếc, việc này không được phép, bạn sẽ không thể lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (flag == 0)
                        {
                            MessageBox.Show("Bạn đã lưu đơn này trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            foreach (var item in existAmountItems)
                            {
                                CalUsedMaterialAmount(item.Key, item.Value, ref usedMaterials);
                            }
                            foreach (var item in ordereds)
                            {
                                UpdateAmountExistInTemp_NoConn(item, connection);
                            }
                            foreach (var item in existAmountItems)
                            {
                                UpdateMaterialTable(item.Key, item.Value, connection);
                            }
                        }
                    }
                    else if (ordereds.Count >= savedItems.Count)
                    {
                        for (int i = 0; i < savedItems.Count; i++)
                        {
                            if (ordereds[i].ID == savedItems[i].id_sp)
                            {
                                if (ordereds[i].Amount > savedItems[i].soLuongYeuCau)
                                {
                                    flag = 2;
                                    existAmountItems.Add(ordereds[i].ID, ordereds[i].Amount - savedItems[i].soLuongYeuCau.Value);
                                }
                                else if (ordereds[i].Amount < savedItems[i].soLuongYeuCau)
                                {
                                    flag = 1;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else if (ordereds[i].ID != savedItems[i].id_sp)
                            {
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 1)
                        {
                            MessageBox.Show("Chúng tôi nhận thấy rằng bạn vừa đổi ít nhất một sản phẩm hoặc giảm số lượng của sản phẩm đã lưu!" +
                                "Rất tiếc, việc này không được phép, bạn sẽ không thể lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (flag == 0)
                        {
                            usedMaterials = new Dictionary<int, int>();
                            for (int i = savedItems.Count; i < ordereds.Count; i++)
                            {
                                InsertInTemp_NoConn(ordereds[i], connection);
                                CalUsedMaterialAmount(ordereds[i].ID, ordereds[i].Amount, ref usedMaterials);
                            }
                            foreach (var item in usedMaterials)
                            {
                                UpdateMaterialTable(item.Key, item.Value, connection);
                            }
                        }
                        else
                        {
                            foreach (var item in existAmountItems)
                            {
                                CalUsedMaterialAmount(item.Key, item.Value, ref usedMaterials);
                            }
                            for (int i = 0; i < savedItems.Count; i++)
                            {
                                UpdateAmountExistInTemp_NoConn(ordereds[i], connection);
                            }
                            foreach (var item in existAmountItems)
                            {
                                UpdateMaterialTable(item.Key, item.Value, connection);
                            }
                            usedMaterials = new Dictionary<int, int>();
                            for (int i = savedItems.Count - 1; i < ordereds.Count; i++)
                            {
                                InsertInTemp_NoConn(ordereds[i], connection);
                                CalUsedMaterialAmount(ordereds[i].ID, ordereds[i].Amount, ref usedMaterials);
                            }
                            foreach (var item in usedMaterials)
                            {
                                UpdateMaterialTable(item.Key, item.Value, connection);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Có vẻ như là bạn muốn xóa ít nhất một sản phẩm khỏi danh sách. Rất tiếc, điều này là không hợp lệ!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    CalUsedMaterialAmountInList(ordereds, ref usedMaterials);
                    foreach (var item in ordereds)
                    {
                        InsertInTemp_NoConn(item, connection);
                    }
                    foreach (var item in usedMaterials)
                    {
                        UpdateMaterialTable(item.Key, item.Value, connection);
                    }
                }
                connection.Close();
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xuất hiện " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        bool IsEmptyFlow()
        {
            int count = this.flowSelectProduct.Controls.Count;
            if (count == 0)
                return true;
            else
                return false;
        }
        void CloneOrderedItems(ref List<ItemOrdered> ordereds)
        {
            foreach (SelectedItemButton item in this.flowSelectProduct.Controls)
            {
                ItemOrdered itemOrdered = new ItemOrdered();
                itemOrdered.IDTable = this.IDThisTable;
                itemOrdered.ID = item.IDItem;
                itemOrdered.Name = item.Name;
                itemOrdered.Price = item.Price;
                itemOrdered.Amount = item.Amount;
                ordereds.Add(itemOrdered);
            }
        }
        void InsertInTemp_NoConn(ItemOrdered item, SqlConnection connection)
        {
            string query = $"insert into dbo.CacBanCoDon (id_ban, id_sp, soLuongYeuCau) values " +
                $"({item.IDTable}," +
                $" {item.ID}," +
                $" {item.Amount})";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        void UpdateAmountExistInTemp_NoConn(ItemOrdered item, SqlConnection connection)
        {
            string query = $"update dbo.CacBanCoDon set soLuongYeuCau = {item.Amount} where id_ban = {item.IDTable} and id_sp = {item.ID}";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        void CalUsedMaterialAmount(int idProduct, int amount, ref Dictionary<int, int> usedMaterials)
        {
            List<NguyenLieu> materials = dataContext.NguyenLieus.ToList();
            List<Lam> makes = dataContext.Lams.ToList();
            Dictionary<int, int> makeIDMaterials = new Dictionary<int, int>();
            foreach (var makeItem in makes)
            {
                if (idProduct == makeItem.id_sanPham)
                {
                    int usedAmount = makeItem.soLuongNL_1_SP.Value * amount;
                    makeIDMaterials.Add(makeItem.id_nguyenLieu, usedAmount);
                }
            }
            foreach (var makeItem in makeIDMaterials)
            {
                foreach (var materialItem in materials)
                {
                    if (makeItem.Key == materialItem.id)
                    {
                        usedMaterials.Add(materialItem.id, makeItem.Value);
                    }
                }
            }
        }
        void CalUsedMaterialAmountInList(List<ItemOrdered> ordereds, ref Dictionary<int, int> usedMaterials)
        {
            foreach (var orderedItem in ordereds)
            {
                CalUsedMaterialAmount(orderedItem.ID, orderedItem.Amount, ref usedMaterials);
            }
        }
        void UpdateMaterialTable(int idMaterial, int usedAmount, SqlConnection connection)
        {
            string query = $"update dbo.NguyenLieu set soLuongConLai = soLuongConLai - {usedAmount} where id = {idMaterial}";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
