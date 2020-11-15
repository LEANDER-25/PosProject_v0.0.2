using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_2
{
    public partial class Form1 : Form
    {
        Thread thread;
        int idStaff;
        public Form1()
        {
            idStaff = -1;
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams create = base.CreateParams;
                create.ClassStyle = 0x00020000;
                return create;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OpenNewForm()
        {
            Application.Run(new HomeForm(idStaff));
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DataPoSContext dataContext = new DataPoSContext();
            List<NhanVien> staffs = dataContext.NhanViens.ToList();
            Console.WriteLine(this.txtAccName.Text + " " + this.txtPwd.Text);
            foreach (var staff in staffs)
            {
                if(staff.ten_dangNhap.Equals(this.txtAccName.Text) && staff.matKhau.Equals(this.txtPwd.Text))
                {
                    idStaff = staff.id_nhanVien;
                    break;
                }
            }
            if(idStaff == -1)
            {
                MessageBox.Show("Sai thông tin đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
            thread = new Thread(OpenNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void txtAccName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.txtPwd.Focus();
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(this, new EventArgs());
            }
        }
    }
}
