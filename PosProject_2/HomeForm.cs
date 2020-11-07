using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosProject_2.FormChildren;
using PosProject_2.Models;
using System.Data.SqlClient;

namespace PosProject_2
{
    public partial class HomeForm : Form
    {
        public int IDStaff { get; set; }
        Timer t = null;
        DataPoSContext dataContext;
        public Form activeForm;
        public HomeForm()
        {
            InitializeComponent();
        }
        public HomeForm(int idStaff)
        {
            dataContext = new DataPoSContext();
            this.IDStaff = idStaff;
            InitializeComponent();
            LoadForm();
        }
        private void StartTime()
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Enabled = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            this.lbCurrentTime.Text = DateTime.Now.ToString();
        }
        void LoadForm()
        {
            List<NhanVien> staffs = dataContext.NhanViens.Where(s => s.id_nhanVien == this.IDStaff).ToList();
            this.lbStaffName.Text = staffs[0].ten_nhanVien;
            this.lbStaffPosition.Text = "Vị trí: " + staffs[0].chucVu;
            //MarkStaffState(StaffState.Online);
            StartTime();
        }

        void MarkStaffState(StaffState state)
        {
            string connString = @"Data Source=LAPTOP-VGNL1UAA;Initial Catalog=Project_1_Pos_FakeData;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                int isOnline = 0;
                if (state.Equals(StaffState.Online)) isOnline = 1;
                string query = $"update dbo.NhanVien set isOnline = {isOnline} where id_nhanVien = {this.IDStaff}";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void OpenTablesForm(int idTable)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            TablesForm tablesForm = new TablesForm(idTable);
            activeForm = tablesForm;
            tablesForm.TopLevel = false;
            //tablesForm.Dock = DockStyle.Fill;
            this.panelAreas.Controls.Add(tablesForm);
            this.panelAreas.Tag = tablesForm;
            this.ActivateMdiChild(tablesForm);
            tablesForm.BringToFront();
            tablesForm.Show();
        }

        private void HomeForm_Activated(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.flowAreas.Controls.Clear();
            List<KhuVuc> areas = dataContext.KhuVucs.ToList();
            foreach (var area in areas)
            {
                int x = Color.DarkOrchid.ToArgb();
                int y = Color.LightPink.ToArgb();
                int color = rnd.Next(x, y);
                AreaButton areaButton = new AreaButton(area);
                areaButton.BackColor = Color.FromArgb(color);
                areaButton.ForeColor = Color.White;
                areaButton.Click += AreaButton_Click;
                this.flowAreas.Controls.Add(areaButton);
            }
        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            AreaButton btn = sender as AreaButton;
            OpenTablesForm(Int32.Parse(btn.Name));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            var result = from staff in dataContext.NhanViens
                         where staff.id_nhanVien == IDStaff
                         select staff.chucVu;
            if (result.Equals("Quản lý")) { }
            else
            {
                MessageBox.Show("Rất tiếc! Chỉ có vị trí Quản lý mới được sử dụng chức năng này", "Vị trí bị giới hạn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //MarkStaffState(StaffState.Offline);
            Application.Exit();
        }
    }
    enum StaffState
    {
        Online,
        Offline
    }
}
