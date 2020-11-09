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

namespace PosProject_2.FormChildren
{
    public partial class SetOrderForm : Form
    {
        public int IDThisTable { get; set; }
        DataPoSContext dataContext;
        Form activateForm;
        public SetOrderForm()
        {
            InitializeComponent();
        }
        public SetOrderForm(int idThisTable)
        {
            this.IDThisTable = idThisTable;
            dataContext = new DataPoSContext();
            InitializeComponent();
        }

        void OpenForm(Form child)
        {
            if(activateForm != null){
                activateForm.Close();
            }
            activateForm = child;
            this.ActivateMdiChild(child);
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.pnlThisTableContent.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void SetOrderForm_Activated(object sender, EventArgs e)
        {
            var tableName = from table in dataContext.BanAns
                            where table.id == this.IDThisTable
                            select table.ten_ban;
            this.lbTableName.Text = tableName.First().ToString();
            OpenForm(new OrderedForm(this.IDThisTable));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(this.activateForm.Name.Equals("OrderedForm"))
            {
                this.Close();
            }
            else
            {
                OpenForm(new OrderedForm(this.IDThisTable));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!activateForm.Name.Equals("OrderedForm"))
            {
                Console.WriteLine("This is not a ordered form");
                return;
            }
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
                    if(ordereds.Count == savedItems.Count)
                    {
                        for (int i = 0; i < savedItems.Count; i++)
                        {
                            if (ordereds[i].ID == savedItems[i].id_sp)
                            {
                                if(ordereds[i].Amount > savedItems[i].soLuongYeuCau)
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
                    else if(ordereds.Count >= savedItems.Count)
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
                        else if(flag == 2)
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
                            for (int i = 0; i < savedItems.Count; i ++)
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
            int count = ((OrderedForm)activateForm).flowSelectProduct.Controls.Count;
            if (count == 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Clone or Copy items were selected in OrderedForm
        /// </summary>
        /// <param name="ordereds"></param>
        void CloneOrderedItems(ref List<ItemOrdered> ordereds)
        {
            if (!activateForm.Name.Equals("OrderedForm")) return;
            ordereds = ((OrderedForm)activateForm).GetOrdereds();
        }
        /// <summary>
        /// The name of method describe what it does. It just a command executes insert query without open/close connection 
        /// </summary>
        void InsertInTemp_NoConn(ItemOrdered item, SqlConnection connection)
        {
            string query = $"insert into dbo.CacBanCoDon (id_ban, id_sp, ten_sp, giaBan, soLuongYeuCau) values " +
                $"({item.IDTable}," +
                $" {item.ID}," +
                $" N'{item.Name}'," +
                $" {item.Price}," +
                $" {item.Amount})";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Like InsertInTemp_NoConn() but with a query update new amount of item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="connection"></param>
        void UpdateAmountExistInTemp_NoConn(ItemOrdered item, SqlConnection connection)
        {
            string query = $"update dbo.CacBanCoDon set soLuongYeuCau = {item.Amount} where id_ban = {item.IDTable} and id_sp = {item.ID}";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Absolutely, this method contains a delete temp table query
        /// </summary>
        /// <param name="idTable"></param>
        /// <param name="connection"></param>
        void DelTemp_NoConn(int idTable, SqlConnection connection)
        {
            string query = $"delete from dbo.CacBanCoDon where id_ban in ({idTable})";
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

        private void btnPay_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<CacBanCoDon> orderedItem = dataContext.CacBanCoDons.Where(item => item.id_ban == this.IDThisTable).ToList();
            List<NhanVien> staffs = dataContext.NhanViens.Where(s => s.isOnline == true).ToList();
            if (orderedItem.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào được Lưu nên không xuất hoá đơn được", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(this.activateForm.Name.Equals("PayAction"))
            {
                string connString = @"Data Source=LAPTOP-VGNL1UAA;Initial Catalog=Project_1_Pos_FakeData;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connString);
                try
                {
                    connection.Open();
                    SqlCommand command;
                    int totalCash = ((PayAction)activateForm).TotalCash;
                    List<ItemPayDetail> orderedItems = ((PayAction)activateForm).OrderedItems;
                    List<HoaDonBanHang> billSales = dataContext.HoaDonBanHangs.ToList();
                    int idBill = billSales.Count + 1;
                    string query = $"insert into dbo.HoaDonBanHang (id_hd, ngayBan, ten_nv, id_nv, TongTien) values " +
                        $"({idBill}, " +
                        $"'{DateTime.Now.ToString()}', " +
                        $"N'{staffs[0].ten_nhanVien}', " +
                        $"{staffs[0].id_nhanVien}, " +
                        $"{totalCash})";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    foreach (var item in orderedItems)
                    {
                        query = $"insert into dbo.ChiTietBanHang (id_hdBan, id_sp, ten_sp, soLuong, giaBan, thanhTien) values (" +
                            $"{idBill}, {item.ID_Product}, N'{item.Name}', {item.Amount}, {item.Price}, {item.ToCash})";
                        command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }
                    DelTemp_NoConn(this.IDThisTable, connection);
                    connection.Close();
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetOrderForm_Activated(this, new EventArgs());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                OpenForm(new PayAction(this.lbTableName.Text, orderedItem, staffs[0].ten_nhanVien));
            }
        }
    }
}
