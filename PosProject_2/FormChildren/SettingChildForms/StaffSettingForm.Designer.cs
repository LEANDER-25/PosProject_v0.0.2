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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSettingForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSignUp = new System.Windows.Forms.TabPage();
            this.tabViewInfo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPwdConfirm = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lbCheckPwdCF = new System.Windows.Forms.Label();
            this.lbCheckNN = new System.Windows.Forms.Label();
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
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNNInfo = new System.Windows.Forms.TextBox();
            this.txtPositionInfo = new System.Windows.Forms.TextBox();
            this.txtPhoneInfo = new System.Windows.Forms.TextBox();
            this.txtNameInfo = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdioIDOptional = new System.Windows.Forms.RadioButton();
            this.rdioNameOptional = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.listStaffs = new System.Windows.Forms.ListView();
            this.rdioNameOptionalDel = new System.Windows.Forms.RadioButton();
            this.rdioIDOptionalDel = new System.Windows.Forms.RadioButton();
            this.btnSearchInfo = new System.Windows.Forms.Button();
            this.txtSearchInfo = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowPwd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSignUp.SuspendLayout();
            this.tabViewInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSignUp);
            this.tabControl1.Controls.Add(this.tabViewInfo);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 401);
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
            this.tabSignUp.Size = new System.Drawing.Size(727, 372);
            this.tabSignUp.TabIndex = 0;
            this.tabSignUp.Text = "Đăng ký thông tin";
            this.tabSignUp.UseVisualStyleBackColor = true;
            // 
            // tabViewInfo
            // 
            this.tabViewInfo.Controls.Add(this.btnChangeInfo);
            this.tabViewInfo.Controls.Add(this.label14);
            this.tabViewInfo.Controls.Add(this.rdioNameOptional);
            this.tabViewInfo.Controls.Add(this.rdioIDOptional);
            this.tabViewInfo.Controls.Add(this.btnSearch);
            this.tabViewInfo.Controls.Add(this.txtSearch);
            this.tabViewInfo.Controls.Add(this.label10);
            this.tabViewInfo.Controls.Add(this.label11);
            this.tabViewInfo.Controls.Add(this.label12);
            this.tabViewInfo.Controls.Add(this.label13);
            this.tabViewInfo.Controls.Add(this.txtNNInfo);
            this.tabViewInfo.Controls.Add(this.txtPositionInfo);
            this.tabViewInfo.Controls.Add(this.txtPhoneInfo);
            this.tabViewInfo.Controls.Add(this.txtNameInfo);
            this.tabViewInfo.Location = new System.Drawing.Point(4, 25);
            this.tabViewInfo.Name = "tabViewInfo";
            this.tabViewInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewInfo.Size = new System.Drawing.Size(727, 372);
            this.tabViewInfo.TabIndex = 1;
            this.tabViewInfo.Text = "Xem thông tin";
            this.tabViewInfo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnShowPwd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPwdConfirm);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.lbCheckPwdCF);
            this.panel1.Controls.Add(this.lbCheckNN);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.txtNickName);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(288, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 360);
            this.panel1.TabIndex = 7;
            // 
            // txtPwdConfirm
            // 
            this.txtPwdConfirm.Location = new System.Drawing.Point(4, 227);
            this.txtPwdConfirm.Name = "txtPwdConfirm";
            this.txtPwdConfirm.Size = new System.Drawing.Size(194, 22);
            this.txtPwdConfirm.TabIndex = 10;
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
            this.btnSignUp.TabIndex = 9;
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
            this.lbCheckPwdCF.TabIndex = 8;
            // 
            // lbCheckNN
            // 
            this.lbCheckNN.BackColor = System.Drawing.Color.Turquoise;
            this.lbCheckNN.Location = new System.Drawing.Point(204, 171);
            this.lbCheckNN.Name = "lbCheckNN";
            this.lbCheckNN.Size = new System.Drawing.Size(30, 22);
            this.lbCheckNN.TabIndex = 6;
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
            this.label9.Location = new System.Drawing.Point(152, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên thật";
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.rdioNameOptionalDel);
            this.tabDelete.Controls.Add(this.rdioIDOptionalDel);
            this.tabDelete.Controls.Add(this.btnSearchInfo);
            this.tabDelete.Controls.Add(this.txtSearchInfo);
            this.tabDelete.Controls.Add(this.listStaffs);
            this.tabDelete.Location = new System.Drawing.Point(4, 25);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(727, 372);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Xóa nhân viên";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Chức vụ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Số điện thoại";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tên đăng nhập";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Tên thật";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNNInfo
            // 
            this.txtNNInfo.Location = new System.Drawing.Point(295, 277);
            this.txtNNInfo.Name = "txtNNInfo";
            this.txtNNInfo.Size = new System.Drawing.Size(194, 22);
            this.txtNNInfo.TabIndex = 17;
            // 
            // txtPositionInfo
            // 
            this.txtPositionInfo.Location = new System.Drawing.Point(295, 249);
            this.txtPositionInfo.Name = "txtPositionInfo";
            this.txtPositionInfo.Size = new System.Drawing.Size(194, 22);
            this.txtPositionInfo.TabIndex = 16;
            // 
            // txtPhoneInfo
            // 
            this.txtPhoneInfo.Location = new System.Drawing.Point(295, 221);
            this.txtPhoneInfo.Name = "txtPhoneInfo";
            this.txtPhoneInfo.Size = new System.Drawing.Size(194, 22);
            this.txtPhoneInfo.TabIndex = 15;
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.Location = new System.Drawing.Point(295, 193);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.Size = new System.Drawing.Size(194, 22);
            this.txtNameInfo.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(241, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 22);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.WordWrap = false;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(441, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 22);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // rdioIDOptional
            // 
            this.rdioIDOptional.AutoSize = true;
            this.rdioIDOptional.Location = new System.Drawing.Point(241, 87);
            this.rdioIDOptional.Name = "rdioIDOptional";
            this.rdioIDOptional.Size = new System.Drawing.Size(101, 21);
            this.rdioIDOptional.TabIndex = 24;
            this.rdioIDOptional.TabStop = true;
            this.rdioIDOptional.Text = "Tìm theo ID";
            this.rdioIDOptional.UseVisualStyleBackColor = true;
            // 
            // rdioNameOptional
            // 
            this.rdioNameOptional.AutoSize = true;
            this.rdioNameOptional.Location = new System.Drawing.Point(348, 87);
            this.rdioNameOptional.Name = "rdioNameOptional";
            this.rdioNameOptional.Size = new System.Drawing.Size(113, 21);
            this.rdioNameOptional.TabIndex = 25;
            this.rdioNameOptional.TabStop = true;
            this.rdioNameOptional.Text = "Tìm theo Tên";
            this.rdioNameOptional.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(241, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 23);
            this.label14.TabIndex = 26;
            this.label14.Text = "THÔNG TIN";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listStaffs
            // 
            this.listStaffs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listStaffs.GridLines = true;
            this.listStaffs.HideSelection = false;
            this.listStaffs.Location = new System.Drawing.Point(51, 4);
            this.listStaffs.Name = "listStaffs";
            this.listStaffs.Size = new System.Drawing.Size(627, 291);
            this.listStaffs.TabIndex = 0;
            this.listStaffs.UseCompatibleStateImageBehavior = false;
            this.listStaffs.View = System.Windows.Forms.View.Details;
            // 
            // rdioNameOptionalDel
            // 
            this.rdioNameOptionalDel.AutoSize = true;
            this.rdioNameOptionalDel.Location = new System.Drawing.Point(357, 338);
            this.rdioNameOptionalDel.Name = "rdioNameOptionalDel";
            this.rdioNameOptionalDel.Size = new System.Drawing.Size(113, 21);
            this.rdioNameOptionalDel.TabIndex = 29;
            this.rdioNameOptionalDel.TabStop = true;
            this.rdioNameOptionalDel.Text = "Tìm theo Tên";
            this.rdioNameOptionalDel.UseVisualStyleBackColor = true;
            // 
            // rdioIDOptionalDel
            // 
            this.rdioIDOptionalDel.AutoSize = true;
            this.rdioIDOptionalDel.Location = new System.Drawing.Point(250, 338);
            this.rdioIDOptionalDel.Name = "rdioIDOptionalDel";
            this.rdioIDOptionalDel.Size = new System.Drawing.Size(101, 21);
            this.rdioIDOptionalDel.TabIndex = 28;
            this.rdioIDOptionalDel.TabStop = true;
            this.rdioIDOptionalDel.Text = "Tìm theo ID";
            this.rdioIDOptionalDel.UseVisualStyleBackColor = true;
            // 
            // btnSearchInfo
            // 
            this.btnSearchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchInfo.Image")));
            this.btnSearchInfo.Location = new System.Drawing.Point(450, 310);
            this.btnSearchInfo.Name = "btnSearchInfo";
            this.btnSearchInfo.Size = new System.Drawing.Size(48, 22);
            this.btnSearchInfo.TabIndex = 27;
            this.btnSearchInfo.UseVisualStyleBackColor = true;
            // 
            // txtSearchInfo
            // 
            this.txtSearchInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearchInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchInfo.Location = new System.Drawing.Point(250, 310);
            this.txtSearchInfo.Name = "txtSearchInfo";
            this.txtSearchInfo.Size = new System.Drawing.Size(194, 22);
            this.txtSearchInfo.TabIndex = 26;
            this.txtSearchInfo.WordWrap = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 198;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SĐT";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chức vụ";
            this.columnHeader4.Width = 208;
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(390, 306);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(98, 30);
            this.btnChangeInfo.TabIndex = 27;
            this.btnChangeInfo.Text = "Đổi thông tin";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(204, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowPwd
            // 
            this.btnShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPwd.ForeColor = System.Drawing.Color.White;
            this.btnShowPwd.Location = new System.Drawing.Point(240, 199);
            this.btnShowPwd.Name = "btnShowPwd";
            this.btnShowPwd.Size = new System.Drawing.Size(56, 50);
            this.btnShowPwd.TabIndex = 12;
            this.btnShowPwd.Text = "Xem MK";
            this.btnShowPwd.UseVisualStyleBackColor = true;
            this.btnShowPwd.Click += new System.EventHandler(this.btnShowPwd_Click);
            // 
            // StaffSettingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(760, 426);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffSettingForm";
            this.Text = "StaffSettingForm";
            this.tabControl1.ResumeLayout(false);
            this.tabSignUp.ResumeLayout(false);
            this.tabSignUp.PerformLayout();
            this.tabViewInfo.ResumeLayout(false);
            this.tabViewInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPwdConfirm;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lbCheckPwdCF;
        private System.Windows.Forms.Label lbCheckNN;
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
        private System.Windows.Forms.TabPage tabViewInfo;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNNInfo;
        private System.Windows.Forms.TextBox txtPositionInfo;
        private System.Windows.Forms.TextBox txtPhoneInfo;
        private System.Windows.Forms.TextBox txtNameInfo;
        private System.Windows.Forms.RadioButton rdioNameOptional;
        private System.Windows.Forms.RadioButton rdioIDOptional;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rdioNameOptionalDel;
        private System.Windows.Forms.RadioButton rdioIDOptionalDel;
        private System.Windows.Forms.Button btnSearchInfo;
        private System.Windows.Forms.TextBox txtSearchInfo;
        private System.Windows.Forms.ListView listStaffs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnShowPwd;
        private System.Windows.Forms.Label label6;
    }
}