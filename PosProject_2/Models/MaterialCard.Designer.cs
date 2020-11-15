namespace PosProject_2.Models
{
    partial class MaterialCard
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
            this.txtNumberMate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMateName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNumberMate
            // 
            this.txtNumberMate.Location = new System.Drawing.Point(184, 3);
            this.txtNumberMate.Name = "txtNumberMate";
            this.txtNumberMate.Size = new System.Drawing.Size(93, 22);
            this.txtNumberMate.TabIndex = 0;
            this.txtNumberMate.TextChanged += new System.EventHandler(this.txtNumberMate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "/sản phẩm";
            // 
            // checkMateName
            // 
            this.checkMateName.AutoSize = true;
            this.checkMateName.Location = new System.Drawing.Point(3, 5);
            this.checkMateName.Name = "checkMateName";
            this.checkMateName.Size = new System.Drawing.Size(98, 21);
            this.checkMateName.TabIndex = 4;
            this.checkMateName.Text = "checkBox1";
            this.checkMateName.UseVisualStyleBackColor = true;
            // 
            // MaterialCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.checkMateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberMate);
            this.Name = "MaterialCard";
            this.Size = new System.Drawing.Size(360, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkMateName;
        public System.Windows.Forms.TextBox txtNumberMate;
    }
}
