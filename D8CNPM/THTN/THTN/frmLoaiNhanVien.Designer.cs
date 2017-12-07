namespace THTN
{
    partial class frmLoaiNhanVien
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
            this.dgvLoaiNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiNhanVien
            // 
            this.dgvLoaiNhanVien.AllowUserToAddRows = false;
            this.dgvLoaiNhanVien.AllowUserToDeleteRows = false;
            this.dgvLoaiNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiNV,
            this.TenLoaiNV});
            this.dgvLoaiNhanVien.Location = new System.Drawing.Point(12, 61);
            this.dgvLoaiNhanVien.Name = "dgvLoaiNhanVien";
            this.dgvLoaiNhanVien.ReadOnly = true;
            this.dgvLoaiNhanVien.Size = new System.Drawing.Size(511, 275);
            this.dgvLoaiNhanVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Nhân Viên";
            // 
            // MaLoaiNV
            // 
            this.MaLoaiNV.DataPropertyName = "MaLoaiNV";
            this.MaLoaiNV.HeaderText = "Mã Loại Nhân Viên";
            this.MaLoaiNV.Name = "MaLoaiNV";
            this.MaLoaiNV.ReadOnly = true;
            this.MaLoaiNV.Width = 200;
            // 
            // TenLoaiNV
            // 
            this.TenLoaiNV.DataPropertyName = "TenLoaiNV";
            this.TenLoaiNV.HeaderText = "Tên Loại Nhân Viên";
            this.TenLoaiNV.Name = "TenLoaiNV";
            this.TenLoaiNV.ReadOnly = true;
            this.TenLoaiNV.Width = 200;
            // 
            // frmLoaiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLoaiNhanVien);
            this.Name = "frmLoaiNhanVien";
            this.Text = "frmLoaiNhanVien";
            this.Load += new System.EventHandler(this.frmLoaiNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiNV;
    }
}