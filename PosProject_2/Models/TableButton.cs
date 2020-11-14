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
    public partial class TableButton : UserControl
    {
        public BanAn Table { get; set; }
        public TableButton()
        {
            InitializeComponent();
        }
        public TableButton(BanAn table)
        {
            this.Table = table;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            this.lbText.Text = this.Table.ten_ban;
            this.lbText.TextAlign = ContentAlignment.MiddleCenter;
            this.lbText.ForeColor = Color.White;
            this.lbText.BackColor = Color.Transparent;
            this.BackColor = this.Table.isOrder == true ? ColorTranslator.FromHtml("#A352D9") : ColorTranslator.FromHtml("#DAA2F2");
            this.Name = this.Table.id.ToString();
        }
    }
}
