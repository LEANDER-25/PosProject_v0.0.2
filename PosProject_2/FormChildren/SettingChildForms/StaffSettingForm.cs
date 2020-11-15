using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosProject_2.Models;

namespace PosProject_2.FormChildren.SettingChildForms
{
    public partial class StaffSettingForm : Form
    {
        DataPoSContext dataContext;
        bool showPwdOn;
        public StaffSettingForm()
        {
            showPwdOn = false;
            InitializeComponent();
            LoadData();
        }
        ListViewItem CreateLVItem(NhanVien staff)
        {
            ListViewItem item = new ListViewItem();
            item.Name = staff.id_nhanVien.ToString();
            item.Text = staff.id_nhanVien.ToString();
            item.SubItems.Add(staff.ten_nhanVien);
            item.SubItems.Add(staff.SDT);
            item.SubItems.Add(staff.chucVu);
            item.SubItems.Add(staff.ten_dangNhap);
            return item;
        }
        void LoadData()
        {
            listStaffs.Items.Clear();
            dataContext = new DataPoSContext();
            List<NhanVien> staffs = dataContext.NhanViens.ToList();
            foreach (var staff in staffs)
            {
                if (staff.chucVu.Equals("admin") || staff.stillWorking == false)
                {
                    continue;
                }
                ListViewItem item = CreateLVItem(staff);
                listStaffs.Items.Add(item);
            }
        }
        string TrimInput(string text)
        {
            string result = text.TrimStart();
            result = text.TrimEnd();
            return result;
        }
        void ValidInputString(ref string textInput, string pattern, ref Color foreColor)
        {
            string text = textInput.TrimStart();
            text = text.TrimEnd();
            if (!Regex.IsMatch(text, pattern)){
                foreColor = Color.Red;
            }
            else
            {
                foreColor = Color.Green;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string text = this.txtName.Text;
            Color fore = this.txtName.ForeColor;
            ValidInputString(ref text, @"^[\p{L}\p{M}' \.\-]+$", ref fore);
            this.txtName.ForeColor = fore;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string text = this.txtPhone.Text;
            Color fore = this.txtPhone.ForeColor;
            ValidInputString(ref text, @"^[\d]{10}$", ref fore);
            this.txtPhone.ForeColor = fore;
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            string text = this.txtPosition.Text;
            Color fore = this.txtPosition.ForeColor;
            ValidInputString(ref text, @"^[\p{L}\p{M}|0-9|' \.\-]+$", ref fore);
            this.txtPosition.ForeColor = fore;
        }

        private void txtNickName_TextChanged(object sender, EventArgs e)
        {
            string text = this.txtNickName.Text;
            Color fore = this.txtNickName.ForeColor;
            ValidInputString(ref text, @"^[A-Z_a-z0-9]+$", ref fore);
            this.txtNickName.ForeColor = fore;
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            string text = this.txtPwd.Text;
            Color fore = this.txtPwd.ForeColor;
            ValidInputString(ref text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{3,}$", ref fore);
            this.txtPwd.ForeColor = fore;
        }

        private void txtPwdConfirm_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPwdConfirm.Text.Equals(this.txtPwd.Text))
            {
                this.lbCheckPwdCF.BackColor = Color.SpringGreen;
            }
            else
            {
                this.lbCheckPwdCF.BackColor = Color.Red;
            }
        }

        private void btnShowPwd_Click(object sender, EventArgs e)
        {
            this.txtPwd.UseSystemPasswordChar = !this.txtPwd.UseSystemPasswordChar;
            bool isShow = !showPwdOn;
            showPwdOn = isShow;
            if (isShow) this.btnShowPwd.BackColor = Color.Black;
            else this.btnShowPwd.BackColor = Color.DarkCyan;
        }

        List<string> CloneTexts()
        {
            List<string> clones = new List<string>();
            clones.Add(TrimInput(this.txtName.Text));
            clones.Add(TrimInput(this.txtPhone.Text));
            clones.Add(TrimInput(this.txtPosition.Text));
            clones.Add(TrimInput(this.txtNickName.Text));
            clones.Add(TrimInput(this.txtPwd.Text));
            clones.Add(TrimInput(this.txtPwdConfirm.Text));
            return clones;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            List<int> flags = new List<int>();
            flags.Add(-1);
            List<string> texts = CloneTexts();
            for (int i = 0; i < texts.Count; i++)
            {
                string item = texts[i];
                if(item.Length == 0)
                {
                    flags.Add(i);
                }
            }
            TextFillInError(flags, "chưa được nhập!");
            bool fillFull = CheckFillFull(flags);
            if (!fillFull)
            {
                return;
            }
            flags.Clear();
            if(this.txtPwd.ForeColor == Color.Red || this.lbCheckPwdCF.BackColor == Color.Red)
            {
                flags.Add(4);
                flags.Add(5);
                TextFillInError(flags, "không giống nhau!");
                flags.Clear();
                return;
            }
            flags.Add(-1);
            dataContext = new DataPoSContext();
            List<string> staffNames = dataContext.NhanViens.Select(s => s.ten_nhanVien).ToList();
            List<string> staffAccs = dataContext.NhanViens.Select(s => s.ten_dangNhap).ToList();
            flags.Add(CheckExist(staffNames, texts[0], 0));
            flags.Add(CheckExist(staffAccs, texts[3], 3));
            TextFillInError(flags, "đã tồn tại");
            fillFull = CheckFillFull(flags);
            if (fillFull)
            {
                Console.WriteLine(fillFull.ToString());
                var admin = from nv in dataContext.NhanViens
                            where nv.isOnline == true
                            select nv.chucVu;
                if (texts[2].Equals("Quản lý") && !admin.First().Equals("admin"))
                {
                    MessageBox.Show("Bạn không có quyền cài đặt chức quản lý!\n" +
                        "Chỉ có admin mới được cài chức danh này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string query = $"insert into dbo.NhanVien (ten_nhanVien, ten_dangNhap, matKhau, chucVu, SDT) values " +
                    $"(N'{texts[0]}', '{texts[3]}', '{texts[4]}', N'{texts[2]}', '{texts[1]}'" +
                    $")";
                SQLQuery sqlOject = new SQLQuery();
                sqlOject.OpenCloseConn(query);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }
        bool CheckFillFull(List<int> flags)
        {
            bool fillFull = true;
            foreach (var item in flags)
            {
                if (item != -1)
                {
                    fillFull = false;
                    break;
                }
            }
            return fillFull;
        }
        void TextFillInError(List<int> flags, string error)
        {
            foreach (var flag in flags)
            {
                foreach (Control item in panel1.Controls)
                {
                    if(item.TabIndex == flag)
                    {
                        item.Text = $"Thông tin này {error}";
                    }
                }
            }
        }
        int CheckExist(List<string> existInfo, string text, int i)
        {
            foreach (var item in existInfo)
            {
                if (item.Equals(text))
                {
                    return i;
                }
            }
            return -1;
        }

        private void rdioIDOptional_CheckedChanged(object sender, EventArgs e)
        {
            dataContext = new DataPoSContext();
            List<int> idStaffs = dataContext.NhanViens.Select(nv => nv.id_nhanVien).ToList();
            RadioButton radio = sender as RadioButton;
            foreach (int item in idStaffs)
            {
                this.txtSearchInfo.AutoCompleteCustomSource.Add(item.ToString());
            }
        }

        private void rdioNameOptional_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            dataContext = new DataPoSContext();
            this.txtSearchInfo.AutoCompleteCustomSource.AddRange(dataContext.NhanViens.Select(nv => nv.ten_nhanVien).ToArray());
        }

        private void btnSearchInfo_Click(object sender, EventArgs e)
        {
            string searchText = this.txtSearchInfo.Text;
            int idSearch = 0;
            try
            {
                if (this.rdioIDOptional.Checked)
                {
                    Int32.TryParse(searchText, out idSearch);
                }
                List<NhanVien> staffs = dataContext.NhanViens.ToList();
                listStaffs.Items.Clear();
                foreach (var staff in staffs)
                {
                    if (staff.id_nhanVien.Equals(idSearch) || staff.ten_nhanVien.Contains(searchText))
                    {
                        ListViewItem item = CreateLVItem(staff);
                        listStaffs.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtSearchInfo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSearchInfo.Text.Equals(""))
            {
                LoadData();
            }
        }

        private void listStaffs_DoubleClick(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            if(listView.SelectedItems.Count > 0)
            {
                string idStaff = listView.SelectedItems[0].Text;
                string nameStaff = listView.SelectedItems[0].SubItems[1].Text;
                string phoneContact = listView.SelectedItems[0].SubItems[2].Text;
                string positionStaff = listView.SelectedItems[0].SubItems[3].Text;
                string accountName = listView.SelectedItems[0].SubItems[4].Text;
                StaffInfoOption option = new StaffInfoOption(idStaff, nameStaff, positionStaff, phoneContact, accountName);
                option.ShowDialog();
            }
        }

        private void StaffSettingForm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            StaffSettingForm_Activated(this, new EventArgs());
        }
    }
}
