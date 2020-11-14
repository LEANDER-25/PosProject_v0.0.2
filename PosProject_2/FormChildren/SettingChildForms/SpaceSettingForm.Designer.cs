namespace PosProject_2.FormChildren.SettingChildForms
{
    partial class SpaceSettingForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chckChangeTableName = new System.Windows.Forms.CheckBox();
            this.txtNewTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAreaExist = new System.Windows.Forms.TextBox();
            this.btnUpdateTableName = new System.Windows.Forms.Button();
            this.btnDelTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckChangeAreaName = new System.Windows.Forms.CheckBox();
            this.txtNewAreaName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateAreaName = new System.Windows.Forms.Button();
            this.btnDelArea = new System.Windows.Forms.Button();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(143)))), ((int)(((byte)(20)))));
            this.groupBox2.Controls.Add(this.chckChangeTableName);
            this.groupBox2.Controls.Add(this.txtNewTableName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAreaExist);
            this.groupBox2.Controls.Add(this.btnUpdateTableName);
            this.groupBox2.Controls.Add(this.btnDelTable);
            this.groupBox2.Controls.Add(this.btnAddTable);
            this.groupBox2.Controls.Add(this.txtTable);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 198);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bàn";
            // 
            // chckChangeTableName
            // 
            this.chckChangeTableName.AutoSize = true;
            this.chckChangeTableName.ForeColor = System.Drawing.Color.White;
            this.chckChangeTableName.Location = new System.Drawing.Point(510, 78);
            this.chckChangeTableName.Name = "chckChangeTableName";
            this.chckChangeTableName.Size = new System.Drawing.Size(75, 21);
            this.chckChangeTableName.TabIndex = 17;
            this.chckChangeTableName.Text = "Đổi tên";
            this.chckChangeTableName.UseVisualStyleBackColor = true;
            this.chckChangeTableName.CheckStateChanged += new System.EventHandler(this.chckChangeTableName_CheckStateChanged);
            // 
            // txtNewTableName
            // 
            this.txtNewTableName.Location = new System.Drawing.Point(282, 104);
            this.txtNewTableName.Name = "txtNewTableName";
            this.txtNewTableName.Size = new System.Drawing.Size(222, 22);
            this.txtNewTableName.TabIndex = 7;
            this.txtNewTableName.Text = "Nhập tên mới";
            this.txtNewTableName.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(190, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên khu vực";
            // 
            // txtAreaExist
            // 
            this.txtAreaExist.Location = new System.Drawing.Point(282, 48);
            this.txtAreaExist.Name = "txtAreaExist";
            this.txtAreaExist.Size = new System.Drawing.Size(222, 22);
            this.txtAreaExist.TabIndex = 5;
            // 
            // btnUpdateTableName
            // 
            this.btnUpdateTableName.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdateTableName.FlatAppearance.BorderSize = 0;
            this.btnUpdateTableName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTableName.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTableName.Location = new System.Drawing.Point(434, 132);
            this.btnUpdateTableName.Name = "btnUpdateTableName";
            this.btnUpdateTableName.Size = new System.Drawing.Size(70, 30);
            this.btnUpdateTableName.TabIndex = 10;
            this.btnUpdateTableName.Text = "Đổi tên";
            this.btnUpdateTableName.UseVisualStyleBackColor = false;
            this.btnUpdateTableName.Visible = false;
            this.btnUpdateTableName.Click += new System.EventHandler(this.btnUpdateTableName_Click);
            // 
            // btnDelTable
            // 
            this.btnDelTable.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDelTable.FlatAppearance.BorderSize = 0;
            this.btnDelTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTable.ForeColor = System.Drawing.Color.White;
            this.btnDelTable.Location = new System.Drawing.Point(358, 132);
            this.btnDelTable.Name = "btnDelTable";
            this.btnDelTable.Size = new System.Drawing.Size(70, 30);
            this.btnDelTable.TabIndex = 9;
            this.btnDelTable.Text = "Xóa";
            this.btnDelTable.UseVisualStyleBackColor = false;
            this.btnDelTable.Click += new System.EventHandler(this.btnDelTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.Orange;
            this.btnAddTable.FlatAppearance.BorderSize = 0;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.Location = new System.Drawing.Point(282, 132);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(70, 30);
            this.btnAddTable.TabIndex = 8;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(282, 76);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(222, 22);
            this.txtTable.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(212)))), ((int)(((byte)(121)))));
            this.groupBox1.Controls.Add(this.chckChangeAreaName);
            this.groupBox1.Controls.Add(this.txtNewAreaName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnUpdateAreaName);
            this.groupBox1.Controls.Add(this.btnDelArea);
            this.groupBox1.Controls.Add(this.btnAddArea);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 198);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu vực";
            // 
            // chckChangeAreaName
            // 
            this.chckChangeAreaName.AutoSize = true;
            this.chckChangeAreaName.Location = new System.Drawing.Point(510, 60);
            this.chckChangeAreaName.Name = "chckChangeAreaName";
            this.chckChangeAreaName.Size = new System.Drawing.Size(75, 21);
            this.chckChangeAreaName.TabIndex = 15;
            this.chckChangeAreaName.Text = "Đổi tên";
            this.chckChangeAreaName.UseVisualStyleBackColor = true;
            this.chckChangeAreaName.CheckStateChanged += new System.EventHandler(this.chckChangeAreaName_CheckStateChanged);
            // 
            // txtNewAreaName
            // 
            this.txtNewAreaName.Location = new System.Drawing.Point(282, 87);
            this.txtNewAreaName.Name = "txtNewAreaName";
            this.txtNewAreaName.Size = new System.Drawing.Size(222, 22);
            this.txtNewAreaName.TabIndex = 1;
            this.txtNewAreaName.Text = "Nhập tên mới";
            this.txtNewAreaName.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tên khu vực";
            // 
            // btnUpdateAreaName
            // 
            this.btnUpdateAreaName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAreaName.ForeColor = System.Drawing.Color.Chocolate;
            this.btnUpdateAreaName.Location = new System.Drawing.Point(434, 115);
            this.btnUpdateAreaName.Name = "btnUpdateAreaName";
            this.btnUpdateAreaName.Size = new System.Drawing.Size(70, 30);
            this.btnUpdateAreaName.TabIndex = 4;
            this.btnUpdateAreaName.Text = "Đổi tên";
            this.btnUpdateAreaName.UseVisualStyleBackColor = true;
            this.btnUpdateAreaName.Visible = false;
            this.btnUpdateAreaName.Click += new System.EventHandler(this.btnUpdateArea_Click);
            // 
            // btnDelArea
            // 
            this.btnDelArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelArea.ForeColor = System.Drawing.Color.Red;
            this.btnDelArea.Location = new System.Drawing.Point(358, 115);
            this.btnDelArea.Name = "btnDelArea";
            this.btnDelArea.Size = new System.Drawing.Size(70, 30);
            this.btnDelArea.TabIndex = 3;
            this.btnDelArea.Text = "Xóa";
            this.btnDelArea.UseVisualStyleBackColor = true;
            this.btnDelArea.Click += new System.EventHandler(this.btnDelArea_Click);
            // 
            // btnAddArea
            // 
            this.btnAddArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.btnAddArea.Location = new System.Drawing.Point(282, 115);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(70, 30);
            this.btnAddArea.TabIndex = 2;
            this.btnAddArea.Text = "Thêm";
            this.btnAddArea.UseVisualStyleBackColor = true;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(282, 58);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(222, 22);
            this.txtArea.TabIndex = 0;
            // 
            // SpaceSettingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(808, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpaceSettingForm";
            this.Text = "SpaceSettingForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAreaExist;
        private System.Windows.Forms.Button btnUpdateTableName;
        private System.Windows.Forms.Button btnDelTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateAreaName;
        private System.Windows.Forms.Button btnDelArea;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.CheckBox chckChangeAreaName;
        private System.Windows.Forms.TextBox txtNewAreaName;
        private System.Windows.Forms.CheckBox chckChangeTableName;
        private System.Windows.Forms.TextBox txtNewTableName;
    }
}