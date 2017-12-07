namespace thuchanhtrenlop
{
    partial class Loainhanvien
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
            this.dgvloainv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloainv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvloainv
            // 
            this.dgvloainv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloainv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiNV,
            this.TenLoaiNV});
            this.dgvloainv.Location = new System.Drawing.Point(184, 52);
            this.dgvloainv.Name = "dgvloainv";
            this.dgvloainv.Size = new System.Drawing.Size(356, 150);
            this.dgvloainv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại nhân viên";
            // 
            // MaLoaiNV
            // 
            this.MaLoaiNV.DataPropertyName = "MaLoaiNV";
            this.MaLoaiNV.HeaderText = "Mã loại nhân viên";
            this.MaLoaiNV.Name = "MaLoaiNV";
            this.MaLoaiNV.Width = 150;
            // 
            // TenLoaiNV
            // 
            this.TenLoaiNV.DataPropertyName = "TenLoaiNV";
            this.TenLoaiNV.HeaderText = "Tên Loại Nhân viên";
            this.TenLoaiNV.Name = "TenLoaiNV";
            this.TenLoaiNV.Width = 150;
            // 
            // Loainhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvloainv);
            this.Name = "Loainhanvien";
            this.Text = "Loainhanvien";
            this.Load += new System.EventHandler(this.Loainhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloainv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvloainv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiNV;
    }
}