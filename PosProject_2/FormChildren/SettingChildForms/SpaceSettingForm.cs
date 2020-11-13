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
                if (area.Equals(textInput))
                {
                    idArea = area.id;
                }
            }
            tables = dataContext.BanAns.Where(ba => ba.id_khuVuc == idArea).ToList();

        }

        private void btnUpdateArea_Click(object sender, EventArgs e)
        {

        }

        
    }
}
