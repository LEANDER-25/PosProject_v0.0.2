namespace PosProject_2.FormChildren.SettingChildForms.StorageForms
{
    partial class MenuSettingForm
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rdioNameFilter = new System.Windows.Forms.RadioButton();
            this.btnOpenAddForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFilter.Location = new System.Drawing.Point(132, 352);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(180, 22);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 348);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listProduct
            // 
            this.listProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listProduct.FullRowSelect = true;
            this.listProduct.GridLines = true;
            this.listProduct.HideSelection = false;
            this.listProduct.Location = new System.Drawing.Point(9, 18);
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(643, 324);
            this.listProduct.TabIndex = 12;
            this.listProduct.UseCompatibleStateImageBehavior = false;
            this.listProduct.View = System.Windows.Forms.View.Details;
            this.listProduct.DoubleClick += new System.EventHandler(this.listProduct_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 269;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá bán";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn vị";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại";
            this.columnHeader5.Width = 139;
            // 
            // rdioNameFilter
            // 
            this.rdioNameFilter.AutoSize = true;
            this.rdioNameFilter.Checked = true;
            this.rdioNameFilter.Location = new System.Drawing.Point(318, 353);
            this.rdioNameFilter.Name = "rdioNameFilter";
            this.rdioNameFilter.Size = new System.Drawing.Size(86, 21);
            this.rdioNameFilter.TabIndex = 16;
            this.rdioNameFilter.TabStop = true;
            this.rdioNameFilter.Text = "Theo tên";
            this.rdioNameFilter.UseVisualStyleBackColor = true;
            this.rdioNameFilter.CheckedChanged += new System.EventHandler(this.rdioNameFilter_CheckedChanged);
            // 
            // btnOpenAddForm
            // 
            this.btnOpenAddForm.Location = new System.Drawing.Point(410, 348);
            this.btnOpenAddForm.Name = "btnOpenAddForm";
            this.btnOpenAddForm.Size = new System.Drawing.Size(89, 30);
            this.btnOpenAddForm.TabIndex = 17;
            this.btnOpenAddForm.Text = "Thêm";
            this.btnOpenAddForm.UseVisualStyleBackColor = true;
            this.btnOpenAddForm.Click += new System.EventHandler(this.btnOpenAddForm_Click);
            // 
            // MenuSettingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(660, 421);
            this.Controls.Add(this.btnOpenAddForm);
            this.Controls.Add(this.rdioNameFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSettingForm";
            this.Text = "MenuSettingForm";
            this.Activated += new System.EventHandler(this.MenuSettingForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView listProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.RadioButton rdioNameFilter;
        private System.Windows.Forms.Button btnOpenAddForm;
    }
}