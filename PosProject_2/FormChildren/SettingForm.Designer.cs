namespace PosProject_2.FormChildren
{
    partial class SettingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStorageSetting = new System.Windows.Forms.Button();
            this.btnStaffSetting = new System.Windows.Forms.Button();
            this.btnSpaceSetting = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnStorageSetting);
            this.panel1.Controls.Add(this.btnStaffSetting);
            this.panel1.Controls.Add(this.btnSpaceSetting);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnStorageSetting
            // 
            this.btnStorageSetting.FlatAppearance.BorderSize = 0;
            this.btnStorageSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStorageSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorageSetting.ForeColor = System.Drawing.Color.White;
            this.btnStorageSetting.Location = new System.Drawing.Point(3, 126);
            this.btnStorageSetting.Name = "btnStorageSetting";
            this.btnStorageSetting.Size = new System.Drawing.Size(144, 52);
            this.btnStorageSetting.TabIndex = 2;
            this.btnStorageSetting.Text = "Kho, nguyên liệu";
            this.btnStorageSetting.UseVisualStyleBackColor = true;
            this.btnStorageSetting.Click += new System.EventHandler(this.btnStorageSetting_Click);
            // 
            // btnStaffSetting
            // 
            this.btnStaffSetting.FlatAppearance.BorderSize = 0;
            this.btnStaffSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStaffSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffSetting.ForeColor = System.Drawing.Color.White;
            this.btnStaffSetting.Location = new System.Drawing.Point(3, 68);
            this.btnStaffSetting.Name = "btnStaffSetting";
            this.btnStaffSetting.Size = new System.Drawing.Size(144, 52);
            this.btnStaffSetting.TabIndex = 1;
            this.btnStaffSetting.Text = "Nhân viên";
            this.btnStaffSetting.UseVisualStyleBackColor = true;
            this.btnStaffSetting.Click += new System.EventHandler(this.btnStaffSetting_Click);
            // 
            // btnSpaceSetting
            // 
            this.btnSpaceSetting.FlatAppearance.BorderSize = 0;
            this.btnSpaceSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSpaceSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpaceSetting.ForeColor = System.Drawing.Color.White;
            this.btnSpaceSetting.Location = new System.Drawing.Point(3, 10);
            this.btnSpaceSetting.Name = "btnSpaceSetting";
            this.btnSpaceSetting.Size = new System.Drawing.Size(144, 52);
            this.btnSpaceSetting.TabIndex = 0;
            this.btnSpaceSetting.Text = "Không gian";
            this.btnSpaceSetting.UseVisualStyleBackColor = true;
            this.btnSpaceSetting.Click += new System.EventHandler(this.btnSpaceSetting_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(159, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(808, 426);
            this.panelChildForm.TabIndex = 1;
            // 
            // SettingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(970, 430);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStaffSetting;
        private System.Windows.Forms.Button btnSpaceSetting;
        private System.Windows.Forms.Button btnStorageSetting;
        private System.Windows.Forms.Panel panelChildForm;
    }
}