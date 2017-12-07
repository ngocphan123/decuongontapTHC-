namespace de5
{
    partial class LoaiPhong
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
            this.dgloaiphong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgloaiphong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgloaiphong
            // 
            this.dgloaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgloaiphong.Location = new System.Drawing.Point(150, 72);
            this.dgloaiphong.Name = "dgloaiphong";
            this.dgloaiphong.Size = new System.Drawing.Size(397, 150);
            this.dgloaiphong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách loại phòng học sắp xếp theo tên loại phòng";
            // 
            // LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgloaiphong);
            this.Name = "LoaiPhong";
            this.Text = "LoaiPhong";
            this.Load += new System.EventHandler(this.LoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgloaiphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgloaiphong;
        private System.Windows.Forms.Label label1;
    }
}