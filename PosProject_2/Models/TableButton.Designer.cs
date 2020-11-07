namespace PosProject_2.Models
{
    partial class TableButton
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
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(3, 30);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(86, 30);
            this.lbText.TabIndex = 0;
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lbText);
            this.Name = "TableButton";
            this.Size = new System.Drawing.Size(92, 92);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbText;
    }
}
