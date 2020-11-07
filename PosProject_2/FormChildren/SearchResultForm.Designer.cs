namespace PosProject_2.FormChildren
{
    partial class SearchResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.listSResult = new System.Windows.Forms.ListView();
            this.headerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết quả tìm kiếm";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Red;
            this.btnCloseForm.Location = new System.Drawing.Point(487, 2);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(28, 28);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "O";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // listSResult
            // 
            this.listSResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerID,
            this.headerName,
            this.headerPrice});
            this.listSResult.FullRowSelect = true;
            this.listSResult.GridLines = true;
            this.listSResult.HideSelection = false;
            this.listSResult.Location = new System.Drawing.Point(3, 37);
            this.listSResult.MultiSelect = false;
            this.listSResult.Name = "listSResult";
            this.listSResult.Size = new System.Drawing.Size(512, 278);
            this.listSResult.TabIndex = 2;
            this.listSResult.UseCompatibleStateImageBehavior = false;
            this.listSResult.View = System.Windows.Forms.View.Details;
            // 
            // headerID
            // 
            this.headerID.Text = "ID";
            this.headerID.Width = 50;
            // 
            // headerName
            // 
            this.headerName.Text = "Tên sản phẩm";
            this.headerName.Width = 350;
            // 
            // headerPrice
            // 
            this.headerPrice.Text = "Giá tiền";
            this.headerPrice.Width = 108;
            // 
            // SearchResultForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(517, 318);
            this.Controls.Add(this.listSResult);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchResultForm";
            this.Text = "SearchResultForm";
            this.Activated += new System.EventHandler(this.SearchResultForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.ColumnHeader headerID;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerPrice;
        public System.Windows.Forms.ListView listSResult;
    }
}