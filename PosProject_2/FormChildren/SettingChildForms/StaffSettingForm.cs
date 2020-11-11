using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject_2.FormChildren.SettingChildForms
{
    public partial class StaffSettingForm : Form
    {
        DataPoSContext dataContext;
        public StaffSettingForm()
        {
            InitializeComponent();
        }
        void ValidInputString(Control control, string pattern)
        {
            string text = control.Text.TrimStart();
            text = text.TrimEnd();
            if (!Regex.IsMatch(text, pattern)){
                control.ForeColor = Color.Red;
            }
            else
            {
                control.ForeColor = Color.Green;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtName, @"^[\p{L}\p{M}' \.\-]+$");
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtPhone, @"^[\d]{10}$");
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtPosition, @"^[\p{L}\p{M}\d' \.\-]+$");
        }

        private void txtNickName_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtNickName, @"[\w|_]+$");
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            ValidInputString(this.txtPwd, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{3,}$");
        }

        private void txtPwdConfirm_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPwdConfirm.Text.Equals(this.txtPwd.Text))
            {
                this.lbCheckPwdCF.BackColor = Color.SpringGreen;
            }
            else
            {
                this.lbCheckPwdCF.BackColor = Color.Crimson;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPwd_Click(object sender, EventArgs e)
        {
            this.txtPwd.UseSystemPasswordChar = !this.txtPwd.UseSystemPasswordChar;
        }
    }
}
