using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_2.Models
{
    public partial class StaffInfoOption : Form
    {
        string idStaff;
        string nameStaff;
        string positionStaff;
        string phoneContact;
        string accountName;
        public StaffInfoOption()
        {
            InitializeComponent();
        }
        public StaffInfoOption(string id, string name, string position, string phone, string account)
        {
            this.idStaff = id;
            this.nameStaff = name;
            this.positionStaff = position;
            this.phoneContact = phone;
            this.accountName = account;
            InitializeComponent();
        }

        private void StaffInfoOption_Load(object sender, EventArgs e)
        {
            this.txtID.Text = this.idStaff;
            this.txtName.Text = this.nameStaff;
            this.txtPhone.Text = this.phoneContact;
            this.txtPosition.Text = this.positionStaff;
            this.txtAcc.Text = this.accountName;
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            bool[] isChange = { true, true, true, true};
            if (this.nameStaff.Equals(this.txtName.Text)) isChange[0] = false;
            if (this.positionStaff.Equals(this.txtPosition.Text)) isChange[1] = false;
            if (this.phoneContact.Equals(this.txtPhone.Text)) isChange[2] = false;
            if (this.accountName.Equals(this.txtAcc.Text)) isChange[3] = false;
            bool flag = false;
            foreach (var item in isChange)
            {
                if (item)
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Không có thông tin nào được thay đổi!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtPosition.Text.Equals("admin"))
            {
                MessageBox.Show("Bạn không có quyền thêm nhân viên này", "Lỗi: Quyền lực được hạn chế", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int id = Int32.Parse(this.idStaff);
            string query = $"update dbo.NhanVien " +
                $"set " +
                $"ten_nhanVien = N'{this.txtName.Text}'," +
                $"ten_dangNhap = '{this.txtAcc.Text}'," +
                $"chucVu = N'{this.txtPosition.Text}'," +
                $"SDT = '{this.txtPhone.Text}' where id_nhanVien = {id}";
            SQLQuery sqlOject = new SQLQuery();
            sqlOject.OpenCloseConn(query);
            MessageBox.Show("Cập nhật thành công :>", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            DataPoSContext dataContext = new DataPoSContext();
            var isOnline = from staff in dataContext.NhanViens
                           where staff.isOnline == true
                           select staff.chucVu;
            if (!isOnline.First().Equals("admin")&&(this.positionStaff.Equals("Quản lý")||this.positionStaff.Equals("admin")))
            {
                MessageBox.Show("Bạn không có quyền xóa nhân viên này", "Lỗi: Quyền lực được hạn chế", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult warningBox = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này khỏi hệ thống?\n" +
                "Xin vui lòng bấm OK!\n" +
                "Đi lại thì bấm Cancel\n" +
                "Thông tin thanh niên xấu số này là:\n\n" +
                $"Họ tên: {this.nameStaff}\n" +
                $"Chức vụ: {this.positionStaff}", "Cảnh báo: Suy nghĩ kỹ!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(warningBox == DialogResult.OK)
            {
                int id = Int32.Parse(this.idStaff);
                string query = $"delete from dbo.NhanVien where id_nhanVien = {id}";
                SQLQuery sqlOject = new SQLQuery();
                sqlOject.OpenCloseConn(query);
                MessageBox.Show("Xóa anh/chị đẹp trai/gái thành công :<", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
