﻿using System;
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
                if (staff.chucVu.Equals("admin"))
                {
                    continue;
                }
                ListViewItem item = CreateLVItem(staff);
                listStaffs.Items.Add(item);
            }
        }
        void ValidInputString(Control control, string pattern)
        {
            string text = control.Text.TrimStart();
            text = text.TrimEnd();
            if (!Regex.IsMatch(text, pattern)){
                control.ForeColor = Color.Red;
            }
            else
            {
                control.ForeColor = Color.Green;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtName, @"^[\p{L}\p{M}' \.\-]+$");
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtPhone, @"^[\d]{10}$");
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtPosition, @"^[\p{L}\p{M}\d' \.\-]+$");
        }

        private void txtNickName_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtNickName, @"[\w|_]+$");
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtPwd, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{3,}$");
        }

        private void txtPwdConfirm_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPwdConfirm.Text.Equals(this.txtPwd.Text))
            {
                this.lbCheckPwdCF.BackColor = Color.SpringGreen;
            }
            else
            {
                this.lbCheckPwdCF.BackColor = Color.Crimson;
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
            clones.Add(this.txtName.Text);
            clones.Add(this.txtPhone.Text);
            clones.Add(this.txtPosition.Text);
            clones.Add(this.txtNickName.Text);
            clones.Add(this.txtPwd.Text);
            clones.Add(this.txtPwdConfirm.Text);
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
            flags.Clear();
            flags.Add(-1);
            dataContext = new DataPoSContext();
            List<string> staffNames = dataContext.NhanViens.Select(s => s.ten_nhanVien).ToList();
            List<string> staffAccs = dataContext.NhanViens.Select(s => s.ten_dangNhap).ToList();
            flags.Add(CheckExist(staffNames, texts[0], 0));
            flags.Add(CheckExist(staffNames, texts[3], 3));
            TextFillInError(flags, "đã tồn tại");
            bool fillFull = true;
            foreach (var item in flags)
            {
                if(item != -1)
                {
                    fillFull = false;
                    break;
                }
            }
            if (fillFull)
            {
                var admin = from nv in dataContext.NhanViens
                            where nv.isOnline == true
                            select nv.chucVu;
                if(texts[2].Equals("Quản lý") && !admin.First().Equals("admin"))
                {
                    MessageBox.Show("Bạn không có quyền cài đặt chức quản lý!\n" +
                        "Chỉ có admin mới được cài chức danh này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string query = $"insert into dbo.NhanVien (ten_nhanVien, ten_dangNhap, matKhau, chucVu, SDT) values " +
                    $"(N'{texts[0]}', '{texts[3]}', '{texts[4]}', N'{texts[2]}', '{texts[1]}'" +
                    $")";
                string connString = @"Data Source=LAPTOP-VGNL1UAA;Initial Catalog=Project_1_Pos_FakeData;Integrated Security=True";
                SQLQuery.OpenCloseConn(query, connString);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}
