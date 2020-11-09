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
    public partial class SelectedItemButton : UserControl
    {
        public int IDItem { get; set; }
        int amount;
        public int Price { get; set; }
        public int Amount { get { return amount; } set { amount = value; this.txtAmount.Text = amount.ToString(); } }
        public SelectedItemButton()
        {
            InitializeComponent();
        }
        public SelectedItemButton(int idItem, int amount)
        {
            this.IDItem = idItem;
            this.amount = amount;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            this.btnRemoveThis.Parent = this;
            DataPoSContext data = new DataPoSContext();
            var result = from item in data.SanPhams
                         where item.id_sp == IDItem
                         select item;
            this.Name = result.First().ten_sp;
            this.label1.Text = result.First().ten_sp;
            this.label2.Text = result.First().giaBan.ToString();
            this.Price = result.First().giaBan.Value;
            this.txtAmount.Text = Amount.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if(Amount <= 1)
            {
                return;
            }
            amount--;
            this.txtAmount.Text = Amount.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            amount++;
            this.txtAmount.Text = Amount.ToString();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = 0;
            if (!Int32.TryParse(this.txtAmount.Text, out amount)) return;
            else this.amount = amount;
        }
    }
}
