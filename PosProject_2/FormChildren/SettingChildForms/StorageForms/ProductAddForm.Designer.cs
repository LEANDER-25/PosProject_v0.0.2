namespace PosProject_2.FormChildren.SettingChildForms.StorageForms
{
    partial class ProductAddForm
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
            this.cbbTypeProd = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNameProd = new System.Windows.Forms.TextBox();
            this.txtPriceProd = new System.Windows.Forms.TextBox();
            this.txtUnitProd = new System.Windows.Forms.TextBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbTypeProd);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.txtNameProd);
            this.panel1.Controls.Add(this.txtPriceProd);
            this.panel1.Controls.Add(this.txtUnitProd);
            this.panel1.Location = new System.Drawing.Point(179, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 375);
            this.panel1.TabIndex = 21;
            // 
            // cbbTypeProd
            // 
            this.cbbTypeProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTypeProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbTypeProd.FormattingEnabled = true;
            this.cbbTypeProd.Location = new System.Drawing.Point(8, 91);
            this.cbbTypeProd.Name = "cbbTypeProd";
            this.cbbTypeProd.Size = new System.Drawing.Size(150, 24);
            this.cbbTypeProd.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(164, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 368);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // txtNameProd
            // 
            this.txtNameProd.Location = new System.Drawing.Point(8, 7);
            this.txtNameProd.Name = "txtNameProd";
            this.txtNameProd.Size = new System.Drawing.Size(150, 22);
            this.txtNameProd.TabIndex = 0;
            // 
            // txtPriceProd
            // 
            this.txtPriceProd.ForeColor = System.Drawing.Color.Black;
            this.txtPriceProd.Location = new System.Drawing.Point(8, 35);
            this.txtPriceProd.Name = "txtPriceProd";
            this.txtPriceProd.Size = new System.Drawing.Size(150, 22);
            this.txtPriceProd.TabIndex = 1;
            this.txtPriceProd.TextChanged += new System.EventHandler(this.txtPriceProd_TextChanged);
            // 
            // txtUnitProd
            // 
            this.txtUnitProd.ForeColor = System.Drawing.Color.Black;
            this.txtUnitProd.Location = new System.Drawing.Point(8, 63);
            this.txtUnitProd.Name = "txtUnitProd";
            this.txtUnitProd.Size = new System.Drawing.Size(150, 22);
            this.txtUnitProd.TabIndex = 2;
            this.txtUnitProd.TextChanged += new System.EventHandler(this.txtUnitProd_TextChanged);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(73, 348);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(100, 66);
            this.btnAddProd.TabIndex = 20;
            this.btnAddProd.Text = "Thêm";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Đơn vị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giá bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên sản phẩm";
            // 
            // ProductAddForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductAddForm";
            this.ShowIcon = false;
            this.Text = "ProductAddForm";
            this.Load += new System.EventHandler(this.ProductOptionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbTypeProd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtNameProd;
        private System.Windows.Forms.TextBox txtPriceProd;
        private System.Windows.Forms.TextBox txtUnitProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}