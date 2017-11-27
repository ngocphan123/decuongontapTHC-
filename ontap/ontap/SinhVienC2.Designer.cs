namespace ontap
{
    partial class SinhVienC2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.monhocMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.diemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monhocMenu,
            this.diemMenu,
            this.thongkeMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // monhocMenu
            // 
            this.monhocMenu.Name = "monhocMenu";
            this.monhocMenu.Size = new System.Drawing.Size(67, 20);
            this.monhocMenu.Text = "Môn học";
            this.monhocMenu.Click += new System.EventHandler(this.monhocMenu_Click);
            // 
            // diemMenu
            // 
            this.diemMenu.Name = "diemMenu";
            this.diemMenu.Size = new System.Drawing.Size(47, 20);
            this.diemMenu.Text = "Điểm";
            this.diemMenu.Click += new System.EventHandler(this.diemMenu_Click);
            // 
            // thongkeMenu
            // 
            this.thongkeMenu.Name = "thongkeMenu";
            this.thongkeMenu.Size = new System.Drawing.Size(69, 20);
            this.thongkeMenu.Text = "Thống kê";
            this.thongkeMenu.Click += new System.EventHandler(this.thongkeMenu_Click);
            // 
            // SinhVienC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 333);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SinhVienC2";
            this.Text = "SinhVienC2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem monhocMenu;
        private System.Windows.Forms.ToolStripMenuItem diemMenu;
        private System.Windows.Forms.ToolStripMenuItem thongkeMenu;
    }
}