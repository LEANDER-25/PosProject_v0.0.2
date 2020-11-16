using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosProject_2.FormChildren.RevenueForms;

namespace PosProject_2.FormChildren
{
    public partial class RevenueForm : Form
    {
        Form activeForm;
        public RevenueForm()
        {
            InitializeComponent();
        }
        void OpenTablesForm(Form child)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = child;
            child.TopLevel = false;
            //tablesForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(child);
            this.panel2.Tag = child;
            this.ActivateMdiChild(child);
            child.BringToFront();
            child.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            OpenTablesForm(new ExportForm());
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenTablesForm(new ImportBillsForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenTablesForm(new ChartForm());
        }
    }
}
