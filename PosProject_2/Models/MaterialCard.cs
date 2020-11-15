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
    public partial class MaterialCard : UserControl
    {
        public int ID { get; set; }
        public string MateName { get; set; }
        int numberProd = 0;
        public int NumberPerProd 
        { 
            get
            {
                return numberProd;
            }
        }
        public MaterialCard()
        {
            InitializeComponent();
        }
        public MaterialCard(int id, string name)
        {
            this.ID = id;
            this.MateName = name;
            this.numberProd = 0;
            InitializeComponent();
            this.Name = this.ID.ToString();
            this.checkMateName.Parent = this;
            this.checkMateName.Name = this.Name;
            this.checkMateName.Text = this.MateName;
            this.txtNumberMate.Text = this.numberProd.ToString();
        }
        public void SetNumber(int number)
        {
            this.numberProd = number;
            this.txtNumberMate.Text = number.ToString();
        }

        private void txtNumberMate_TextChanged(object sender, EventArgs e)
        {
            int number = 0;
            this.numberProd = Int32.TryParse(this.txtNumberMate.Text, out number) ? number : 0;
        }
    }
}
