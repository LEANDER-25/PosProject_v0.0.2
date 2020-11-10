namespace PosProject_2
{
    partial class HomeForm
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
            this.btnMinimum = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelChildFormShow = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbStaffPosition = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.panelAreas = new System.Windows.Forms.Panel();
            this.flowAreas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelChildFormShow.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnMinimum);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimum
            // 
            this.btnMinimum.FlatAppearance.BorderSize = 0;
            this.btnMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimum.ForeColor = System.Drawing.Color.Lime;
            this.btnMinimum.Location = new System.Drawing.Point(908, 4);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(31, 29);
            this.btnMinimum.TabIndex = 2;
            this.btnMinimum.Text = "O";
            this.btnMinimum.UseVisualStyleBackColor = true;
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimum_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(945, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "O";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelChildFormShow
            // 
            this.panelChildFormShow.Controls.Add(this.panel3);
            this.panelChildFormShow.Controls.Add(this.panelAreas);
            this.panelChildFormShow.Controls.Add(this.flowAreas);
            this.panelChildFormShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormShow.Location = new System.Drawing.Point(0, 39);
            this.panelChildFormShow.Name = "panelChildFormShow";
            this.panelChildFormShow.Size = new System.Drawing.Size(980, 661);
            this.panelChildFormShow.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbStaffPosition);
            this.panel3.Controls.Add(this.lbCurrentTime);
            this.panel3.Controls.Add(this.lbStaffName);
            this.panel3.Location = new System.Drawing.Point(5, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 89);
            this.panel3.TabIndex = 2;
            // 
            // lbStaffPosition
            // 
            this.lbStaffPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffPosition.Location = new System.Drawing.Point(13, 47);
            this.lbStaffPosition.Name = "lbStaffPosition";
            this.lbStaffPosition.Size = new System.Drawing.Size(294, 28);
            this.lbStaffPosition.TabIndex = 6;
            this.lbStaffPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTime.Location = new System.Drawing.Point(788, 14);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(174, 61);
            this.lbCurrentTime.TabIndex = 5;
            this.lbCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStaffName
            // 
            this.lbStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffName.Location = new System.Drawing.Point(13, 14);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(294, 28);
            this.lbStaffName.TabIndex = 4;
            this.lbStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAreas
            // 
            this.panelAreas.Location = new System.Drawing.Point(5, 164);
            this.panelAreas.Name = "panelAreas";
            this.panelAreas.Size = new System.Drawing.Size(972, 430);
            this.panelAreas.TabIndex = 1;
            // 
            // flowAreas
            // 
            this.flowAreas.AutoScroll = true;
            this.flowAreas.Location = new System.Drawing.Point(12, 101);
            this.flowAreas.Name = "flowAreas";
            this.flowAreas.Size = new System.Drawing.Size(956, 57);
            this.flowAreas.TabIndex = 0;
            this.flowAreas.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnRevenue);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 64);
            this.panel2.TabIndex = 3;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Orchid;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(4, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(137, 58);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Cài đặt (Quản lý)";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.DeepPink;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.Location = new System.Drawing.Point(718, 3);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(123, 58);
            this.btnRevenue.TabIndex = 1;
            this.btnRevenue.Text = "Xem Doanh thu";
            this.btnRevenue.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.HotPink;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(847, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(123, 58);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(980, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChildFormShow);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.HomeForm_Activated);
            this.panel1.ResumeLayout(false);
            this.panelChildFormShow.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildFormShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelAreas;
        private System.Windows.Forms.FlowLayoutPanel flowAreas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbStaffPosition;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.Button btnMinimum;
        private System.Windows.Forms.Button btnExit;
    }
}