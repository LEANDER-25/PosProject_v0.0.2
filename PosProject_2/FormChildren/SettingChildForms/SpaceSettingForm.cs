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

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<string> areas = dataContext.KhuVucs.Select(kv => kv.ten_khuVuc).ToList();
            string text = this.txtArea.Text;
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
            foreach (var area in areas)
            {
                if (area.ten_khuVuc.Equals(textInput))
                {
                    idArea = area.id;
                }
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
                string query = $"delete from KhuVuc where id = {idArea}";
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
            string query = $"update KhuVuc set ten_khuVuc = N'{newArea}' where ten_khuVuc = N'{oldArea}'";
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

        private void btnUpdateTableName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {

        }

        private void btnDelTable_Click(object sender, EventArgs e)
        {

        }
    }
}
