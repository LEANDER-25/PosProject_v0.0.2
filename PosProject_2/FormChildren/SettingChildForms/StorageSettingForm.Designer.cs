namespace PosProject_2.FormChildren.SettingChildForms
{
    partial class StorageSettingForm
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
            this.btnImportGoods = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnMenuSetting = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportGoods);
            this.panel1.Controls.Add(this.btnMaterial);
            this.panel1.Controls.Add(this.btnMenuSetting);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 424);
            this.panel1.TabIndex = 0;
            // 
            // btnImportGoods
            // 
            this.btnImportGoods.Location = new System.Drawing.Point(3, 115);
            this.btnImportGoods.Name = "btnImportGoods";
            this.btnImportGoods.Size = new System.Drawing.Size(134, 50);
            this.btnImportGoods.TabIndex = 2;
            this.btnImportGoods.Text = "Nhập hàng";
            this.btnImportGoods.UseVisualStyleBackColor = true;
            this.btnImportGoods.Click += new System.EventHandler(this.btnImportGoods_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(3, 59);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(134, 50);
            this.btnMaterial.TabIndex = 1;
            this.btnMaterial.Text = "Nguyên liệu";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnMenuSetting
            // 
            this.btnMenuSetting.Location = new System.Drawing.Point(3, 3);
            this.btnMenuSetting.Name = "btnMenuSetting";
            this.btnMenuSetting.Size = new System.Drawing.Size(134, 50);
            this.btnMenuSetting.TabIndex = 0;
            this.btnMenuSetting.Text = "MENU/Sản phẩm";
            this.btnMenuSetting.UseVisualStyleBackColor = true;
            this.btnMenuSetting.Click += new System.EventHandler(this.btnMenuSetting_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(144, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 421);
            this.panel2.TabIndex = 1;
            // 
            // StorageSettingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(808, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageSettingForm";
            this.Text = "StorageSettingForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnMenuSetting;
        private System.Windows.Forms.Button btnImportGoods;
        private System.Windows.Forms.Panel panel2;
    }
}