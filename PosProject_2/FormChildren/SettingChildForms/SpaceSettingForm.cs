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

namespace PosProject_2.FormChildren.SettingChildForms
{
    public partial class SpaceSettingForm : Form
    {
        DataPoSContext dataContext;
        public SpaceSettingForm()
        {
            InitializeComponent();
        }
        bool IsExist(string target, List<string> exists)
        {
            bool isExist = false;
            foreach (var item in exists)
            {
                if (target.Equals(item))
                {
                    isExist = true;
                }
            }
            return isExist;
        }
        bool IsTextEmpty(string text)
        {
            if (text.Length == 0 || text.Equals("") || text.Equals("Vui lòng điền tên khu vực"))
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<string> areas = dataContext.KhuVucs.Select(kv => kv.ten_khuVuc).ToList();
            string text = this.txtArea.Text;
            if (IsTextEmpty(text))
            {
                this.txtArea.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if (IsExist(text, areas))
            {
                this.txtArea.Text = "Khu vực đã tồn tại";
                return;
            }
            string query = $"insert into dbo.KhuVuc (id, ten_khuVuc) values ({areas.Count}, N'{text}')";
            SQLQuery sqlOject = new SQLQuery();
            sqlOject.OpenCloseConn(query);
            MessageBox.Show("Thêm khu vực thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelArea_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<KhuVuc> areas = dataContext.KhuVucs.ToList();
            List<BanAn> tables;
            int idArea = -1;
            string textInput = this.txtArea.Text;
            if (IsTextEmpty(textInput))
            {
                this.txtArea.Text = "Vui lòng điền tên khu vực";
                return;
            }
            bool find = false;
            foreach (var area in areas)
            {
                if (area.ten_khuVuc.Equals(textInput))
                {
                    idArea = area.id;
                    find = true;
                }
            }
            if (!find)
            {
                this.txtArea.Text = "Không tìm thấy khu vực cần xóa!";
                return;
            }
            tables = dataContext.BanAns.Where(ba => ba.id_khuVuc == idArea).ToList();
            int countTableOrdered = 0;
            foreach (var table in tables)
            {
                if (table.isOrder.Value) countTableOrdered++;
            }
            if(countTableOrdered > 0)
            {
                MessageBox.Show($"Chúng tôi nhận thấy rằng khu vực {textInput} sắp bị xóa!\n" +
                    $"Tuy nhiên, trong khu vực này có {countTableOrdered} bàn đang được đặt.\n" +
                    $"Vui lòng thanh toán (các) bàn đó trước khi xóa khu vực!", "Cảnh báo: Khu vực không thể xóa!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = $"delete from dbo.KhuVuc where id = {idArea}";
                SQLQuery sqlOject = new SQLQuery();
                sqlOject.OpenCloseConn(query);
                MessageBox.Show("Xóa khu vực thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateArea_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<string> areas = dataContext.KhuVucs.Select(kv => kv.ten_khuVuc).ToList();
            string oldArea = this.txtArea.Text;
            string newArea = this.txtNewAreaName.Text;
            if (IsTextEmpty(oldArea))
            {
                this.txtArea.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if(IsTextEmpty(newArea) || newArea.Equals("Nhập tên mới"))
            {
                this.txtNewAreaName.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if (!IsExist(oldArea, areas))
            {
                this.txtArea.Text = "Khu vực cần đổi tên không tồn tại";
                return;
            }
            if (IsExist(newArea, areas))
            {
                this.txtNewAreaName.Text = "Tên mới của khu vực đã tồn tại";
                return;
            }
            string query = $"update dbo.KhuVuc set ten_khuVuc = N'{newArea}' where ten_khuVuc = N'{oldArea}'";
            SQLQuery sqlOject = new SQLQuery();
            sqlOject.OpenCloseConn(query);
            MessageBox.Show("Cập nhật tên khu vực thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chckChangeAreaName_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chckChangeAreaName.Checked)
            {
                this.txtNewAreaName.Visible = true;
                this.btnUpdateAreaName.Visible = true;
            }
            else
            {
                this.txtNewAreaName.Visible = false;
                this.btnUpdateAreaName.Visible = false;
            }
        }

        private void chckChangeTableName_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chckChangeTableName.Checked)
            {
                this.txtNewTableName.Visible = true;
                this.btnUpdateTableName.Visible = true;
            }
            else
            {
                this.txtNewTableName.Visible = false;
                this.btnUpdateTableName.Visible = false;
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<string> areas = dataContext.KhuVucs.Select(kv => kv.ten_khuVuc).ToList();
            List<string> tables = dataContext.BanAns.Select(ba => ba.ten_ban).ToList();
            string text = this.txtTable.Text;
            string textArea = this.txtAreaExist.Text;
            if (IsTextEmpty(textArea))
            {
                this.txtAreaExist.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if (IsTextEmpty(text))
            {
                this.txtTable.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if(!IsExist(textArea, areas))
            {
                this.txtAreaExist.Text = $"Không tồn tại Khu vực {textArea}";
                return;
            }
            if (IsExist(text, tables))
            {
                this.txtTable.Text = $"Bàn {text} đã tồn tại";
                return;
            }
            var idArea = from area in dataContext.KhuVucs
                         where area.ten_khuVuc.Equals(textArea)
                         select area.id;
            string query = $"insert into dbo.BanAn (id, ten_ban, id_khuVuc) values ({tables.Count + 1}, N'{text}', {idArea.First()})";
            SQLQuery sqlOject = new SQLQuery();
            sqlOject.OpenCloseConn(query);
            MessageBox.Show("Thêm bàn thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelTable_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<string> areas = dataContext.KhuVucs.Select(kv => kv.ten_khuVuc).ToList();
            List<string> tables = dataContext.BanAns.Select(ba => ba.ten_ban).ToList();
            string text = this.txtTable.Text;
            string textArea = this.txtAreaExist.Text;
            if (IsTextEmpty(textArea))
            {
                this.txtAreaExist.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if (IsTextEmpty(text))
            {
                this.txtTable.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if (!IsExist(textArea, areas))
            {
                this.txtAreaExist.Text = $"Không tồn tại Khu vực {textArea}";
                return;
            }
            if (!IsExist(text, tables))
            {
                this.txtTable.Text = $"Bàn {text} không tồn tại";
                return;
            }
            var table = from item in dataContext.BanAns
                        where item.ten_ban.Equals(text)
                        select item.isOrder;
            if (table.First().Value)
            {
                this.txtTable.Text = "Bàn này đang có đơn, vui lòng thanh toán trước khi xóa!";
                return;
            }
            string query = $"delete from dbo.BanAn where ten_ban = N'{text}'";
            SQLQuery sqlObject = new SQLQuery();
            sqlObject.OpenCloseConn(query);
            MessageBox.Show("Xóa bàn thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateTableName_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<string> areas = dataContext.KhuVucs.Select(kv => kv.ten_khuVuc).ToList();
            List<string> tables = dataContext.BanAns.Select(ba => ba.ten_ban).ToList();
            string text = this.txtTable.Text;
            string textArea = this.txtAreaExist.Text;
            string newTable = this.txtNewTableName.Text;
            if (IsTextEmpty(textArea))
            {
                this.txtAreaExist.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if (IsTextEmpty(text))
            {
                this.txtTable.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if (IsTextEmpty(newTable) || newTable.Equals("Nhập tên mới"))
            {
                this.txtNewTableName.Text = "Vui lòng điền tên khu vực";
                return;
            }
            if (!IsExist(textArea, areas))
            {
                this.txtAreaExist.Text = $"Không tồn tại Khu vực {textArea}";
                return;
            }
            if (!IsExist(text, tables))
            {
                this.txtTable.Text = $"Bàn {text} không tồn tại";
                return;
            }
            var table = from item in dataContext.BanAns
                        where item.ten_ban.Equals(text)
                        select item.isOrder;
            if (table.First().Value)
            {
                this.txtTable.Text = "Bàn này đang có đơn, vui lòng thanh toán trước khi đổi tên!";
                return;
            }
            if (IsExist(newTable, tables))
            {
                this.txtTable.Text = $"Bàn {text} này đã tồn tại";
                return;
            }
            string query = $"update dbo.BanAn set ten_ban = N'{newTable}' where ten_ban = N'{text}'";
            SQLQuery sqlOject = new SQLQuery();
            sqlOject.OpenCloseConn(query);
            MessageBox.Show("Cập nhật tên bàn thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
