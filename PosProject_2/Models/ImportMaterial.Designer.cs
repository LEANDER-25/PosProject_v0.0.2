namespace PosProject_2.Models
{
    partial class ImportMaterial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chckName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(141, 6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(82, 22);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(229, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 22);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // chckName
            // 
            this.chckName.AutoSize = true;
            this.chckName.Location = new System.Drawing.Point(3, 8);
            this.chckName.Name = "chckName";
            this.chckName.Size = new System.Drawing.Size(98, 21);
            this.chckName.TabIndex = 0;
            this.chckName.Text = "checkBox1";
            this.chckName.UseVisualStyleBackColor = true;
            // 
            // ImportMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.chckName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAmount);
            this.Name = "ImportMaterial";
            this.Size = new System.Drawing.Size(342, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox chckName;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.TextBox txtPrice;
    }
}
