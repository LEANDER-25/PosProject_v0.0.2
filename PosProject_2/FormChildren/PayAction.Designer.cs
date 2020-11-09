namespace PosProject_2.FormChildren
{
    partial class PayAction
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTableName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalCash = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listOrderdItems = new System.Windows.Forms.ListView();
            this.headerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 443);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTableName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbStaffName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbTotalCash);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 61);
            this.panel1.TabIndex = 0;
            // 
            // lbTableName
            // 
            this.lbTableName.BackColor = System.Drawing.Color.Aquamarine;
            this.lbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableName.ForeColor = System.Drawing.Color.Salmon;
            this.lbTableName.Location = new System.Drawing.Point(356, 15);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(75, 29);
            this.lbTableName.TabIndex = 5;
            this.lbTableName.Text = "label6";
            this.lbTableName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label5.Location = new System.Drawing.Point(298, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bàn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStaffName
            // 
            this.lbStaffName.BackColor = System.Drawing.Color.Transparent;
            this.lbStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffName.ForeColor = System.Drawing.Color.White;
            this.lbStaffName.Location = new System.Drawing.Point(100, 15);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(192, 29);
            this.lbStaffName.TabIndex = 3;
            this.lbStaffName.Text = "label4";
            this.lbStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(481, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng số tiền";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalCash
            // 
            this.lbTotalCash.BackColor = System.Drawing.Color.Wheat;
            this.lbTotalCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCash.Location = new System.Drawing.Point(617, 15);
            this.lbTotalCash.Name = "lbTotalCash";
            this.lbTotalCash.Size = new System.Drawing.Size(130, 29);
            this.lbTotalCash.TabIndex = 0;
            this.lbTotalCash.Text = "label1";
            this.lbTotalCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Location = new System.Drawing.Point(295, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 29);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.listOrderdItems);
            this.panel2.Location = new System.Drawing.Point(294, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 370);
            this.panel2.TabIndex = 1;
            // 
            // listOrderdItems
            // 
            this.listOrderdItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerID,
            this.headerName,
            this.headerAmount,
            this.headerPrice});
            this.listOrderdItems.FullRowSelect = true;
            this.listOrderdItems.GridLines = true;
            this.listOrderdItems.HideSelection = false;
            this.listOrderdItems.Location = new System.Drawing.Point(4, 4);
            this.listOrderdItems.Name = "listOrderdItems";
            this.listOrderdItems.Size = new System.Drawing.Size(313, 363);
            this.listOrderdItems.TabIndex = 0;
            this.listOrderdItems.UseCompatibleStateImageBehavior = false;
            this.listOrderdItems.View = System.Windows.Forms.View.Details;
            // 
            // headerID
            // 
            this.headerID.Text = "STT";
            this.headerID.Width = 40;
            // 
            // headerName
            // 
            this.headerName.Text = "Tên SP";
            this.headerName.Width = 120;
            // 
            // headerAmount
            // 
            this.headerAmount.Text = "Số lượng";
            this.headerAmount.Width = 50;
            // 
            // headerPrice
            // 
            this.headerPrice.Text = "Thành tiền";
            this.headerPrice.Width = 98;
            // 
            // PayAction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(933, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayAction";
            this.Text = "PayAction";
            this.Activated += new System.EventHandler(this.PayAction_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalCash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listOrderdItems;
        private System.Windows.Forms.ColumnHeader headerID;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerAmount;
        private System.Windows.Forms.ColumnHeader headerPrice;
        private System.Windows.Forms.Panel panel3;
    }
}