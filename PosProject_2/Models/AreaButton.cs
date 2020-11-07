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
        }
    }
}
