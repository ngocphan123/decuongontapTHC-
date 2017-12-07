namespace de5
{
    partial class PhongMay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgphongmay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.txtdiadiem = new System.Windows.Forms.TextBox();
            this.numsomay = new System.Windows.Forms.NumericUpDown();
            this.cmbtinhtrang = new System.Windows.Forms.ComboBox();
            this.cmbloaiphong = new System.Windows.Forms.ComboBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgphongmay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsomay)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dgphongmay);
            this.groupBox1.Location = new System.Drawing.Point(268, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbloaiphong);
            this.groupBox2.Controls.Add(this.cmbtinhtrang);
            this.groupBox2.Controls.Add(this.numsomay);
            this.groupBox2.Controls.Add(this.txtdiadiem);
            this.groupBox2.Controls.Add(this.txttenphong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtmaphong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(-4, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thay đổi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Controls.Add(this.btnlammoi);
            this.groupBox3.Location = new System.Drawing.Point(-4, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Công cụ";
            // 
            // dgphongmay
            // 
            this.dgphongmay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgphongmay.Location = new System.Drawing.Point(0, 94);
            this.dgphongmay.Name = "dgphongmay";
            this.dgphongmay.Size = new System.Drawing.Size(557, 172);
            this.dgphongmay.TabIndex = 0;
            this.dgphongmay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgphongmay_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(59, 27);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(158, 20);
            this.txttimkiem.TabIndex = 2;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(235, 27);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 3;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phòng máy";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(105, 24);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(152, 20);
            this.txtmaphong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên phòng máy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng máy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tình trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Loại phòng";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(105, 60);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(152, 20);
            this.txttenphong.TabIndex = 9;
            // 
            // txtdiadiem
            // 
            this.txtdiadiem.Location = new System.Drawing.Point(105, 124);
            this.txtdiadiem.Name = "txtdiadiem";
            this.txtdiadiem.Size = new System.Drawing.Size(152, 20);
            this.txtdiadiem.TabIndex = 10;
            // 
            // numsomay
            // 
            this.numsomay.Location = new System.Drawing.Point(105, 92);
            this.numsomay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numsomay.Name = "numsomay";
            this.numsomay.Size = new System.Drawing.Size(152, 20);
            this.numsomay.TabIndex = 11;
            // 
            // cmbtinhtrang
            // 
            this.cmbtinhtrang.FormattingEnabled = true;
            this.cmbtinhtrang.Items.AddRange(new object[] {
            "Còn sử dụng",
            "Đang sửa chữa",
            "Đang hỏng"});
            this.cmbtinhtrang.Location = new System.Drawing.Point(105, 154);
            this.cmbtinhtrang.Name = "cmbtinhtrang";
            this.cmbtinhtrang.Size = new System.Drawing.Size(152, 21);
            this.cmbtinhtrang.TabIndex = 12;
            // 
            // cmbloaiphong
            // 
            this.cmbloaiphong.FormattingEnabled = true;
            this.cmbloaiphong.Location = new System.Drawing.Point(105, 189);
            this.cmbloaiphong.Name = "cmbloaiphong";
            this.cmbloaiphong.Size = new System.Drawing.Size(152, 21);
            this.cmbloaiphong.TabIndex = 13;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(60, 36);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 23);
            this.btnlammoi.TabIndex = 4;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(182, 36);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(297, 36);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(408, 36);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btntimkiem);
            this.groupBox4.Controls.Add(this.txttimkiem);
            this.groupBox4.Location = new System.Drawing.Point(90, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 73);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm theo loại phòng";
            // 
            // PhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 350);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhongMay";
            this.Text = "PhongMay";
            this.Load += new System.EventHandler(this.PhongMay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgphongmay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsomay)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgphongmay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbloaiphong;
        private System.Windows.Forms.ComboBox cmbtinhtrang;
        private System.Windows.Forms.NumericUpDown numsomay;
        private System.Windows.Forms.TextBox txtdiadiem;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}