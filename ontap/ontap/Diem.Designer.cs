namespace ontap
{
    partial class Diem
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
            this.dgdiem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbmonhoc = new System.Windows.Forms.ComboBox();
            this.cmnam = new System.Windows.Forms.ComboBox();
            this.cmmasv = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numdiem = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numky = new System.Windows.Forms.NumericUpDown();
            this.btnlammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numky)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdiem
            // 
            this.dgdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdiem.Location = new System.Drawing.Point(16, 176);
            this.dgdiem.Name = "dgdiem";
            this.dgdiem.Size = new System.Drawing.Size(723, 142);
            this.dgdiem.TabIndex = 0;
            this.dgdiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdiem_CellClick);
            this.dgdiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdiem_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm tổng kết:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm học:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.numky);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numdiem);
            this.groupBox1.Controls.Add(this.cmbmonhoc);
            this.groupBox1.Controls.Add(this.cmnam);
            this.groupBox1.Controls.Add(this.cmmasv);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(218, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(521, 122);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm thông tin điểm tổng kết cho sinh viên";
            // 
            // cmbmonhoc
            // 
            this.cmbmonhoc.FormattingEnabled = true;
            this.cmbmonhoc.Location = new System.Drawing.Point(76, 60);
            this.cmbmonhoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbmonhoc.Name = "cmbmonhoc";
            this.cmbmonhoc.Size = new System.Drawing.Size(119, 23);
            this.cmbmonhoc.TabIndex = 16;
            // 
            // cmnam
            // 
            this.cmnam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmnam.FormattingEnabled = true;
            this.cmnam.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            ""});
            this.cmnam.Location = new System.Drawing.Point(285, 62);
            this.cmnam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmnam.Name = "cmnam";
            this.cmnam.Size = new System.Drawing.Size(95, 23);
            this.cmnam.TabIndex = 15;
            // 
            // cmmasv
            // 
            this.cmmasv.FormattingEnabled = true;
            this.cmmasv.Location = new System.Drawing.Point(76, 19);
            this.cmmasv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmmasv.Name = "cmmasv";
            this.cmmasv.Size = new System.Drawing.Size(119, 23);
            this.cmmasv.TabIndex = 13;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(44, 90);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(68, 24);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(117, 90);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(68, 24);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(189, 90);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(68, 24);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh sách thông tin điểm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(187, 115);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(78, 25);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(79, 21);
            this.txttimkiem.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên lớp";
            // 
            // numdiem
            // 
            this.numdiem.Location = new System.Drawing.Point(285, 26);
            this.numdiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numdiem.Name = "numdiem";
            this.numdiem.Size = new System.Drawing.Size(93, 21);
            this.numdiem.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kỳ:";
            // 
            // numky
            // 
            this.numky.Location = new System.Drawing.Point(428, 25);
            this.numky.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numky.Name = "numky";
            this.numky.Size = new System.Drawing.Size(76, 21);
            this.numky.TabIndex = 19;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(272, 89);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(68, 24);
            this.btnlammoi.TabIndex = 20;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgdiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Diem";
            this.Text = "Diem";
            this.Load += new System.EventHandler(this.Diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.ComboBox cmnam;
        private System.Windows.Forms.ComboBox cmmasv;
        private System.Windows.Forms.ComboBox cmbmonhoc;
        private System.Windows.Forms.NumericUpDown numdiem;
        private System.Windows.Forms.NumericUpDown numky;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnlammoi;
    }
}