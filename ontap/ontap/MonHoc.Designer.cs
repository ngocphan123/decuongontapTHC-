namespace ontap
{
    partial class MonHoc
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
            this.dgmonhoc = new System.Windows.Forms.DataGridView();
            this.tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgmonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục môn học";
            // 
            // dgmonhoc
            // 
            this.dgmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenmon,
            this.dvht});
            this.dgmonhoc.Location = new System.Drawing.Point(231, 61);
            this.dgmonhoc.Name = "dgmonhoc";
            this.dgmonhoc.Size = new System.Drawing.Size(444, 143);
            this.dgmonhoc.TabIndex = 1;
            // 
            // tenmon
            // 
            this.tenmon.DataPropertyName = "TenMH";
            this.tenmon.HeaderText = "Môn học";
            this.tenmon.Name = "tenmon";
            this.tenmon.Width = 200;
            // 
            // dvht
            // 
            this.dvht.DataPropertyName = "DVHT";
            this.dvht.HeaderText = "Đơn vị học trình";
            this.dvht.Name = "dvht";
            this.dvht.Width = 200;
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 361);
            this.Controls.Add(this.dgmonhoc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MonHoc";
            this.Text = "MonHoc";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgmonhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvht;
    }
}