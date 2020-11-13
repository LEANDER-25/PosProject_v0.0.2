namespace PosProject_2.Models
{
    partial class AreaButton
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
            this.lbAreaName = new System.Windows.Forms.Label();
            this.lbNotice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAreaName
            // 
            this.lbAreaName.AutoSize = true;
            this.lbAreaName.BackColor = System.Drawing.Color.Transparent;
            this.lbAreaName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAreaName.Location = new System.Drawing.Point(3, 17);
            this.lbAreaName.Name = "lbAreaName";
            this.lbAreaName.Size = new System.Drawing.Size(53, 20);
            this.lbAreaName.TabIndex = 0;
            this.lbAreaName.Text = "label1";
            this.lbAreaName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.ForeColor = System.Drawing.Color.Transparent;
            this.lbNotice.Location = new System.Drawing.Point(131, 0);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(0, 17);
            this.lbNotice.TabIndex = 1;
            // 
            // AreaButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.lbAreaName);
            this.Name = "AreaButton";
            this.Size = new System.Drawing.Size(150, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAreaName;
        private System.Windows.Forms.Label lbNotice;
    }
}
