using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosProject_2.FormChildren.SettingChildForms.StorageForms;

namespace PosProject_2.FormChildren.SettingChildForms
{
    public partial class StorageSettingForm : Form
    {
        Form activatedChild;
        public StorageSettingForm()
        {
            InitializeComponent();
        }
        void OpenChildForm(Form child)
        {
            if(activatedChild != null)
            {
                activatedChild.Close();
            }
            activatedChild = child;
            child.TopLevel = false;
            this.panel2.Controls.Add(child);
            this.ActivateMdiChild(child);
            child.BringToFront();
            child.Show();
        }
        private void btnMenuSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuSettingForm());
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MaterialSettingForm());
        }

        private void btnImportGoods_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ImportForm());
        }
    }
}
