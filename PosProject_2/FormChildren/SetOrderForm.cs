﻿using System;
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
                SQLQuery sqlOject = new SQLQuery();
                SqlConnection connection = new SqlConnection(sqlOject.ConnectionString);
                try
                {
                    connection.Open();
                    SqlCommand command;
                    int totalCash = ((PayAction)activateForm).TotalCash;
                    List<ItemPayDetail> orderedItems = ((PayAction)activateForm).OrderedItems;
                    List<HoaDonBanHang> billSales = dataContext.HoaDonBanHangs.ToList();
                    int idBill = billSales.Count + 1;
                    string query = $"insert into dbo.HoaDonBanHang (id_hd, ngayBan, id_nv) values " +
                        $"({idBill}, " +
                        $"'{DateTime.Now.ToString()}', " +
                        $"{staffs[0].id_nhanVien} )";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    foreach (var item in orderedItems)
                    {
                        query = $"insert into dbo.ChiTietBanHang (id_hdBan, id_sp, soLuong) values (" +
                            $"{idBill}, {item.ID_Product}, {item.Amount})";
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
