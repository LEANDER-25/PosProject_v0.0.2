namespace PosProject_2.FormChildren
{
    partial class TablesForm
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
            this.flowTables = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowTables
            // 
            this.flowTables.Location = new System.Drawing.Point(13, 13);
            this.flowTables.Name = "flowTables";
            this.flowTables.Size = new System.Drawing.Size(945, 405);
            this.flowTables.TabIndex = 0;
            // 
            // TablesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(970, 430);
            this.Controls.Add(this.flowTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TablesForm";
            this.Activated += new System.EventHandler(this.TablesForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowTables;
    }
}