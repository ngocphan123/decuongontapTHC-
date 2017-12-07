namespace ontap
{
    partial class ThongKe
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.numnamhoc = new System.Windows.Forms.NumericUpDown();
            this.btnthongke = new System.Windows.Forms.Button();
            this.thongkediem = new ontap.thongkediem();
            this.thongkediemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DiemTableAdapter = new ontap.thongkediemTableAdapters.DiemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numnamhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkediem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkediemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm học";
            // 
            // numnamhoc
            // 
            this.numnamhoc.Location = new System.Drawing.Point(304, 13);
            this.numnamhoc.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numnamhoc.Name = "numnamhoc";
            this.numnamhoc.Size = new System.Drawing.Size(120, 20);
            this.numnamhoc.TabIndex = 2;
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(447, 10);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(75, 23);
            this.btnthongke.TabIndex = 3;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // thongkediem
            // 
            this.thongkediem.DataSetName = "thongkediem";
            this.thongkediem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongkediemBindingSource
            // 
            this.thongkediemBindingSource.DataSource = this.thongkediem;
            this.thongkediemBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DiemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ontap.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(114, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(618, 246);
            this.reportViewer1.TabIndex = 4;
            // 
            // DiemBindingSource
            // 
            this.DiemBindingSource.DataMember = "Diem";
            this.DiemBindingSource.DataSource = this.thongkediem;
            // 
            // DiemTableAdapter
            // 
            this.DiemTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 328);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.numnamhoc);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numnamhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkediem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkediemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numnamhoc;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.BindingSource thongkediemBindingSource;
        private thongkediem thongkediem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DiemBindingSource;
        private thongkediemTableAdapters.DiemTableAdapter DiemTableAdapter;
    }
}