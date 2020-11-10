using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosProject_2.FormChildren.SettingChildForms;

namespace PosProject_2.FormChildren
{
    public partial class SettingForm : Form
    {
        Form activateForm;
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }
        void OpenSettingChildForm(Form childForm)
        {
            if(activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.Parent = this;
            this.panelChildForm.Controls.Add(childForm);
            this.ActivateMdiChild(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSpaceSetting_Click(object sender, EventArgs e)
        {
            OpenSettingChildForm(new SpaceSettingForm());
        }

        private void btnStaffSetting_Click(object sender, EventArgs e)
        {
            OpenSettingChildForm(new StaffSettingForm());
        }
    }
}
