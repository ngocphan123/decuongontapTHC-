namespace de5
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.btnthongke = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dslich = new de5.dslich();
            this.LichDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LichDangKyTableAdapter = new de5.dslichTableAdapters.LichDangKyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dslich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LichDangKyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(227, 20);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(112, 20);
            this.txtnam.TabIndex = 1;
            this.txtnam.Text = "2016";
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(366, 16);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(75, 23);
            this.btnthongke.TabIndex = 2;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.LichDangKyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "de5.rplich.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(45, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(631, 232);
            this.reportViewer1.TabIndex = 3;
            // 
            // dslich
            // 
            this.dslich.DataSetName = "dslich";
            this.dslich.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LichDangKyBindingSource
            // 
            this.LichDangKyBindingSource.DataMember = "LichDangKy";
            this.LichDangKyBindingSource.DataSource = this.dslich;
            // 
            // LichDangKyTableAdapter
            // 
            this.LichDangKyTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 300);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dslich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LichDangKyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Button btnthongke;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LichDangKyBindingSource;
        private dslich dslich;
        private dslichTableAdapters.LichDangKyTableAdapter LichDangKyTableAdapter;
    }
}