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
    public partial class ImportMaterial : UserControl
    {
        public int Amount { get; set; }
        public int Price { get; set; }
        public ImportMaterial()
        {
            InitializeComponent();
        }
        public ImportMaterial(int idMaterial, string nameMaterial)
        {
            InitializeComponent();
            this.Name = idMaterial.ToString();
            this.chckName.Name = this.Name;
            this.chckName.Text = nameMaterial;
            this.chckName.Parent = this;
            this.txtAmount.Text = "0";
            this.txtPrice.Text = "1000";
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            int amount = 0;
            this.Amount = Int32.TryParse(this.txtAmount.Text, out amount) ? amount : 0;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int price = 0;
            this.Price = Int32.TryParse(this.txtPrice.Text, out price) ? price : 1000;
        }
    }
}
