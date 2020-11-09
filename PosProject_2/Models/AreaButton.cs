using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_2.Models
{
    public partial class AreaButton : UserControl
    {
        public KhuVuc Area { get; set; }
        public AreaButton()
        {
            InitializeComponent();
        }
        public AreaButton(KhuVuc area)
        {
            this.Area = area;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            this.lbAreaName.Text = this.Area.ten_khuVuc;
            //this.lbAreaName.ForeColor = Color.White;
            this.Name = this.Area.id.ToString();
            DataPoSContext context = new DataPoSContext();
            List<BanAn> tables = context.BanAns.Where(t => t.id_khuVuc == this.Area.id).ToList();
            bool haveOrder = false;
            int count = 0;
            foreach (var item in tables)
            {
                if (item.isOrder.Value)
                {
                    count++;
                    haveOrder = true;
                }
            }
            if (haveOrder)
            {
                this.lbNotice.Text = count.ToString();
                this.lbNotice.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                this.lbNotice.ForeColor = Color.Red;
            }
        }
    }
}
