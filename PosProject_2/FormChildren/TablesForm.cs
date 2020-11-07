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

namespace PosProject_2.FormChildren
{
    public partial class TablesForm : Form
    {
        int idArea;
        DataPoSContext dataContext;
        public TablesForm()
        {
            InitializeComponent();
        }
        public TablesForm(int idArea)
        {
            this.idArea = idArea;
            dataContext = new DataPoSContext();
            InitializeComponent();
        }

        public void TablesForm_Activated(object sender, EventArgs e)
        {
            LoadDataInForm();
        }
        void LoadDataInForm()
        {
            this.flowTables.Controls.Clear();
            DataPoSContext dataContext = new DataPoSContext();
            List<BanAn> tables = dataContext.BanAns.Where(t => t.id_khuVuc == idArea).ToList();
            foreach (var table in tables)
            {
                TableButton tableButton = new TableButton(table);
                tableButton.Click += TableButton_Click;
                this.flowTables.Controls.Add(tableButton);
            }
        }
        //void LoadDataInForm()
        //{
        //    this.tabControl1.Controls.Clear();
        //    List<KhuVuc> areas = dataContext.KhuVucs.ToList();
        //    List<BanAn> tables = dataContext.BanAns.ToList();
        //    Random random = new Random();
        //    foreach (var area in areas)
        //    {
        //        TabPage tabPage = new TabPage();
        //        tabPage.Name = area.id.ToString();
        //        int min = Color.DarkOrchid.ToArgb();
        //        int max = Color.Violet.ToArgb();
        //        int rbg = random.Next(min, max);
        //        tabPage.BackColor = Color.FromArgb(rbg);
        //        tabPage.Text = area.ten_khuVuc;
        //        tabPage.Font = new Font("Microsoft Sans Serif", 10);
        //        this.tabControl1.TabPages.Add(tabPage);
        //        int x = 1, y = 1, count = 0;
        //        foreach (var table in tables)
        //        {
        //            if (table.id_khuVuc == area.id)
        //            {
        //                TableButton tableButton = new TableButton(table);
        //                tableButton.Location = new Point(x, y);
        //                tableButton.Click += TableButton_Click;
        //                x += tableButton.Size.Width;
        //                count++;
        //                if (count > 9)
        //                {
        //                    count = 0;
        //                    y += tableButton.Height;
        //                    x = 1;
        //                }
        //                tabPage.Controls.Add(tableButton);
        //            }
        //        }
        //    }
        //}
        void OpenSetOrderTable(int idTable)
        {
            //TablesForm tablesForm = new TablesForm(IDStaff);
            //tablesForm.TopLevel = false;
            //tablesForm.Dock = DockStyle.Fill;
            //this.panelChildFormShow.Controls.Add(tablesForm);
            //this.panelChildFormShow.Tag = tablesForm;
            //this.ActivateMdiChild(tablesForm);
            //tablesForm.BringToFront();
            //tablesForm.Show();
            SetOrderForm form = new SetOrderForm(idTable);
            this.TopLevel = false;
            form.TopLevel = true;
            this.Close();
            form.BringToFront();
            form.Show();
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            TableButton btn = sender as TableButton;
            SetOrderForm form = new SetOrderForm(Int32.Parse(btn.Name));
            form.ShowDialog();
        }
    }
}
