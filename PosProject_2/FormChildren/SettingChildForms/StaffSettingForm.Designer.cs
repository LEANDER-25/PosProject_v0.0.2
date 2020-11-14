namespace PosProject_2.FormChildren.SettingChildForms
{
    partial class StaffSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSettingForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSignUp = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowPwd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPwdConfirm = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lbCheckPwdCF = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.rdioNameOptional = new System.Windows.Forms.RadioButton();
            this.rdioIDOptional = new System.Windows.Forms.RadioButton();
            this.btnSearchInfo = new System.Windows.Forms.Button();
            this.txtSearchInfo = new System.Windows.Forms.TextBox();
            this.listStaffs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTipHintPwdRule = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabSignUp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSignUp);
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSignUp
            // 
            this.tabSignUp.Controls.Add(this.panel1);
            this.tabSignUp.Controls.Add(this.label9);
            this.tabSignUp.Controls.Add(this.label5);
            this.tabSignUp.Controls.Add(this.label4);
            this.tabSignUp.Controls.Add(this.label3);
            this.tabSignUp.Controls.Add(this.label2);
            this.tabSignUp.Controls.Add(this.label1);
            this.tabSignUp.Location = new System.Drawing.Point(4, 25);
            this.tabSignUp.Name = "tabSignUp";
            this.tabSignUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignUp.Size = new System.Drawing.Size(775, 372);
            this.tabSignUp.TabIndex = 0;
            this.tabSignUp.Text = "Đăng ký thông tin";
            this.tabSignUp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnShowPwd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPwdConfirm);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.lbCheckPwdCF);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.txtNickName);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(322, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 366);
            this.panel1.TabIndex = 7;
            // 
            // btnShowPwd
            // 
            this.btnShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPwd.ForeColor = System.Drawing.Color.White;
            this.btnShowPwd.Location = new System.Drawing.Point(240, 199);
            this.btnShowPwd.Name = "btnShowPwd";
            this.btnShowPwd.Size = new System.Drawing.Size(56, 50);
            this.btnShowPwd.TabIndex = 16;
            this.btnShowPwd.Text = "Xem MK";
            this.btnShowPwd.UseVisualStyleBackColor = true;
            this.btnShowPwd.Click += new System.EventHandler(this.btnShowPwd_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(204, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipHintPwdRule.SetToolTip(this.label6, "Mk phải có độ dài ít nhất là 3, chứa 1 số hoặc chữ (hoa hoặc thường)");
            // 
            // txtPwdConfirm
            // 
            this.txtPwdConfirm.Location = new System.Drawing.Point(4, 227);
            this.txtPwdConfirm.Name = "txtPwdConfirm";
            this.txtPwdConfirm.Size = new System.Drawing.Size(194, 22);
            this.txtPwdConfirm.TabIndex = 5;
            this.txtPwdConfirm.UseSystemPasswordChar = true;
            this.txtPwdConfirm.TextChanged += new System.EventHandler(this.txtPwdConfirm_TextChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(106, 281);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(92, 34);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lbCheckPwdCF
            // 
            this.lbCheckPwdCF.BackColor = System.Drawing.Color.Turquoise;
            this.lbCheckPwdCF.Location = new System.Drawing.Point(204, 227);
            this.lbCheckPwdCF.Name = "lbCheckPwdCF";
            this.lbCheckPwdCF.Size = new System.Drawing.Size(30, 22);
            this.lbCheckPwdCF.TabIndex = 15;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(4, 199);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(194, 22);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(4, 171);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(194, 22);
            this.txtNickName.TabIndex = 3;
            this.txtNickName.TextChanged += new System.EventHandler(this.txtNickName_TextChanged);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(4, 143);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(194, 22);
            this.txtPosition.TabIndex = 2;
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(4, 114);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 22);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(4, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên thật";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.rdioNameOptional);
            this.tabInfo.Controls.Add(this.rdioIDOptional);
            this.tabInfo.Controls.Add(this.btnSearchInfo);
            this.tabInfo.Controls.Add(this.txtSearchInfo);
            this.tabInfo.Controls.Add(this.listStaffs);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(775, 372);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Thông tin nhân viên";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // rdioNameOptional
            // 
            this.rdioNameOptional.AutoSize = true;
            this.rdioNameOptional.Location = new System.Drawing.Point(389, 339);
            this.rdioNameOptional.Name = "rdioNameOptional";
            this.rdioNameOptional.Size = new System.Drawing.Size(113, 21);
            this.rdioNameOptional.TabIndex = 2;
            this.rdioNameOptional.TabStop = true;
            this.rdioNameOptional.Text = "Tìm theo Tên";
            this.rdioNameOptional.UseVisualStyleBackColor = true;
            this.rdioNameOptional.CheckedChanged += new System.EventHandler(this.rdioNameOptional_CheckedChanged);
            // 
            // rdioIDOptional
            // 
            this.rdioIDOptional.AutoSize = true;
            this.rdioIDOptional.Location = new System.Drawing.Point(282, 339);
            this.rdioIDOptional.Name = "rdioIDOptional";
            this.rdioIDOptional.Size = new System.Drawing.Size(101, 21);
            this.rdioIDOptional.TabIndex = 28;
            this.rdioIDOptional.TabStop = true;
            this.rdioIDOptional.Text = "Tìm theo ID";
            this.rdioIDOptional.UseVisualStyleBackColor = true;
            this.rdioIDOptional.CheckedChanged += new System.EventHandler(this.rdioIDOptional_CheckedChanged);
            // 
            // btnSearchInfo
            // 
            this.btnSearchInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchInfo.BackgroundImage")));
            this.btnSearchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInfo.Location = new System.Drawing.Point(482, 311);
            this.btnSearchInfo.Name = "btnSearchInfo";
            this.btnSearchInfo.Size = new System.Drawing.Size(48, 22);
            this.btnSearchInfo.TabIndex = 1;
            this.btnSearchInfo.UseVisualStyleBackColor = true;
            this.btnSearchInfo.Click += new System.EventHandler(this.btnSearchInfo_Click);
            // 
            // txtSearchInfo
            // 
            this.txtSearchInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchInfo.Location = new System.Drawing.Point(282, 311);
            this.txtSearchInfo.Name = "txtSearchInfo";
            this.txtSearchInfo.Size = new System.Drawing.Size(194, 22);
            this.txtSearchInfo.TabIndex = 0;
            this.txtSearchInfo.WordWrap = false;
            this.txtSearchInfo.TextChanged += new System.EventHandler(this.txtSearchInfo_TextChanged);
            // 
            // listStaffs
            // 
            this.listStaffs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listStaffs.FullRowSelect = true;
            this.listStaffs.GridLines = true;
            this.listStaffs.HideSelection = false;
            this.listStaffs.Location = new System.Drawing.Point(50, 3);
            this.listStaffs.Name = "listStaffs";
            this.listStaffs.Size = new System.Drawing.Size(673, 291);
            this.listStaffs.TabIndex = 3;
            this.listStaffs.UseCompatibleStateImageBehavior = false;
            this.listStaffs.View = System.Windows.Forms.View.Details;
            this.listStaffs.DoubleClick += new System.EventHandler(this.listStaffs_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SĐT";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chức vụ";
            this.columnHeader4.Width = 166;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên đăng nhập";
            this.columnHeader5.Width = 149;
            // 
            // toolTipHintPwdRule
            // 
            this.toolTipHintPwdRule.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // StaffSettingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(808, 426);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffSettingForm";
            this.Text = "StaffSettingForm";
            this.tabControl1.ResumeLayout(false);
            this.tabSignUp.ResumeLayout(false);
            this.tabSignUp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPwdConfirm;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lbCheckPwdCF;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.RadioButton rdioNameOptional;
        private System.Windows.Forms.RadioButton rdioIDOptional;
        private System.Windows.Forms.Button btnSearchInfo;
        private System.Windows.Forms.TextBox txtSearchInfo;
        private System.Windows.Forms.ListView listStaffs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnShowPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTipHintPwdRule;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}